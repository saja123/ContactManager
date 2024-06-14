using System.Collections.Generic;

namespace ContactManager
    
{
    public class Program
    {
        public static List<string> contacts = new List<string>();
        static void Main(string[] args)
        {
            ContactsManager();
        }

       
        public static void ContactsManager()
        {

            // Add to the List:
            AddContact("");
            AddContact("Joun");
            AddContact("Joun");
            AddContact("saja");


            Console.WriteLine("List of contacts is :");
            ViewAllContacts();

            // Remove from the list
            RemoveContact("saja");

            Console.WriteLine("List of contacts after to remove :");
            ViewAllContacts();

        }
        public static void AddContact(string contact)
        {
            if (!string.IsNullOrEmpty(contact))
            {
                if (!contacts.Contains(contact))
                { 
                    contacts.Add(contact);                    
                }
                else
                {
                    Console.WriteLine("Sorry it's duplicate");
                }
            }
            else
            {
                Console.WriteLine("Sorry You Can't Add Null Value");
            }
                
        }

        public static void RemoveContact(string contact)
        {
            if (contacts.Contains(contact))
            {
                contacts.Remove(contact);
            }
            else {
                Console.WriteLine("it's not Contain in List");
            }
        }

        public static void ViewAllContacts()
        {
            for (int i = 0; i < contacts.Count; i++) {
                Console.WriteLine(contacts[i]);
            }
        }
    }
}
