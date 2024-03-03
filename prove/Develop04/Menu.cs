public class Menu
{
    public void ShowMenu()
    {
        Console.WriteLine("Please select an activity:\n1. Breathing\n2. Reflecting\n3. Listing\n 4. Quit");
    }

    public Activity SelectActivity()
    {
        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                return new BreathingActivity(0);
            case 2:
                return new ReflectingActivity(0);
            case 3:
                return new ListingActivity(0);
            default:
                return null;
        }
    }
}