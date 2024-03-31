public class Email
{
    public string Address { get; set; }

    public void Display()
    {
        Console.WriteLine($"Email: {Address}");
    }
}