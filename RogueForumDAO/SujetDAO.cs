using RogueForumDLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueForumDAO
{
    public static class SujetDAO
    {
        #region "Propriétés et accesseurs"

    
        private static SqlConnection conn = ConnexionSQLServer.GetConnexion();
        
        #endregion
        
        #region "Methodes"
        /// <summary>
        /// Methode qui Retourne tous les sujets du forum
        /// </summary>
        /// <returns>La liste des sujets</returns>
        public static List<Sujet> GetAllSujets()
        {
            //conn.Open();
            SqlCommand cmd =  conn.CreateCommand();
            cmd.CommandText = "GetAllSujets";
            cmd.CommandType = CommandType.StoredProcedure;
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("AllSujets");
            da.Fill(dt);
           // conn.Close();
            if (dt.Rows.Count >= 1)
            {
                List<Sujet> _Sujets = new List<Sujet>();
                foreach (DataRow row in dt.Rows)
                {
                    _Sujets.Add(new Sujet(int.Parse(row["ID_SUJET"].ToString()), row["TITRE_SUJET"].ToString(), row["DESCRIPTION_SUJET"].ToString(),
                        RubriqueDAO.GetRubriqueByID(int.Parse(row["ID_RUBRIQUE"].ToString()))));
                }
                return _Sujets;
            }
            return null;
        }

        /// <summary>
        /// Methode qui retourne le sujet dont l'id est passé en parametre
        /// </summary>
        /// <param name="idsujet"></param>
        /// <returns>Un sujet</returns>
        public static Sujet GetSujetByID(int idsujet)
        {
            //conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "GetSujetByIDSujet";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = cmd.CreateParameter();
            param.ParameterName = "@IdSujet";
            param.Value = idsujet;
            cmd.Parameters.Add(param);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Sujet");
            da.Fill(dt);
           // conn.Close();
            if (dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                Sujet sujet = new Sujet(int.Parse(row["ID_SUJET"].ToString()), row["TITRE_SUJET"].ToString(), row["DESCRIPTION_SUJET"].ToString(),
                    RubriqueDAO.GetRubriqueByID(int.Parse(row["ID_RUBRIQUE"].ToString())));
                return sujet;
            }
            return null;
        }

        /// <summary>
        /// Methode qui retourne les sujets appartenant à la rubrique passé en parametre
        /// </summary>
        /// <param name="idRubrique"></param>
        /// <returns>La liste des sujets pour la rubrique</returns>
        public static List<Sujet> GetSujetsByRubriqueID(int idRubrique)
        {
            //conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "GetAllSujetsByIDRubrique";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = cmd.CreateParameter();
            param.ParameterName = "@IdRubrique";
            param.Value = idRubrique;
            cmd.Parameters.Add(param);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("AllSujets");
            da.Fill(dt);
            // conn.Close();
            if (dt.Rows.Count >= 1)
            {
                List<Sujet> _Sujets = new List<Sujet>();
                foreach (DataRow row in dt.Rows)
                {
                    _Sujets.Add(new Sujet(int.Parse(row["ID_SUJET"].ToString()), row["TITRE_SUJET"].ToString(), row["DESCRIPTION_SUJET"].ToString(),
                        RubriqueDAO.GetRubriqueByID(idRubrique)));
                }
                return _Sujets;
            }
            return null;
        }

        /// <summary>
        /// Methode qui ajoute un sujet dans la bdd
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <param name="idRubrique"></param>
        /// <param name="titre"></param>
        /// <param name="description"></param>
        /// <returns>Renvoie le nombre de ligne (doit renvoyer 1 si tout va bien)</returns>
        public static int AddSujet(int idUtilisateur, int idRubrique, string titre, string description)
        {
            
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "AddSujet";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter paramIdUtilisateur = cmd.CreateParameter();
            paramIdUtilisateur.ParameterName = "@ID_UTILISATEUR";
            paramIdUtilisateur.Value = idUtilisateur;
            cmd.Parameters.Add(paramIdUtilisateur);

            SqlParameter paramIdRubrique = cmd.CreateParameter();
            paramIdRubrique.ParameterName = "@ID_RUBRIQUE";
            paramIdRubrique.Value = idRubrique;
            cmd.Parameters.Add(paramIdRubrique);

            SqlParameter paramTitre = cmd.CreateParameter();
            paramTitre.ParameterName = "@TITRE_SUJET";
            paramTitre.Value = titre;
            cmd.Parameters.Add(paramTitre);

            SqlParameter paramDesc = cmd.CreateParameter();
            paramDesc.ParameterName = "@DESCRIPTION_SUJET";
            paramDesc.Value = description;
            cmd.Parameters.Add(paramDesc);
            conn.Open();
           int nbLigne= cmd.ExecuteNonQuery();
            conn.Close();
            return nbLigne;
        }
        /// <summary>
        /// Methode qui supprime le sujet dont l'id est passé en parametre
        /// </summary>
        /// <param name="idSujet"></param>
        /// <returns></returns>
        public static int DeleteSujet(int idSujet)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DeleteSujet";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter paramIdSujet = cmd.CreateParameter();
            paramIdSujet.ParameterName = "@ID_SUJET";
            paramIdSujet.Value = idSujet;
            cmd.Parameters.Add(paramIdSujet);
            
            conn.Open();
            int nbLigne = cmd.ExecuteNonQuery();
            conn.Close();
            
            return nbLigne;
        }

        /// <summary>
        /// Methode qui permet de modifier un sujet en changeant le titre et/ou la description
        /// On passe l'ancient sujet en paramètre pour eviter les accés concurrents
        /// </summary>
        /// <param name="sujet"></param>
        /// <param name="newTitre"></param>
        /// <param name="newDescription"></param>
        /// <returns>Retourne le nombre de lignes affectées, 1 si tout va bien</returns>
        public static int EditSujet(Sujet sujet, string newTitre, string newDescription)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "EditSujet";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter paramIdSujet = cmd.CreateParameter();
            paramIdSujet.ParameterName = "@ID_SUJET";
            paramIdSujet.Value = sujet.Id;
            cmd.Parameters.Add(paramIdSujet);

            SqlParameter paramNewTitre = cmd.CreateParameter();
            paramNewTitre.ParameterName = "@NEW_TITRE";
            paramNewTitre.Value = newTitre;
            cmd.Parameters.Add(paramNewTitre);

            SqlParameter paramOldTitre = cmd.CreateParameter();
            paramOldTitre.ParameterName = "@OLD_TITRE";
            paramOldTitre.Value = sujet.Titre;
            cmd.Parameters.Add(paramOldTitre);

            SqlParameter paramNewDesc = cmd.CreateParameter();
            paramNewDesc.ParameterName = "@NEW_DESC";
            paramNewDesc.Value = newDescription;
            cmd.Parameters.Add(paramNewDesc);

            SqlParameter paramOldDesc = cmd.CreateParameter();
            paramOldDesc.ParameterName = "@OLD_DESC";
            paramOldDesc.Value = sujet.Desc;
            cmd.Parameters.Add(paramOldDesc);

            conn.Open();
            int nbLigne = cmd.ExecuteNonQuery();
            conn.Close();
            return nbLigne;
        }
        #endregion
        #region "Methodes héritées et substituées"
        #endregion
        #region "Methodes à implementer pour les interfaces"
        #endregion

    }
}
