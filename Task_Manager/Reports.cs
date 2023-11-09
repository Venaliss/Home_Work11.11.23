using System;

namespace Task_Manager
{
    public class Reports
    {
        public Employee performer;
        public string str;
        public DateTime time = DateTime.Now;
        
        public Reports(Employee performer, string str)
        {
            this.performer = performer;
            this.str = str;
        }
    }
}
