//
// ICT2106 Software Design - Timer exercise
//
// A class that prints a message to the screen every time it receives a notification.
//

using System;

namespace Timer
{
    class TextAlarm : INotification
    {
        // the message to be printed
        private string message;
        private int seconds{set; get;}

        // constructor
        public TextAlarm(string messageIn, int count)  
        {
            // save the message for later
            message = messageIn;
            seconds = count;
        }

        // get tick
        public int getSecond(){
            return seconds;
        }

        public void decreaseCount(){
            seconds--;
        }

		
		// to be invoked when the alarm is triggered
		public void Update()
		{
			Console.WriteLine(message);
		}
    }
}
