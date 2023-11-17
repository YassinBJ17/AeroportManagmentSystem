namespace AMS.ApplicationCore.Domain;

public class Passenger
{
#nullable disable

    public DateTime BirthDate { get; set; }
    public int PassportNumber { get; set; }
    public string EmailAddress { get; set; }
    public string FirstName {  get; set; }
    public string LastName { get; set; }
    public string TelNumber {  get; set; }
    public Flight Flight {  get; set; }
    
 public override string ToString()
    {
        return "BirthDate : " + BirthDate +
            " , EmailAddress : " + EmailAddress +
            " , PassportNumber : " + PassportNumber +
            " , FirstName : " + FirstName +
            " , LastName : " + LastName +
            " , TelNumber : " + TelNumber;
    }

    

    public bool CheckProfile(string first, string last,string email=null)
    {
        if (email!=null)
        {
            return (FirstName == first) && LastName.Equals(last) && (email==EmailAddress);
        }

        return (FirstName == first) && LastName.Equals(last);

    }

    public virtual string PassengerType()
    {
         return"I am a passenger !";
    }




}
