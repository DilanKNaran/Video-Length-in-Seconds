using System.Text.RegularExpressions;

namespace VideoLengthSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of minutes with the following format mm:ss");
            string minutes = Console.ReadLine();
            int result = MinuteToSeconds(minutes);
            Console.WriteLine(minutes + " = " + result);
        }

        public static int MinuteToSeconds(string minutes)
        {
            int result = 0;
            if (minutes.IndexOf(':') > -1)
            {
                string[] minutesArray = minutes.Split(":");
                if (Regex.IsMatch(minutesArray[0], @"^\d+$") && Regex.IsMatch(minutesArray[1], @"^\d+$"))
                {
                    if (!(int.Parse(minutesArray[1]) >= 60))
                    {
                        result = (int.Parse(minutesArray[0]) * 60) + int.Parse(minutesArray[1]);
                    }
                    else
                    {
                        result = -1;
                    }
                }
                else
                {
                    Console.WriteLine("Rerun app with the following format mm:ss including numbers only for the minutes and seconds");
                }
            }
            else
            {
                Console.WriteLine("Rerun app with the following format mm:ss including the colon character \":\"");
            }
            return result;
        }
    }
}

