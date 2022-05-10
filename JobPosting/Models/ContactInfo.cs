namespace JobPosting.Models
{
  public class ContactInfo
  {
    public string Email {get; set;}
    public string Name {get; set;}
    public string PhoneNum {get; set;}

    public ContactInfo(string email, string name, string phoneNum)
    {
      Email = "Email: " + email;
      Name = "Name: " + name;
      PhoneNum = "Phone Number: " + phoneNum;
    }
  }
}