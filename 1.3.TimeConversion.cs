
public class TimeConversion
{
 

    public static string timeConversion(string s)
    {
        string[] time = s.Split(':');
        string militaryHour = string.Empty;

        if (time[2].Contains("PM"))
        {
            if (time[0] == "12")
                militaryHour += time[0];
            else
                militaryHour += (int.Parse(time[0]) + 12).ToString();
        }
        else
        {
            if (time[0] == "12")
                militaryHour += "00";
            else
                militaryHour += time[0];
        }

        militaryHour += string.Format(":{0}:{1}", time[1], time[2].Substring(0, 2));

        return militaryHour;
    }
}
