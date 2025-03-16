﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    internal static class ModLoader
    {
        internal static void InitializeMods()
        {
            string modDir =  Path.Combine(NET.Program.BaseDirectory, "mods");

            if (Directory.Exists(modDir))
            {
                int modCount = Parless.GetModCount();

                for (int i = 0; i < modCount; i++)
                {
                    IntPtr str = Parless.GetModName(i);

                    string name = Marshal.PtrToStringAnsi(str);
                    string path = Path.Combine(modDir, name);

                    if(Directory.Exists(path))
                    {
                        string[] modFiles = Directory.GetFiles(path, "*.dll");

                        foreach (string dllFile in modFiles)
                        {
                            bool loadRes = InitializeModLibrary(dllFile);

                            if (loadRes)
                                OE.LogInfo("Successfully loaded DLL library in " + name);
                        }
                    }
                }
            }

            OE.LogInfo("\n\nAll mods have been initialized.");
        }

        private static bool InitializeModLibrary(string path)
        {
            if (string.IsNullOrEmpty(path))
                return false;

            if (!File.Exists(path))
            {
                OE.LogError(path + " does not exist.");
                return false;
            }

            try
            {
                //Ugly reflection type
                Assembly loadedAssembly = Assembly.LoadFrom(path);
                Type modInfoType = typeof(Y5Mod);

                foreach (CustomAttributeData dat in loadedAssembly.CustomAttributes)
                    if (dat.AttributeType.FullName == typeof(Y5ModAttribute).FullName) // type comparing didnt work. so we compare names
                    {
                        ProcessY5Mod(dat.ConstructorArguments);
                        return true;
                    }

                return false;
            }
            catch (Exception ex)
            {
                //The issue was not that it wasn't a valid .NET library, it was something else.
                if (ex as BadImageFormatException == null)
                    OE.LogError("Failed to load library.\nError: " + ex.Message + "\n" + ex.InnerException + "\nStacktrace:\n" + ex.StackTrace);

                return false;
            }
        }

        private static void ProcessY5Mod(IList<CustomAttributeTypedArgument> modInfo)
        {
            string modName = (string)modInfo[0].Value;
            string modAuthor = (string)modInfo[1].Value;
            Type modType = (Type)modInfo[2].Value;

            if (modType == null)
            {
                OE.LogError($"The mod {modName} does not have a valid mod initialization class");
                return;
            }


            if (modType.BaseType.FullName == "Y5Lib.Y5Mod")
            {
                object createdObj = Activator.CreateInstance(modType);

                if (createdObj != null)
                    modType.GetMethod("OnModInit", BindingFlags.Public | BindingFlags.Instance).Invoke(createdObj, null);
                else
                    OE.LogError("Mod class initialization for " + modName + " failed!");
            }
            else
                OE.LogError(modName + "'s initialization class does not derive from OOEMod!");

        }
    }
}



