using System;
using System.Collections.Generic;

namespace EmployeeManager
{
    public class EmployeeMgtSys
    {
        public EmployeeMgtSys(){
            employeeInfo = new List<EmployeeInformation>();
            var employee1= new EmployeeInformation("raman","Formay",27,"qa",40000);
            var employee2= new EmployeeInformation("aman","formay",25,"acc",60000);
            employeeInfo.Add(employee1);
            employeeInfo.Add(employee2);
        }
        public List<EmployeeInformation> employeeInfo{ get; private set; }
        public EmployeeInformation searchEmployee(string name){
            return genericFinder(employeeInfo,name);
              
        }
        public EmployeeInformation addEmployee(string firstName,string lastName,int age,string designation,int salary){
            var employee = new EmployeeInformation(firstName,lastName,age, designation,salary);
            employeeInfo.Add(employee);
            return genericFinder(employeeInfo,firstName);
        }
        // generic function
        public EmployeeInformation genericFinder(List<EmployeeInformation> employee, string name){
            for(int i=0;i<employeeInfo.Count;i++){
               if(name== employeeInfo[i].FirstName.ToLower()){
                   return employeeInfo[i]; 
               }   
           } 
          return null; 
        }
    }
}