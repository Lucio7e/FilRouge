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
        #endregion
        #region "Methodes héritées et substituées"
        #endregion
        #region "Methodes à implementer pour les interfaces"
        #endregion

    }
}
