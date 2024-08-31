using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO03EF.Entites
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department WorkFor { get; set; }
    }
}
