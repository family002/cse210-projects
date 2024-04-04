using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        ContactBook contactBook = new ContactBook();

        Menu menu = new Menu(contactBook);
        menu.Run();
    }
}