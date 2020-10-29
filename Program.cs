using System;
namespace EmployeeManager
{
    class Program
    {
         static void Main(string[] args)
        {
            //employee mgt instance creeation
            var employee = new EmployeeMgtSys();
            // employee user input method calling
            EmployeeUserInput.input(employee);

        }

        
    }
}
