using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multithreads2
{
    enum ActionStatus 
    {
        Active,
        InProcess,
        NoActive
    }
    enum MemoryStatus
    {
        MemoryNotNeeded,
        MemoryNeeded,
        TaskFinishedAndMemoryNeeded,
        InProgress
    }
    class Thread
    {
        private List<IAction> actions;
        public ActionStatus ReadStatus { get; set; } = ActionStatus.Active;
        public ActionStatus ComputeStatus { get; set; } = ActionStatus.NoActive;
        public ActionStatus WriteStatus { get; set; } = ActionStatus.NoActive;

        private TimeConsumeSettings timeConsumeSettings;
        public Thread(TimeConsumeSettings _timeConsumeSettings)
        {
            actions = new List<IAction>();
            timeConsumeSettings = _timeConsumeSettings;
        }

        public Thread(Thread thread)
        {
            actions = new List<IAction>(thread.actions);
            ReadStatus = thread.ReadStatus;
            ComputeStatus = thread.ComputeStatus;
            WriteStatus = thread.WriteStatus;
            timeConsumeSettings = thread.timeConsumeSettings;
        }

        public int AllTimeConsumed()
        {
            int allTimeConsumed = 0;
            foreach (IAction action in actions)
                allTimeConsumed += action.GetTimeConsume();
            return allTimeConsumed;
        }

        public MemoryStatus TickAndCheck() 
        {
            if (actions.Count == 0)
                return MemoryStatus.MemoryNeeded;
            if (actions.Last().TickAndCheck())
            {
                if (ReadStatus == ActionStatus.InProcess)
                {
                    ReadStatus = ActionStatus.NoActive;
                    ComputeStatus = ActionStatus.Active;
                    return MemoryStatus.MemoryNotNeeded;
                }
                else if (ComputeStatus == ActionStatus.InProcess)
                {
                    ComputeStatus = ActionStatus.NoActive;
                    WriteStatus = ActionStatus.Active;
                    return MemoryStatus.MemoryNeeded;
                }
                else if (WriteStatus == ActionStatus.InProcess)
                {
                    WriteStatus = ActionStatus.NoActive;
                    ReadStatus = ActionStatus.Active;
                    return MemoryStatus.TaskFinishedAndMemoryNeeded;
                }
                else if (ReadStatus == ActionStatus.Active || WriteStatus == ActionStatus.Active)
                {
                    return MemoryStatus.MemoryNeeded;
                }
                else 
                {
                    return MemoryStatus.MemoryNotNeeded;
                }
            }
            return MemoryStatus.InProgress;
        }

        public List<ListViewItem> Show() 
        {
            List<ListViewItem> show = new List<ListViewItem>();
            foreach (IAction action in actions) 
            {
                show.Add(new ListViewItem(new string[] {
                            action.GetName(),
                            action.GetTimeConsume().ToString() } 
                ));
            }
            return show;
        }

        public void AddAction(bool isNextAction) 
        {
            if (isNextAction)
            {
                if (ReadStatus == ActionStatus.Active)
                {
                    actions.Add(new ReadMemory(timeConsumeSettings.timeReadUnit));
                    ReadStatus = ActionStatus.InProcess;
                }
                else if (ComputeStatus == ActionStatus.Active)
                {
                    actions.Add(new Compute(timeConsumeSettings.timeComputeUnit));
                    ComputeStatus = ActionStatus.InProcess;
                }
                else if (WriteStatus == ActionStatus.Active)
                {
                    actions.Add(new WriteMemory(timeConsumeSettings.timeWriteUnit));
                    WriteStatus = ActionStatus.InProcess;
                }
            }
            else
                actions.Add(new Lock());
        }
    }
}
