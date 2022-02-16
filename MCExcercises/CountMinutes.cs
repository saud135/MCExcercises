using System;

namespace MCExcercises
{
    public class CountMinutes
    {
        public class CountingMinutes
        {
           public  string countMinutes(string str)
            {
                string[] times = str.Split("-");

                int totalMinutes = 0;

                string fromTime = times[0].Substring(times[0].Length - 2);
                string toTime = times[1].Substring(times[1].Length - 2);


                if (!fromTime.Equals(toTime))
                    totalMinutes = 720;

                string fromHour = times[0].Substring(0, times[0].IndexOf(":"));
                string toHour = times[1].Substring(0, times[1].IndexOf(":"));

                string fromMinutes = times[0].Substring((times[0].IndexOf(":") + 1), 2);
                string toMinutes = times[1].Substring((times[1].IndexOf(":") + 1), (2));

                int fromMinutesTotal = ((int.Parse(fromHour) * 60) + int.Parse(fromMinutes));
                int toMinutesTotal = ((int.Parse(toHour) * 60) + int.Parse(toMinutes));

                totalMinutes = (totalMinutes + (toMinutesTotal - fromMinutesTotal));

                if ((Math.Sign(totalMinutes) == -1))
                    return (1440 + totalMinutes).ToString();


                return totalMinutes.ToString();
            }
        }
    }
}
