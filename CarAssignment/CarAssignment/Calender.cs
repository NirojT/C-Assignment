using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssignment
{
    public class Calender
    {
        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
                Thursday,
                Friday,
                Saturday,
                Sunday
        }
        public void PrintWeekdays()
        {
            Console.WriteLine($"All Day of the week are {DaysOfWeek.Monday} \n {DaysOfWeek.Tuesday} \n" +
                $"{DaysOfWeek.Wednesday} \n {DaysOfWeek.Friday} \n" +
                $"{DaysOfWeek.Saturday} \n {DaysOfWeek.Sunday}");
        }
    }
}
