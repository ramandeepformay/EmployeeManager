namespace EmployeeManager
{
    public class EmployeeUserInput
    {
        public static void input(){
            while(true){ 
                // Intro to my employee Manager
                System.Console.WriteLine("Welcome to the Employee Manager");
                System.Console.WriteLine("What would you like to do today? \n Enter s for search \n Enter a for Add \n Enter d for Delete \n Enter q for quit");
                var userInput=System.Console.ReadLine().ToLower();

                if(userInput=="s"){

                   searchForEmployee();
                }

                if(userInput=="a"){
                    addEmployee();
                }
                if(userInput=="d"){
                    System.Console.WriteLine("add");
                }
                if(userInput=="q"){
                    break;
                }
            }

        }
        static void searchForEmployee(){
            var employee = new EmployeeMgtSys();
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
        static void addEmployee(){
            var employee = new EmployeeMgtSys();
            System.Console.WriteLine("Please add some details to add an employee in our directory");
            
        }
    }
}