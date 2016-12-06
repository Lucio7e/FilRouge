using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RogueForumMetierPortable
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
        private bool _IsModo;
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

        public bool IsModo
        {
            get
            {
                return _IsModo;
            }

            set
            {
                _IsModo = value;
            }
        }




        #endregion
        #region "Constructeurs"
        /// <summary>
        /// Constructeur d'un utilisateur
        /// </summary>
        /// <param name="login">Le login</param>
        /// <param name="mdp">le mot de passe</param>
        public Utilisateur (int id,string login, string mdp, bool isModo)
        {
            this.Id = id;
            this.Login = login;
            this.Mdp = mdp;
            this.IsModo = isModo;
        }
        #endregion
       
        #region "Methodes héritées et substituées"
        #endregion
        #region "Methodes à implementer pour les interfaces"
        #endregion

    }
}
