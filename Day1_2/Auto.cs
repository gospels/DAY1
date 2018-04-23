using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_2
{
    public class Auto
    {
        /// <summary>
        /// Tas ka tas ir konstruktors, parāda tas ka nav
        /// VOID = rezultāta tipa
        /// un arī tas ka nosaukums sakrīt ar klases nosaukumu
        /// </summary>
        public Auto()
        // ar to kas ir zemāk mēs uzstādam vērtības pēc noklusējuma, kas tiks parādītas, kamēr netiks uzstādītas
        {
            this.Marka = "Nezināms";
            this.Krasa = "Nezināms";
        }
        //tā ir īpašība - tā kā nav iekavas, tad tā nav funkcija - ja būtu iekavas - būtu funkcija
        public string Marka;
        public string Krasa;

        public void Info()
        {
            Console.WriteLine("Auto marka ir " + this.Marka);
            //var arī iztikt bez *this* - jo tad tiks izmantota esošā īpašība
            // ja funkcijā atslēgas vārds ir tāds pats kā klasē - tad *this* ir jālieto
            Console.WriteLine("Auto krasa ir " + this.Krasa);
        }

    
    }
}
