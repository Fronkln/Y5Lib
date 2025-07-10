using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Threading;

namespace Y5Lib.NET
{
    internal class Program
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr LoadLibrary(string libname);

        static void Main(string[] args)
        {
            try
            {
                OE.BaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                OE.Root = args[0];

                //Environment.CurrentDirectory = OE.Root;
                OE._LogPath = Path.Combine(OE.Root, "log.txt");

                OE.LogInfo("Y5Lib Start");

                string libPath = Path.Combine(OE.Root, "Y5Lib.dll");

                OE.LogInfo("BaseDirectory: " + OE.BaseDirectory);
                OE.LogInfo("OOELibrary path: " + libPath);

                if (LoadLibrary(libPath) == IntPtr.Zero)
                {
                    OE.LogError("Failed to load the library! " + "GetLastWinError32:" + Marshal.GetLastWin32Error());
                    return;
                }
                else
                    OE.LogInfo("Loaded Y5Library, initialization time!");

                AppDomain.CurrentDomain.AssemblyResolve += delegate (object sender, ResolveEventArgs argses)
                {
                    string assemblyName = argses.Name.Split(',')[0];

                    if (assemblyName == "Y5Lib.NET")
                        return AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(x => x.GetName().Name == "Y5Lib.NET");

                    return null;
                };


                OE.LogInfo("Starting initialization thread");
                Thread thread = new Thread(InitThread);
                thread.Start();

                File.WriteAllText("log.txt", "");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void InitThread()
        {
            while (!OE.IsInitialized())
            {
#if DEBUG
                OE.LogInfo("Proccing initialization");

#endif
                OE.Init();
            }

            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            Console.WriteLine("Initialize mod");
            ModLoader.InitializeMods();

            Environment.CurrentDirectory = OE.BaseDirectory;

            Console.WriteLine("Y5Lib Initialized");
        }


        [DllImport("user32.dll")]
        private static extern int MessageBox(IntPtr hWnd, String text, String caption, int options);

        [SecurityCritical, HandleProcessCorruptedStateExceptions]
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            AppDomain.CurrentDomain.UnhandledException -= CurrentDomain_UnhandledException;  // this is important. Any exception occuring in the logging mechanism can cause a stack overflow exception which triggers the window's own JIT message/App crash message if Win JIT is not available.

            Exception ex = e.ExceptionObject as Exception;
            OE.LogInfo("*******************FATAL ERROR***************");
            OE.LogInfo("Inner Exception:\n" + ex.InnerException);
            OE.LogInfo("Message:\n" + ex.Message);
            OE.LogInfo("Stacktrace: \n" + ex.StackTrace);
            MessageBox((IntPtr)0, "Fatal error! More information available on Mods/Y5lib/log.txt. The game will now exit", "Fatal OOELibrary Error", 0x00000010);
            Environment.Exit(-1); // exit and avoid WER etc
        }
    }
}
