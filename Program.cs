using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatWorx.BadgeMaker {
  class Program {
   

    static void PrintEmployees(List<Employee> employees){
      for (int i = 0; i < employees.Count; i++){
        string template = "{0,  -10}\t{1, -20}\t{2}";
        Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));
      }
    }

  async static Task Main(string[] args) {     
    // List<Employee> employees = GetEmployees();
    List<Employee> employees = await PeopleFetcher.GetFromApi();

    Util.PrintEmployees(employees);
    Util.MakeCSV(employees);
    await Util.MakeBadges(employees);

    }
  }
}