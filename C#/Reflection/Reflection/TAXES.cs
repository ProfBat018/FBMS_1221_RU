// MulticastDelegate

public delegate float SalaryDelegate(ref float salary);

static class TAXES
{
    public static readonly float DVX = 0.05f;
    public static readonly float DSMF = 75;
    public static readonly float ITSDA = 12;
    
    private static SalaryDelegate salaryCalc;

    static TAXES()
    {
        salaryCalc = CountDVX;
        salaryCalc += CountDSMF;
        salaryCalc += CountITSDA;
    }

    public static float CountAllTaxes(ref float salary)
    {
        return salaryCalc(ref salary);
    }
    private static float CountDVX(ref float salary)
    {
        salary = salary - (salary * TAXES.DVX);
        return salary;
    }
    private static float CountDSMF(ref float salary)
    {
        salary = salary - TAXES.DSMF;
        return salary;
    }
    private static float CountITSDA(ref float salary)
    {
        salary  = salary - TAXES.ITSDA;
        return salary;
    }
}
