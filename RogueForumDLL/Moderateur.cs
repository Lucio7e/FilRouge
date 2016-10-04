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
        #region "Methodes"
        /// <summary>
        /// Méthode qui permet de supprimer un sujet
        /// </summary>
        /// <param name="sujet">le sujet que l'on veut supprimer</param>
        /// <returns></returns>
        public bool SupprimerSujet(Sujet sujet)
        {
            return true;
        }
        /// <summary>
        /// Methode permettant de supprimer une liste de sujets
        /// </summary>
        /// <param name="sujets"></param>
        /// <returns></returns>
        public bool SupprimerSujet(List<Sujet> sujets)
        {
            foreach (Sujet sujet in sujets)
            {
                SupprimerSujet(sujet);
            }
            return true;
        }
        /// <summary>
        /// Methode qui permet de modifier un sujet
        /// </summary>
        /// <param name="sujet">Le sujet que l'on modifie</param>
        /// <param name="titre">Le titre du sujet que l'on modifie</param>
        /// <returns></returns>
        public bool EditerSujet(Sujet sujet,string titre)
        {
            return true;
        }
        /// <summary>
        /// Methode permettant de supprimer une réponse
        /// </summary>
        /// <param name="reponse">La réponse que l'on supprimer</param>
        /// <returns></returns>
        public bool SupprimerReponse(Reponse reponse)
        {
            return true;
        }


        public bool SupprimerReponse(List<Reponse> reponses) {
            foreach (Reponse rep in reponses)
            {
                SupprimerReponse(rep);
            }
            return true;
        }
        #endregion
        #region "Methodes héritées et substituées"
        #endregion
        #region "Methodes à implementer pour les interfaces"
        #endregion


    }
}
