using System; 
using System.Collections.Generic; 
using System.Linq; 

namespace ContactManager
{
    class Program
    {
        static void Main(string[] args)
    {
        Contact contact = new Contact ("Jan", "Kowalski", "123456789", "jankowalski@abc.com"); // tworzenie nowego obiektu Contact
        
        // wyswietlenie danych kontaktu 
        
        Console.WriteLine("FirstName: " + contact.FirstName); 
        Console.WriteLine("LastName: " + contact.LastName); 
        Console.WriteLine("PhoneNumber: " + contact.PhoneNumber);
        Console.WriteLine("Email: " + contact.Email);
    }
}

}
