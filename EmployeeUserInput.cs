using  System;
namespace EmployeeManager
{
    public class EmployeeUserInput
    {   
        public static void input(EmployeeMgtSys employee){
             
            while(true){ 
                // Welcome message 
                System.Console.WriteLine("\nWelcome to the Employee Manager \nWhat would you like to do today? \n Enter s for search \n Enter a for Add \n Enter d for Delete \n Enter p for Promotion \n Enter q for quit");
                var userInput=System.Console.ReadLine().ToLower();

                // options available to select
                if(userInput=="s"){
                   searchTheEmployee(employee);
                }
                if(userInput=="a"){
                    addTheEmployee(employee);
                }
                if(userInput=="d"){
                    deleteTheEmployee(employee);
                }
                if(userInput=="p"){
                    promoteTheEmployee(employee);
                }
                if(userInput=="q"){
                    break;
                }
            }

        }
        // search for employee func and validation of type
        static void searchTheEmployee(EmployeeMgtSys employee){
            //  welcome search func 
            System.Console.WriteLine("\nHow would you like to search an employee today \nTo search by firstname enter firstname");
            var nameSearchInput=System.Console.ReadLine().ToLower();

            if(EmployeeGenericFunc.regexChecker(nameSearchInput)==null){
                System.Console.WriteLine("\nPlease enter valid type");
            }
            else{
                var searchResult = employee.searchEmployee(nameSearchInput);
                EmployeeGenericFunc.displayEmployee(searchResult,nameSearchInput,"founded");
             
            }
        }
        // validation fo data type for add employee
        static void addTheEmployee(EmployeeMgtSys employee){
            //  welcome add func 
            System.Console.WriteLine("\nPlease add some details to add an employee in our directoryEnter first Name\n");
            var firstName = Console.ReadLine();
            EmployeeGenericFunc.regexChecker(firstName);

            System.Console.WriteLine("Enter last Name\n");
            var lastName = Console.ReadLine();
            EmployeeGenericFunc.regexChecker(lastName);

            System.Console.WriteLine("Enter age\n");
            var age = Console.ReadLine();
            // var ageInt =Convert.ToInt32(regexChecker
            var ageInt = EmployeeGenericFunc.intChecker(age);

            System.Console.WriteLine("Enter Designation\n");
            var designation = Console.ReadLine();
            EmployeeGenericFunc.regexChecker(designation);

            System.Console.WriteLine("Enter Employee's Salary\n");
            var salary =Console.ReadLine();
            var salaryInt = EmployeeGenericFunc.intChecker(salary);

            if(firstName==null||lastName==null||ageInt==0||designation==null||salaryInt==0){
                 System.Console.WriteLine("\nPlease enter valid type");
                 return;
            }
            else{
                 var employeeAdded=employee.addEmployee(firstName,lastName,ageInt,designation,salaryInt);
                // employee display
                EmployeeGenericFunc.displayEmployee(employeeAdded,employeeAdded.FirstName,"added");
            }
           
        }
    // delete employee func for the validation
        static void deleteTheEmployee(EmployeeMgtSys employee){
            //  welcome del func 
            System.Console.WriteLine("\nEnter the employees's first name that you want to delete?");
            var userDelInput =Console.ReadLine().ToLower();
            EmployeeGenericFunc.regexChecker
            (userDelInput);
            var delEmployee = employee.deleteEmployee(userDelInput);
            // employee display
            EmployeeGenericFunc.displayEmployee(delEmployee,userDelInput,"deleted");
        }

        // promote employee func fo the validation
        static void promoteTheEmployee(EmployeeMgtSys employee){
            System.Console.WriteLine("Which employee would you like to promote");
            var userPromInput = Console.ReadLine().ToLower();
            var employeeValidator=EmployeeGenericFunc.regexChecker(userPromInput);
            var employeeExistence=employee.searchEmployee(employeeValidator);

            if(employeeExistence!=null){
                System.Console.WriteLine($"Would like to promote or demote an employee?\nPlease enter {"pr or de"} to complete the process!");
                var userRatInput=Console.ReadLine().ToLower();

                if(userRatInput=="pr"|| userRatInput=="p"||userRatInput=="de"|| userRatInput=="d" ){
                   var updatedRating= employee.promoteEmployee(employeeExistence, userRatInput);
                   if(employeeExistence.Rating < updatedRating ){
                       System.Console.WriteLine("Employee has been promoted");
                   }
                   else if(employeeExistence.Rating > updatedRating){
                        System.Console.WriteLine("Employee has been demoted");
                   }
                }

                else{
                    System.Console.WriteLine("\n Please enter valid answer");
                    return;
                }
            }

            else{
                System.Console.WriteLine("Employee doesn't exist in our diectory.");
            }
        }
        
    }
}