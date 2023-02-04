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
                    "2)Add new Contact, Display and Stores contact in the list\n" +
                    "3)Edit Details of Contact\n" +
                    "4)Remove Contact Details from the List\n" +
                    "5)Enter numbers for Adding Multiple Contacts\n");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("::::::::::::::::::::::::::");
                        addobj.createContact();
                        Console.WriteLine("::::::::::::::::::::::::::");
                        Console.WriteLine("Entered Details of Person given as :");
                        addobj.Display();
                        addobj.addPerson();
                        break;

                       case 2:

                        while (check)
                        {
                            Console.WriteLine("Follow Steps to add details:\n" +
                               "1) To addContact\n" + "2) To Edit Contact\n" +
                               "3) To Display Contact\n");

                            int select = Convert.ToInt32(Console.ReadLine());
                            switch (select)
                            {
                                case 1:
                                    addobj.addPerson();
                                    Console.WriteLine(":::::::::::::::::::::::::::;");

                                    addobj.EditContact();
                                    Console.WriteLine(":::::::::::::::::::::::::::;");

                                    addobj.Display();
                                    Console.WriteLine(":::::::::::::::::::::::::::;");
                                    break;

                                default:

                                    check = !check;
                                    break;
                            }
                        }
                        break;

                    case 4:

                        while (check)
                        {
                            Console.WriteLine("Follow Steps to add details:\n" +
                               "1) To addContact\n" + "2) To Edit Contact\n" +
                               "3) To Remove Contact\n" + "4) To Display Contact\n");

                            int select = Convert.ToInt32(Console.ReadLine());
                            switch (select)
                            {
                                case 1:
                                    addobj.addPerson();
                                    Console.WriteLine(":::::::::::::::::::::::::::;");
                               

                                    addobj.EditContact();
                                    Console.WriteLine(":::::::::::::::::::::::::::;");
                                 
                                    addobj.DeleteContact();
                                    Console.WriteLine(":::::::::::::::::::::::::::;");


                                
                                    addobj.Display();
                                    Console.WriteLine(":::::::::::::::::::::::::::;");
                                  

                              
                                    addobj.AddMultipleContact();
                                    Console.WriteLine(":::::::::::::::::::::::::::;");
                                    break;

                                default:

                                    check = !check;
                                    break;
                            }
                        }
                        break;


                      

                    default:
                        Console.WriteLine("Please select proper option");
                        break;
                }
                check = false;
                Console.WriteLine("Try Again ");
                break;
            }
        }
    }
    

}
