public abstract class Activity
{
    public string Date { get; set; }
    public int Minutes { get; set; }

    public Activity(string date, int minutes)
    {
        Date = date;
        Minutes = minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        string activityType = this.GetType().Name;
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        return $"{Date} {activityType} ({Minutes} min) - Distance: {distance:F2} km, Speed: {speed:F2} kph, Pace: {pace:F2} min/km";
    }
}
