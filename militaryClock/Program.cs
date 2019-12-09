using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace militaryClock
{
    /// <summary>
    /// Author: David Krummen
    /// Creation Date: 9/22/2019
    /// Company: Onshore Outsourcing Bootcamp
    /// Description: Military Clock without using date time. Displays 00:00:00 - 23:59:59
    /// </summary>
    /// 
    class Program
    {
        static void Main(string[] args)
        {

            //Set seconds, minutes and hours to 0 to start clock
            //Create loop to count 60 seconds
            //Write time on one line every second
            //Add one second every loop
            //Once 'seconds' hits 59 the next it will reset to 00 and add 1 to 'minutes'
            //Once 59 minutes and 59 seconds they reset to 00 and adds 1 to hours
            //repeat until 23:59:59 then reset to 00:00:00 and keep looping the whole process


            //Start clock at 00:00:00
            int Seconds= 0;
            int Minutes = 0;
            int Hours =0;


            for (int i = 0; i <= 60; i++)//Loop increments on 'seconds'
            {
                // .Write prints time on one line
                // "\r{0}" resets the line so new time can display
                //.ToString("D2") formats interger to have at least 2 digits. Prints 00 - 09 insted of 0 - 9
                Console.Write("\r{0}", Hours.ToString("D2") + ":" + Minutes.ToString("D2") + ":" + Seconds.ToString("D2"));
                Thread.Sleep(1000);// Sets a 1000ms (1 second) pause for each new time display
                Seconds++;// Adds a second each run of loop

                //If statments control 'seconds' & 'minutes' to prevent the display of 60 and 24 hours
                if (i >= 60)
                {
                    i = 0;
                    Seconds = 0;
                    Minutes++;
                }
                if (Minutes >= 60)
                {
                    Minutes = 0;
                    Hours++;
                }
                if (Hours >= 24)
                {
                    Hours = 0;
                }
            }
        }
    }
}
