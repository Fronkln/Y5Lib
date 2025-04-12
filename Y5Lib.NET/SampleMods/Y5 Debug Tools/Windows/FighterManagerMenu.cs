using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Y5Lib;
using ImGuiNET;

namespace Y5_Debug_Tools
{
    internal static class FighterManagerMenu
    {
        public static bool Enabled;

        public static void Draw()
        {
            if(ImGui.Begin("Fighter Manager"))
            {
                if (ImGui.TreeNode("Fighters"))
                {
                    for (int i = 0; i < 64; i++)
                    {
                        Fighter fighter = ActionFighterManager.GetFighter(i);

                        if (fighter.Pointer == IntPtr.Zero)
                            break;

                        if (ImGui.TreeNode(fighter.Dispose.modelName.ToString() + $" ({i})"))
                        {
                            if (ImGui.TreeNode("Entity Info"))
                            {
                                SubWindowEntity.Draw(fighter);
                                ImGui.TreePop();
                            }

                            if(ImGui.TreeNode("Human Info"))
                            {
                                SubWindowHuman.Draw(fighter);
                                ImGui.TreePop();
                            }

                            if (ImGui.TreeNode("Fighter Info"))
                            {
                                SubWindowFighter.Draw(fighter);
                                ImGui.TreePop();
                            }

                            ImGui.TreePop();
                        }
                    }

                    ImGui.TreePop();
                }
            }
        }
    }
}
