using System;
using System.Text.RegularExpressions;
namespace EmployeeManager
{
    public class EmployeeGenericFunc
    {
       public static void displayEmployee(EmployeeInformation result, string nameSearchInput, string msg){
            if(result==null){
                System.Console.WriteLine($"{nameSearchInput} has not been {msg} in our directory ");
            }
            else{
                System.Console.WriteLine($"{nameSearchInput} has been {msg} in our directory");
            }
        }

       public static string regexChecker(string nameSearchInput){
            var regEx = new Regex(@"^([a-zA-z\s]{2,32})$");
            if(regEx.IsMatch(nameSearchInput)){
                return nameSearchInput; 
            }
            else{
                return null;
            }
        }

       public static int intChecker(string age){
            int number;
            bool success =Int32.TryParse(age, out number);
            if(!success){
                return 0;
            }
            else{
                return number;
            }
        }
       
    }
}