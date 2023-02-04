using System;

namespace Address_Book
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            bool check = true;

            AddressBook addobj = new AddressBook();

            while (check)
            {
                Console.WriteLine("Please select the Options :\n" +
                    "1)Enter Details to add Contact in List\n" +
                    "2)Add new Contact, Display and Stores contact in the list\n");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("::::::::::::::::::::::::::");
                        addobj.createContact();
                        break;

                    case 2:
                        Console.WriteLine("::::::::::::::::::::::::::");
                        addobj.createContact();

                        Console.WriteLine("::::::::::::::::::::::::::");
                        Console.WriteLine("Entered Details of Person given as :");
                        addobj.Display();

                        addobj.addPerson();
                        break;


                    default:
                        Console.WriteLine("Please select proper option");
                        break;
                }
                check = false;
                break;
            }
        }
    }
    

}
