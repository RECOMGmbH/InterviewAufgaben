using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class WorkTime
    {
        /// <summary>
        /// Given a list of planned meetings and unplanned phone calls, calculates the max. TimeSpan you can work concentrated on your own task.
        /// </summary>
        public static int Calculate(Meeting[] meetings, PhoneCall[] phoneCalls)
        {
            return 0;
        }
    }

    public class Meeting
    {
        public DateTime Begin { get; set; }
        public TimeSpan Duration{ get; set; }
    }

    public class PhoneCall
    {
        public DateTime Begin { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
