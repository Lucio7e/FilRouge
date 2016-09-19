using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueForumDLL
{
    /// <summary>
    /// Un utilisateur est identifié par son ID, son login et son mot de passe
    /// </summary>
    public class Utilisateur
    {


        #region "Propriétés et accesseurs"

        private int _Id;
        private string _Login;
        private string _Mdp;
        private List<Sujet> _Sujets;
        /// <summary>
        /// L'identifiant de l'utilisateur
        /// </summary>
        public int Id
        {
            get
            {
                return _Id;
            }

            set
            {
                _Id = value;
            }
        }

        /// <summary>
        /// Le login de l'utilisateur
        /// </summary>
        public string Login
        {
            get
            {
                return _Login;
            }

            set
            {
                _Login = value;
            }
        }

        /// <summary>
        /// Le mot de passe de l'utilisateur
        /// </summary>
        public string Mdp
        {
            get
            {
                return _Mdp;
            }

            set
            {
                _Mdp = value;
            }
        }

        public List<Sujet> Sujets
        {
            get
            {
                return _Sujets;
            }

         }


        #endregion
        #region "Constructeurs"
        /// <summary>
        /// Constructeur d'un utilisateur
        /// </summary>
        /// <param name="login">Le login</param>
        /// <param name="mdp">le mot de passe</param>
        public Utilisateur (string login, string mdp)
        {
            this.Login = login;
            this.Mdp = mdp;
        }
        #endregion
        #region "Methodes"
        /// <summary>
        /// Methode permettant à un utilisateur de poster un nouveau Sujet dans le forum
        /// </summary>
        /// <param name="titre">Le titre du sujet</param>
        /// <param name="description">La description du sujet</param>
        /// <param name="rubrique">La rubrique à laquelle appartient le sujet</param>
        public void PosterSujet(string titre, string description, Rubrique rubrique)
        {
            Sujet sujet = new Sujet(titre, description, rubrique);
            if(!string.IsNullOrEmpty(titre) && !string.IsNullOrEmpty(description) && !rubrique.Equals(null) ) {
                Sujets.Add(sujet);
            }
            
        }

        /// <summary>
        /// Methode permettant de poster une réponse à un sujet
        /// </summary>
        /// <param name="texte">La réponse</param>
        /// <param name="sujet">le sujet auquel on répond</param>
        public void Repondre(string texte, Sujet sujet) {
            Reponse reponse = new Reponse(texte, sujet);
            sujet.Reponses.Add(reponse);
        }
        #endregion
        #region "Methodes héritées et substituées"
        #endregion
        #region "Methodes à implementer pour les interfaces"
        #endregion

    }
}
