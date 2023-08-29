using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    static void Main(string[] args)
    {
        // this is our employee-getting code
        List<string> employees = GetEmployees();
        for(int i = 0; i < employees.Count; i++){
            Console.WriteLine(employees[i]);
        }
    }

    static List<string> GetEmployees()
        {
            List<string> employees = new List<string>();
            while (true) {
                Console.WriteLine("Please enter a name: (leave empty to exit): ");
                string input = Console.ReadLine() ?? "";
                if (input == "") {
                    break;
                }
                employees.Add(input);
            }
        // This is important!
        return employees;
        }

    static void PrintEmployees(List<string> employees){
        for(int i = 0; i< employees.Count; i++){
            Console.WriteLine(employees[i]);
        }
    }
  }
}

