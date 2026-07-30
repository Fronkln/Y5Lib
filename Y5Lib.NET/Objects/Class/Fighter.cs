using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public class Fighter : Human
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_GETTER_HEALTH", CallingConvention = CallingConvention.Cdecl)]
        internal static extern ushort Y5Lib_Fighter_Getter_Health(IntPtr fighter);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_SETTER_HEALTH", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_Fighter_Setter_Health(IntPtr fighter, ushort health);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_GETTER_MAXHEALTH", CallingConvention = CallingConvention.Cdecl)]
        internal static extern ushort Y5Lib_Fighter_Getter_MaxHealth(IntPtr fighter);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_SETTER_MAXHEALTH", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_Fighter_Setter_MaxHealth(IntPtr fighter, ushort health);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_GETTER_HEAT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern ushort Y5Lib_Fighter_Getter_Heat(IntPtr fighter);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_SETTER_HEAT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_Fighter_Setter_Heat(IntPtr fighter, ushort heat);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_GETTER_MAXHEAT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern ushort Y5Lib_Fighter_Getter_MaxHeat(IntPtr fighter);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_SETTER_MAXHEAT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_Fighter_Setter_MaxHeat(IntPtr fighter, ushort heat);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_GETTER_DISPOSE_INFO", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_Fighter_Getter_DisposeInfo(IntPtr fighter);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_SETTER_DISPOSE_INFO", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_Fighter_Setter_DisposeInfo(IntPtr fighter, ref DisposeInfo inf);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_GETTER_MODEL_NAME", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_Fighter_Getter_ModelName(IntPtr fighter);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_GETTER_FIGHTERMODEMANAGER", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_Fighter_Getter_FighterModeManager(IntPtr fighter);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_GETTER_INPUT_FLAGS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_Fighter_Getter_InputFlags(IntPtr fighter);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_GETTER_INDEX", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_Fighter_Getter_Index(IntPtr fighter);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_SETTER_INPUT_FLAGS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_Fighter_Setter_InputFlags(IntPtr fighter, int val);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_GETTER_INPUT_FORWARD_DIRECTION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern float Y5Lib_Fighter_Getter_InputForward(IntPtr fighter);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_SETTER_INPUT_FORWARD_DIRECTION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_Fighter_Setter_InputForward(IntPtr fighter, float value);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_GETTER_INPUT_SIDE_DIRECTION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern short Y5Lib_Fighter_Getter_InputSide(IntPtr fighter);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_SETTER_INPUT_SIDE_DIRECTION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_Fighter_Setter_InputSide(IntPtr fighter, short value);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_GETTER_INPUT_SIDE_DIRECTION2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern short Y5Lib_Fighter_Getter_InputSide2(IntPtr fighter);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_SETTER_INPUT_SIDE_DIRECTION2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_Fighter_Setter_InputSide2(IntPtr fighter, short value);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_GETTER_DAMAGE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern byte Y5Lib_Fighter_Getter_Damage(IntPtr fighter);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_SETTER_DAMAGE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_Fighter_Setter_Damage(IntPtr fighter, byte value);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_GETTER_TYPE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern byte Y5Lib_Fighter_Getter_Type(IntPtr fighter);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_SET_THINK_MODE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_Fighter_SetAllowThink(IntPtr fighter, int mode);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_TODEAD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_Fighter_ToDead(IntPtr fighter);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_GETTER_FLAGS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint Y5Lib_Fighter_Getter_FighterFlags(IntPtr fighter);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_GETTER_SYNC_SERIAL", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_Fighter_Getter_SyncSerial(IntPtr fighter);


        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_GETTER_FUID", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_Fighter_Getter_FUID(IntPtr fighter);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_SETTER_FUID", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_Fighter_Setter_FUID(IntPtr fighter, int fuid);


        public FighterFlag Flags
        {
            get
            {
                return (FighterFlag)Y5Lib_Fighter_Getter_FighterFlags(Pointer);
            }
        }

        public ushort Health
        {

            get
            {
                return Y5Lib_Fighter_Getter_Health(Pointer);
            }
            set
            {
                Y5Lib_Fighter_Setter_Health(Pointer, value);
            }
        }

        public ushort MaxHealth
        {

            get
            {
                return Y5Lib_Fighter_Getter_MaxHealth(Pointer);
            }
            set
            {
                Y5Lib_Fighter_Setter_MaxHealth(Pointer, value);
            }
        }

        public ushort Heat
        {

            get
            {
                return Y5Lib_Fighter_Getter_Heat(Pointer);
            }
            set
            {
                Y5Lib_Fighter_Setter_Heat(Pointer, value);
            }
        }

        public ushort MaxHeat
        {

            get
            {
                return Y5Lib_Fighter_Getter_MaxHeat(Pointer);
            }
            set
            {
                Y5Lib_Fighter_Setter_MaxHeat(Pointer, value);
            }
        }

        /// <summary>
        /// Kinda expensive to access
        /// </summary>
        public unsafe DisposeInfo Dispose
        {
            get
            {
                IntPtr dispInf = Y5Lib_Fighter_Getter_DisposeInfo(Pointer);

                if (dispInf == IntPtr.Zero)
                    return new DisposeInfo();

                DisposeInfo informat = Marshal.PtrToStructure<DisposeInfo>(dispInf);
                return informat;
            }
            set
            {
                Y5Lib_Fighter_Setter_DisposeInfo(Pointer, ref value);
            }
        }

        public FighterModeManager ModeManager
        {
            get
            {
                return new FighterModeManager() { Pointer = Y5Lib_Fighter_Getter_FighterModeManager(Pointer) };
            }
        }

        public int InputFlags
        {
            get
            {
                return Y5Lib_Fighter_Getter_InputFlags(Pointer);
            }
            set
            {
                Y5Lib_Fighter_Setter_InputFlags(Pointer, value);
            }
        }

        public float InputForward
        {
            get
            {
                return Y5Lib_Fighter_Getter_InputForward(Pointer);
            }
            set
            {
                Y5Lib_Fighter_Setter_InputForward(Pointer, value);
            }
        }

        public short InputSide
        {
            get
            {
                return Y5Lib_Fighter_Getter_InputSide(Pointer);
            }
            set
            {
                Y5Lib_Fighter_Setter_InputSide(Pointer, value);
            }
        }

        public short InputSide2
        {
            get
            {
                return Y5Lib_Fighter_Getter_InputSide2(Pointer);
            }
            set
            {
                Y5Lib_Fighter_Setter_InputSide2(Pointer, value);
            }
        }

        public int Index
        {
            get
            {
                return Y5Lib_Fighter_Getter_Index(Pointer);
            }
        }

        public byte Damage
        {
            get
            {
                return Y5Lib_Fighter_Getter_Damage(Pointer);
            }

            set
            {
                Y5Lib_Fighter_Setter_Damage(Pointer, value);
            }
        }

        public NPCType Type
        {
            get
            {
                return (NPCType)Y5Lib_Fighter_Getter_Type(Pointer);
            }
        }

        /// <summary>
        /// The unique fighter UID of this character
        /// </summary>
        public int FUID
        {
            get => Y5Lib_Fighter_Getter_FUID(Pointer);
            set => Y5Lib_Fighter_Setter_FUID(Pointer, value);
        }

        public int SyncSerial
        {
            get
            {
                return Y5Lib_Fighter_Getter_SyncSerial(Pointer);
            }
        }


        public SyncRegisterData SyncData
        {
            get
            {
                return ActionFighterSyncManager.GetSyncDataBySerial(SyncSerial);
            }
        }

        /// <summary>
        /// Is sy1 in sync
        /// </summary>
        /// <returns></returns>
        public bool IsSyncTarget()
        {
            var syncData = SyncData;

            if (SyncData.Pointer == IntPtr.Zero)
                return false;

            return SyncData.GetPairFighterIndex(0) != Index;
        }

        /// <summary>
        /// AI fighters only
        /// </summary>
        public void SetThinkMode(int mode)
        {
            Y5Lib_Fighter_SetAllowThink(Pointer, mode);
        }

        public bool IsSync()
        {
            return SyncSerial != -1;
        }

        public bool IsDead()
        {
            return Flags.HasFlag(FighterFlag.Dead);
        }

        public void ToDead()
        {
            Y5Lib_Fighter_ToDead(Pointer);
        }
    }
}
