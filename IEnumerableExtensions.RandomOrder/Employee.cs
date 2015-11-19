using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions.RandomOrder
{
    public class Employee
    {
        public string FirstName { get; set; } = "John";
        public string LastName { get; set; } = "Doe";
        public int Id { get; set; }

        public Employee(int id)
        {
           Id = id;
        }

        /// <summary>
        /// Temporary datasoruce returning all employess
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Employee> GetAllEmployee()
        {
            List<Employee> allEmployes = new List<Employee>();
            for (int i = 0; i < 10; i++)
            {
                allEmployes.Add(new Employee(i));
            }
            return allEmployes.AsEnumerable();
        }
    }


}
