using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class Timer
    {
        public static bool start = false;
        public static int Minutes = 25;
        public static int Seconds = 00;
        public static int nextState = 0; // 1 = break, 0 = study

        public static string Formatting()
        {
            string text = "";
            if (Timer.Seconds.ToString().Length == 1)
            {
                text = Timer.Minutes.ToString() + ":0" + Timer.Seconds.ToString();

            }
            else
            {
                text = Timer.Minutes.ToString() + ":" + Timer.Seconds.ToString();
            }

            return text;
        }
    }

    
}
