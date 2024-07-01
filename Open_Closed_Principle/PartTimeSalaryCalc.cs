namespace Open_Closed_Principle;

public class PartTimeSalaryCalc : ISalaryCalc
{
    public decimal CalculateSalary(Employee employee)
    {
        return employee.Salary / 2;
    }
}

