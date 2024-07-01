namespace Open_Closed_Principle;

public class SalaryCalc
{
    /* public decimal CalculateSalary(Employee employee) // FullTime, PartTime, Intern
     {
         if (employee.Type == "FullTime")
         {
             return employee.Salary;
         }
         else if (employee.Type == "PartTime")
         {
             return employee.Salary / 2;
         }
         else if (employee.Type == "Intern")
         {
             return employee.Salary / 4;
         }
         else
         {
             throw new Exception("Invalid employee type");
         }
     }*/


    private Dictionary<string, ISalaryCalc> salaryCalc = new Dictionary<string, ISalaryCalc>();

    public SalaryCalc()
    {
        salaryCalc.Add("FullTime", new FullTimeSalaryCalc());
        salaryCalc.Add("PartTime", new PartTimeSalaryCalc());
        salaryCalc.Add("Intern", new InternSalaryCalc());
        salaryCalc.Add("Remotly", new RemotlySalaryCalc());
    }

    public decimal CalculateSalary(Employee employee)
    {
        //salaryCalc["FullTime"].CalculateSalary(employee);
        return salaryCalc[employee.Type].CalculateSalary(employee);
    }
}
