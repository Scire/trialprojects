using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            users.Add("Anders", "banan");
            users.Add("Gustaf", "apelsin");
            users.Add("Klara", "päron");
            
           
            string userName = null;
            string userPassword = null;
            while (true)
            {
                Console.Write("User Name: ");
                userName = Console.ReadLine();           
                if (users.ContainsKey(userName))
                {
                    string correctPassword = users[userName].ToString();
                    while (true)
                    {
                        Console.Write("Password: ");
                        userPassword = Console.ReadLine();
                        if (userPassword == correctPassword)
                        {
                            Console.WriteLine("Welcome");
                            Console.ReadLine();
                            return;
                        }
                        else
                        {
                            // Returns admonishment if user is stupid                           
                            Console.WriteLine("Wrong Password");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Wrong User!");
                }
            } 
        }
    }
}
