using System.Collections.Generic;
namespace JobPosting.Models
{
  public class JobPost
  {
    public ContactInfo Contact {get; set;}
    public string Title {get; set;}
    public string Description {get; set;}
    private static List<JobPost> _jobs = new List<JobPost>();

    public JobPost(ContactInfo contact, string title, string description)
    {
      Contact = contact;
      Title = title;
      Description = description;
      _jobs.Add(this);
    }
    public static List<JobPost> GetAll()
    {
      return _jobs;
    }
  }
}