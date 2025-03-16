using System;
using Y5Lib;

namespace Y5_Debug_Tools
{
    public static class NoclipMode
    {
        private static bool m_enabled = false;

        private static Vector4 m_curPos;
        private static float m_curAng;

        private const float m_speed = 8;

        public static void Toggle()
        {
            Toggle(!m_enabled);
        }

        public static void Toggle(bool enabled)
        {
            if (m_enabled == enabled)
                return;

            if (enabled)
            {
                m_curPos = ActionFighterManager.Player.Position;
                OE.RegisterJob(Update, 16);
            }
            else
                OE.UnregisterJob(Update, 16);

            m_enabled = enabled;
        }

        private static void Update()
        {
            Human player = ActionFighterManager.Player;

            Vector3 movement = Vector3.zero;
            float rotation = 0;


            if (OE.IsKeyHeld(VirtualKey.Q))
                movement += -player.Transform.upDirection;
            if (OE.IsKeyHeld(VirtualKey.E))
                movement += player.Transform.upDirection;

            if (OE.IsKeyHeld(VirtualKey.A))
                rotation += 0.5f;
            if (OE.IsKeyHeld(VirtualKey.D))
                rotation -= 0.5f;

            if (DragonEngine.IsKeyHeld(VirtualKey.W))
                movement += player.Transform.forwardDirection;
            if (DragonEngine.IsKeyHeld(VirtualKey.S))
                movement += -player.Transform.forwardDirection;


            float outSpeed = m_speed * (DragonEngine.IsKeyHeld(VirtualKey.LeftShift) ? 2 : 1);

            m_curPos += (movement * outSpeed) * DragonEngine.deltaTime;
            m_curAng += (rotation * outSpeed) * DragonEngine.deltaTime;

            player.RequestWarpPose(new PoseInfo(m_curPos, m_curAng));
            // player.Transform.Position = m_curPos;
            // player.Transform.Orient = m_curAng;
        }
    }
}
