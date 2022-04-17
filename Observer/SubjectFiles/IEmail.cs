using Observer.ObserverFiles;
using System.Collections.Generic;
using System.Timers;

namespace Observer.SubjectFiles
{
    public interface IEmail:ISubject
    {
        public void CreateTimer();

        public void HandleTimerElapsed(object sender, ElapsedEventArgs e);
    }
}