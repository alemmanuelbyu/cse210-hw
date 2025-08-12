public class Cycling : Activity
{
    private double SpeedInKph { get; set; }

    public Cycling(string date, int minutes, double speedInKph) : base(date, minutes)
    {
        SpeedInKph = speedInKph;
    }

    public override double GetDistance()
    {
        return SpeedInKph * Minutes / 60;
    }

    public override double GetSpeed()
    {
        return SpeedInKph;
    }

    public override double GetPace()
    {
        return 60 / SpeedInKph;
    }
}
