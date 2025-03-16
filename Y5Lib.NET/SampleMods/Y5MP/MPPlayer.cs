using System;
using System.Threading.Tasks;
using Y5Lib;
using Steamworks;

namespace Y5MP
{
    internal class MPPlayer : NetworkedFighter
    {
        public static MPPlayer LocalPlayer = null;

        public string Model = "";
        public bool CharacterIsBeingCreated = false;

        uint LocalPlayerLastAnim = 0;

        public bool IsLocalPlayer()
        {
            return SteamUser.GetSteamID() == Owner;
        }

        public bool IsHost()
        {
            return SteamMatchmaking.GetLobbyOwner(MPManager.Lobby) == Owner;
        }

        public bool ShouldCreateChara()
        {
#if !DEBUG_CREATE_LOCAL_PLAYER_CHARA
            if (IsLocalPlayer())
                return false;
#endif

            if (CharacterIsBeingCreated)
                return false;

            if (string.IsNullOrEmpty(Model))
                return false;

            //DO NOT create player NPC's if kiryu does not exist!
            if (ActionFighterManager.Player.Pointer == IntPtr.Zero)
                return false;

            if (FighterExists())
                return false;

            return true;
        }

        public async Task<int> CreateChar()
        {
            MPManager.CharaMotions.Remove(FighterEntity.HumanMotion.Pointer);

            CharacterIsBeingCreated = true;

            DisposeInfo inf = new DisposeInfo();
            inf.N000002CE = 64904;
            inf.N00000520 = 52;
            inf.N00000521 = 11;
            inf.modelName.checksum = 1143;
            inf.modelName.Set(Model);
            inf.N00000549 = 300;
            inf.N0000054A = 100;
            inf.N00004547 = -1;
            inf.N0000454A = 4;
            inf.FighterType = NPCType.Mannequin;
            inf.N0000454B = 10;
            inf.N0000054B = 4;
            inf.N00004552 = 25;
            inf.spawnPosition = NetworkInf.LastPosition;
            inf.N0000054E = 5997;
            inf.battleStartAnim.Set("eMID_NONE");
            inf.N0000453C = -1;

            int index = await ActionFighterManager.SpawnCharacterAsync(inf);

            if (index < 0)
                OE.LogWarning("Fighter limit reached! Player character cannot be created!");
            else
            {
                //FighterEntity = ActionFighterManager.GetFighter(index);

                DisposeCache = inf;
                //   MPManager.FighterCharas[fighter.Pointer] = fighter;
            }

            CharacterIsBeingCreated = false;

            return index;
        }

        public static MPPlayer Create(CSteamID id)
        {
            if (id.m_SteamID == 0)
            {
#if DEBUG
                OE.LogWarning("Attempted to create player with 0 steamID. Ignoring");
#endif
                return null;
            }

            MPPlayer player = new MPPlayer();
            player.FighterIndex = -1;
            player.Owner = id;

            if (player.IsLocalPlayer())
                LocalPlayer = player;

            return player;
        }

        public void RemoveFighter()
        {
            //as of right now, its not possible to "destroy" player entities
            //we shall teleport them to someplace they will never be found!
            //when a player enters an encounter/changes map, the game will dispose them.

            if (!FighterExists())
                return;

            FighterEntity.HumanMotion.SetPosition(new Vector3(9999, 9999, 9999));
            FighterIndex = -1;

            MPManager.CharaMotions.Remove(FighterEntity.HumanMotion.Pointer);
        }

        public override void UpdateNetworkInf()
        {

            NetPacket packet = new NetPacket(false);
            packet.Writer.Write((byte)PacketType.NetworkedFighterUpdate);
            packet.Writer.Write(false);
            packet.Writer.Write(GetNetID());

            Fighter localPlr = ActionFighterManager.Player;

            packet.Writer.Write(localPlr.Position);
            packet.Writer.Write(localPlr.HumanMotion.GetAngleY());

            MPManager.SendToEveryone(packet);
        }

        public void SendInfoPacketToEveryone()
        {
            NetPacket packet = new NetPacket(false);
            packet.Writer.Write((byte)PacketType.PlayerInfo);
            packet.Writer.Write(ActionFighterManager.Player.Model);

            MPManager.SendToEveryone(packet, EP2PSend.k_EP2PSendReliable);
        }

        public override void OwnerUpdate()
        {
            base.OwnerUpdate();

            if (CharacterIsBeingCreated)
                return;

            Fighter player = ActionFighterManager.Player;

            if (player.Pointer != IntPtr.Zero)
            {

                uint curAnim = player.HymanMotion.CurrentAnimation;

                if (curAnim != LocalPlayerLastAnim || player.HumanMotion.AnimationTime < 0.05f)
                {
                    NetPacket packet = new NetPacket(false);
                    packet.Writer.Write((byte)PacketType.NetworkedFighterPlayAnim);
                    packet.Writer.Write(curAnim);

                    MPManager.SendToEveryone(packet, EP2PSend.k_EP2PSendReliable);
                }

                LocalPlayerLastAnim = curAnim;

            }
        }

        public async override void Update()
        {
            base.Update();

            if (CharacterIsBeingCreated)
                return;

            if (ShouldCreateChara())
            {
                FighterIndex = await CreateChar();

                if (FighterIndex > 0)
                    OE.LogInfo("Created character for " + Owner.Name());
            }

            if (!FighterExists())
                return;

            if (!MPManager.CharaMotions.ContainsKey(FighterEntity.HumanMotion.Pointer))
                MPManager.CharaMotions.Add(FighterEntity.HumanMotion.Pointer, FighterEntity.HumanMotion);

            MoveToPosition();
        }
    }
}
