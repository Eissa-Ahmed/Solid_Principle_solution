namespace Open_Closed_Principle;

public class FullTimeSalaryCalc : ISalaryCalc
{
    public decimal CalculateSalary(Employee employee)
    {
        return employee.Salary;
    }
}

