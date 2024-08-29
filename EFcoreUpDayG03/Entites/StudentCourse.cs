using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcoreUpDayG03.Entites
{
    internal class StudentCourse
    {
        public int StudentId {  get; set; }//Fk
        public int CourseId { get; set; }//FK
        public Student Student { get; set; }
        public Course Course { get; set; }
        public double Grade {  get; set; }
    }
}
