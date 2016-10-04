using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueForumDLL
{
    public class Reponse
    {
        
        #region "Propriétés et accesseurs"
        
        private int _Id;
        private string _Texte;
        private DateTime _Date;
        private Sujet _Sujet;
        private Utilisateur _Utilisateur;

        /// <summary>
        /// L'identifiant de la réponse
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
        /// Le texte de la réponse
        /// </summary>
        public string Texte
        {
            get
            {
                return _Texte;
            }

            set
            {
                _Texte = value;
            }
        }
        /// <summary>
        /// La date de création de la réponse
        /// </summary>
        public DateTime Date
        {
            get
            {
                return _Date;
            }

            set
            {
                _Date = value;
            }
        }
        /// <summary>
        /// Le sujet auquel appartient la réponse
        /// </summary>
        public Sujet Sujet { get { return _Sujet; }set { _Sujet = value; } }
        /// <summary>
        /// L'utilisateur ayant posté la réponse
        /// </summary>
        public Utilisateur Utilisateur { get { return _Utilisateur; } set { _Utilisateur = value; } }
        #endregion
        #region "Constructeurs"

        public Reponse(int id,string texte, Sujet sujet, Utilisateur utilisateur)
        {
            this.Id = id;
            this.Texte = texte;
            this.Date = DateTime.Now;
            this.Sujet = sujet;
            this.Utilisateur = utilisateur;
        }

        #endregion
        #region "Methodes"
        #endregion
        #region "Methodes héritées et substituées"
        #endregion
        #region "Methodes à implementer pour les interfaces"
        #endregion

    }
}
