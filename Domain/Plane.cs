
using System.Drawing;

namespace AMS.ApplicationCore.Domain;


public enum PlaneType { Boing, Airbus }
public class Plane
{
    public Plane(int capacity, DateTime manufactureDate, int planeId, PlaneType planeType)
    {
        Capacity = capacity;
        ManufactureDate = manufactureDate;
        PlaneId = planeId;
        PlaneType = planeType;
    }

    //ctor 
    public Plane()
    {
        Console.WriteLine("Constructor");
    }

    public int Capacity { get; set; }
    public DateTime ManufactureDate { get; set; }
    public int PlaneId {get;set;}
    public PlaneType PlaneType { get; set; }

    //prop de navigation virtual
    public virtual IList<Flight>? Flights { get; set; }

    public override string? ToString()
    {
        return $"Plane = {PlaneId}" +
                ", ManufactureDte = " + ManufactureDate +
                ", PlanrId = " + PlaneId +
                ", PlaneType = " + PlaneType +
                ", Capacity = " + Capacity ;
    }

 


}
