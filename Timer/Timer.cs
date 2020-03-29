//
// ICT2106 Software Design - Timer exercise
//
// A class representing a timer.
//
using System;
using System.Collections.Generic;

namespace Timer
{
    class Timer : ITimer
    {
        private List<INotification> obsList;
        private List<INotification> detachList;

        // constructor
        public Timer(){
            obsList = new List<INotification>();
            detachList = new List<INotification>();
        }

        // repeatedly wait one second, exiting after numberOfTicks iterations
        public void Run(int numberOfTicks)
        {
            while (numberOfTicks > 0)
            {
                System.Threading.Thread.Sleep(1000);
                System.Console.WriteLine("Sleeping...");
                Notify();
                numberOfTicks--;
            }
            System.Console.ReadLine();
        }

         // attach the observer
        public void Attach(INotification notification){
            obsList.Add(notification);
        }
        // detach the observer
        public void Detach(INotification notification){
            obsList.Remove(notification);
        }

        // notify the observer
        public void Notify(){
            foreach (var element in obsList){
                if(element.getSecond() == 0){
                    element.Update();
                    detachList.Add(element);
                } else {
                    element.decreaseCount();
                }
            }
            RemoveQueue();
        }

        // check the remove queue for list of observer to be detach
        private void RemoveQueue()
        {
            foreach(var i in detachList) 
            {
                Detach(i);
            }
            detachList.Clear();
        }
    }
}
