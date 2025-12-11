public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return "Title: " + _title + "\n" +
               "Description: " + _description + "\n" +
               "Date: " + _date + "\n" +
               "Time: " + _time + "\n" +
               "Address: " + _address.GetFullAddress();
    }

    public virtual string GetFullDetails()
    {
        // Overridden in child classes
        return GetStandardDetails();
    }

    public string GetShortDescription()
    {
        return "Event Type: " + GetEventTypeName() +
               " | Title: " + _title +
               " | Date: " + _date;
    }

    public string GetEventTypeName()
    {
        return this.GetType().Name;
    }

    public string GetTitle()
    {
        return _title;
    }
}
