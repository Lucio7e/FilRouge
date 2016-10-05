using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueForumDLL
{
    /// <summary>
    /// Un modérateur herite d'un utilisateur, il a des droits supplémentaires sur les sujets et réponses
    /// </summary>
    public class Moderateur:Utilisateur
    {

        #region "Propriétés et accesseurs"
        #endregion
        #region "Constructeurs"

        /// <summary>
        /// Constructeur d'un modérateur qui utilise le constructeur d'utilisateur
        /// </summary>
        /// <param name="login">Le login du modérateur</param>
        /// <param name="mdp">le mot de passe </param>
        public Moderateur(int id,string login, string mdp, bool modo) : base(id,login, mdp,modo) { }

        #endregion
       
        #region "Methodes héritées et substituées"
        #endregion
        #region "Methodes à implementer pour les interfaces"
        #endregion


    }
}
