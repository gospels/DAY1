using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_2
{
    class Program
    {
        //Galvenais ieejas punkts aplikācijās = MAIN
        static void Main(string[] args)
        {
            /*Uzdevumi uzdevumi = new Uzdevumi();
            uzdevumi.Starpiba(156, 252);
            
            Console.ReadLine();
            */

            /*            
            // izveido jaunu objektu no klases Uzdevumi
            Uzdevumi uzdevumi = new Uzdevumi();
           
            //tiek izsauktas konkrēta objekta funkcijas
            uzdevumi.Starpiba(156, 252);
            uzdevumi.Reizinajums(898456, 2, 1);
            uzdevumi.SkaitluMaina(50, 6);
            uzdevumi.DaudzMatematikas(8, 10);
            uzdevumi.IevadiVardu();
            uzdevumi.GraduParversana();

            //funkcija kas gaida ievadi, līdz ar to logs paliek vaļā, kamēr nenospiedīs ENTER
            Console.ReadLine();
            */

            /*
            Auto auto = new Auto();
            auto.Krasa = "Melna";
            auto.Marka = "BMW";
            auto.Info();

            Auto vw = new Auto();
            vw.Krasa = "Zaļa";
            vw.Marka = "VW";
            vw.Info();
            //konstruktos ir ...
            Auto nezinams = new Auto();
            nezinams.Info();
            */

            Kvadrats kv1 = new Kvadrats();
            kv1.Krasa = "sarkana";
            kv1.MalasGarums = 4;

            kv1.KrasasIzvade();
            int laukums = kv1.Laukums();
            Console.WriteLine("Laukums ir " + laukums);
            Console.WriteLine("Perimetrs ir " + kv1.Perimetrs());

            Kvadrats kv2 = new Kvadrats("melns", 5);
            kv2.KrasasIzvade();
            Console.WriteLine("Perimetrs ir " + kv2.Perimetrs());

            Console.ReadLine();
        }
    }
}