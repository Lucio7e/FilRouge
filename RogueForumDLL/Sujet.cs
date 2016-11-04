using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RogueForumDLL
{
    [Serializable]
    [DataContract]
    public class Sujet
    {


        #region "Propriétés et accesseurs"
        
        private int _Id;
        private string _Titre;
        private string _Desc;
        private DateTime _Date;
        private Rubrique _Rubrique;
        private List<Reponse> _Reponses;

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
        #endregion

        #region "Constructeurs"
        /// <summary>
        /// Constructeur d'un nouveau sujet  n'ayant pas encore de réponses
        /// </summary>
        /// <param name="titre">Le titre du sujet</param>
        /// <param name="description">La description du sujet</param>
        public Sujet(string titre, string description, Rubrique rubrique)
        {
            Titre = titre;
            Desc = description;
            Date = DateTime.Now;
            Rubrique = rubrique;
            Reponses = new List<Reponse>();
        }

        public Sujet(int id, string titre, string description, Rubrique rubrique)
        {
            this.Id = id;
            this.Titre = titre;
            this.Desc = description;
            this.Date = DateTime.Now;
            this.Rubrique = rubrique;
            this.Reponses = new List<Reponse>();
        }
        /// <summary>
        /// Constructeur d'un objet Sujet ayant déjà des réponses
        /// </summary>
        /// <param name="titre"></param>
        /// <param name="description"></param>
        /// <param name="rubrique"></param>
        /// <param name="reponses"></param>
        public Sujet(string titre, string description, Rubrique rubrique,List<Reponse> reponses):this(titre,description,rubrique) {
            _Reponses = Reponses;
        }
        public Sujet(int id, string titre)
        {
            this.Id = id;
            this.Titre = titre;
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
