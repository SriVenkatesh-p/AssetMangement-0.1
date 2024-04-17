using System;
using Typeuser;
using Existing;

namespace AssetManagementSystem
{
    public class AssetManagement
    {
        public static void Main(string[] args)
        {
            WelcomeAddress.Welcome();
            TypeUser.validate();
        }
    }
    internal class WelcomeAddress
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to Asset Management System Industies");
            Console.WriteLine("----------------------------");
            Console.WriteLine("");
            Console.WriteLine("1. New User ");
            Console.WriteLine("2. Existing User");
            Console.WriteLine("----------------------------");
            Console.Write("Select the Option :  ");
        }
    }
}
