using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assigning;

namespace Existing
{
    internal class ExistingUser
    {
        public static void Exit()
        {
            Validate vali = new Validate();
            vali.condition();
        }

    }
    internal class Validate()
    {
        public void condition()
        {
            Console.Write("Enter UserID  :\t");
            var Id = Console.ReadLine().ToUpper();
            Console.Write("Enter Passkey :\t");
            var Key = Console.ReadLine().ToUpper();
            Console.WriteLine("");
            Console.WriteLine("----------------------------");

            if (string.IsNullOrEmpty(Id))
            {
                Console.WriteLine("User Id cannot be Empty");
                condition();
            }
            else if (string.IsNullOrEmpty(Key))
            {
                Console.WriteLine("PassKey cannot be Empty");
                condition();
            }

            var user = new (string id, string key)[]
            {
                (id:"VENKAT",key:"2024"),
                (id:"MITHUN",key:"1011"),
                (id:"NAVEEN",key:"2022"),

            };

            bool check = false;
            foreach (var item in user)
            {
                if (Id == item.id && Key == item.key)
                {
                    Console.WriteLine($"WELCOME BACK  {item.id}\n\n");
                    Console.WriteLine(item.id, item.key);
                    check = true;

                }

                continue;
            }
            if (check == false)
            {
                Console.WriteLine("Invalid User ID are PassKey");
                Console.WriteLine("IF YOU ARE A NEW USER PRESS 1 TO CREATE NEW USER");
            }

            Operations assign = new Operations();
            assign.listOfItem();



        }
    }
}





