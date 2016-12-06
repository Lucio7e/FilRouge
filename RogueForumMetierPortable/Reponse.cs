using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RogueForumMetierPortable
{
    
    [DataContract]
    public class Reponse
    {        
        #region "Propriétés et accesseurs"
        
        private int _Id;
        private string _Texte;
        private DateTime _Date;
        private Sujet _Sujet;
        private Utilisateur _Utilisateur;
        private string _NomAuteur;

        /// <summary>
        /// L'identifiant de la réponse
        /// </summary>
        [DataMember]
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
        [DataMember]
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
        [DataMember]
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
        [DataMember]
        public Sujet Sujet { get { return _Sujet; }set { _Sujet = value; } }
        /// <summary>
        /// L'utilisateur ayant posté la réponse
        /// </summary>
        [IgnoreDataMember]
        public Utilisateur Utilisateur { get { return _Utilisateur; } set { _Utilisateur = value; } }
        /// <summary>
        /// Le nom de l'auteur de la réponse
        /// </summary>
        [DataMember]
        public string NomAuteur
        {
            get
            {
                return _NomAuteur;
            }

            set
            {
                _NomAuteur = value;
            }
        }
        #endregion
        #region "Constructeurs"

        public Reponse(int id,string texte,DateTime date, Sujet sujet, Utilisateur utilisateur)
        {
            this.Id = id;
            this.Texte = texte;
            this.Date = date;
            this.Sujet = sujet;
            this.Utilisateur = utilisateur;
            this.NomAuteur = utilisateur.Login;
        }

        public Reponse(int id, string texte)
        {
            this.Id = id;
            this.Texte = texte;
        }
        #endregion
        #region "Methodes"
        /// <summary>
        /// Methode qui renvoie le nom de l'auteur de la réponse
        /// </summary>
        /// <returns></returns>
        public string GetNomUtilisateur()
        {
            return this.Utilisateur.Login;
        }
        #endregion
        #region "Methodes héritées et substituées"

        #endregion
        #region "Methodes à implementer pour les interfaces"
        #endregion

        

    }
}
