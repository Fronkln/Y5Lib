using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y5Lib
{
    public struct EntityHandle
    {
        public int UID;


        public EntityHandle(Entity ent)
        {
            if (ent != null)
                UID = ent.UID;
            else
                UID = 0;
        }

        public EntityHandle(int uid)
        {
            UID = uid;
        }

        public bool IsValid()
        {
            return UID != 0 && ActionEntityManager.GetEntityByUID(UID) != IntPtr.Zero;
        }

        public T To<T>() where T: Entity, new()
        {
            IntPtr entPtr = ActionEntityManager.GetEntityByUID(UID);

            T ent = new T();
            ent.Pointer = entPtr;

            return ent;
        }
    }
}
