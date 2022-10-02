namespace ADOEmployeePayRoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Payroll Service program using MSSQL & ADO.NET \n");
            EmployeeADO emp = new EmployeeADO();
           
            List<Employee> list = new List<Employee>() { new Employee { CompanyName = "SpaceX",EmpName = "Sachin Tendulkar",
               Gender = "M",PhoneNumber=123456789,EmpAddress="fjksgf fjksf",StartDate=DateTime.Now,Department="Sales",
               BasicPay=12345678,Deductions=1234,IncomeTax=5678},
               new Employee { CompanyName = "Tesla",EmpName = "Elon Musk",
               Gender = "M",PhoneNumber=912345678,EmpAddress="street texas",StartDate=DateTime.Now,Department="Marketing",
               BasicPay=999999,Deductions=7873,IncomeTax=5678} };

            OptionsDisplay();

            void OptionsDisplay()
            {
                Console.Write("\nSelect option :\n1.Get Payroll Table Details\n2.Add Employee details\n3.Update Payment details\n4.Delete Employee details\n5.Get Emp Details by Date range\n");

                int option = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (option)
                {
                    case 1:
                        emp.GetEmployeeDetails();
                        OptionsDisplay();
                        break;
                    case 2:
                        emp.AddEmpDetails();
                        OptionsDisplay();
                        break;
                    case 3:
                        emp.UpdateBasicPay();
                        OptionsDisplay();
                        break;
                    case 4:
                        emp.DeleteEmployeeRecord();
                        OptionsDisplay();
                        break;
                    case 5:
                        emp.GetRowsByDateRange();
                        OptionsDisplay();
                        break;
                    case 6:
                        emp.AddMultipleEmployees(list);
                        emp.AddMultipleEmployeesUsingThreads(list);
                        break;
                    default:
                        Console.WriteLine("Enter correct option");
                        break;
                }
            }
        }
    }
}