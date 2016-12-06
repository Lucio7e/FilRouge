using RogueForumDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RogueForumMetierPortable;
namespace RogueForumDLL
{
    public static class Controller
    {
        #region Methodes Sujets

        /// <summary>
        /// Methode qui recupere le sujet dont l'id est passé en param
        /// </summary>
        /// <param name="idsujet"></param>
        /// <returns></returns>
        public static Sujet GetSujetByID(int idsujet)
        {
           DataTable dt = SujetDAO.GetSujetByID(idsujet);
            if (dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                Sujet sujet = new Sujet(int.Parse(row["ID_SUJET"].ToString()), GetUtilisateurByID(int.Parse(row["ID_UTILISATEUR"].ToString())), row["TITRE_SUJET"].ToString(), row["DESCRIPTION_SUJET"].ToString(),
                   GetRubriqueByID(int.Parse(row["ID_RUBRIQUE"].ToString())), DateTime.Parse(row["DATE_CREATION"].ToString()));
                return sujet;
            }
            return null;
        }

        /// <summary>
        /// Methode qui recupere la liste des sujets d'une rubrique
        /// </summary>
        /// <param name="idRubrique"></param>
        /// <returns></returns>
        public static List<Sujet> GetSujetsByRubriqueID(int idRubrique)
        {
            DataTable dt = SujetDAO.GetSujetsByRubriqueID(idRubrique);
            if (dt.Rows.Count >= 1)
            {
                List<Sujet> _Sujets = new List<Sujet>();
                
                foreach (DataRow row in dt.Rows)
                {
                    int idsujet = int.Parse(row["ID_SUJET"].ToString());
                    Utilisateur utilisateur = GetUtilisateurByID(int.Parse(row["ID_UTILISATEUR"].ToString()));
                    List<Reponse> reponses = GetAllReponsesBySujetID(int.Parse(row["ID_SUJET"].ToString()));
                    Rubrique rubrique = GetRubriqueByID(idRubrique);
                    string titreSujet = row["TITRE_SUJET"].ToString();
                    string descSujet = row["DESCRIPTION_SUJET"].ToString();
                    DateTime dateSujet = DateTime.Parse(row["DATE_CREATION"].ToString());
                    _Sujets.Add(new Sujet(idsujet, utilisateur, titreSujet, descSujet, rubrique, dateSujet, reponses));
                }
                return _Sujets;
            }
            return null;
        }

        /// <summary>
        /// Methode qui ajoute un sujet
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <param name="idRubrique"></param>
        /// <param name="titre"></param>
        /// <param name="description"></param>
        /// <returns>renvoi 1 si tout va bien, 0 sinon</returns>
        public static int AddSujet(int idUtilisateur, int idRubrique, string titre, string description)
        {
            return SujetDAO.AddSujet(idUtilisateur, idRubrique, titre, description);
        }

        /// <summary>
        /// Methode qui supprime le sujet dont l'id est passé en parametre
        /// </summary>
        /// <param name="idSujet"></param>
        /// <returns>Retourne le nombre de lignes affectées, 1 si tout va bien</returns>
        public static int DeleteSujet(int idSujet)
        {
            return SujetDAO.DeleteSujet(idSujet);
        }
        /// <summary>
        /// Methode qui permet de modifier un sujet en changeant le titre et/ou la description
        /// On passe l'ancient sujet en paramètre pour eviter les accés concurrents
        /// </summary>
        /// <param name="sujet"></param>
        /// <param name="newTitre"></param>
        /// <param name="newDescription"></param>
        /// <returns>Retourne le nombre de lignes affectées, 1 si tout va bien</returns>
        public static int EditSujet(int idsujet, string oldTitre, string oldDesc, string newTitre, string newDescription)
        {
            return SujetDAO.EditSujet(idsujet, oldTitre, oldDesc, newTitre, newDescription);
        }
        #endregion

        #region Methodes Rubriques
        public static Rubrique GetRubriqueByID(int idRubrique)
        {
            DataTable dt = RubriqueDAO.GetRubriqueByID(idRubrique);
            if (dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                Rubrique rubrique = new Rubrique(idRubrique, row["NOM_RUBRIQUE"].ToString());
                return rubrique;
            }

            return null;
        }

        public static List<Rubrique> GetAllRubriques()
        {
            DataTable dt = RubriqueDAO.GetAllRubriques();
            if (dt.Rows.Count >= 1)
            {
                List<Rubrique> _Rubriques = new List<Rubrique>();
                foreach (DataRow row in dt.Rows)
                {
                    Rubrique rubrique = new Rubrique(int.Parse(row["ID_RUBRIQUE"].ToString()), row["NOM_RUBRIQUE"].ToString());
                    rubrique.Id = int.Parse(row["ID_RUBRIQUE"].ToString());
                    _Rubriques.Add(rubrique);

                }
                return _Rubriques;
            }
            return null;
        }
        #endregion

        #region Methodes Reponses

        /// <summary>
        /// Methode qui renvoi la Liste des réponses correspondant à un sujet
        /// </summary>
        /// <param name="idsujet"></param>
        /// <returns></returns>
        public static List<Reponse> GetAllReponsesBySujetID(int idsujet)
        {
            DataTable dt = ReponseDAO.GetAllReponsesBySujetID(idsujet);
            if (dt.Rows.Count >= 1)
            {
                List<Reponse> _Reponses = new List<Reponse>();
                foreach (DataRow row in dt.Rows)
                {
                    Reponse rep = new Reponse(int.Parse(row["ID_REPONSE"].ToString()), row["TEXTE_REPONSE"].ToString(), DateTime.Parse(row["DATE_REPONSE"].ToString()), GetSujetByID(idsujet),
                       GetUtilisateurByID(int.Parse(row["ID_UTILISATEUR"].ToString())));
                    _Reponses.Add(rep);
                }
                return _Reponses;
            }
            return null;
        }

        /// <summary>
        /// Methode qui renvoi la Liste des réponses correspondant à un sujet
        /// </summary>
        /// <param name="idsujet"></param>
        /// <returns></returns>
        public static List<Reponse> GetTop10ReponsesBySujetID(int idsujet)
        {
            DataTable dt = ReponseDAO.GetTop10ReponsesBySujetID(idsujet);
            if (dt.Rows.Count >= 1)
            {
                List<Reponse> _Reponses = new List<Reponse>();
                foreach (DataRow row in dt.Rows)
                {
                    Reponse rep = new Reponse(int.Parse(row["ID_REPONSE"].ToString()), row["TEXTE_REPONSE"].ToString(), DateTime.Parse(row["DATE_REPONSE"].ToString()), GetSujetByID(idsujet),
                       GetUtilisateurByID(int.Parse(row["ID_UTILISATEUR"].ToString())));
                    _Reponses.Add(rep);
                }
                return _Reponses;
            }
            return null;
        }

        /// <summary>
        /// Methode qui renvoi la list des réponses d'un utilisateur
        /// </summary>
        /// <param name="idUser"></param>
        /// <returns></returns>
        public static List<Reponse> GetAllReponsesByUserID(int idUser)
        {
            DataTable dt = ReponseDAO.GetAllReponsesByUserID(idUser);
            if (dt.Rows.Count >= 1)
            {
                List<Reponse> _Reponses = new List<Reponse>();
                foreach (DataRow row in dt.Rows)
                {
                    Reponse rep = new Reponse(int.Parse(row["ID_REPONSE"].ToString()), row["TEXTE_REPONSE"].ToString(), DateTime.Parse(row["DATE_REPONSE"].ToString()), GetSujetByID(int.Parse(row["ID_SUJET"].ToString())),
                      GetUtilisateurByID(idUser));
                    _Reponses.Add(rep);
                }
                return _Reponses;
            }
            return null;

        }

        /// <summary>
        /// Methode qui permet d'ajouter une réponse à un sujet
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <param name="idSujet"></param>
        /// <param name="texte"></param>
        /// <returns>renvoi 1 si tout se passe bien, 0 sinon</returns>
        public static int AddReponse(int idUtilisateur, int idSujet, string texte)
        {
            return ReponseDAO.AddReponse(idUtilisateur, idSujet, texte);
        }

        /// <summary>
        /// Methode qui supprime la réponse dont l'identifiant est passé en param
        /// </summary>
        /// <param name="idReponse"></param>
        /// <returns>Renvoi 1 si tout se passe bien, 0 sinon</returns>
        public static int DeleteReponseByReponseID(int idReponse)
        {
            return ReponseDAO.DeleteReponseByReponseID(idReponse);
        }
        #endregion

        #region Methodes Utilisateurs

            /// <summary>
            /// Renvoi un utilisateur dont l'id est passé en param
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
        public static Utilisateur GetUtilisateurByID(int id)
        {
            DataTable dt = UtilisateurDAO.GetUtilisateurByID(id);
            if (dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                Utilisateur utilisateur = new Utilisateur(int.Parse(row["ID_UTILISATEUR"].ToString()), row["LOGIN"].ToString(),
                        row["MDP"].ToString(), (bool)row["MODERATEUR"]);
                return utilisateur;
            }
            return null;
        }
        
        /// <summary>
        /// Renvoi un utilisateur si la combinaison Login/mdp est bonne, null sinon
        /// </summary>
        /// <param name="login"></param>
        /// <param name="mdp"></param>
        /// <returns></returns>
        public static Utilisateur Login(string login, string mdp)
        {
            DataTable dt = UtilisateurDAO.Login(login, mdp);
            if (dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                return GetUtilisateurByID(int.Parse(row["ID_UTILISATEUR"].ToString()));
            }
            return null;
        }

        /// <summary>
        /// Retourn le nombre de ligne affectées, 1 si tout se passe bien, 0 sinon
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="mdp"></param>
        /// <returns></returns>
        public static int ChangeMdp(string login, string mdp)
        {
            return UtilisateurDAO.ChangeMDP(login, mdp);
        }

        public static bool GetUserByLoginMail(string login, string mail)
        {
            DataTable dt = UtilisateurDAO.GetUserByLoginMail(login, mail);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
    #endregion
}
}
