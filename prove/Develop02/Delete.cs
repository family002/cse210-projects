using System.Diagnostics.CodeAnalysis;

class DeleteFile
{
    public static void Delete(string fileName)
    {   
        string savefolder = "saves";
        if (File.Exists(fileName)) // This is where this code gets stuck on if you try to delete
        {
            string directoryPath = Path.GetDirectoryName(fileName);
            if (directoryPath.EndsWith($"{Path.DirectorySeparatorChar}{savefolder}", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"The file '{fileName}' exists in the directory '{directoryPath}'.");
                Console.Write($"Are you sure you want to delete {fileName}? (y/n): ");
                string _answer = Console.ReadLine();

                if (_answer.ToLower() == "y")
                {
                    Console.WriteLine($"Deleting {fileName} in 5 seconds. Press any key to cancel.");
                    for (int i = 5; i > 0; i--)
                    {
                        if (Console.KeyAvailable)
                        {
                            Console.ReadKey(true);
                            Console.WriteLine("Deletion cancelled.");
                            return;
                        }

                        Console.Write($"{i}");
                        System.Threading.Thread.Sleep(1000);
                    }

                    try
                    {
                        File.Delete(fileName);
                        Console.WriteLine($"{fileName} has been deleted.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error deleting file: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("Deletion cancelled.");
                }
            }
            else
            {
                Console.WriteLine($"The file '{fileName}' isn't in the correct folder.");
            }
        }
        else
        {
            Console.WriteLine($"The file '{fileName}' does not exist.");
        }
    }
}