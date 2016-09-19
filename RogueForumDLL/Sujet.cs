using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueForumDLL
{
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
        public string Titre
        {
            get { return _Titre; }
            set { _Titre = value; }
        }

        /// <summary>
        /// La description du sujet
        /// </summary>
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
        public List<Reponse> Reponses
        {
            get
            {
                return _Reponses;
            }

        }
        #endregion

        #region "Constructeurs"
        /// <summary>
        /// Constructeur d'un objet sujet
        /// </summary>
        /// <param name="titre">Le titre du sujet</param>
        /// <param name="description">La description du sujet</param>
        public Sujet(string titre, string description, Rubrique rubrique)
        {
            this.Titre = titre;
            this.Desc = description;
            this.Date = DateTime.Now;
            this._Rubrique = rubrique;
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
