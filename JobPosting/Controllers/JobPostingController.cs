using Microsoft.AspNetCore.Mvc;
using JobPosting.Models;
using System.Collections.Generic;

namespace JobPosting.Controllers
{
  public class JobPostingController : Controller
  {
    [HttpGet("/jobposting/form")]
    public ActionResult Form()
    {
      return View();
    }
    [HttpPost("/jobposting/display")]
    public ActionResult Display(string title, string description, string name, string email, string phoneNum)
    {
      ContactInfo contact = new ContactInfo(email, name, phoneNum);
      JobPost newJobPost = new JobPost(contact, title, description);
      List<JobPost> allJobs = JobPost.GetAll();
      return View(allJobs);
    }
  }
}