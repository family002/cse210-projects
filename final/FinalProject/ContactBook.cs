using System.Collections.Generic;
using System.IO;

public class ContactBook
{
    private List<Contact> contacts;

    public ContactBook()
    {
        contacts = new List<Contact>();
    }

    public void AddContact(Contact contact)
    {
        contacts.Add(contact);
    }

    public void DisplayAllContacts()
    {
        foreach (Contact contact in contacts)
        {
            contact.DisplayContactInfo();
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Contact contact in contacts)
            {
                writer.WriteLine(contact.GetType().Name);
                writer.WriteLine(contact.Name);
                if (contact is PersonalContact)
                {
                    PersonalContact personalContact = contact as PersonalContact;
                    writer.WriteLine(personalContact.HomeAddress.Street);
                    writer.WriteLine(personalContact.HomeAddress.City);
                    writer.WriteLine(personalContact.HomeAddress.State);
                    writer.WriteLine(personalContact.HomeAddress.ZipCode);
                    writer.WriteLine(personalContact.PersonalPhoneNumber.Number);
                    writer.WriteLine(personalContact.PersonalEmail.Address);
                }
                else if (contact is BusinessContact)
                {
                    BusinessContact businessContact = contact as BusinessContact;
                    writer.WriteLine(businessContact.BusinessAddress.Street);
                    writer.WriteLine(businessContact.BusinessAddress.City);
                    writer.WriteLine(businessContact.BusinessAddress.State);
                    writer.WriteLine(businessContact.BusinessAddress.ZipCode);
                    writer.WriteLine(businessContact.BusinessPhoneNumber.Number);
                    writer.WriteLine(businessContact.BusinessEmail.Address);
                }
            }
        }
    }
}