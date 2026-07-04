using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public static class SequenceManager
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_GETTER_SEQUENCECOMMANDDEF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_ActionSequenceManager_Getter_SequenceCommandDef();


        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_GETTER_CURRENT_MISSION_DATA", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_ActionSequenceManager_Getter_CurrentMissionData();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_GETTER_CURRENT_MISSION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint Y5Lib_ActionSequenceManager_Getter_CurrentMission();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_GETTER_NEXT_MISSION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint Y5Lib_ActionSequenceManager_Getter_NextMission();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_GETTER_SEQUENCE_PHASE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint Y5Lib_ActionSequenceManager_Getter_SequencePhase();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_GETTER_IS_LOADING", CallingConvention = CallingConvention.Cdecl)]
        [return:MarshalAs(UnmanagedType.U1)]
        internal static extern bool Y5Lib_ActionSequenceManager_Getter_IsLoading();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_GETTER_CURRENT_MISSION_SCENARIO", CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint Y5Lib_ActionSequenceManager_Getter_CurrentMissionScenario();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_GETTER_NEXT_MISSION_SCENARIO", CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint Y5Lib_ActionSequenceManager_Getter_NextMissionScenario();
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_GETTER_CURRENT_STAGE_ID", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_ActionSequenceManager_Getter_CurrentStageID();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_GETTER_CURRENT_UNKNOWN_MODE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_ActionSequenceManager_Getter_UnknownMode();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_GETTER_NEXT_STAGE_ID", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_ActionSequenceManager_Getter_NextStageID();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_GETTER_NEXT_UNKNOWN_MODE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_ActionSequenceManager_Getter_NextUnknownMode();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_GETTER_NEXT_PLAYER_POSITION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Vector3 Y5Lib_ActionSequenceManager_Getter_NextPlayerPosition();


        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_SET_NEXT_SCENARIO_ID", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetNextScenarioID(uint scenarioID);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_SET_NEXT_MISSION_ID", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetNextMissionID(MissionID mission);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_SET_NEXT_STAGE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetNextStageID(int stageID);
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_SET_NEXT_UNKNOWN_MODE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetNextUnknownMode(int mode);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_SET_NEXT_PLAYER_POSITION", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetNextPlayerPosition(Vector3 position);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_LOAD_NEXT_MISSION", CallingConvention = CallingConvention.Cdecl)]
        public static extern void LoadNextMission();


        public static SequenceCommandDef SequenceCommandDef
        {
            get
            {
                return new SequenceCommandDef() { Pointer = Y5Lib_ActionSequenceManager_Getter_SequenceCommandDef() };
            }
        }


        public static IntPtr MissionData { get { return Y5Lib_ActionSequenceManager_Getter_CurrentMissionData(); } }

        public static MissionID MissionID { get { return (MissionID)Y5Lib_ActionSequenceManager_Getter_CurrentMission(); } }
        public static MissionID NextMissionID { get { return (MissionID)Y5Lib_ActionSequenceManager_Getter_NextMission(); } }
        public static uint ScenarioID { get { return Y5Lib_ActionSequenceManager_Getter_CurrentMissionScenario(); } }
        public static uint NextScenarioID { get { return Y5Lib_ActionSequenceManager_Getter_NextMissionScenario(); } }

        public static int StageID { get { return Y5Lib_ActionSequenceManager_Getter_CurrentStageID(); } }
        public static int NextStageID { get { return Y5Lib_ActionSequenceManager_Getter_NextStageID(); } }
        public static int UnknownMode { get { return Y5Lib_ActionSequenceManager_Getter_UnknownMode(); } }
        public static int NextUnknownMode { get { return Y5Lib_ActionSequenceManager_Getter_NextUnknownMode(); } }

        public static Vector3 NextPlayerPosition { get {  return Y5Lib_ActionSequenceManager_Getter_NextPlayerPosition(); }  }

        public static uint SequencePhase { get { return Y5Lib_ActionSequenceManager_Getter_SequencePhase(); } }
        public static bool IsLoading { get { return Y5Lib_ActionSequenceManager_Getter_IsLoading(); } }

        /// <summary>
        /// Allow the mission to transition to the next sequence if the value for it is set.
        /// </summary>
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_ALLOW_MISSION_TRANSITION", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern void AllowMissionTransition(bool allow);

    }
}
