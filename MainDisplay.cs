using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeDataScheduling;

namespace RoomFinder_1
{
    public class MainDisplay
    {
        Bitmap Available = new Bitmap(@"C:\Users\josha\Destop_project\repos\RoomFinder_1\RoomFinder_1\Images\available.png");
        Bitmap Not_Available = new Bitmap(@"C:\Users\josha\Destop_project\repos\RoomFinder_1\RoomFinder_1\Images\Not_available.png");

        // Display the image
        public Bitmap RoomImage(string name, TimeSpan current)
        {
            var datetime = DataModels.GetTimeSpan(name);
            List<string> start = datetime.Item1;
            List<string> end = datetime.Item2;
            List<int> hasclass = datetime.Item3;

            int indexResult = GetTime(start, end, current);

            if (indexResult != -1)
            {
                if (hasclass[indexResult] == 1)
                {
                    return Not_Available;
                }
                else
                {
                    return Available;
                }
            }

            return Available;
        }

        // Display the time of rooms
        public string RoomTimeGet(string name, TimeSpan current)
        {
            var datetime = DataModels.GetTimeSpan(name);
            List<string> start = datetime.Item1;
            List<string> end = datetime.Item2;
            List<int> hasclass = datetime.Item3;
            string time;

            int indexResult = GetTime(start, end, current);

            if (indexResult != -1)
            {
                if (hasclass[indexResult] == 1)
                {
                    time = $"Class: {start[indexResult]} - {end[indexResult]}";
                    return time;
                }
                else
                {
                    time = $"Available: {start[indexResult]} - {end[indexResult]}";
                    return time;
                }
            }

            return "Out of Index!";
        }

        //Check Time
        public static int GetTime(List<string> start, List<string> end, TimeSpan current)
        {
            for (int i = 0; i < start.Count; i++)
            {
                TimeSpan Start = DateTime.ParseExact(start[i], "h:mm tt", null).TimeOfDay;
                TimeSpan End = DateTime.ParseExact(end[i], "h:mm tt", null).TimeOfDay;

                if (current >= Start && current <= End)
                    return i;
            }

            return -1;
        }

    }
}
