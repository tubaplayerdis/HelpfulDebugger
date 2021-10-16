using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Helpful_debuger
{
    static class NtCreateThreadEx
    {

        public delegate int NtCreateThreadExProc(
        out IntPtr threadHandle,
        uint desiredAccess,
        IntPtr objectAttributes,
        IntPtr processHandle,
        IntPtr lpStartAddress,
        IntPtr lpParameter,
        int createSuspended,
        uint stackZeroBits,
        uint sizeOfStackCommit,
        uint sizeOfStackReserve,
        IntPtr lpBytesBuffer);


        struct NtCreateThreadExBuffer
        {
            public int Size;
            public UInt64 Unknown1;
            public UInt64 Unknown2;
            public UIntPtr Unknown3;
            public UInt64 Unknown4;
            public UInt64 Unknown5;
            public UInt64 Unknown6;
            public UIntPtr Unknown7;
            public UInt64 Unknown8;
        };

        public unsafe static bool NtCreateThread(IntPtr hProcess, string dllPath, IntPtr loadLibAddy)
        {
                IntPtr ntCreateThreadAddy = Imports.GetProcAddress(Imports.GetModuleHandle("ntdll.dll"), "NtCreateThreadEx");
            if (ntCreateThreadAddy == IntPtr.Zero)
            {
                Imports.kernelErrMsg("Couldn't get the NtCreateThreadExaddress.");
            }

            if (loadLibAddy == IntPtr.Zero)
                loadLibAddy = Imports.GetProcAddress(Imports.GetModuleHandle("Kernel32"), "LoadLibraryW");
            if (loadLibAddy == IntPtr.Zero)
            {
                Imports.kernelErrMsg("Couldn't get the LoadLibraryaddress.");
                return false;
            }

            UInt32 temp1 = 0, temp2 = 0;
            NtCreateThreadExBuffer nb = new NtCreateThreadExBuffer
            {
                Size = sizeof(NtCreateThreadExBuffer),
                Unknown1 = 0x10003,
                Unknown2 = 0x8,
                Unknown3 = new UIntPtr(&temp2),
                Unknown4 = 0,
                Unknown5 = 0x10004,
                Unknown6 = 4,
                Unknown7 = new UIntPtr(&temp1),
                Unknown8 = 0,
            };

            NtCreateThreadExProc ntCreateThreadEx = (NtCreateThreadEx.NtCreateThreadExProc)
                Marshal.GetDelegateForFunctionPointer(ntCreateThreadAddy, typeof(NtCreateThreadEx.NtCreateThreadExProc));
            if (ntCreateThreadEx == null)
            {
                Imports.kernelErrMsg("Couldn't get the NtCreateThreadEx function");
                return false;
            }

            var dllPathBytes = Encoding.Unicode.GetBytes(dllPath + "\0");

            IntPtr baseAddress = Imports.VirtualAllocEx(hProcess, IntPtr.Zero, dllPathBytes.Length, (0x00001000 | 0x00002000), 0x40);
            if (baseAddress == (IntPtr)null)
            {
                Imports.kernelErrMsg("Couldn't allocate Memory in target process.");
                return false;
            }

            UIntPtr writtenBytes = (UIntPtr)null;
            bool written = Imports.WriteProcessMemory(hProcess, baseAddress, dllPathBytes, dllPathBytes.Length, out writtenBytes);
            if (!written || writtenBytes == (UIntPtr)null)
            {
                Imports.kernelErrMsg("Couldn't write bytes into target process.");
                return false;
            }
            IntPtr hRemoteThread = IntPtr.Zero;
                ntCreateThreadEx(
                    out hRemoteThread,
                    0x1FFFFF,
                    IntPtr.Zero,
                    hProcess,
                    loadLibAddy,
                    baseAddress,
                    0,
                    0,
                    0,
                    0,
                    IntPtr.Zero);



            if (hRemoteThread == IntPtr.Zero)
            {
                Imports.kernelErrMsg("Couldn't create NTtype Thread");
                return false;
            }

            return true;
        }
    }
}
