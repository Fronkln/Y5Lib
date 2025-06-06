﻿using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    //https://stackoverflow.com/a/52103996/14569631
    public static class ObjectHandleExtensions
    {
        public static string ToNullTerminatedString(this char[] letters)
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();

            int i = 0;

            while (letters[i] != 0 && i < letters.Length)
            {
                builder.Append(letters[i]);
                i++;
            }

            return builder.ToString();
        }

        public static IntPtr ToIntPtr(this object target)
        {
            IntPtr allocedObj = Marshal.AllocHGlobal(Marshal.SizeOf(target));
            Marshal.StructureToPtr(target, allocedObj, false);

            return allocedObj;
        }

        public static GCHandle ToGcHandle(this object target)
        {
            return GCHandle.Alloc(target);
        }

        public static IntPtr ToIntPtr(this GCHandle target)
        {
            return GCHandle.ToIntPtr(target);
        }
    }
}
