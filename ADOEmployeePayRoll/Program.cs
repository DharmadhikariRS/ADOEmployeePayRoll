namespace ADOEmployeePayRoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Payroll Service program using MSSQL & ADO.NET \n");
            EmployeeADO emp = new EmployeeADO();
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

                    default:
                        Console.WriteLine("Enter correct option");
                        break;
                }
            }
        }
    }
}