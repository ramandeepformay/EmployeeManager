using  System;
namespace EmployeeManager
{
    public class EmployeeUserInput
    {   
           
        public static void input(EmployeeMgtSys employee){
             
            while(true){ 
                // Employee Manager Inro
                System.Console.WriteLine("Welcome to the Employee Manager");
                System.Console.WriteLine("What would you like to do today? \n Enter s for search \n Enter a for Add \n Enter d for Delete \n Enter q for quit");
                var userInput=System.Console.ReadLine().ToLower();
                // options available to select
                if(userInput=="s"){
                   searchForEmployee(employee);
                }

                if(userInput=="a"){
                    addEmployee(employee);
                }
                if(userInput=="d"){
                    System.Console.WriteLine("add");
                }
                if(userInput=="q"){
                    break;
                }
            }

        }
        static void searchForEmployee(EmployeeMgtSys employee){
           
            System.Console.WriteLine("How would you like to search an employee today");
            System.Console.WriteLine("To search by firstname enter firstname\n");
            var nameSearchInput=System.Console.ReadLine().ToLower();
            var searchResult = employee.searchEmployee(nameSearchInput);
        
            if(searchResult==null){
                System.Console.WriteLine($"{nameSearchInput} doesn't exist in our directory");
            }
            else{
                System.Console.WriteLine($"{nameSearchInput} does exist in our directory");
            }
        }
        static void addEmployee(EmployeeMgtSys employee){
            System.Console.WriteLine("\nPlease add some details to add an employee in our directory");
            System.Console.WriteLine("Enter first Name\n");
            var firstName = Console.ReadLine();
            System.Console.WriteLine("Enter last Name\n");
            var lastName = Console.ReadLine();
            System.Console.WriteLine("Enter age\n");
            var age = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Designation\n");
            var designation = Console.ReadLine();
            System.Console.WriteLine("Enter Employee's Salary\n");
            var salary =Convert.ToInt32(Console.ReadLine());
            var employeeAdded=employee.addEmployee(firstName,lastName,age,designation,salary);
            if(employeeAdded==null){
                System.Console.WriteLine("Employee not added");
            }
            else{
                System.Console.WriteLine($"{employeeAdded.FirstName} has been added");
            }
        }
    }
}