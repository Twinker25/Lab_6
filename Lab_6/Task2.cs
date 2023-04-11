using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Passport
    {
        public string PIB { get; set; }
        public string date_birth { get; set; }
        public int num_passport { get; set; }
        public int identifical_code { get; set; }

        public void Input()
        {
            Console.Write("Enter your PIB: ");
            PIB = Console.ReadLine();
            Console.Write("Enter your date of birth: ");
            date_birth = Console.ReadLine(); 
            Console.Write("Enter your number of passport: ");
            num_passport = int.Parse(Console.ReadLine());
            Console.Write("Enter your identifical code: ");
            identifical_code = int.Parse(Console.ReadLine());
        }

        public void Show()
        {
            Console.WriteLine($"PIB: {PIB}");
            Console.WriteLine($"Date of birth: {date_birth}");
            Console.WriteLine($"Number of passport: {num_passport}");
            Console.WriteLine($"Identifical code: {identifical_code}");
        }
    }

    class ForeignPassport : Passport
    {
        public int num_for_passport { get; set; }
        public int num_viza { get; set; }
        public string type_viza { get; set; }
        public int num_enter { get; set; }

        public void ForInput()
        {
            Console.Write("Enter your number foreign passport: ");
            num_for_passport = int.Parse(Console.ReadLine());
            Console.Write("Enter your number of viza: ");
            num_viza = int.Parse(Console.ReadLine());
            Console.Write("Enter your type of viza: ");
            type_viza = Console.ReadLine();
            Console.Write("Enter your number of entries in other country: ");
            num_enter = int.Parse(Console.ReadLine());
        }

        public void ForShow()
        {
            Console.WriteLine($"Number foreign passport: {num_for_passport}");
            Console.WriteLine($"Number of viza: {num_viza}");
            Console.WriteLine($"Type of viza: {type_viza}");
            Console.WriteLine($"Number of entries in other country: {num_enter}");
        }
    }
}
