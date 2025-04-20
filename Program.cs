using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CustomersRegistration
{
    class Program
    {
        static List<Customer> customers = new List<Customer>();
        static void Main(string[] args)
        {
            Console.Clear();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1 - Add customer");
                Console.WriteLine("2 - View customer");
                Console.WriteLine("3 - Edit customer");
                Console.WriteLine("4 - Delete customer");
                Console.WriteLine("5 - Exit");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        AddCustomer();
                        break;
                    case 2:
                        Console.Clear();
                        ViewCustomer();
                        break;
                    case 3:
                        Console.Clear();
                        EditCustomer();
                        break;
                    case 4:
                        Console.Clear();
                        DeletCustomer();
                        break;
                    case 5:
                        Console.Clear();
                        running = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid Option");
                        break;
                }

            }
        }
        static void AddCustomer()
        {
            Console.WriteLine("Enter the customer name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the customer e-mail: ");
            string email = Console.ReadLine();

            Customer customer = new Customer(name, email);
            customers.Add(customer);
            Console.Clear();
            Console.WriteLine("Customer added successfully");
        }
        static void ViewCustomer()
        {
            Console.WriteLine("Total customers: " + customers.Count);
            for (int i = 0; i < customers.Count; i++)
            {
                Console.WriteLine($"[{i}] Name: {customers[i].Name}");
                Console.WriteLine($"     E-mail: {customers[i].Email}");
                Console.WriteLine("----------------------");
            }
        }
        static void EditCustomer()
        {
            Console.WriteLine("Enter customer name with you want to edit: ");
            string name = Console.ReadLine();

            Customer customer = customers.Find(c => c.Name == name);

            if (customer != null)
            {
                Console.WriteLine("Enter the new name of costumer: ");
                string newName = Console.ReadLine();

                Console.WriteLine("Enter the new e-mail of costumer: ");
                string newEmail = Console.ReadLine();

                customer.Name = newName;
                customer.Email = newEmail;

                Console.WriteLine("Customer edited successfully.");
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
        }
        static void DeletCustomer()
        {
            Console.WriteLine("Enter the name of customer to delete");
            string name = Console.ReadLine();

            Customer customer = customers.Find(c => c.Name == name);

            if (customer != null)
            {
                customers.Remove(customer);
                Console.WriteLine("Customer delete sucess");
            }
            else
            {
                Console.WriteLine("Customer not found");
            }
        }
    }
    class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}