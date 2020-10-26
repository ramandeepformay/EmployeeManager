using System.Security.Cryptography;
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
                    deleteEmployee(employee);
                }
                if(userInput=="q"){
                    break;
                }
            }

        }
        static void searchForEmployee(EmployeeMgtSys employee){
            //  welcome search func 
            System.Console.WriteLine("How would you like to search an employee today");
            System.Console.WriteLine("To search by firstname enter firstname\n");
            var nameSearchInput=System.Console.ReadLine().ToLower();
            var searchResult = employee.searchEmployee(nameSearchInput);
            // employee display
            displayEmployee(searchResult,nameSearchInput,"founded");
            
        }
        static void addEmployee(EmployeeMgtSys employee){
            //  welcome add func 
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
            // employee display
            displayEmployee(employeeAdded,employeeAdded.FirstName,"added");
        }

        static void deleteEmployee(EmployeeMgtSys employee){
            //  welcome del func 
            System.Console.WriteLine("Enter the employees's first name that you want to delete?");
            var userDelInput =Console.ReadLine().ToLower();
            var delEmployee = employee.deleteEmployee(userDelInput);
            // employee display
            displayEmployee(delEmployee,userDelInput,"deleted");
        }

        // generic func
        static void displayEmployee(EmployeeInformation result, string nameSearchInput, string msg){
            if(result==null){
                System.Console.WriteLine($"{nameSearchInput} has not been {msg} in our directory ");
            }
            else{
                System.Console.WriteLine($"{nameSearchInput} has been {msg} in our directory");
            }
        }
    }
}