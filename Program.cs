using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    static void Main(string[] args)
    {
        // this is our employee-getting code
        List<Employee> employees = GetEmployees();
        PrintEmployees(employees);
        // for(int i = 0; i < employees.Count; i++){
        //     Console.WriteLine(employees[i]);
        // }
    }

    static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            while (true) {
                Console.WriteLine("Enter first name (leave empty to exit): ");
                string firstName = Console.ReadLine() ?? "";
                if (firstName == "") {
                    break;
                }
                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine() ?? "";
                Console.Write("Enter ID: ");
                int id = Int32.Parse(Console.ReadLine()??"");
                Console.Write("Enter Photo URL: ");
                string photoUrl = Console.ReadLine() ?? "";

                Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                employees.Add(currentEmployee);
            }
        // This is important!
        return employees;
        }

    static void PrintEmployees(List<Employee> employees){
        for(int i = 0; i< employees.Count; i++){
            string template = "{0,-10}\t{1,-20}\t{2}";
            Console.WriteLine(String.Format(template,employees[i].GetId(),employees[i].GetFullName(),employees[i].GetPhotoUrl()));
        }
    }
  }
}

