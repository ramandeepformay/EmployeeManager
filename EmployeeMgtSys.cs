using System;
using System.Collections.Generic;

namespace EmployeeManager
{
    public class EmployeeMgtSys
    {
        public EmployeeMgtSys(){
            employeeInfo =new List<EmployeeInformation>();
            var employee1= new EmployeeInformation("raman","Formay",27,"qa",40000);
            var employee2= new EmployeeInformation("aman","formay",25,"acc",60000);
            employeeInfo.Add(employee1);
            employeeInfo.Add(employee2);
        }

        public List<EmployeeInformation> employeeInfo{ get; private set; }

        public EmployeeInformation searchEmployee(string name){
           for(int i=0;i<employeeInfo.Count;i++){
               if(name== employeeInfo[i].FirstName.ToLower()){
                   return employeeInfo[i]; 
               }   
           } 
          return null;    
        }

        public EmployeeInformation addEmployee(){
            
        }
    }
}