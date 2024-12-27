using System; 
using System.Collections.Generic; 
using System.Linq; 

namespace ContactManager 
{
    public class Contact 
    {
        public string FirstName { get; set; } // własciwosci klasy camel FirstName publiczne pole klasy
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact(string firstName, string lastName, string phoneNumber, string email) // konstruktor klasy 
        {
            FirstName = firstName;  // przypisanie parametrow do wlasciwosci firstName=zmienna 
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}

