using System;
using System.Collections.Generic;

namespace SchoolSchedule
{
   
    public class Class1
    {
        
        public List<string> GetMarks(DateTime now, List<string> student)
        {
            List<string> people = new List<string>(); 
            Random rnd = new Random();
         //  int dt = rnd.Next(DateTime.Now.Day,DateTime.Now.Day+10);
            int mrk = rnd.Next(2, 5);         
            people.Add(student+ " " + mrk); 
            return people;

        }

        public class Mark
        {
            public string pos;
            private int mrk;
            public Mark(int mrk)
            {
                this.mrk = mrk;
            }
        }
                
       //public int mark { get; }

    }
}
