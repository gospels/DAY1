using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_2
{
    public class Uzdevumi
    {
        /// <summary>
        /// Starpiba starp skaitlis 1 un 2
        /// </summary>
        /// <param name="skaitlis 1"></param>
        /// <param name="skaitlis 2"></param>
        public void Starpiba(int skaitlis1, int skaitlis2)
        {
            int rezultato = skaitlis1 - skaitlis2;
            Console.WriteLine(rezultato);
        }
        /// <summary>
        /// Tris ciparu reizinajums
        /// </summary>
        /// <param name="skaitlis1"></param>
        /// <param name="skaitlis2"></param>
        /// <param name="skaitlis3"></param>
        public void Reizinajums (int skaitlis1, int skaitlis2, int skaitlis3)
        {
            long reizinajumaSumma = skaitlis1 * skaitlis2 * skaitlis3;
            Console.WriteLine(" ");
            Console.WriteLine(reizinajumaSumma);
        }

        public void SkaitluMaina (int skaitlis1, int skaitlis2)
        {
            Console.WriteLine(" ");
            Console.WriteLine("sk1 = " + skaitlis1);
            Console.WriteLine("sk2 = " + skaitlis2);
            // izveido jaunu mainīgo - kam piešķir esošo vērtību, esošo pārceļ uz otru, otram piesķir veco
            int skaitlis1Vecais = skaitlis1;
            skaitlis1 = skaitlis2;
            skaitlis2 = skaitlis1Vecais;
            
            Console.WriteLine("sk1 = " + skaitlis1);
            Console.WriteLine("sk2 = " + skaitlis2);

        }
        public void DaudzMatematikas (int sk1, int sk2)
        {
            int Summa = sk1 + sk2;
            int Starpiba = sk1 - sk2;
            long Reizinajums = sk1 * sk2;
            // - ee wrong long Dalijums = sk1 / sk2;

            Console.WriteLine(" ");
            Console.WriteLine("Daudz matematikas");
            Console.WriteLine("Skaitlis 1 = " + sk1);
            Console.WriteLine("Skaitlis 2 = " + sk2);
            Console.WriteLine("Summa = " + Summa);
            Console.WriteLine("Starpiba = "+ Starpiba);
            Console.WriteLine("Reizinajums = " + Reizinajums);
            Console.WriteLine("Dalijums = " + (double)sk1/sk2);
            //dalījuma atlikums - 3ās klases viela - eju nokaunēties
            Console.WriteLine("Dalijuma atlikums = " + sk1 % sk2);
        }
        /// teorija - 
        /// Console.Write - kursors paliek tajā pašā rindā, rLine - pāriet uz nākamo
        /// read - nolasa vienu simbolu, readLine - nolasa visu rindu, kas ir ierakstīta (tas vienmēr būs strings - nav summējams, ne dalāms)
        /// convert - pārvērš ievadīto vērtību uz citu Convert.ToInt32(text) - tā nostrādās tikai tad ja vērtība ir pieejama - A uz int nekonvertēs

        //Tiek definēta jauna funkcija, kas nesaņem parametrus un neatgriež vērtību
        public void IevadiVardu()
        {
            //Izvada tekstu nākamās 3 un pēdējai kursors paliek tajā pašā rindā
            Console.WriteLine(" ");
            Console.WriteLine("Visu kaut ko ievadam");
            Console.Write("Ievadi vārdu: ");
            //Nolasa ievadīto vārdu
            string vards = Console.ReadLine();
            //atgriež foršu rezultātu un kursors aiziet jaunā rindā
            Console.WriteLine("Tevi sauc " + vards);

            Console.Write("Ievadi skaitli: ");
            //nolasa ievadīto tekstu
            string skaitlisTekstuals = Console.ReadLine();
            //pārvērš stringu par ciparu
            int skaitlis = Convert.ToInt32(skaitlisTekstuals);
            //parāda rezultātu - ja tie bija burti - tad būs errors un nebūs rezultāta
            Console.WriteLine("Skaitlis ir " + skaitlis);
        }
        public void GraduParversana()
        {
            //rēķinām dažādus grādus
            Console.WriteLine(" ");
            Console.Write("Ievadi Celsija grādus, izrēķināšu Fārenheitus un Kelvinus: ");
            string gradiTeksta = Console.ReadLine();
            int cipars = Convert.ToInt32(gradiTeksta);
            double farenheits = (cipars * 9) / 5 + 32;
            double kelvins = cipars + 273.15;

            Console.WriteLine("Fārenheits teiktu: " + farenheits);
            Console.WriteLine("Kelvins teiktu: " + kelvins);
        }




    }

}
