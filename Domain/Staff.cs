

namespace AMS.ApplicationCore.Domain;

public class Staff:Passenger
{
    public DateTime EmploymentDate { get; set; }
    public string? Function { get; set; }
    public float Salary { get; set; }

    public override string ToString()
    {
        return "EmployementDate = " + EmploymentDate +
            " , Function = " + Function +
            " , Salary = " + Salary;
    }
    public override string PassengerType()
    {
        return base.PassengerType() + " I am a Staff Member";
    }
}
