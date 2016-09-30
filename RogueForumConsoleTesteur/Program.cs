using RogueForumDAO;
using RogueForumDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueForumConsoleTesteur
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rubrique> rubriques = RubriqueDAO.GetAllRubriques();
            foreach (Rubrique rubrique in rubriques)
            {
                Console.WriteLine("ID Rubrique : {0}, libelle : {1}",rubrique.Id,rubrique.Libelle);
            }
            List<Sujet> sujets = SujetDAO.getSujetsFromDB();
            foreach (Sujet sujet in sujets)
            {
                Console.WriteLine("Titre sujet : {0}, Description Sujet : {1}", sujet.Titre, sujet.Desc);
            }
            Console.Read();
        }
    }
}
