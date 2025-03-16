using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection;
using Steamworks;
using Y5Lib;

namespace Y5MP
{
    public static class Extensions
    {

        public static byte[] ToBytes<T>(this T type)
        {

            int size = Marshal.SizeOf(type);
            byte[] arr = new byte[size];

            IntPtr ptr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(type, ptr, true);
            Marshal.Copy(ptr, arr, 0, size);
            Marshal.FreeHGlobal(ptr);
            return arr;
        }

        //Has to exactly match or epic failure
        public static object[] ReadFunctionArguments(this BinaryReader reader, MethodInfo funcInf)
        {
            ParameterInfo[] parameters = funcInf.GetParameters();
            object[] readParams = new object[parameters.Length];

            for (int i = 0; i < parameters.Length; i++)
            {
                ParameterInfo param = parameters[i];
                readParams[i] = reader.ReadObjectUnknown(param.ParameterType);
            }

            return readParams;
        }

        public static T ToObject<T>(this byte[] arr) where T : new()
        {
            T obj = new T();

            int size = Marshal.SizeOf(obj);
            IntPtr ptr = Marshal.AllocHGlobal(size);

            Marshal.Copy(arr, 0, ptr, size);

            obj = (T)Marshal.PtrToStructure(ptr, typeof(T));
            Marshal.FreeHGlobal(ptr);

            return obj;
        }

        public static object ToObjectType(this byte[] arr, Type T)
        {
            object obj = Activator.CreateInstance(T);

            int size = Marshal.SizeOf(obj);
            IntPtr ptr = Marshal.AllocHGlobal(size);

            Marshal.Copy(arr, 0, ptr, size);

            obj = Marshal.PtrToStructure(ptr, T);
            Marshal.FreeHGlobal(ptr);

            return obj;
        }

        public static int SizeOf(this object type)
        {
            return Marshal.SizeOf(type);
        }

        public static string Name(this CSteamID id)
        {
            string name = SteamFriends.GetFriendPersonaName(id);

            if (string.IsNullOrEmpty(name))
                return "(EMPTY NAME)";

            return name;
        }

        public static void Write(this BinaryWriter writer, Vector3 pos)
        {
            writer.Write(pos.x);
            writer.Write(pos.y);
            writer.Write(pos.z);
        }

        public static void Write(this BinaryWriter writer, Vector4 pos)
        {
            writer.Write(pos.x);
            writer.Write(pos.y);
            writer.Write(pos.z);
            writer.Write(pos.w);
        }

        public static void Write(this BinaryWriter writer, Quaternion quat)
        {
            writer.Write(quat.x);
            writer.Write(quat.y);
            writer.Write(quat.z);
            writer.Write(quat.w);
        }

        public static void WriteObject<T>(this BinaryWriter writer, T obj) where T : new()
        {
            writer.Write(obj.ToBytes());
        }

        public static T ReadObject<T>(this BinaryReader reader) where T : new()
        {
            byte[] buff = reader.ReadBytes(Marshal.SizeOf<T>());

            return buff.ToObject<T>();
        }

        public static object ReadObjectUnknown(this BinaryReader reader, Type type)
        {
            byte[] buff = reader.ReadBytes(Marshal.SizeOf(type));

            return buff.ToObjectType(type);
        }

        public static Vector3 ReadVector3(this BinaryReader reader)
        {
            return new Vector3(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());
        }

        public static Vector4 ReadVector4(this BinaryReader reader)
        {
            return new Vector4(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());
        }

        public static Quaternion ReadQuaternion(this BinaryReader reader)
        {
            return new Quaternion(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());
        }
    }
}
