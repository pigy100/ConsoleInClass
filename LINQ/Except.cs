using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LINQ.Except;

namespace LINQ
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $" ID : {this.ID} Name : {this.Name}";
        }
        public override bool Equals(object obj)
        {
            //As the obj parameter type is object, so we need to
            //cast it to Student Type
            return this.ID == ((Student)obj).ID && this.Name == ((Student)obj).Name;
        }
        public override int GetHashCode()
        {
            //Get the ID hash code value
            int IDHashCode = this.ID.GetHashCode();
            //Get the string HashCode Value
            //Check for null refernece exception
            int NameHashCode = this.Name == null ? 0 : this.Name.GetHashCode();
            return IDHashCode ^ NameHashCode;
        }
    }
    internal class Except
    {
        private static void ToPrint(IEnumerable list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        /*

        public class StudentComparer : IEqualityComparer<Student>
        {
            public bool Equals(Student x, Student y)
            {
                //First check if both object reference are equal then return true
                if (object.ReferenceEquals(x, y))
                {

                    return true;

                }
                //If either one of the object refernce is null, return false
                if (object.ReferenceEquals(x, null) || object.ReferenceEquals(y, null))
                {

                    return false;

                }
                //Comparing all the properties one by one
                return x.ID == y.ID && x.Name == y.Name;
            }
        }
        */
        static void Main(string[] args)
        {
            /*
            List<int> dataSource1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> dataSource2 = new List<int>() { 1, 3, 5, 8, 9, 10 };
            //Method Syntax
            var MS = dataSource1.Except(dataSource2).ToList();
            //Query Syntax
            var QS = (from num in dataSource1 select num).Except(dataSource2).ToList();
            ToPrint(MS);
            Console.WriteLine("-------------------------");
            ToPrint(QS);
            
            string[] dataSource1 = { "India", "USA", "UK", "Canada", "Israel" };
            string[] dataSource2 = { "India", "uk", "Canada", "France", "Japan"};
//Method Syntax
var MS = dataSource1.Except(dataSource2).ToList();
            ToPrint(MS);
            var allStudents = new List<Student>()
{
new Student { ID=101,Name="Preety"},
new Student { ID=102,Name="Sabmit"},
new Student { ID=103,Name="Hana"},
new Student { ID=104,Name="Tomer"},
new Student { ID=105,Name="Yossi"},
new Student { ID=106,Name="Sanny"}
            };

            var class7Students = new List<Student>()
{
new Student { ID=102,Name="Sabmit"},
new Student { ID=104,Name="Tomer"},
new Student { ID = 106, Name = "Sanny" },
};
            Console.WriteLine("ALL STUDENTS");
            ToPrint(allStudents.Select(x => x.Name));
            Console.WriteLine("\nCLASS7 STUDENTS");
            ToPrint(class7Students.Select(x => x.Name));

            //We need to fetch the class7 student names from the allStudents data source,
            //which are not present in the second data source, i.e., class7Students.
            //Method Syntax
            //var MS = allStudents.Select(x => new { x.ID, x.Name }).Except(class7Students.Select(x => new { x.ID, x.Name })).ToList();
            //var MS = allStudents.Except(class7Students).ToList().Select(x=> x.Name);

            Console.WriteLine("\nMETHOD SYNTAX");
            ToPrint(MS);
        */
    
        }
    }
}
