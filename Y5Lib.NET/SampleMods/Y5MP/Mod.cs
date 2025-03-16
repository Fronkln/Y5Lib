using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Collections.Generic;
using Steamworks;
using Y5Lib;
using MinHook.NET;

namespace Y5MP
{
    public class Mod : Y5Mod
    {
        private List<object> m_callbacks = new List<object>();

        public void InputThread()
        {
            while(true)
            {
                if (OE.IsKeyDown(VirtualKey.Numpad7))
                    SteamMatchmaking.CreateLobby(ELobbyType.k_ELobbyTypePublic, 8);
            }
        }

        public override void OnModInit()
        {

            try
            {
                MinHookHelper.initialize();
            }
            catch { }

            m_callbacks.Add(Callback<P2PSessionRequest_t>.Create(MPManager.OnP2PRequest));
            m_callbacks.Add(Callback<LobbyChatUpdate_t>.Create(MPManager.OnLobbyChatUpdate));
            m_callbacks.Add(Callback<LobbyCreated_t>.Create(MPManager.OnLobbyCreate));
            m_callbacks.Add(Callback<LobbyEnter_t>.Create(MPManager.OnLobbyEnter));
            m_callbacks.Add(Callback<GameLobbyJoinRequested_t>.Create(MPManager.OnGameLobbyJoinRequested));

            MPHooks.Init();

            //Executes before pretty much anything. Ideal for overriding any value
            OE.RegisterJob(MPManager.Update, 20);

            Thread thread = new Thread(InputThread);
            thread.Start();

            Console.WriteLine("Y5MP");
        }
    }
}
