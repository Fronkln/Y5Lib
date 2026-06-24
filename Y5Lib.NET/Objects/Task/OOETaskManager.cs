using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y5Lib
{
    public static class OOETaskManager
    {
        private static List<OOETask> m_tasksToStart = new List<OOETask>();
        private static List<OOETask> m_tasks = new List<OOETask>();

        public static void Update()
        {
            foreach (var task in m_tasksToStart)
                m_tasks.Add(task);

            m_tasksToStart.Clear();

            List<OOETask> incompleteTasks = new List<OOETask>();

            foreach (OOETask task in m_tasks)
                if (!task.IsComplete())
                    incompleteTasks.Add(task);

            m_tasks = incompleteTasks;

            foreach (OOETask task in m_tasks)
                task.Update();
        }

        public static void StartTask(OOETask task)
        {
            m_tasksToStart.Add(task);
        }
    }
}
