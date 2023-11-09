using System;
using System.Collections.Generic;

namespace Task_Manager
{
    public class Works
    {
        public enum Period
        {
            Custom,
            Daily,
            Monthly,
            None
        }

        public enum Status
        {
            Assigned,
            Worked,
            Tested,
            Done
        }


        public string descriptions;
        public DateTime deadlines;
        public Employee performer;
        public Employee perk;
        public Status status;

        public List<Reports> reports = new List<Reports>();
        Period period;
        byte day;

        public void Complete()
        {
            status = Status.Done;
        }

        public Works(string description, DateTime deadlines, Employee perk, Period period, byte day)
        {
            if (day > 31 & day < 0)
            {
                throw new ArgumentException("День должен находиться в промежутке от 1 до 31");
            }
            this.period = period;
            this.day = day;
            this.descriptions = descriptions;
            this.deadlines = deadlines;
            this.perk = perk;
        }  
        
    }
}
