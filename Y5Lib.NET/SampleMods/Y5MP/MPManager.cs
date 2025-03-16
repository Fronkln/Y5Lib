using System;
using System.Collections.Generic;
using Y5Lib;
using Steamworks;

namespace Y5MP
{
    internal static class MPManager
    {
        public static CSteamID Lobby;
        public static bool Connected = false;

        public static Dictionary<ulong, MPPlayer> Players = new Dictionary<ulong, MPPlayer>();
        public static Dictionary<IntPtr, MotionThingy> CharaMotions = new Dictionary<IntPtr, MotionThingy>();

        public static float Time = 0;

        public static void Update()
        {
            if (!Connected)
                return;

            Time = ActionManager.Time;

            int lobbyPlayers = SteamMatchmaking.GetNumLobbyMembers(Lobby);

            for (int i = 0; i < lobbyPlayers; i++)
            {
                CSteamID player = SteamMatchmaking.GetLobbyMemberByIndex(Lobby, i);

                if (!Players.ContainsKey(player.m_SteamID))
                {
                    MPPlayer playerObj = MPPlayer.Create(player);

                    if (playerObj != null)
                        Players.Add(player.m_SteamID, playerObj);
                }
            }

            ReadNetworkData();

            foreach (var kv in Players)
                kv.Value.Update();
        }

        public static void Disconnect()
        {
            if (!Connected)
                return;

            Connected = false;
            SteamMatchmaking.LeaveLobby(Lobby);

            foreach (var kv in Players)
                kv.Value.RemoveFighter();

            Players.Clear();
            CharaMotions.Clear();

            OE.LogInfo("Disconnected.");
        }

        public static void ReadNetworkData()
        {
            uint packetSize;

            while (SteamNetworking.IsP2PPacketAvailable(out packetSize, 0))
            {
                byte[] buffer = new byte[packetSize];
                uint readBytes = 0;
                CSteamID sender;

                if (SteamNetworking.ReadP2PPacket(buffer, packetSize, out readBytes, out sender))
                {
                    NetPacket netPacket = new NetPacket(buffer);
                    PacketHandler.HandleP2PMessage((PacketType)netPacket.Reader.ReadByte(), sender, netPacket);
                }
            }
        }

        public static void OnP2PRequest(P2PSessionRequest_t request)
        {
            OE.LogInfo("Accepting P2P request with " + request.m_steamIDRemote.Name());
            SteamNetworking.AcceptP2PSessionWithUser(request.m_steamIDRemote);
        }

        public static void OnLobbyChatUpdate(LobbyChatUpdate_t update)
        {
            CSteamID id = new CSteamID(update.m_ulSteamIDMakingChange);

            MPPlayer.LocalPlayer.SendInfoPacketToEveryone();

            switch ((EChatMemberStateChange)update.m_rgfChatMemberStateChange)
            {
                case EChatMemberStateChange.k_EChatMemberStateChangeEntered:
                    OE.LogInfo(id.Name() + " has entered the lobby.");
                    break;

                case EChatMemberStateChange.k_EChatMemberStateChangeDisconnected:
                    Players[id.m_SteamID].RemoveFighter();
                    Players.Remove(id.m_SteamID);

                    OE.LogInfo(id.Name() + " left.");
                    break;
                case EChatMemberStateChange.k_EChatMemberStateChangeLeft:
                    goto case EChatMemberStateChange.k_EChatMemberStateChangeDisconnected;
            }
        }

        public static void OnGameLobbyJoinRequested(GameLobbyJoinRequested_t request)
        {
            SteamMatchmaking.JoinLobby(request.m_steamIDLobby);
        }

        public static void OnLobbyEnter(LobbyEnter_t enter)
        {
            OE.LogInfo("Entered lobby: " + enter.m_ulSteamIDLobby);

            Lobby = (CSteamID)enter.m_ulSteamIDLobby;
            Connected = true;
            Time = 0;

            Players.Add(SteamUser.GetSteamID().m_SteamID, MPPlayer.Create(SteamUser.GetSteamID()));
            MPPlayer.LocalPlayer.SendInfoPacketToEveryone();
        }

        public static void OnLobbyCreate(LobbyCreated_t createdLobby)
        {
            OE.LogInfo("Created lobby: " + createdLobby.m_ulSteamIDLobby);
        }

        public static bool SendPacket(CSteamID target, NetPacket data, EP2PSend mode = EP2PSend.k_EP2PSendUnreliable)
        {
            if (!Connected)
                return false;

            bool status = SteamNetworking.SendP2PPacket(target, data.Stream.GetBuffer(), (uint)data.Stream.Length, mode, 0);

            if (!status)
                OE.LogError("Failed to send packet to " + target);

            return status;
        }

        public static bool SendToServer(NetPacket data, EP2PSend mode = EP2PSend.k_EP2PSendUnreliable)
        {
            if (!Connected)
                return false;

            return SendPacket(SteamMatchmaking.GetLobbyOwner(Lobby), data, mode);
        }

        public static bool SendToEveryone(NetPacket data, EP2PSend mode = EP2PSend.k_EP2PSendUnreliable)
        {
            if (!Connected)
                return false;

            int playerCount = SteamMatchmaking.GetNumLobbyMembers(Lobby);

            for (int i = 0; i < playerCount; i++)
                SendPacket(SteamMatchmaking.GetLobbyMemberByIndex(Lobby, i), data, mode);

            return true;
        }
    }
}
