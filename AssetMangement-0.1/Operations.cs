using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigning
{
    internal class Operations
    {
        public void listOfItem()
        {
            DataEnter data = new();
            data.rec();
            data.Enter();

        }
    }


    public class recData
    {
        public void rec()
        {
            bool lT = true;
            while (lT)
            {
                Console.WriteLine("1. Adding New Asset");//create
                Console.WriteLine("2. Delete the Asset");//Delete
                Console.WriteLine("3. View the Asset");//read
                Console.WriteLine("4. Update the Asset");//Update
                Console.WriteLine("5. Exist the Application");//Update
                break;
            }
        }
    }
    public class DataEnter : recData
    {
        public void Enter()
        {
            string list = Console.ReadLine();
            switch (list)
            {
                case "1":
                    Console.WriteLine("ADDING");
                    Add add = new Add();
                    add.Adding();
                    break;
                case "2":
                    Console.WriteLine("DELETE");
                    break;
                case "3":
                    Console.WriteLine("READ");
                    break;
                case "4":
                    Console.WriteLine("UPDATE");
                    break;
                case "5":
                    Console.WriteLine("Exist");
                    break;
                default:
                    Console.WriteLine("Invaild");
                    break;

            }
        }
        public class Add
        {
            public void Adding()
            {
                Console.WriteLine("Enter the product name : ");

            }
        }
        public class Delete
        {
            public void DeleteItem()
            {

            }
        }
        public class Read
        {
            public void ViewItem()
            {

            }
        }
        public class Update
        {
            public void UpdatItem()
            {

            }
        }

    }
}



