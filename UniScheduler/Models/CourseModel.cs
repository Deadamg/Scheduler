using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniScheduler.Models
{
    public  class CourseModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class TeacherModel
    {
        public int Ids { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string Phone { get; set; }
    }
    
    public class CourseLecturesModel 
    {

        public int CourseId { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public int TeacherId    { get; set;   }

        public int Ids { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string Phone { get; set; }

        public DateTime Time { get; set; }
        public string Room { get; set; }











    }
}
