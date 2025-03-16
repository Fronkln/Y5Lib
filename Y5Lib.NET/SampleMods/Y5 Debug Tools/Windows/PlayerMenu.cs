using System;
using Y5Lib;
using ImGuiNET;

namespace Y5_Debug_Tools
{
    internal static class PlayerMenu
    {
        public static void Draw()
        {
            Fighter player = ActionFighterManager.Player;

            if (ImGui.Begin("Player"))
            {

                if (player.Pointer == IntPtr.Zero)
                {
                    ImGui.Text("Player does not exist.");
                    ImGui.End();
                    return;
                }

                SubWindowEntity.Draw(player);

                ImGui.Text("Motion ID: " + player.HumanMotion.CurrentAnimation);

                ImGui.End();
            }

        }
    }
}
