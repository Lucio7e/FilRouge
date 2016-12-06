using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RogueForumMetierPortable
{
    /// <summary>
    /// La classe rubrique est composé d'un identifiant et d'un libelle
    /// </summary>
   
    [DataContract]
    public class Rubrique
    {
        #region "Propriétés et accesseurs"

        private int _Id;
        private string _Libelle;

        /// <summary>
        /// L'identifiant de la rubrique
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
        /// Le libelle de la rubrique
        /// </summary>
        [DataMember]
        public string Libelle
        {
            get
            {
                return _Libelle;
            }

            set
            {
                _Libelle = value;
            }
        }

        #endregion
        #region "Constructeurs"
        /// <summary>
        /// Constructeur d'une rubrique
        /// </summary>
        /// <param name="libelle">Le libelle de la rubrique</param>
        public Rubrique(int id, string libelle)
        {
            this.Id = id;
            this.Libelle = libelle;
        }

        public Rubrique() { }
        #endregion
        #region "Methodes"
        #endregion
        #region "Methodes héritées et substituées"
        public override string ToString()
        {
            return "Libelle rubrique : "+this.Libelle;
        }
        #endregion
        #region "Methodes à implementer pour les interfaces"
        #endregion

    }
}
