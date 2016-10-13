using RogueForumDAO;
using RogueForumDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueForumController
{
    public static class Controller
    {
        #region "Methodes Utilisateur"
        /// <summary>
        /// Methode permettant à un utilisateur de poster un nouveau Sujet dans le forum
        /// </summary>
        /// <param name="titre">Le titre du sujet</param>
        /// <param name="description">La description du sujet</param>
        /// <param name="rubrique">La rubrique à laquelle appartient le sujet</param>
        public static void PosterSujet(string titre, string description, Rubrique rubrique)
        {
            //todo
        }

        /// <summary>
        /// Methode permettant de poster une réponse à un sujet
        /// </summary>
        /// <param name="texte">La réponse</param>
        /// <param name="sujet">le sujet auquel on répond</param>
        public static void Repondre(string texte, Sujet sujet)
        {
            //TODO
        }

        public static Utilisateur Login(string login, string mdp)
        {
            return UtilisateurDAO.Login(login, mdp);
        }
        #endregion

        #region "Methodes Moderateur"

        /// <summary>
        /// Méthode qui permet de supprimer un sujet
        /// </summary>
        /// <param name="sujet">le sujet que l'on veut supprimer</param>
        /// <returns></returns>
        public static bool SupprimerSujet(Sujet sujet)
        {
            return true;
        }
        /// <summary>
        /// Methode permettant de supprimer une liste de sujets
        /// </summary>
        /// <param name="sujets"></param>
        /// <returns></returns>
        public static bool SupprimerSujet(List<Sujet> sujets)
        {
            foreach (Sujet sujet in sujets)
            {
                SupprimerSujet(sujet);
            }
            return true;
        }
        /// <summary>
        /// Methode qui permet de modifier un sujet
        /// </summary>
        /// <param name="sujet">Le sujet que l'on modifie</param>
        /// <param name="titre">Le titre du sujet que l'on modifie</param>
        /// <returns></returns>
        public static bool EditerSujet(Sujet sujet, string titre)
        {

            return true;
        }
        /// <summary>
        /// Methode permettant de supprimer une réponse
        /// </summary>
        /// <param name="reponse">La réponse que l'on supprimer</param>
        /// <returns></returns>
        public static bool SupprimerReponse(Reponse reponse)
        {
            return true;
        }


        public static bool SupprimerReponse(List<Reponse> reponses)
        {
            foreach (Reponse rep in reponses)
            {
                SupprimerReponse(rep);
            }
            return true;
        }

        #endregion

        #region "Methodes Sujet"

        public static List<Sujet> GetAllSujets()
        {
            return SujetDAO.GetAllSujets();
        }

        public static Sujet GetSujetByID(int idsujet)
        {
            return SujetDAO.GetSujetByID(idsujet);
        }

        public static List<Sujet> GetSujetsByRubriqueID(int idRubrique)
        {
            return SujetDAO.GetSujetsByRubriqueID(idRubrique);
        }

        public static int AddSujet(int idUtilisateur, int IdRubrique, string titre, string description)
        {
            return SujetDAO.AddSujet(idUtilisateur, IdRubrique, titre, description);
        }
        #endregion

        #region "Methodes Rubrique"

        public static Rubrique GetRubriqueByID(int id)
        {
            return RubriqueDAO.GetRubriqueByID(id);
        }

        public static List<Rubrique> GetAllRubriques()
        {
            return RubriqueDAO.GetAllRubriques();
        }

        #endregion

        #region "Methodes Reponse"

        public static List<Reponse> GetAllReponsesBySujetID(int idSujet)
        {
            return ReponseDAO.GetAllReponsesBySujetID(idSujet);
        }

        public static List<Reponse> GetAllReponsesByUserID(int idUser)
        {
            return ReponseDAO.GetAllReponsesByUserID(idUser);
        }
        public static int AddReponse(int idUtilisateur, int idSujet, string texte)
        {
            return ReponseDAO.AddReponse(idUtilisateur, idSujet, texte);
        }

        #endregion
    }
}
