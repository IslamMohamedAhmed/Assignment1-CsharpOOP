using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_01_OOP_Demo_C_.Encapsulation
{
    internal struct Employee
    {
        #region Attributes
        public int id;
        public string name;
        public decimal salary;
        #endregion

        #region Constructors
        public Employee(int id, string name, decimal salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            Console.WriteLine("one!");

        }
        public Employee(int id, string name) : this(id, name, 3900)
        {
            Console.WriteLine("two!");


        }
        public Employee(int id) : this(id, "islam", 45000) //constructor chaining  
        {
            Console.WriteLine("three!");


        }
        #endregion

        #region ToString
        public override string ToString()
        {
            return $"id: {id}\nname: {name}\nsalary: {salary}";
        }


        #endregion

        #region OldEncapsulationMethodUsingGettersAndSetters
        public void SetID(int id)
        {
            this.id = id;
        }
        public int GetID() { return this.id; }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName() { return this.name; }
        public void SetSalary(decimal salary)
        {
            this.salary = salary;
        }
        public decimal GetSalary() { return this.salary; }
        #endregion


        #region NewEncapsulationMethodUsingProperties
        #region AutomaticProperties
        // they don't need a variable to be initialized 
        // when creating them the compiler will make an automatic private variable in the backin field

        public int idProp { get; set; }
        public string nameProp { get; set; }
        public decimal salaryProp { get; set; }


        #endregion

        #region FullProperties

        // I can make validation here and apply control statements unlike automatic properties
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public decimal Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }


        #endregion
        #endregion
    }
}
