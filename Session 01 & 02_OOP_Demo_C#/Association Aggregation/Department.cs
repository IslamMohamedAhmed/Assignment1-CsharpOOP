using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Session_01_OOP_Demo_C_.Association_Aggregation
{
    internal class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Employee[]? employees { get; set; }

        public Department(int Id, string Name, Employee[] employees)
        {
            this.Id = Id;
            this.Name = Name;
            this.employees = employees;

        }




    }
}
