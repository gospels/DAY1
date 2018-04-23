using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_2
{
    public class ManaPirmaKlase
    { 
        // funkcija bez rezultāta un bez ievades
        public void SayHello()
        {
            Console.WriteLine("Say hello!");
        }
        // funkcija bez rezultāta un bez ievades
        public void Rata()
        {
            Console.WriteLine("Dabudaba");
        }
        //ja nav VOID - tad beigsies ar atslēgas vārdu Return - funkcija ar ievadu un atgriež skaitli
        public int GetNumber()
        {
            return 99; 
        }
        // funkcija ar rezultatu un ievada parametru - atgriež skaitli ko saņēmusi parametrā
        /// <summary>
        /// Atgriež skaitli
        /// </summary>
        /// <param name="skaitlis"></param>
        /// <returns></returns>
        public int GetNumber2(int skaitlis)
        {
            return skaitlis;
        }
    }
}
