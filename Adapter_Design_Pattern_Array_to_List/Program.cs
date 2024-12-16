//Storing the Employees Data in a String Array
using Adapter_Design_Pattern_Array_to_List.Adapter;

//Ref:https://dotnettutorials.net/lesson/adapter-design-pattern/


string[,] employeesArray = new string[5, 4]
{
                {"101","Adi","SE","10000"},
                {"102","Pavan","SE","20000"},
                {"103","Anil","SSE","30000"},
                {"104","Pam","SE","40000"},
                {"105","Sara","SSE","50000"}
};
//The EmployeeAdapter Makes it possible to work with Two Incompatible Interfaces
Console.WriteLine("HR system passes employee string array to Adapter\n");
ITarget target = new EmployeeAdapter();
target.ProcessCompanySalary(employeesArray);
Console.Read();



