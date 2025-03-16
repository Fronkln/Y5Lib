using System;
using System.Threading;
using Y5Lib;
using ImGuiNET;

namespace Y5_Debug_Tools
{
    public class Mod : Y5Mod
    {
        private bool m_player;
        private bool m_noclip = false;

        public void InputThread()
        {
            while(true)
            {
                if(OE.IsKeyHeld(VirtualKey.Shift))
                {
                    if (OE.IsKeyDown(VirtualKey.V))
                        Noclip.Toggle();
                }
            }
        }

        public override void OnModInit()
        {
            base.OnModInit();

            Thread thread = new Thread(InputThread);
            thread.Start();

            Y5Lib.Advanced.ImGui.Init();
            Y5Lib.Advanced.ImGui.RegisterUIUpdate(Test);
        }

        public void Test()
        {
            ImGui.Begin("Debug");

            ImGui.Checkbox("Player", ref m_player);
            ImGui.Checkbox("Action Fighter Manager", ref FighterManagerMenu.Enabled);

            if (m_player)
                PlayerMenu.Draw();

            if (FighterManagerMenu.Enabled)
                FighterManagerMenu.Draw();

            UnityIntegration.Draw();

            ImGui.End();
        }
    }
}
