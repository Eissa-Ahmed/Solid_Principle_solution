namespace Open_Closed_Principle;

public class RemotlySalaryCalc : ISalaryCalc
{
    public decimal CalculateSalary(Employee employee)
    {
        return employee.Salary - (employee.Salary * 0.1m);
    }
}
