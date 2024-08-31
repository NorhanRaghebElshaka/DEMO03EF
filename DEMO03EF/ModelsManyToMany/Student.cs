using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO03EF.ModelsManyToMany
{
    // iF You Have Relation Many to Many Without Any Attributes On Diamond : Create Classes 2 (LINQ Generte Three Table)
    public class Student
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public virtual List<Course> courses { get; set; }
    }
}
