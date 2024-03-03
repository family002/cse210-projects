class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();

        while (true)
        {
            menu.ShowMenu();
            Activity activity = menu.SelectActivity();

            if (activity == null)
            {
                break;
            }

            activity.Start();
            activity.End();
        }
    }
}