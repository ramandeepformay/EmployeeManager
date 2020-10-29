using  System;
using System.Collections.Generic;
namespace EmployeeManager
{
    public class EmployeeInformation
    {
        public  EmployeeInformation(string firstName, string lastName, int age, string designation, double salary){  
            Id = new Guid();
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Designation = designation;
            Salary = salary;
            Rating =0;
        } 
        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }   
        public int Age { get; private set; }
        public string Designation { get; private set; } 
        public string FullName
        {
           get { return $"{FirstName} {LastName}"; }
        }
        public double Salary { get; private set; }

        public int Rating { get; set;}

    }
}