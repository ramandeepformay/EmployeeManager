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

        // seacrch employee func
        public EmployeeInformation searchEmployee(string name){
            return genericFinder(employeeInfo,name);
              
        }
        // Add Employee func
        public EmployeeInformation addEmployee(string firstName,string lastName,int age,string designation,int salary){
            var employee = new EmployeeInformation(firstName,lastName,age, designation,salary);
            employeeInfo.Add(employee);
            return genericFinder(employeeInfo,firstName);
        }

        // delete employee func
        public EmployeeInformation deleteEmployee(string name){
            var findEmp=searchEmployee(name);
           for(int i=0; i<employeeInfo.Count; i++){
               if(findEmp.Id==employeeInfo[i].Id){
                   var deleted=employeeInfo.Remove(employeeInfo[i]);
                   if(deleted){
                       return employeeInfo[i];
                   }
               }
           }
           return null;
        }

        public int promoteEmployee(EmployeeInformation employee, string ans){
            var oldRating =employee.Rating;
            int newRating ;
            if(ans=="pr"|| ans=="p"){
                newRating=oldRating+1;
                return newRating;
            }
            else{
                if(oldRating>0){
                    newRating=oldRating-1;
                    return newRating;
                }
                else{
                    return oldRating;
                }
               
            }

        }
        // Generic finder to find en employee in the directory
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