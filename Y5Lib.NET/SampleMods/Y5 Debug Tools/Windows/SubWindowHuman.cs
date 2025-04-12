using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImGuiNET;
using Y5Lib;

namespace Y5_Debug_Tools
{
    internal static class SubWindowHuman
    {
        public static void Draw(Human human)
        {
            ImGui.Text("Current Animation: " + human.HumanMotion.CurrentAnimation);
        }
    }
}
