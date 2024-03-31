public class PhoneNumber
{
    public string Number { get; set; }

    public void Display()
    {
        Console.WriteLine($"Phone Number: {Number}");
    }
}