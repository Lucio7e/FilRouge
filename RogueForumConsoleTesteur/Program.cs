

using RogueForumMetierPortable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RogueForumConsoleTesteur
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadRubriques();
            Console.Read();
            
        }

        public static async void ReadRubriques()
        {
            List<Rubrique> rub = await RogueForumConsumeWSR.ConsumeWSR.getRubriques();
            foreach (Rubrique r in rub)
            {
                Console.WriteLine(r.Libelle);
            }
            Console.Read();
        }
    }
}
