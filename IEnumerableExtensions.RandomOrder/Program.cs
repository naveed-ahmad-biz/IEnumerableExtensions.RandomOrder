using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions.RandomOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            //get all employees
            var employees = Employee.GetAllEmployee();
            //print in sequence
            PrintEmployees(employees);
            //randomize using extension
            var randomEmployees = Employee.GetAllEmployee().Randomize();
            //print them again
            Console.WriteLine("**************");
            PrintEmployees(randomEmployees);


        }

        private static void PrintEmployees(IEnumerable<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Id} : {employee.FirstName} - {employee.LastName}");
            }
        }

        /* Sample output 

        0 : John - Doe
        1 : John - Doe
        2 : John - Doe
        3 : John - Doe
        4 : John - Doe
        5 : John - Doe
        6 : John - Doe
        7 : John - Doe
        8 : John - Doe
        9 : John - Doe
        **************
        6 : John - Doe
        2 : John - Doe
        9 : John - Doe
        7 : John - Doe
        1 : John - Doe
        0 : John - Doe
        5 : John - Doe
        8 : John - Doe
        4 : John - Doe
        3 : John - Doe
        Press any key to continue . . .
        */
    }
}
