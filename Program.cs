using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti înăltimea (cm): ");
            double inaltime = double.Parse(Console.ReadLine());

            Console.Write("Introduceti varsta (ani): ");
            int varsta = int.Parse(Console.ReadLine());

            Console.Write("Introduceti sexul (f pentru femei, m pentru barbati): ");
            char sex = char.ToLower(Console.ReadKey().KeyChar);

            double greutateIdeala = 0;

            if (sex == 'm')
            {
                greutateIdeala = CalculGreutateBarbati(inaltime, varsta);
            }
            else if (sex == 'f')
            {
                greutateIdeala = CalculGreutateFemei(inaltime, varsta);
            }
            else
            {
                Console.WriteLine("Optiune de sex invalidă.");
                return;
            }

            AfisareGreutateIdeala(greutateIdeala);
            Console.ReadLine();
        }
        static double CalculGreutateBarbati(double inaltime, int varsta)
        {
            return inaltime - 100 - ((inaltime - 150) / 4) + ((varsta - 20) / 4);
        }

        static double CalculGreutateFemei(double inaltime, int varsta)
        {
            return inaltime - 100 - ((inaltime - 150) / 2.5) + ((varsta - 20) / 6);
        }

        static void AfisareGreutateIdeala(double greutateIdeala)
        {
            Console.WriteLine($"\nGreutatea ideală este: {greutateIdeala} kg");
        }
    }
}
