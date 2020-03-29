//
// ICT2106 Software Design - Observer example
//
// Interface to be implemented by all observers.
//
// Author: Seng Yong
//

namespace Timer
{
    interface ITimer
    {
        // attach the observer
        void Attach(INotification notification);
        // detach the observer
        void Detach(INotification notification);
        // notify the observer
        void Notify();
    }
}
