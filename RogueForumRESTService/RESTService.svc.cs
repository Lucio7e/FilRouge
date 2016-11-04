using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using RogueForumDLL;

namespace RogueForumRESTService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "RogueForumREST" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez RogueForumREST.svc ou RogueForumREST.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class RESTService : IRogueForumREST
    {
       
        public List<Rubrique> GetAllRubriques()
        {
            return RogueForumDAO.RubriqueDAO.GetAllRubriques();
        }

        public List<Sujet> GetAllSujetsByRubrique(string idrubrique)
        {
            int r;
            if (int.TryParse(idrubrique, out r))
            {
                return RogueForumDAO.SujetDAO.GetSujetsByRubriqueID(r);
            }

            else
            {
                return null;
            }
        }

        public List<Reponse> GetAllReponsesBySujet(string idsujet)
        {
            int r;
            if (int.TryParse(idsujet, out r)) {
                return RogueForumDAO.ReponseDAO.GetAllReponsesBySujetID(r);
            }

            else
            {
                return null;
            }
        }
    }
}
