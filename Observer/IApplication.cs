using Observer.ObserverFiles;
using Observer.SubjectFiles;

namespace Observer
{
    public interface IApplication
    {
        IEmail Email { get; set; }
        IEmailWatcher EmailWatcher { get; set; }

        void Run();
    }
}