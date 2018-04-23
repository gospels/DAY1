using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_2
{
    public class Kvadrats
    {
        public string Krasa;
        public int MalasGarums;
        
        //uzstādam vienu variantu, kurā nekas netiks ievadīts
        public Kvadrats()
        {

        }
        
        //otrs variants kuram būs ievades paramateri
        public Kvadrats(string krasa, int garums)
        {
            this.Krasa = krasa;
            this.MalasGarums = garums;
        }

        public void KrasasIzvade()
        {
            Console.WriteLine("Krāsa ir " + this.Krasa);
        }
        // neievadam parametrus - jo tie jau ir nodefinēti klasē
        public int Laukums()
        {
            return this.MalasGarums * this.MalasGarums;
        }

        public int Perimetrs()
        {
            return this.MalasGarums * 4; 
        }

    }
}
