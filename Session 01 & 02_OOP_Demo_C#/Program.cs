using Common;
using Session_01_OOP_Demo_C_.Encapsulation;
using Session_01_OOP_Demo_C_.OOPInheritance;
namespace Session_01_OOP_Demo_C_
{
    internal class Program
    {

        #region Overloading

        public static int sum(int x, int y)
        {
            return x + y;
        }
        public static double sum(double x, double y)
        {
            return x + y;
        }
        public static string sum(int x, int y,int z)
        {
            return $"{x + y + z}";
        }
        #endregion
        static void Main(string[] args)
        {


            #region AccessModifiers
            //TypeA ta = new TypeA();
            //ta.z = 23;
            //Console.WriteLine(ta.z);
            #endregion

            #region Encapsulation
            //Employee employee = new Employee(150, "islam", 200000);
            //employee.id = 207;
            //Console.WriteLine(employee.ToString());
            #endregion

            #region OldEncapsulationReviewUsingGettersAndSetters
            //Employee emp1 = new Employee();
            //emp1.SetID(317);
            //emp1.SetName("Nano");
            //emp1.SetSalary(100000);
            //Console.WriteLine(String.Format("emp1 id is {0}, emp1 name is {1} and emp1 salary is {2}",emp1.GetID(),emp1.GetName(),emp1.GetSalary()));
            #endregion

            #region NewEncapsulationUsingPropertiesPreview
            #region AutomaticPropertyPreview
            //Employee emp2 = new Employee();
            //emp2.idProp = 425;
            //emp2.nameProp = "Rules";
            //emp2.salaryProp = 200000;
            //Console.WriteLine(String.Format("emp2 id is {0}, emp2 name is {1} and emp2 salary is {2}", emp2.idProp, emp2.nameProp, emp2.salaryProp));
            #endregion

            #region FullPropertyPreview
            //Employee emp3 = new Employee();
            //emp3.ID = 264;
            //emp3.Name = "Test";
            //emp3.Salary = 300000;
            //Console.WriteLine(String.Format("emp3 id is {0}, emp3 name is {1} and emp3 salary is {2}", emp3.ID, emp3.Name, emp3.Salary));
            #endregion
            #endregion



            Car car = new Car(519,"Ford",234.67d);
            Console.WriteLine(car);

            Child ch = new Child(1,2,3);
            Console.WriteLine(ch);



            #region Overriding
            // it occurs when you inherit a method from a parent class but you want to change its signature like we did with toString method!
            #endregion








        }
    }
}
