public class Resume()
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}\nJobs:");

        foreach (Job book in _jobs)
        {
            book.DisplayJob();
        }
    }

}