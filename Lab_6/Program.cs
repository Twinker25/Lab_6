using System.Transactions;

namespace Lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do 
            {
                Console.Write("Enter task (1 - 3): ");
                choice = int.Parse(Console.ReadLine());
                switch (choice) 
                {
                    case 1:
                        Console.WriteLine("\nBuilder: ");
                        Builder builder = new Builder();
                        builder.InputB();
                        Console.WriteLine("\nShow info:");
                        builder.ShowB();

                        Console.WriteLine("\nSailor: ");
                        Sailor sailor = new Sailor();
                        sailor.InputS();
                        Console.WriteLine("\nShow info:");
                        sailor.ShowS();

                        Console.WriteLine("\nPilot: ");
                        Pilot pilot = new Pilot();
                        pilot.InputP();
                        Console.WriteLine("\nShow info:");
                        pilot.ShowP();
                        break;
                    case 2:
                        Console.WriteLine();
                        Passport passport = new Passport();
                        passport.Input();
                        Console.WriteLine("\nShow info:");
                        passport.Show();
                        Console.WriteLine();
                        ForeignPassport foreignPassport = new ForeignPassport();
                        foreignPassport.ForInput();
                        Console.WriteLine("\nShow info:");
                        foreignPassport.ForShow();
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.Write("Enter name of tiger: ");
                        string namet = Console.ReadLine();
                        Console.Write("Enter age of tiger: ");
                        int aget = int.Parse(Console.ReadLine());
                        Console.Write("Enter weight of tiger: ");
                        int weightt = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Enter name of crocodile: ");
                        string namec = Console.ReadLine();
                        Console.Write("Enter age of crocodile: ");
                        int agec = int.Parse(Console.ReadLine());
                        Console.Write("Enter weight of crocodile: ");
                        int weightc = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Enter name of kangaroo: ");
                        string namek = Console.ReadLine();
                        Console.Write("Enter age of kangaroo: ");
                        int agek = int.Parse(Console.ReadLine());
                        Console.Write("Enter weight of kangaroo: ");
                        int weightk = int.Parse(Console.ReadLine());
                        Tiger tiger = new Tiger(namet, aget, weightt);
                        Crocodile crocodile = new Crocodile(namec, agec, weightc);
                        Kangaroo kangaroo = new Kangaroo(namek, agek, weightk);

                        Console.WriteLine("\nTiger:");
                        Console.WriteLine("Name: " + namet);
                        Console.WriteLine("Age: " + aget);
                        Console.WriteLine("Weight: " + weightt);
                        tiger.Roar();
                        Console.WriteLine("\nCrocodile:");
                        Console.WriteLine("Name: " + namec);
                        Console.WriteLine("Age: " + agec);
                        Console.WriteLine("Weight: " + weightc);
                        crocodile.Swim();
                        Console.WriteLine("\nKangaroo:");
                        Console.WriteLine("Name: " + namek);
                        Console.WriteLine("Age: " + agek);
                        Console.WriteLine("Weight: " + weightk);
                        kangaroo.Jump();
                        break;
                    default:
                        Console.WriteLine("Error! Try again!");
                        break;
                }
            }while (choice < 1 || choice > 3);
        }
    }
}