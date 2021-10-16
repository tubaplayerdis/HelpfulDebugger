using System;
using System.Text;


namespace Helpful_debuger
{
    class LoadLibraryEx
    {

        const int MEM_COMMIT = 0x00001000;
        const int MEM_RESERVE = 0x00002000;
        const int MEM_DECOMMIT = 0x4000;
        const int MEM_RELEASE = 0x8000;
        const int PAGE_EXECUTE_READWRITE = 0x40;


        public static bool LoadLibrary(IntPtr hProcess, string dllPath, IntPtr LoadLibAddy)
        {
            if (LoadLibAddy == IntPtr.Zero)
                LoadLibAddy = Imports.GetProcAddress(Imports.GetModuleHandle("Kernel32"), "LoadLibraryW");
            if (LoadLibAddy == (IntPtr)null)
            {
                Imports.kernelErrMsg("Couldn't get the LoadLibraryaddress.");
                return false;
            }

            var dllPathBytes = Encoding.Unicode.GetBytes(dllPath + "\0");

            IntPtr baseAddress = Imports.VirtualAllocEx(hProcess, IntPtr.Zero, dllPathBytes.Length, (MEM_COMMIT | MEM_RESERVE), PAGE_EXECUTE_READWRITE);
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

            IntPtr hThread = Imports.CreateRemoteThread(hProcess, IntPtr.Zero, 0, LoadLibAddy, baseAddress, 0, IntPtr.Zero);
            if (hThread == (IntPtr.Zero))
            {
                Imports.kernelErrMsg("Couldn't create thread in target process.");
                return false;
            }

            int freed = Imports.VirtualFreeEx(hProcess, baseAddress, 0, MEM_RELEASE);
            if (freed == 0)
            {
                Imports.kernelErrMsg("Couldn't free memory.");
                Imports.GetLastError();
                return false;
            }

            int closed = Imports.CloseHandle(hProcess);
            if (closed == 0)
            {
                Imports.kernelErrMsg("Can't close handle.");
                return false;
            }

            return true;
        }
    }
}
