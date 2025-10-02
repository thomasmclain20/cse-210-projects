using System.Security.Cryptography.X509Certificates;

public class Resume
{
    public string Name { get; set; }
    public List<Job> Jobs { get; set; }

    public Resume(string name)
    {
        Name = name;
        Jobs = new List<Job>();
    }
}