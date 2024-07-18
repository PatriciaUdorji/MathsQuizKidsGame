using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;


namespace MathsQuizKidsGame
{
    internal class Login
    {


        public string Username { get; set; }
        public string Password { get;set; }
        public string Name { get;set; }
        public Login(string username, string password, string name)
        {
            Username = username;
            Password = password;
            Name = name;
        }
        

        public static void userLogin()
        {
            int input;
            Console.WriteLine();
            Console.WriteLine("1: Create a new Username and Password");
            Console.WriteLine("2: Login");
            Console.WriteLine("3: Exit");
            Console.WriteLine();

            input =int.Parse(Console.ReadLine());
        }

        string passWordSpecialCharacter=" ";

        public static bool SignUp(string username, string password, string name)
        {
            // Verify password length
            if (password.Length < 8 || password.Length > 16)
            {
                Console.WriteLine("Password must be in range of 8-16 characters.");
                return false;
            }
            newuser regex = new newuser("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]+");

            if (regex.Match(password).Value == "")
            {
                Console.WriteLine("Password must contains alphanumeric characters and atleast 1 special symbol.");
                return false;
            }

            return true;

        }

}}

        


        
       