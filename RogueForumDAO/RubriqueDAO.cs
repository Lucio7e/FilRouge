
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueForumDAO
{
    /// <summary>
    /// DAO Classe permettant de récuperer les rubriques en base de données
    /// </summary>
    public static class RubriqueDAO
    {
        private static SqlConnection conn = ConnexionSQLServer.GetConnexion();
       
        public static DataTable GetRubriqueByID (int idRubrique)
        {
           // conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "GetRubriqueByIdRubrique";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = cmd.CreateParameter();
            param.ParameterName = "@IdRubrique";
            param.Value = idRubrique;
            cmd.Parameters.Add(param);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Rubrique");
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }
          
        }

        public static DataTable GetAllRubriques()
        {
           // conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "GetAllRubriques";
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Rubriques");
                da.Fill(dt);
                return dt;
            }
            catch ( Exception)
            {
                return null;
            }
          
        }
    }
}
