using RogueForumConsumeWSR;
using RogueForumMetierPortable;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueForumWinPhone
{
   public class ViewModelRubrique : ViewModelBase
    {
       
        private ConsumeWSR _dal;
        private int _idRubrique;
        private string _libelle;

        internal ViewModelRubrique(Rubrique rubrique, ConsumeWSR Dal)
        {
            _idRubrique = rubrique.Id;
            _libelle = rubrique.Libelle;
            _dal = Dal;
        }

        #region Propriétés Bindables

       public int IdRubrique
        {
            get { return _idRubrique; }
            private set
            {
                _idRubrique = value;
                RaisePropertyChanged();
            }
        }

        public string Libelle
        {
            get { return _libelle; }
            private set
            {
                _libelle = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        public override string ToString()
        {
            return Libelle;
        }
    }
}
