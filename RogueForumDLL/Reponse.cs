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
        #endregion
        #region "Constructeurs"

        public Reponse(string texte, Sujet sujet)
        {
            this.Texte = texte;
            this.Date = DateTime.Now;
            this.Sujet = sujet;
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
