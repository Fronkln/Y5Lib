using Y5Lib;
using ImGuiNET;
using System.IO.Pipes;
using System.IO;
using System;
using System.Threading;
using System.Diagnostics;
using System.Net.Sockets;

namespace Y5_Debug_Tools
{
    internal static class UnityIntegration
    {

        private static Thread thread;
        private static NamedPipeClientStream clientStream;

        private static float m_nextWrite = 0;
        private static bool m_isRunning = false;

        private static string filePath = "mods/DebugTools/integration_file";

        public static void Draw()
        {
            if (ImGui.Begin("Unity Integration"))
                if (!m_isRunning)
                {
                    if (ImGui.Button("Connect"))
                    {
                        OE.LogInfo("started session");
                        m_isRunning = true;

                        thread = new Thread(WriteThread);
                        thread.Start();
                    }
                }
                else
                {
                    if (ImGui.Button("Disconnect"))
                    {
                        OE.LogInfo("disconnected");
                        m_isRunning = false;

                        thread.Abort();
                        clientStream.Close();
                    }
                }

            if(m_isRunning)
            {
                /*
                using (MemoryStream ms = new MemoryStream())
                {
                    using(BinaryWriter bw = new BinaryWriter(ms))
                    {
                        Fighter targetFighter = ActionFighterManager.GetFighter(0);
   
                        Vector3 pos = targetFighter.Position;
                        bw.Write(pos.x);
                        bw.Write(pos.y);
                        bw.Write(pos.z);
                        bw.Write((uint)targetFighter.HumanMotion.GetAngleY());

                        File.WriteAllBytes(filePath, ms.ToArray());
                    }
                }
                */
                
            }
        }


        static void WriteThread()
        {
            OE.LogInfo("Start");
            clientStream = new NamedPipeClientStream(".", "IT_ClientWrite", PipeDirection.Out);
            clientStream.Connect();

            OE.LogInfo("Connected");

            while (true)
            {
                try
                {
                    System.Random rand = new System.Random();
                    Vector3 rnd = new Vector3(rand.Next(0, 1000), rand.Next(0, 1000), rand.Next(0, 1000));


                    BinaryWriter bw = new BinaryWriter(clientStream);
                    Fighter targetFighter = ActionFighterManager.GetFighter(0);

                    Vector3 pos = targetFighter.Position;
                    bw.Write(pos.x);
                    bw.Write(pos.y);
                    bw.Write(pos.z);
                    bw.Write((uint)targetFighter.HumanMotion.GetAngleY());
                    bw.Flush();
                    //new StreamString(clientStream).WriteString(new System.Random().Next(0, 1000).ToString());
                }
                catch
                {
                    clientStream.Close();
                    m_isRunning = false;
                    break;
                }
            }
        }
    }
}
