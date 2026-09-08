using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Y5Lib
{
    public static class ActionDanceBattleManager
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_DANCEBATTLEMANAGER_GET_DANCER", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_DanceBattleManager_GetDancer(int idx);

        public static UISStoryHDb GetUI()
        {
            IntPtr danceManagerAction = ActionManager.GetAction(260);

            if (danceManagerAction == IntPtr.Zero)
                return new UISStoryHDb();

            return new UISStoryHDb() { Pointer = Marshal.ReadIntPtr(danceManagerAction + 0x230) };
        }

        public static DanceBattleDancer GetDancer(int idx)
        {
            IntPtr action = ActionManager.GetAction(ActionID.DanceBattle);

            if (action == IntPtr.Zero)
                return new DanceBattleDancer();

            return new DanceBattleDancer() { Pointer = Marshal.ReadIntPtr(action + 0x220 + (8 * idx)) };
        }

        public static LbdSheetHandler GetSheetHandler()
        {
            IntPtr action = ActionManager.GetAction(ActionID.DanceBattle);

            if (action == IntPtr.Zero)
                return new LbdSheetHandler();

            return new LbdSheetHandler() { Pointer = Marshal.ReadIntPtr(action + 0x1D8) };
        }
    }
}
