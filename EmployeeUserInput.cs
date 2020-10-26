using  System;

namespace EmployeeManager
{
    public class EmployeeUserInput
    {   
           
        public static void input(EmployeeMgtSys employee){
             
            while(true){ 
                // Employee Manager Inro
                System.Console.WriteLine("\nWelcome to the Employee Manager");
                System.Console.WriteLine("\nWhat would you like to do today? \n Enter s for search \n Enter a for Add \n Enter d for Delete \n Enter q for quit");
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
            System.Console.WriteLine("\nHow would you like to search an employee today");
            System.Console.WriteLine("\nTo search by firstname enter firstname");
            var nameSearchInput=System.Console.ReadLine().ToLower();
            if(EmployeeGenericFunc.regexChecker(nameSearchInput)==null){
                System.Console.WriteLine("\nPlease enter valid type");
            }
            else{
                var searchResult = employee.searchEmployee(nameSearchInput);
                EmployeeGenericFunc.displayEmployee(searchResult,nameSearchInput,"founded");
             
            }
            // employee display
            
        
        }
        static void addEmployee(EmployeeMgtSys employee){
            //  welcome add func 
            System.Console.WriteLine("\nPlease add some details to add an employee in our directory");
            System.Console.WriteLine("Enter first Name\n");
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

        static void deleteEmployee(EmployeeMgtSys employee){
            //  welcome del func 
            System.Console.WriteLine("\nEnter the employees's first name that you want to delete?");
            var userDelInput =Console.ReadLine().ToLower();
            EmployeeGenericFunc.regexChecker
            (userDelInput);
            var delEmployee = employee.deleteEmployee(userDelInput);
            // employee display
            EmployeeGenericFunc.displayEmployee(delEmployee,userDelInput,"deleted");
        }

        // generic functions
        
    }
}