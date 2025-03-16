using System;
namespace Y5Lib
{
    internal class Noclip
    {
        private static bool m_enabled = false;

        private static Vector3 m_curPos;
        private static short m_curAng;

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
                m_curPos = ActionFighterManager.GetPlayer().Position;

                OE.RegisterJob(Update, 20);
            }
            else
                OE.UnregisterJob(Update, 20);

            m_enabled = enabled;
        }

        private static void Update()
        {
            if (!m_enabled)
                return;

            Fighter player = ActionFighterManager.GetFighter(0);

            Vector3 movement = Vector3.zero;
            short rotation = 0;

            float movespeed = 0.01f;

            if (OE.IsKeyHeld(VirtualKey.Q))
                movement += -Vector3.up;
            if (OE.IsKeyHeld(VirtualKey.E))
                movement += Vector3.up;

            if (OE.IsKeyHeld(VirtualKey.A))
                rotation += 500;
            if (OE.IsKeyHeld(VirtualKey.D))
                rotation -= 500;


            Matrix4x4 rootMtx = player.HumanMotion.Matrix;

            if (OE.IsKeyHeld(VirtualKey.W))
                movement += rootMtx.ForwardDirection;
            if (OE.IsKeyHeld(VirtualKey.S))
                movement += -rootMtx.ForwardDirection;
            

            float outSpeed = m_speed * (OE.IsKeyHeld(VirtualKey.LeftShift) ? 2 : 1);

            m_curPos += (movement * outSpeed) * movespeed;
            m_curAng += (short)((rotation * outSpeed) * movespeed);

            m_curAng += rotation;

            player.HumanMotion.SetPosition(m_curPos);
            player.HumanMotion.SetAngleY(m_curAng);
            // player.Transform.Position = m_curPos;
            // player.Transform.Orient = m_curAng;
        }
    }
}
