using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Hybrid_H5F_Tool
{
    class Memory
    {
        public enum ProcessAccessFlags : uint
        {
            All = 0x001F0FFF,
            Terminate = 0x00000001,
            CreateThread = 0x00000002,
            VMOperation = 0x00000008,
            VMRead = 0x00000010,
            VMWrite = 0x00000020,
            DupHandle = 0x00000040,
            SetInformation = 0x00000200,
            QueryInformation = 0x00000400,
            Synchronize = 0x00100000
        }

        [DllImport("kernel32.dll")]
        static extern IntPtr OpenProcess(ProcessAccessFlags dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint dwSize, ref int lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        public static extern Int32 CloseHandle(IntPtr hProcess);

        public static IntPtr[] Pointer(Int32 address)
        {
            Process p = Process.GetProcessesByName("halo5forge").FirstOrDefault();
            Int64 startOffset = p.MainModule.BaseAddress.ToInt64();
            Int64 offset = startOffset + address;
            var hProc = OpenProcess(ProcessAccessFlags.All, false, (int)p.Id);
            List<IntPtr> outArray = new List<IntPtr>();

            outArray.Add(hProc);
            outArray.Add(new IntPtr(offset));

            return outArray.ToArray();
        }

        public static byte[] AddressRead(Int32 address)
        {
            int unused = 0; byte[] hex = new byte[4];
            ReadProcessMemory(Pointer(address)[0], Pointer(address)[1], hex, (UInt32)hex.LongLength, ref unused);
            return hex;
        }

        public static void AddressWrite(Int32 address, byte[] hex)
        {
            int unused = 0;
            WriteProcessMemory(Pointer(address)[0], Pointer(address)[1], hex, (UInt32)hex.LongLength, out unused);
            CloseHandle(Pointer(address)[0]);
        }
    }
}
