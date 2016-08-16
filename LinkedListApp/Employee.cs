using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListApp
{
    /// <summary>
    /// Base class for Employees - defines the properties and methods of an Employee
    /// </summary>
    class Employee
    {
        public string name { get; set; }
        public string position { get; set; }
        public Employee manager { get; set; }

        /// <summary>
        /// Pointer to the next item in the list
        /// </summary>
        public Employee Next;

         
        /// <summary>
        /// Returns to the console a list of the selected Employee's managers
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetManagers()
        {
            Employee e = this;            
            List<Employee> managers = new List<Employee>();

            while (e.manager != null)
            {


                managers.Add(e.manager);
                e = e.manager;

            }
            Console.WriteLine("---------------");
            managers.ForEach(i => Console.WriteLine("{0}", i.name));
            Console.WriteLine("---------------");
            return managers;
        }


        /// <summary>
        /// Returns the selected Employee's managers without outputing them to the console
        /// Difference between the 2 methods is only the commented code in the second
        /// Used in  GetMostDirectManagerOfTwo method
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetManagersSilently()
        {
            Employee e = this;
            List<Employee> managers = new List<Employee>();

            while (e.manager != null)
            {


                managers.Add(e.manager);
                e = e.manager;

            }
            //managers.ForEach(i => Console.WriteLine("{0}", i.name));
            //Console.WriteLine("---------------");
            return managers;
        }



    }

    }

