using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListApp
{

    /// <summary>
    /// This class holds all the helper properties and methods of the list
    /// </summary>
    class ListOfEmployees
    {
        private int size;

        public ListOfEmployees()
        {
            size = 0;
            Head = null;
        }

        /// <summary>
        /// this is a variable used for determining the count of the list
        /// </summary>
        public int Count
        {
            get { return size; }
        }

        /// <summary>
        /// pointer to the primary member of the list
        /// </summary>
        public Employee Head;

        


        /// <summary>
        /// Takes a new employee as a parameter and adds it to the beginning of the list,
        /// returns the new size of the list
        /// </summary>
        /// <param name="NewItem"></param>
        /// <returns></returns>
        public int Add(Employee NewItem)
        {
            Employee Sample = new Employee();

            Sample = NewItem;
            Sample.Next = Head;
            Head = Sample;
            return size++;

        }

        /// <summary>
        /// Deletes the element at the given position
        /// Example: Employees.Delete(2);
        /// </summary>
        /// <param name="Position"></param>
        /// <returns></returns>
        public bool Delete(int Position)
        {
            if (this.Retrieve(Position) == null)

                return false;
            this.Retrieve(Position - 1).Next = this.Retrieve(Position + 1);
            size--;
            return true;

        }


        /// <summary>
        /// Retrieving information for the employees up to the given position -
        /// Used for displaying information for all the employees in the list using Employees.Count
        /// </summary>
        /// <param name="Position"></param>
        /// <returns></returns>
        public Employee Retrieve(int Position)
        {
            Employee Current = Head;

            for (int i = 0; i < Position && Current != null; i++)
                Current = Current.Next;
            return Current;
        }


        /// <summary>
        /// This methods is used to convert user's input string to an object
        /// to be passed to the find Managers methods
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public Employee SearchByName(string Name)
        {
            Employee Current = Head;

            while (Current != null)
            {
                if(Current.name == Name)
                {
                    return Current;
                    
                }
                Current = Current.Next;
                

            }
            Console.WriteLine("No Employee with name {0} was found", Name);
            return null;
             
        }

        /// <summary>
        /// This method iterates over the first list of Managers and checks if the element
        /// is present in the second list - if true - returns it
        /// </summary>
        /// <param name="emp1"></param>
        /// <param name="emp2"></param>
        /// <returns></returns>
        public Employee GetMostDirectManagerOfTwo(Employee emp1, Employee emp2)
        {

            List<Employee> managers1 = emp1.GetManagersSilently();
            List<Employee> managers2 = emp2.GetManagersSilently();

            

            foreach (Employee a in managers1)
            {
                if (managers2.Contains(a))
                {
                    Console.WriteLine("\nMost Direct Manager's name is: {0}", a.name);
                    Console.WriteLine("Most Direct Manager's position is: {0}", a.position);
                    return a;
                    
                } 
                    
                
            }
            
            return null;




        }





       











    }
}
