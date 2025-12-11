public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(
        string title,
        string description,
        string date,
        string time,
        Address address,
        string weatherForecast)
        : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return GetStandardDetails() + "\n" +
               "Event Type: Outdoor Gathering\n" +
               "Weather Forecast: " + _weatherForecast;
    }
}
