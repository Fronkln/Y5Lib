using Y5Lib;
using ImGuiNET;

namespace Y5_Debug_Tools
{
    internal static class SubWindowEntity
    {
        public static void Draw(Entity entity)
        {
            ImGui.Text("Position: " + entity.Position);
        }
    }
}
