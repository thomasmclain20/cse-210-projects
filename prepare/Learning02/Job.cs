public class Job
{
    public string Title { get; set; }
    public string Company { get; set;}
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public List<string> Description { get; set;}
    public string Location { get; set; }

    public Job(string title, string company, DateTime startDate, DateTime? endDate = null, string location = null)
    {
        Title = title;
        Company = company;
        StartDate = startDate;
        EndDate = endDate;
        Description = new List<string>();
        Location = location;
    }

    public void AddResponsibility(string responsibility)
    {
        Description.Add(responsibility);
    }

    public bool IsCurrentJob()
    {
        return EndDate == null;
    }

    public TimeSpan GetDuration()
    {
        var endDate = EndDate ?? DateTime.Now;
        return endDate - StartDate;
    }

    public void DisplayJobDetails()
    {
        string dateRange = IsCurrentJob()
            ? $"{StartDate:MMM yyyy} - Present"
            : $"{StartDate:MMM yyyy} - {EndDate:MMM yyyy}";

            Console.WriteLine($"{Title} at {Company}");
            Console.WriteLine($"Duration: {dateRange}");

            if (!string.IsNullOrEmpty(Location))
            {
                Console.WriteLine($"Location: {Location}");
            }

            foreach(var responsibility in Description)
            {
                Console.WriteLine($"- {responsibility}");
            }

            Console.WriteLine();
    }
}
