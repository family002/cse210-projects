using System.Collections.Generic;
using System.IO;

public class Menu
{
    private ContactBook contactBook;

    public Menu(ContactBook book)
    {
        contactBook = book;
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Contact Book Menu:");
        Console.WriteLine("1. Add Contact");
        Console.WriteLine("2. Display All Contacts");
        Console.WriteLine("3. Save Contacts to File");
        Console.WriteLine("4. Exit");
    }

    public void Run()
    {
        while (true)
        {
            DisplayMenu();
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddContact();
                    break;
                case "2":
                    contactBook.DisplayAllContacts();
                    break;
                case "3":
                    Console.Write("Enter the file name to save: ");
                    string fileName = Console.ReadLine();
                    contactBook.SaveToFile(fileName);
                    Console.WriteLine("Contacts saved successfully!");
                    break;
                case "4":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice! Please enter a valid option.");
                    break;
            }
        }
    }

    private void AddContact()
    {
        Console.WriteLine("Adding Contact:");
        Console.Write("Enter contact name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Is it a personal (P) or business (B) contact?");
        string type = Console.ReadLine().ToUpper();
        Contact contact;
        if (type == "P")
        {
            contact = new PersonalContact { Name = name };
            Console.Write("Enter home address street: ");
            string street = Console.ReadLine();
            Console.Write("Enter home address city: ");
            string city = Console.ReadLine();
            Console.Write("Enter home address state: ");
            string state = Console.ReadLine();
            Console.Write("Enter home address ZIP code: ");
            string zipCode = Console.ReadLine();
            ((PersonalContact)contact).HomeAddress = new Address { Street = street, City = city, State = state, ZipCode = zipCode };
            Console.Write("Enter personal phone number: ");
            string phoneNumber = Console.ReadLine();
            ((PersonalContact)contact).PersonalPhoneNumber = new PhoneNumber { Number = phoneNumber };
            Console.Write("Enter personal email address: ");
            string emailAddress = Console.ReadLine();
            ((PersonalContact)contact).PersonalEmail = new Email { Address = emailAddress };
        }
        else if (type == "B")
        {
            contact = new BusinessContact { Name = name };
            Console.Write("Enter business address street: ");
            string street = Console.ReadLine();
            Console.Write("Enter business address city: ");
            string city = Console.ReadLine();
            Console.Write("Enter business address state: ");
            string state = Console.ReadLine();
            Console.Write("Enter business address ZIP code: ");
            string zipCode = Console.ReadLine();
            ((BusinessContact)contact).BusinessAddress = new Address { Street = street, City = city, State = state, ZipCode = zipCode };
            Console.Write("Enter business phone number: ");
            string phoneNumber = Console.ReadLine();
            ((BusinessContact)contact).BusinessPhoneNumber = new PhoneNumber { Number = phoneNumber };
            Console.Write("Enter business email address: ");
            string emailAddress = Console.ReadLine();
            ((BusinessContact)contact).BusinessEmail = new Email { Address = emailAddress };
        }
        else
        {
            Console.WriteLine("Invalid contact type!");
            return;
        }
        contactBook.AddContact(contact);
        Console.WriteLine("Contact added successfully!");
    }
}