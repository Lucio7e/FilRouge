using RogueForumDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RogueForumRESTService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IRogueForumREST" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IRogueForumREST
    {

        [OperationContract]
        [WebGet(UriTemplate = "Rubriques")]
        List<Rubrique> GetAllRubriques();

        [OperationContract]
        [WebGet(UriTemplate = "Sujets/{idrubrique}")]
        List<Sujet> GetAllSujetsByRubrique(string idrubrique);

        [OperationContract]
        [WebGet(UriTemplate = "Reponses/{idsujet}")]
        List<Reponse> GetAllReponsesBySujet(string idsujet);
    }


  
}
