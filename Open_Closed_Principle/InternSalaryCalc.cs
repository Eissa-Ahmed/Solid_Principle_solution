namespace Open_Closed_Principle;

public class InternSalaryCalc : ISalaryCalc
{
    public decimal CalculateSalary(Employee employee)
    {
        return employee.Salary / 4;
    }
}
