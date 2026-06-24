using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Y5Lib 
{
    public class OOETaskTime : OOETask
    {
        private float m_targetTime;
        private float m_curTime;

        public OOETaskTime(float time, Action onFinished) : base(null, onFinished)
        {
            m_targetTime = time;
            m_onComplete = onFinished;
        }
        public override void Update()
        {
            if (!IsComplete())
            {
                m_curTime += ActionManager.DeltaTime;

                if (m_curTime >= m_targetTime)
                    OnComplete();
            }
        }
    }
}
