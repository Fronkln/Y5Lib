using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Y5Lib
{
    public static class SequenceManager
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_GETTER_CURRENT_MISSION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint Y5Lib_ActionSequenceManager_Getter_CurrentMission();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_GETTER_NEXT_MISSION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint Y5Lib_ActionSequenceManager_Getter_NextMission();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_GETTER_SEQUENCE_PHASE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint Y5Lib_ActionSequenceManager_Getter_SequencePhase();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_GETTER_IS_LOADING", CallingConvention = CallingConvention.Cdecl)]
        [return:MarshalAs(UnmanagedType.U1)]
        internal static extern bool Y5Lib_ActionSequenceManager_Getter_IsLoading();

        //Lowkey useless
        /*
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_SET_NEXT_MISSION_ID", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetNextMissionID(uint missionID);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_SET_NEXT_MISSION_SCENARIO", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetNextMissionScenario(uint scenarioID);
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_SET_NEXT_MISSION_START_TYPE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetNextMissionStartType(int startType);
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_SET_NEXT_MISSION_START_HACT", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetNextMissionStartHAct(string startHAct);
        */

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_GETTER_CURRENT_MISSION_SCENARIO", CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint Y5Lib_ActionSequenceManager_Getter_CurrentMissionScenario();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_GETTER_NEXT_MISSION_SCENARIO", CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint Y5Lib_ActionSequenceManager_Getter_NextMissionScenario();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_LOAD_NEXT_MISSION", CallingConvention = CallingConvention.Cdecl)]
        public static extern void LoadNextMission();

        public static MissionID MissionID { get { return (MissionID)Y5Lib_ActionSequenceManager_Getter_CurrentMission(); } }
        public static MissionID NextMissionID { get { return (MissionID)Y5Lib_ActionSequenceManager_Getter_NextMission(); } }
        public static uint CurrentMissionScenarioID { get { return Y5Lib_ActionSequenceManager_Getter_CurrentMissionScenario(); } }
        public static uint NextMissionScenarioID { get { return Y5Lib_ActionSequenceManager_Getter_NextMissionScenario(); } }
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
