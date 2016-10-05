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
        public static List<Sujet> GetAllSujets()
        {
            //conn.Open();
            SqlCommand cmd =  conn.CreateCommand();
            cmd.CommandText = "SELECT ID_SUJET, ID_UTILISATEUR, ID_RUBRIQUE, TITRE_SUJET, DESCRIPTION_SUJET, DATE_CREATION FROM SUJET";
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

        public static Sujet GetSujetByID(int idsujet)
        {
            //conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = string.Format("SELECT ID_SUJET, ID_UTILISATEUR, ID_RUBRIQUE, TITRE_SUJET, DESCRIPTION_SUJET, DATE_CREATION FROM SUJET WHERE ID_SUJET = {0}", idsujet);
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

        public static List<Sujet> GetSujetsByRubriqueID(int idRubrique)
        {
            //conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = string.Format("SELECT ID_SUJET, ID_UTILISATEUR, ID_RUBRIQUE, TITRE_SUJET, DESCRIPTION_SUJET, DATE_CREATION FROM SUJET WHERE ID_RUBRIQUE= {0}",idRubrique);
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
