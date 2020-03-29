//
// ICT2106 Software Design - Timer exercise
//
// Main program.
//

namespace Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a clock
            Timer timer = new Timer();

            // create some alarms
            TextAlarm alarm1 = new TextAlarm("Wake up!", 5);

            // attach the alarms to the clock
            timer.Attach(alarm1);

            // run the clock for thirty seconds
            timer.Run(15);
        }
    }
}
