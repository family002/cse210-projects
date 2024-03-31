public class BusinessContact : Contact
{
    public Address BusinessAddress { get; set; }
    public PhoneNumber BusinessPhoneNumber { get; set; }
    public Email BusinessEmail { get; set; }

    public override void DisplayContactInfo()
    {
        Console.WriteLine($"Name: {Name}");
        BusinessAddress.Display();
        BusinessPhoneNumber.Display();
        BusinessEmail.Display();
    }
}