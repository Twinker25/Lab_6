using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Human
    {
        public string PIB { get; set; }
        public int age { get; set; }
        public int height { get; set; }
        public int weight { get; set; }

        public void Input()
        {
            Console.Write("Enter PIB: ");
            PIB = Console.ReadLine();
            Console.Write("Enter age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            height = int.Parse(Console.ReadLine());
            Console.Write("Enter weight: ");
            weight = int.Parse(Console.ReadLine());
        }

        public void Show()
        {
            Console.WriteLine($"PIB: {PIB}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Weight: {weight}");
        }
    }

    class Builder : Human
    {
        public string rank { get; set; }
        public int work_exp { get; set; }
        public string build { get; set; }

        public void InputB()
        {
            base .Input();
            Console.Write("Enter rank: ");
            rank = Console.ReadLine();
            Console.Write("Enter work experience: ");
            work_exp = int.Parse(Console.ReadLine());
            Console.Write("Enter type of build: ");
            build = Console.ReadLine();
        }

        public void ShowB()
        {
            base .Show();
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Work experience: {work_exp}");
            Console.WriteLine($"Build: {build}");
        }
    }

    class Sailor : Human
    {
        public string rank { get; set; }
        public int work_exp { get; set; }
        public string ship { get; set; }

        public void InputS()
        {
            base.Input();
            Console.Write("Enter rank: ");
            rank = Console.ReadLine();
            Console.Write("Enter work experience: ");
            work_exp = int.Parse(Console.ReadLine());
            Console.Write("Enter name of ship: ");
            ship = Console.ReadLine();
        }

        public void ShowS()
        {
            base.Show();
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Work experience: {work_exp}");
            Console.WriteLine($"Ship: {ship}");
        }

    }

    class Pilot : Human
    {
        public string rank { get; set; }
        public int work_exp { get; set; }
        public string plane { get; set; }

        public void InputP()
        {
            base.Input();
            Console.Write("Enter rank: ");
            rank = Console.ReadLine();
            Console.Write("Enter work experience: ");
            work_exp = int.Parse(Console.ReadLine());
            Console.Write("Enter name of plane: ");
            plane = Console.ReadLine();
        }

        public void ShowP()
        {
            base.Show();
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Work experience: {work_exp}");
            Console.WriteLine($"Plane: {plane}");
        }
    }
}
