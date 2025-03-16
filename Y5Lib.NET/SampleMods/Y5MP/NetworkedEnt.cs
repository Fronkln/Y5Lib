using Steamworks;

namespace Y5MP
{
    public class BaseP2PObject
    {
        public CSteamID Owner;
        public virtual float UpdateInterval => 0.1f;
        protected float NextUpdate = 0;

        public virtual void OwnerUpdate()
        {

        }

        public virtual void OwnerIntervalUpdate()
        {

        }

        public bool IsOwner()
        {
            return Owner == SteamUser.GetSteamID();
        }


        /// <summary>
        /// Should ideally send a packet
        /// </summary>
        public virtual void UpdateNetworkInf()
        {
        }

        public virtual void Update()
        {
            if (IsOwner())
            {
                OwnerUpdate();

                if (MPManager.Time >= NextUpdate)
                    OwnerIntervalUpdate();
            }
        }
    }
}
