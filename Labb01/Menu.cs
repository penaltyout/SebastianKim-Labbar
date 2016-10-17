using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb01
{
    class Menu
    {
        List<Dog> DogList = new List<Dog>();

        public void StartMenu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("### Sebastian's Doggy Management System v1.1 ###");
                Console.WriteLine();
                Console.WriteLine(" Press \"1\" - Add new data to list");
                Console.WriteLine(" Press \"2\" - Remove data from list");
                Console.WriteLine(" Press \"3\" - Edit data in list");
                Console.WriteLine(" Press \"4\" - Show your dog list");
                Console.WriteLine(" Press \"5\" - Exit prgram");
                Console.WriteLine();
                Console.Write(" You choose: ");
                String inputToChoose = Console.ReadLine();

                switch (inputToChoose)
                {
                    case "1": AddToList(); EnterToContinueKey(); break;
                    case "2": RemoveFromList(); EnterToContinueKey(); break;
                    case "3": EditListData(); EnterToContinueKey(); break;
                    case "4": ShowList(); EnterToContinueKey(); break;
                    case "5": ExitFromProgram(); break;
                    default: EnterToContinueKey(); break;
                }
            } while (true);
        }

        public void AddToList()
        {
            Console.Clear();
            Console.WriteLine("### Add a new dog to your list ###");
            Console.WriteLine();
            Console.Write(" a. Name of the dog: ");
            string inputName = Console.ReadLine();
            Console.Write(" b. Age of the dog: ");
            string inputAge = Console.ReadLine();
            Console.Write(" c. Breed of the dog: ");
            string inputBreed = Console.ReadLine();

            DogList.Add(new Dog(inputName, inputAge, inputBreed));
            Console.WriteLine();
            Console.WriteLine(" Your data has been safely stored.");
        }

        public void RemoveFromList()
        {
            Console.Clear();
            ShowList();
            Console.WriteLine();
            Console.Write(" Choose which one to delete from list: ");
            string inputToDelete = Console.ReadLine();

            int i = 0;

            if (int.TryParse(inputToDelete, out i))
            {
                if (i > DogList.Count)
                {
                    Console.WriteLine();
                    Console.WriteLine(" There is no such data in your list.");
                }
                else
                {
                    DogList.RemoveAt(i - 1);
                    Console.WriteLine();
                    Console.WriteLine(" No.{0} has been safely removed.", i);
                }
            }
        }

        public void EditListData()
        {
            Console.Clear();
            ShowList();
            Console.WriteLine();
            Console.Write(" Choose which one to edit of list: ");
            string inputToEdit = Console.ReadLine();

            int i;

            if (int.TryParse(inputToEdit, out i))
            {
                if (i > DogList.Count)
                {
                    Console.WriteLine();
                    Console.WriteLine(" There is no such data in your list.");
                }
                else
                {
                    Console.WriteLine();
                    Console.Write(" a. Name of the dog: ");
                    string inputName = Console.ReadLine();
                    Console.Write(" b. Age of the dog: ");
                    string inputAge = Console.ReadLine();
                    Console.Write(" c. Breed of the dog: ");
                    string inputBreed = Console.ReadLine();
                    Console.WriteLine();

                    DogList[i - 1] = new Dog(inputName, inputAge, inputBreed);
                    Console.WriteLine(" No.{0} has been safely edited and stored.", i);
                }

            }
        }

        public void ShowList()
        {
            Console.Clear();
            Console.WriteLine("### List of your dog(s) ###");
            Console.WriteLine();

            int i = 1;

            foreach (var dog in DogList)
            {
                Console.WriteLine(" No.{0} - {1}, {2} year(s) old, {3}", i, dog.Name, dog.Age, dog.Breed);
                i++;
            }
        }

        public void ExitFromProgram()
        {
            Console.WriteLine();
            Console.Write(" Are you sure (Y/N): ");
            string inputToExit = Console.ReadLine();

            if (inputToExit.ToUpper() == "Y")
            {
                Environment.Exit(0);
            }
        }

        public void EnterToContinueKey()
        {
            Console.WriteLine();
            Console.WriteLine(" Press any key to continue.");
            Console.ReadKey();
        }
    }
}
