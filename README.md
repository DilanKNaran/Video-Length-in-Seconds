# Video-Length-in-Seconds

This Console C# application accepts user input and converts the length of a video given minutes and seconds into seconds. The length of the video will be entered by the user as a string in the format: "mm:ss" and the program will return the result in seconds as an integer in the format: "ss". However if the user enters 60 or more seconds, the program will return -1.

For example:
- MinuteToSeconds("01:00") = 60
- MinuteToSeconds("13:58") = 836
- MinuteToSeconds("10:60") = -1
- MinuteToSeconds("121:49") = 7309

This program was made in Visual Studio, using C#. This program was made for Sloth's Weekly Challenge for the week of 24 September 2024. This is my first time doing on of these weekly challenges and I really enjoyed it!


## Function
This code block is the function I was tasked to create.
```
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
```
