using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    namespace Unsafe
    {
        public static class CPP
        {
            [DllImport("Y5Lib.dll", EntryPoint = "LIB_UNSAFE_NOP", CallingConvention = CallingConvention.Cdecl)]
            public static extern void NopMemory(IntPtr memory, uint len);


            [DllImport("Y5Lib.dll", EntryPoint = "LIB_UNSAFE_PATCH", CallingConvention = CallingConvention.Cdecl)]
            private static extern void Unsafe_NopMemory(IntPtr memory, IntPtr buf, int len);

            [DllImport("Y5Lib.dll", EntryPoint = "LIB_READ_RELATIVE_ADDRESS", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ResolveRelativeAddress(IntPtr addr, int instructionLen);

            [DllImport("Y5Lib.dll", EntryPoint = "LIB_PATTERN_SEARCH", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr PatternSearch(string pattern);

            [DllImport("Y5Lib.dll", EntryPoint = "LIB_READ_CALL", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ReadCall(IntPtr addr);

            public static void PatchMemory(IntPtr addr, params byte[] bytes)
            {
                IntPtr byteArr = Marshal.AllocHGlobal(bytes.Length);
                Marshal.Copy(bytes, 0, byteArr, bytes.Length);

                Unsafe_NopMemory(addr, byteArr, bytes.Length);

                Marshal.FreeHGlobal(byteArr);
            }
        }
    }

    public static class OE
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_INIT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Init();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_TEST", CallingConvention = CallingConvention.Cdecl)]
        internal unsafe static extern void Test(ref DisposeInfo inf);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_IS_INIT", CallingConvention = CallingConvention.Cdecl)]
        [return:MarshalAs(UnmanagedType.U1)]
        internal static extern bool IsInitialized();

        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);

        internal delegate void RegisterJobDelegate();

        internal class JobRegisterInfo
        {
            public Action funcRaw;
            public RegisterJobDelegate del;
            public IntPtr delPointer;
            public uint phase;
            public bool after;

            public JobRegisterInfo(Action func, RegisterJobDelegate del, IntPtr ptr, uint phase, bool after)
            {
                this.funcRaw = func;
                this.del = del;
                this.phase = phase;
                delPointer = ptr;
                this.after = after;
            }
        }
        internal static List<JobRegisterInfo> _jobDelegates = new List<JobRegisterInfo>();


        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_REGISTER_JOB", CallingConvention = CallingConvention.Cdecl)]
        private static extern uint OELib_RegisterJob(IntPtr deleg, uint type, bool after);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_UNREGISTER_JOB", CallingConvention = CallingConvention.Cdecl)]
        private static extern uint OELib_UnregisterJob(IntPtr deleg, uint type);


        public static void RegisterJob(Action action, uint jobID, bool after = false)
        {
            RegisterJobDelegate del = new RegisterJobDelegate(action);
            JobRegisterInfo inf = new JobRegisterInfo(action, del, Marshal.GetFunctionPointerForDelegate(del), jobID, after);
            _jobDelegates.Add(inf);

            OELib_RegisterJob(inf.delPointer, jobID, after);


            LogInfo("Job for phase " + jobID.ToString() + " registered.");
        }

        /// <summary>
        /// Unregister a job that was registered.
        /// </summary>
        public static void UnregisterJob(Action func, uint phase)
        {

            foreach (JobRegisterInfo job in _jobDelegates.ToArray())
                if (job.phase == phase)
                    if (job.funcRaw == func)
                    {
                        OELib_UnregisterJob(job.delPointer, phase);
                    }
        }

        private static void WriteLineColor(string text, ConsoleColor col)
        {
            lock (m_writeLock)
            {

               // m_logWriter.WriteLine(text);
                System.IO.File.AppendAllText("log.txt", text + "\n");

                Console.ForegroundColor = col;
                Console.WriteLine(text);
                Console.ForegroundColor = ConsoleColor.Gray; //return to normal color or it will do all upcoming writes in this color
            }
        }

        static readonly object m_writeLock = new object();
        public static void LogInfo(object text) => WriteLineColor(text.ToString(), ConsoleColor.Cyan);
        public static void LogWarning(object text) => WriteLineColor(text.ToString(), ConsoleColor.Yellow);
        public static void LogError(object text) => WriteLineColor(text.ToString(), ConsoleColor.Red);

        public static bool IsKeyDown(VirtualKey virtualKey)
        {
            return (GetAsyncKeyState((int)virtualKey)) == -32767;
        }

        public static bool IsKeyHeld(VirtualKey virtualKey)
        {
            return (GetAsyncKeyState((int)virtualKey) & 0x8000) == 0x8000;
        }
    }
}
