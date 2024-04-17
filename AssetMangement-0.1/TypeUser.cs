using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Existing;
using Newuser;

namespace Typeuser
{
    internal class TypeUser
    {
        public static void validate()
        {
            int check = Convert.ToInt32(Console.ReadLine());

            switch (check)
            {
                case 1:
                    //New user File
                    NewUser.New();
                    break;
                case 2:
                    //Existing User file
                    ExistingUser.Exit();
                    break;
                    case 3:
                    Console.WriteLine("THANK YOU FOR VISITING !");
                    Environment.Exit(Environment.ExitCode);
                    
                    break;
                default:
                    Console.WriteLine("Invaild");
                    validate();
                    break;
            }
        }

    }

}


