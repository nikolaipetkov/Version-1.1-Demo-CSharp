using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListApp
{
    class LinkedListApplication
    {
        static int Main()
        {
            ListOfEmployees Employees = new ListOfEmployees();
            Employee CEO;
            Employee DeliveryDirector;
            Employee ProjectManager;
            Employee TeamLeader1;
            Employee TeamLeader2;
            Employee Senior1;
            Employee Trainee1;
            Employee Trainee2;
            Employee Trainee3;
            


            ////Creating new Employees
            CEO = new Employee();
            CEO.name = "CEO Name";
            CEO.position = "CEO";
            CEO.manager = null;
            Employees.Add(CEO);

            DeliveryDirector = new Employee();
            DeliveryDirector.name = "Delivery Director Name";
            DeliveryDirector.position = "Delivery Director";
            DeliveryDirector.manager = CEO;
            Employees.Add(DeliveryDirector);

            ProjectManager = new Employee();
            ProjectManager.name = "Project Manager Name";
            ProjectManager.position = "Project Manager";
            ProjectManager.manager = DeliveryDirector;
            Employees.Add(ProjectManager);

            TeamLeader1 = new Employee();
            TeamLeader1.name = "Team Leader 1 Name";
            TeamLeader1.position = "Team Lead 1";
            TeamLeader1.manager = ProjectManager;
            Employees.Add(TeamLeader1);

            TeamLeader2 = new Employee();
            TeamLeader2.name = "Team Leader 2 Name";
            TeamLeader2.position = "Team Lead 2";
            TeamLeader2.manager = ProjectManager;
            Employees.Add(TeamLeader2);

            Senior1 = new Employee();
            Senior1.name = "Senior 1";
            Senior1.position = "Senior Team 2";
            Senior1.manager = TeamLeader2;
            Employees.Add(Senior1);

            Trainee1 = new Employee();
            Trainee1.name = "Trainee 1";
            Trainee1.position = "Trainee Team 1";
            Trainee1.manager = TeamLeader1;
            Employees.Add(Trainee1);

            Trainee2 = new Employee();
            Trainee2.name = "Trainee 2";
            Trainee2.position = "Trainee Team 1";
            Trainee2.manager = TeamLeader1;
            Employees.Add(Trainee2);

            Trainee3 = new Employee();
            Trainee3.name = "Trainee 3";
            Trainee3.position = "Trainee Team 2";
            Trainee3.manager = TeamLeader2;
            Employees.Add(Trainee3);

            



            ////Outputs to console the employees count
            Console.WriteLine("Number of Employees: {0}\n", Employees.Count);
            
            ////Returns to the console all the employees information            
            for (int i = 0; i < Employees.Count; i++)
            {


                Employee empInfo = Employees.Retrieve(i);

                Console.WriteLine("\nEmployee Information");
                Console.WriteLine("Employee name:  {0}", empInfo.name);
                Console.WriteLine("Employee position: {0}", empInfo.position);
                if (empInfo.manager != null)
                {
                    Console.WriteLine("Employee manager: {0}", empInfo.manager.name);
                }
                Console.WriteLine("---------------");

            }


            /*
            Below is the implementation of the method that returns a selected Employee's managers in a list
            */
            Console.WriteLine("Here we can return a selected Employee's managers list");
            Console.WriteLine("Enter name of the Employee whose managers should be returned");
            string empToReturnManagers = Console.ReadLine();
            Employee empManagersList = Employees.SearchByName(empToReturnManagers);
            empManagersList.GetManagers();




            /*
            Below is the implementation of the method that returns the most direct manager of 2 Employees
            */
            Console.WriteLine("The purpose of this app is to find the most direct manager of 2 Employees.\n");
            Console.WriteLine("Enter name of the first employee:");
            string empToFind1 = Console.ReadLine();
            Employee foundEmployee1 = Employees.SearchByName(empToFind1);
            Console.WriteLine("Employee's position is: {0} \n", foundEmployee1.position);

            Console.WriteLine("Enter name of the second employee:");
            string empToFind2 = Console.ReadLine();
            Employee foundEmployee2 = Employees.SearchByName(empToFind2);
            Console.WriteLine("Employee's position is: {0} \n", foundEmployee2.position);

            Employee mostDirectManager = Employees.GetMostDirectManagerOfTwo(foundEmployee1, foundEmployee2);



            //Option to delete an Employee at position = 2 and return the Count of the employees as a test that it works
            //Employees.Delete(2);
            //Console.WriteLine("Number of Employees: {0}\n", Employees.Count);







            Console.WriteLine();
            return 0;


        }
    }
}
