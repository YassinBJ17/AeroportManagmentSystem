

namespace AMS.ApplicationCore.Domain;

public class Traveller:Passenger
{
        public string HealthInformation { get; set;}=String.Empty;
        public string Nationality { get; set; } = String.Empty;

    public override string ToString()
    {
        return " Traveller HealthInformation = " + HealthInformation
            + "and " + " Nationality =" + Nationality;
    }

    public override string PassengerType()
    {
        return base.PassengerType() + " I am a Traveller";
    }

}
