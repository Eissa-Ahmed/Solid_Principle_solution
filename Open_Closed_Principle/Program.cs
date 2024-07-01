namespace Open_Closed_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "John";
            employee.Type = "Remotly";
            employee.Salary = 1000;

            SalaryCalc salaryCalc = new SalaryCalc();
            decimal salary = salaryCalc.CalculateSalary(employee);
            Console.WriteLine(salary);
        }
    }
}
