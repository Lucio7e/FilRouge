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
    public static class ReponseDAO
    {
        private static SqlConnection conn = ConnexionSQLServer.GetConnexion();
       

        /// <summary>
        /// Methode d'accés aux données permettant de récupérer la liste des réponses pour un sujet dont l'id est passé en parametre
        /// </summary>
        /// <returns></returns>
        public static List<Reponse> GetAllReponsesBySujetID(int idSujet)
        {
          //  conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "GetAllReponsesByIdSujet";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = cmd.CreateParameter();
            param.ParameterName = "@IdSujet";
            param.Value = idSujet;
            cmd.Parameters.Add(param);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Reponses");
            da.Fill(dt);
           // conn.Close();
            if (dt.Rows.Count >= 1)
            {
                List<Reponse> _Reponses = new List<Reponse>();
                foreach (DataRow row in dt.Rows)
                {
                    Reponse rep = new Reponse(int.Parse(row["ID_REPONSE"].ToString()), row["TEXTE_REPONSE"].ToString(),DateTime.Parse(row["DATE_REPONSE"].ToString()), SujetDAO.GetSujetByID(idSujet),
                       UtilisateurDAO.GetUtilisateurByID(int.Parse(row["ID_UTILISATEUR"].ToString())));
                    _Reponses.Add(rep);
                }
                return _Reponses;
            }
            return null;
        }

        /// <summary>
        /// Methode d'accés aux données permettant de récupérer la liste des réponses pour un utilisateur donnée dont l'id est passé en parametre
        /// </summary>
        /// <param name="idUser"></param>
        /// <returns></returns>
        public static List<Reponse> GetAllReponsesByUserID(int idUser)
        {
           // conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "GetReponsesByIdUtilisateur";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = cmd.CreateParameter();
            param.ParameterName = "@IdUtilisateur";
            param.Value = idUser;
            cmd.Parameters.Add(param);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Reponses");
            da.Fill(dt);
           // conn.Close();
            if(dt.Rows.Count >= 1)
            {
                List<Reponse> _Reponses = new List<Reponse>();
                foreach (DataRow row in dt.Rows)
                {
                    Reponse rep = new Reponse(int.Parse(row["ID_REPONSE"].ToString()), row["TEXTE_REPONSE"].ToString(), DateTime.Parse(row["DATE_REPONSE"].ToString()), SujetDAO.GetSujetByID(int.Parse(row["ID_SUJET"].ToString())),
                       UtilisateurDAO.GetUtilisateurByID(idUser));
                    _Reponses.Add(rep);
                }
                return _Reponses;
            }
            return null;
           
        }

        /// <summary>
        /// Methode permettant de poster une réponse au sujet passé en parametre par l'utilisateur connecté
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <param name="idSujet"></param>
        /// <param name="texte"></param>
        /// <returns>Renvoi le nombre de ligne affectées, si tout se passe bien 1</returns>
        public static int AddReponse(int idUtilisateur, int idSujet, string texte)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "AddReponse";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter paramIdUtilisateur = cmd.CreateParameter();
            paramIdUtilisateur.ParameterName = "@ID_UTILISATEUR";
            paramIdUtilisateur.Value = idUtilisateur;
            cmd.Parameters.Add(paramIdUtilisateur);

            SqlParameter paramIdSujet = cmd.CreateParameter();
            paramIdSujet.ParameterName = "@ID_SUJET";
            paramIdSujet.Value = idSujet;
            cmd.Parameters.Add(paramIdSujet);

            SqlParameter paramTexte = cmd.CreateParameter();
            paramTexte.ParameterName = "@TEXTE_REPONSE";
            paramTexte.Value = texte;
            cmd.Parameters.Add(paramTexte);

            conn.Open();
            int nbLigne = cmd.ExecuteNonQuery();
            conn.Close();

            return nbLigne;
        }
    }
}
