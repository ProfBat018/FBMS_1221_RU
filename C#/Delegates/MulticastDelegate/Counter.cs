
// MulticastDelegate

class Counter
{
    public float CountSalary(Employee emp)
    {
        float salary = emp.Salary;
        var res = TAXES.CountAllTaxes(ref salary);
        return res;
    }
}

