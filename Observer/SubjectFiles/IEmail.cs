using Observer.ObserverFiles;
using System.Collections.Generic;

namespace Observer.SubjectFiles
{
    public interface IEmail:ISubject
    {
        string Message { get; set; }
    }
}