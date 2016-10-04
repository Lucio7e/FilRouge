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
            List<Sujet> sujets = SujetDAO.GetAllSujets();
            foreach (Sujet sujet in sujets)
            {
                Console.WriteLine("Titre sujet : {0}, Description Sujet : {1}, Rubrique : {2}", sujet.Titre, sujet.Desc, sujet.Rubrique.Libelle);
               
                if (ReponseDAO.GetAllReponsesBySujetID(sujet.Id) != null)
                {
                    List<Reponse> reponses = new List<Reponse>();
                    reponses = ReponseDAO.GetAllReponsesBySujetID(sujet.Id);
                    foreach (Reponse rep in reponses)
                    {
                        Console.WriteLine("Reponse {0} au sujet {1} : {2} écrite par {3}", rep.Id, sujet.Id, rep.Texte,rep.Utilisateur.Login);
                    }

                 }
                
            }
            
            Console.Read();
        }
    }
}
