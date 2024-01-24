using System;

public class Resume
{
    public string _name;

    // Make sure to initialize your list to a new List before you use it.
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Notice the use of the custom data type "Job" in this loop
        foreach (Job job in _jobs)
        {
            // This calls the Display method on each job
            job.Display();
        }
    }
}

/*using System;

public class Resume {

    public string _personName;
    List<Job> _jobs = new List<Job>();

    public Resume(string _personName)
    {
        this._personName = _personName;
        //_jobs.Add(job1)
    }

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Jobs:");

        foreach(Job job in _jobs)
        {
          Console.WriteLine(job);
        }
    }
}*/