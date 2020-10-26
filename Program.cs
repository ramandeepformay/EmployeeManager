using System;
namespace EmployeeManager
{
    class Program
    {
         static void Main(string[] args)
        {
            
            var employee = new EmployeeMgtSys();
            // employee user input method calling
            EmployeeUserInput.input(employee);

        }

        
    }
}
