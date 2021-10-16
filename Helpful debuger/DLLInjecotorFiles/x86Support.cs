using System;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.Text;

namespace Helpful_debuger
{
    static class x86Support
    {
        public enum MachineType : ushort
        {
            IMAGE_FILE_MACHINE_UNKNOWN = 0x0,
            IMAGE_FILE_MACHINE_AM33 = 0x1d3,
            IMAGE_FILE_MACHINE_AMD64 = 0x8664,
            IMAGE_FILE_MACHINE_ARM = 0x1c0,
            IMAGE_FILE_MACHINE_EBC = 0xebc,
            IMAGE_FILE_MACHINE_I386 = 0x14c,
            IMAGE_FILE_MACHINE_IA64 = 0x200,
            IMAGE_FILE_MACHINE_M32R = 0x9041,
            IMAGE_FILE_MACHINE_MIPS16 = 0x266,
            IMAGE_FILE_MACHINE_MIPSFPU = 0x366,
            IMAGE_FILE_MACHINE_MIPSFPU16 = 0x466,
            IMAGE_FILE_MACHINE_POWERPC = 0x1f0,
            IMAGE_FILE_MACHINE_POWERPCFP = 0x1f1,
            IMAGE_FILE_MACHINE_R4000 = 0x166,
            IMAGE_FILE_MACHINE_SH3 = 0x1a2,
            IMAGE_FILE_MACHINE_SH3DSP = 0x1a3,
            IMAGE_FILE_MACHINE_SH4 = 0x1a6,
            IMAGE_FILE_MACHINE_SH5 = 0x1a8,
            IMAGE_FILE_MACHINE_THUMB = 0x1c2,
            IMAGE_FILE_MACHINE_WCEMIPSV2 = 0x169,
        }

        public static MachineType GetDllMachineType(string dllPath)
        {
            FileStream fs = new FileStream(dllPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            fs.Seek(0x3c, SeekOrigin.Begin);
            Int32 peOffset = br.ReadInt32();
            fs.Seek(peOffset, SeekOrigin.Begin);
            UInt32 peHead = br.ReadUInt32();

            if (peHead != 0x00004550) // "PE\0\0", little-endian
                throw new Exception("Can't find PE header");

            MachineType machineType = (MachineType)br.ReadUInt16();
            br.Close();
            fs.Close();
            return machineType;
        }


        public unsafe static IntPtr GetLoadLibAddy32()
        {
            Process x86sup = new Process();
            x86sup.StartInfo.FileName = "x86_Support.exe";
            x86sup.StartInfo.Arguments = Process.GetCurrentProcess().Id.ToString();
            x86sup.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            NamedPipeServerStream pipeServer =
            new NamedPipeServerStream("injectorPipe", PipeDirection.InOut);

            x86sup.Start();
            pipeServer.WaitForConnection();

            pipeServer.Write(Encoding.ASCII.GetBytes("check"), 0, 5);
            byte[] buffer = new byte[4];
            pipeServer.Read(buffer, 0, 4);


            x86sup.WaitForExit();
            pipeServer.Close();

            return (IntPtr)BitConverter.ToInt32(buffer, 0);;
        }


        public static bool cpuEquals(IntPtr hProcess, string dllPath)
        {
            bool bIsWow32 = false;
            Imports.IsWow64Process(hProcess, ref bIsWow32);
            bool bIsDll32 = false;
            switch (GetDllMachineType(dllPath))
            {
                case MachineType.IMAGE_FILE_MACHINE_I386:
                    bIsDll32 = true;
                    break;
            }

            if (bIsWow32 == bIsDll32)
                return false;
            return true;
        }
    }
}
