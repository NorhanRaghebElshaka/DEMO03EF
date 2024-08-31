using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO03EF.ModelsManyToMany
{
    internal class StudentCourse
    {
        public int CourseId { get; set; }  // Fk
        public int StudentId { get; set; }  // Fk
        public virtual Course Course { get; set; }
        public virtual Student student { get; set; }
        public int Grade { get; set; }
    }
}
