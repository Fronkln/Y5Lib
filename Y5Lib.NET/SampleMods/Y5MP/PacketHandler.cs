using System;
using Steamworks;
using Y5Lib;

namespace Y5MP
{
    internal static class PacketHandler
    {
        public static void HandleP2PMessage(PacketType type, CSteamID sender, NetPacket packet)
        {
            //Ignore any packets sent by this player until MPManager creates their player object.
            if (!MPManager.Players.ContainsKey(sender.m_SteamID))
                return;

            MPPlayer senderPlayer = MPManager.Players[sender.m_SteamID];
            Fighter senderChara = senderPlayer.FighterEntity;

            switch (type)
            {
                default:
                    OE.LogWarning("Unnkown RPC: " + type);
                    break;

                case PacketType.PlayerInfo:
                    senderPlayer.Model = packet.Reader.ReadString();
                    break;

                case PacketType.NetworkedFighterPlayAnim:
                    senderChara.Motion.NextAnimation = packet.Reader.ReadUInt32();
                    Console.WriteLine(senderChara.Motion.NextAnimation);
                    break;

                case PacketType.NetworkedFighterUpdate:
                    //False = networked player
                    bool updFighterIsEnemy = packet.Reader.ReadBoolean();
                    //only used for enemies
                    ushort updFighterNetID = packet.Reader.ReadUInt16();

                    if (updFighterIsEnemy)
                    {
                        /*
                        if (!MPManager.Enemies.ContainsKey(updFighterNetID))
                        {
                            OOE.LogError("Enemy " + updFighterNetID + " don't exist we desynced");
                            return;
                        }
                        */
                    }

                    NetworkedFighter fighter = null;

                    if (updFighterIsEnemy) 
                        ;
                    //fighter = MPManager.Enemies[updFighterNetID];
                    else
                        fighter = senderPlayer;

                    if (!fighter.DebugFreezeLocation)
                    {
                        fighter.NetworkInf.LastPosition = packet.Reader.ReadVector3();
                        fighter.NetworkInf.LastYRotation = packet.Reader.ReadInt16();
                    }

                    break;
            }
        }
    }
}
