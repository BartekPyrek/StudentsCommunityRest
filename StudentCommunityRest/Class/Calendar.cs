using System;
using System.Collections.Generic;
using StudentCommunityRest.Models;

namespace StudentCommunityRest.Class
{
    public class Calendar
    {
        private int year;
        private int month;
        private List<Event>[] days = new List<Event>[31 + 1];

        public int PaddingDays;
        public int DaysInMonth;
        public int CurrentMonth;
        public string CurrentMonthName;
        public int CurrentYear;

        public int PrevMonth;
        public int PrevYear;
        public int NextMonth;
        public int NextYear;


        public Calendar(int year, int month)
        {
            this.year = year;
            this.month = month;
            
            // count padding days
            var firstOfMonth = new DateTime(year, month, 1);
            this.PaddingDays = (int)firstOfMonth.DayOfWeek - 1;
            this.DaysInMonth = DateTime.DaysInMonth(year, month);
            this.CurrentMonth = firstOfMonth.Month;
            this.CurrentMonthName = firstOfMonth.ToString("MMMM");
            this.CurrentYear = firstOfMonth.Year;

            // inicjalizacja tablicy pustymi listami
            for (int i = 1; i <= 31; i++)
            {
                days[i] = new List<Event>();
            }

            // month -1
            DateTime prev = firstOfMonth.AddMonths(-1);
            this.PrevMonth = prev.Month;
            this.PrevYear = prev.Year;

            // month +1
            var next = firstOfMonth.AddMonths(1);
            this.NextMonth = next.Month;
            this.NextYear = next.Year;
            
        }

        /// <summary>
        /// Dodaje wydarzenie do kalendarza
        /// </summary>
        public void AddEvent(Event evnt)
        {
            var eventDate = evnt.Datetime;
            if (eventDate.Year == this.year && eventDate.Month == this.month)
            {
                var day = eventDate.Day;
                days[day].Add(evnt);
            }
        }

        /// <summary>
        /// Zwraca tablice zawierającą lsite wydarzeń
        /// </summary>
        public List<Event>[] getDays()
        {
            return this.days;
        }
    }
}