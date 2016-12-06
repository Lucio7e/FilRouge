using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RogueForumMetierPortable
{
   
    [DataContract]
    public class Sujet
    {


        #region "Propriétés et accesseurs"
        
        private int _Id;
        private string _Titre;
        private string _Desc;
        private DateTime _Date;
        private Rubrique _Rubrique;
        private Utilisateur _Utilisateur;
        private string _NomAuteur;
        private List<Reponse> _Reponses = new List<Reponse>();

        /// <summary>
        /// L'identifiant du sujet
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
        /// Le titre du sujet
        /// </summary>
        [DataMember]
        public string Titre
        {
            get { return _Titre; }
            set { _Titre = value; }
        }

        /// <summary>
        /// La description du sujet
        /// </summary>
        [DataMember]
        public string Desc
        {
            get
            {
                return _Desc;
            }

            set
            {
                _Desc = value;
            }
        }
        /// <summary>
        /// La date de création du sujet
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
        /// La liste des réponses au sujet
        /// </summary>
        [DataMember]
        public List<Reponse> Reponses
        {
            get
            {
                return _Reponses;
            }
            set
            {
                _Reponses = value;
            }

        }
        /// <summary>
        /// La catégorie à laquelle appartient le sujet
        /// </summary>
        [DataMember]
        public Rubrique Rubrique
        {
            get
            {
                return _Rubrique;
            }

            set
            {
                _Rubrique = value;
            }
        }

        /// <summary>
        /// L'utilisateur ayant posté le sujet
        /// </summary>
        public Utilisateur Utilisateur
        {
            get
            {
                return _Utilisateur;
            }

            set
            {
                _Utilisateur = value;
            }
        }
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

        /// <summary>
        /// Constructeur par défaut d'un sujet n'ayant pas de réponse
        /// </summary>
        /// <param name="id"></param>
        /// <param name="utilisateur"></param>
        /// <param name="titre"></param>
        /// <param name="description"></param>
        /// <param name="rubrique"></param>
        /// <param name="date"></param>
        public Sujet(int id, Utilisateur utilisateur, string titre, string description, Rubrique rubrique, DateTime date)
        {
            this.Id = id;
            this.Utilisateur = utilisateur;
            this.Titre = titre;
            this.Desc = description;
            this.Date = date;
            this.Rubrique = rubrique;
            this.NomAuteur = utilisateur.Login;
        }
        /// <summary>
        /// Constructeur d'un objet Sujet ayant déjà des réponses
        /// </summary>
        /// <param name="titre"></param>
        /// <param name="description"></param>
        /// <param name="rubrique"></param>
        /// <param name="reponses"></param>
        public Sujet(int id,Utilisateur utilisateur,string titre, string description, Rubrique rubrique,DateTime date, List<Reponse> reponses):this(id, utilisateur,titre, description,rubrique,date) {
            _Reponses = reponses;
        }

        #endregion
        #region "Methodes"
        #endregion
        #region "Methodes héritées et substituées"

        public override string ToString()
        {
            return "Titre sujet :  "+this.Titre+" Description : " + this.Desc +" Date sujet : "+this.Date;
        }

        #endregion
        #region "Methodes à implementer pour les interfaces"
        #endregion


    }
}
