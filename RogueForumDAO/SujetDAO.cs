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

        private static List<Sujet> _Sujets = new List<Sujet>();
        private static SqlConnection conn = ConnexionSQLServer.GetConnexion();
        
        #endregion
        #region "Constructeurs"
        #endregion
        #region "Methodes"
        public static List<Sujet> getSujetsFromDB()
        {
            conn.Open();
            SqlCommand cmd =  conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM SUJET";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("AllSujets");
            da.Fill(dt);
            conn.Close();
            foreach (DataRow row in dt.Rows)
            {
                _Sujets.Add(new Sujet(row["TITRE_SUJET"].ToString(), row["DESCRIPTION_SUJET"].ToString(), RubriqueDAO.GetRubriqueByID(int.Parse(row["ID_RUBRIQUE"].ToString()))));
            }
            return _Sujets;
        }


        #endregion
        #region "Methodes héritées et substituées"
        #endregion
        #region "Methodes à implementer pour les interfaces"
        #endregion

    }
}
