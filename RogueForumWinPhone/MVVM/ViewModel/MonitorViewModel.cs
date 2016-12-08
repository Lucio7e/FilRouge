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
    public class MonitorViewModel
    {
        private ConsumeWSR _dal;
        private ObservableCollection<ViewModelRubrique> _colViewModelRubrique;

        public MonitorViewModel()
        {
            _dal = new ConsumeWSR();
            _colViewModelRubrique = new ObservableCollection<ViewModelRubrique>();
        }

        public ReadOnlyObservableCollection<ViewModelRubrique> Rubriques
        {
            get { return new ReadOnlyObservableCollection<ViewModelRubrique>(_colViewModelRubrique); }
        }

        public async Task GetRubriques()
        {
            List<Rubrique> rubriques = await _dal.getRubriques();
            MAJ_Rubriques(rubriques);
        }

        private void MAJ_Rubriques(List<Rubrique> rubriques)
        {
            foreach (Rubrique rubrique in rubriques)
            {
                ViewModelRubrique vmRubrique = new ViewModelRubrique(rubrique, _dal);
                if (!_colViewModelRubrique.Contains(vmRubrique))
                {
                    _colViewModelRubrique.Add(vmRubrique);
                }
            }
        }
    }
}
