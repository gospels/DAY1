using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_2
{

    class Program
    {
        /*HT - parakņāties un saprast kas ir šis - kad vienu klasi ienes iekšā citā un no tās izsauc to
         * according to artis - tas ir tāpēc, ka tā ir pierasts to visu sadalīt - klase tiks citā failā iekšā - līdz 
         * ar to nepieciešams viņas izdalīt no Main koda*/

        static void Main(string[] args)
        {
            //1. variable type
            //2.variable name
            //3.Initial value = new object of this class
            /*ManaPirmaKlase objekts = new ManaPirmaKlase();

            //objekts.SayHello();
            objekts.Rata();

            int rezultats = objekts.GetNumber();
            Console.WriteLine(rezultats);
            
            int rezultats2 = objekts.GetNumber2(100);
            Console.WriteLine(rezultats2);

            Console.ReadLine();*/

            Uzdevumi pirmais = new Uzdevumi();

            pirmais.Uzdevums1("Janis");

            pirmais.Uzdevums2(465484654, 5484879);

            Console.ReadLine();
        }
    }
}


/// Teorija 
/// - Datu tipi
/// object - skaitlis, teksts, decimāls - anything, bet viņus nevar sasummēt
/// string - texti - aprox 2GB  - pieraksts "Teksts"
/// int - integer - tikai veseli skaitļi - ne decimāļi - limits 9ciparu skaitlis - plusi un mīnusi
/// long - tas ir garāks par int
/// byte - bitu skaitļi max 255 min 0
/// sbyte - tas ir ar mīnusu 
/// float - floating - decimāļskaitļi - atšķirībā no int - skaitļi ar dec daļām - pieraksts 12.4f
///     decimal (double - maybe - pašam jāpārbauda) - tas arī ir ar komatiem - pieraksts 12.4d - pēdējais simbols nosaka tipu
/// bool (pazīme) - true/false George Bull - izgudrotājs
/// char - tikai un vienīgi viens simbols raksta ar ' '
