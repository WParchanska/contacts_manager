using System; 
using System.Collections.Generic; 
using System.Linq; 

namespace ContactManager
{
    class Program
    {
        static void Main(string[] args)
    
    {
        List<Contact> contacts = new List<Contact>(); 

        Contact contact = new Contact ("Jan", "Kowalski", "123456789", "jankowalski@abc.com"); // tworzenie nowego obiektu Contact
        
        contacts.Add(contact); // dodanie kontaktu do listy 

        Console.WriteLine("Contact added successfully"); // sprawdzenie czy kontakt zostal dodany 

        // wyswietlenie danych kontaktu 
        
        Console.WriteLine("FirstName: " + contact.FirstName); 
        Console.WriteLine("LastName: " + contact.LastName); 
        Console.WriteLine("PhoneNumber: " + contact.PhoneNumber);
        Console.WriteLine("Email: " + contact.Email);
    }
}

}
