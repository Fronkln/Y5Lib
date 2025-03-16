using System;
using Steamworks;
using Y5Lib;
using Y5MP;

namespace Y5MP
{
    public struct FighterNetworkInfo
    {
        public Vector3 LastPosition;
        public short LastYRotation;
    }

    public abstract class NetworkedFighter : BaseP2PObject
    {
        public int FighterIndex = -1;
        public Fighter FighterEntity { get { return ActionFighterManager.GetFighter(FighterIndex); } }

        public DisposeInfo DisposeCache;
        public FighterNetworkInfo NetworkInf;

        public bool DebugFreezeLocation = false;

        public virtual ushort GetNetID()
        {
            return 0;
        }

        public bool FighterExists()
        {
            if (FighterIndex == -1)
                return false;

            if (FighterEntity == null)
                return false;

            if (FighterEntity.Pointer == IntPtr.Zero)
                return false;

            Fighter mngFighter = ActionFighterManager.GetFighter(FighterIndex);

            if (mngFighter.Pointer == IntPtr.Zero)
                return false;

            if (mngFighter.Pointer != FighterEntity.Pointer)
                return false;

            return true;
        }


        protected void MoveToPosition()
        {


            Fighter character = FighterEntity;
            Vector3 pos = FighterEntity.Position;

            float dist = Vector3.Distance(pos, NetworkInf.LastPosition);

            if (dist >= 5)
                character.Motion.SetPosition(NetworkInf.LastPosition);
            else
            {
                Vector3 lerpedPos = Vector3.Lerp(pos, NetworkInf.LastPosition, 0.1f);
                character.Motion.SetPosition(lerpedPos);
            }

            character.Motion.SetAngleY(NetworkInf.LastYRotation);

        }

        public override void UpdateNetworkInf()
        {
            if (!FighterExists())
                return;

            Fighter fighter = FighterEntity;


            NetPacket packet = new NetPacket(false);
            packet.Writer.Write((byte)PacketType.NetworkedFighterUpdate);
            packet.Writer.Write(false); //isenemy
            packet.Writer.Write(GetNetID());

            packet.Writer.Write(fighter.Position);
            packet.Writer.Write(fighter.Motion.GetAngleY());

            MPManager.SendToEveryone(packet);
        }

        public override void OwnerIntervalUpdate()
        {
            base.OwnerIntervalUpdate();
            UpdateNetworkInf();
        }
    }
}
