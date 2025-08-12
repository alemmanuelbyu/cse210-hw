public class Running : Activity
{
    private double DistanceInKm { get; set; }

    public Running(string date, int minutes, double distanceInKm) : base(date, minutes)
    {
        DistanceInKm = distanceInKm;
    }

    public override double GetDistance()
    {
        return DistanceInKm;
    }

    public override double GetSpeed()
    {
        return DistanceInKm / Minutes * 60;
    }

    public override double GetPace()
    {
        return Minutes / DistanceInKm;
    }
}
