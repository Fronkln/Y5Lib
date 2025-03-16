using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Y5Lib;
using ImGuiNET;

namespace Y5_Debug_Tools
{
    internal static class SubWindowFighter
    {
        public static void Draw(Fighter fighter)
        {
            ImGui.Text("Angle Y:" + fighter.HumanMotion.GetAngleY());

            if (ImGui.CollapsingHeader("Input"))
            {
                int flags = fighter.InputFlags;
                StringBuilder inputText = new StringBuilder();

                for (int i = 0; i < 32; i++)
                {
                    if ((flags & 1 << i) != 0)
                        inputText.Append((flags & 1 << i) + " ");
                }

                ImGui.Text("Input:");
                ImGui.Text(inputText.ToString());
            }
        }
    }
}
