public class PersonalContact : Contact
{
    public Address HomeAddress { get; set; }
    public PhoneNumber PersonalPhoneNumber { get; set; }
    public Email PersonalEmail { get; set; }

    public override void DisplayContactInfo()
    {
        Console.WriteLine($"Name: {Name}");
        HomeAddress.Display();
        PersonalPhoneNumber.Display();
        PersonalEmail.Display();
    }
}