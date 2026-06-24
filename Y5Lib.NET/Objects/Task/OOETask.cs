using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y5Lib
{
    public class OOETask
    {
        protected bool m_isComplete;
        protected Action m_onComplete;
        protected Func<bool> m_checkDelegate;

        public OOETask(Func<bool> checkDelegate, Action onFinished)
        {
            m_checkDelegate = checkDelegate;
            m_onComplete = onFinished;
        }

        public bool IsComplete()
        {
            return m_isComplete;
        }

        public virtual void Update()
        {
            if (m_checkDelegate.Invoke())
                OnComplete();
        }

        protected void OnComplete()
        {
            m_isComplete = true;
            m_onComplete?.Invoke();
        }
    }
}
