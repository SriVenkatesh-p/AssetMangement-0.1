using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assigning;

namespace Newuser
{
    internal class NewUser
    {
        public static void New()
        {
         New neew = new();
            neew.User();

            Operations op = new Operations();
            op.listOfItem();

        }
    }
    public class New
    {
        public void User() {

            Console.WriteLine("Create New User Id");
            var newId =Console.ReadLine().ToUpper();
            Console.WriteLine("Create New PassKey ");
            var newKey =Console.ReadLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine($"WELCOME {newId}\n");
        
        }
    }
}
