using Observer.ObserverFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.SubjectFiles
{
    public interface ISubject
    {
        List<IObservers> Observers { get; set; }
        void NotifyObservers();
    }
}
