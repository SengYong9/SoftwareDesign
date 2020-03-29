//
// ICT2106 Software Design - Observer example
//
// Interface to be implemented by all observers.
//
// Author: Seng Yong
//

namespace Timer
{
    interface INotification
    {
        // get tick
        int getSecond();
        // decrement second
        void decreaseCount();

        // send an update
        void Update();
    }
}
