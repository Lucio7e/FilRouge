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
    public abstract class UtilisateurDAO
    {
        private static SqlConnection conn = ConnexionSQLServer.GetConnexion();
      
        /// <summary>
        /// Methode d'accés aux données permettant de récupérer la liste de tous les utilisateurs
        /// </summary>
        /// <returns></returns>
        public static List<Utilisateur> GetAllUtilisateur()
        {
            //conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ID_UTILISATEUR, LOGIN, MDP, MODERATEUR FROM UTILISATEUR";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Utilisateurs");
            da.Fill(dt);
            //conn.Close();
            if(dt.Rows.Count >= 1)
            {
                List<Utilisateur> _Utilisateurs = new List<Utilisateur>();
                foreach (DataRow row in dt.Rows)
                {
                    Utilisateur utilisateur = new Utilisateur(int.Parse(row["ID_UTILISATEUR"].ToString()), row["LOGIN"].ToString(),
                        row["MDP"].ToString(), (bool)row["MODERATEUR"]);
                    _Utilisateurs.Add(utilisateur);
                }
                return _Utilisateurs;
            }
            return null;
           
        }

        /// <summary>
        /// Methode d'accés aux données permettant de récupérer l'utilisateur dont l'identifiant est passé en parametre
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Utilisateur GetUtilisateurByID(int id)
        {
           // conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "GetUtilisateurById";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = cmd.CreateParameter();
            param.ParameterName = "@IdUtilisateur";
            param.Value = id;
            cmd.Parameters.Add(param);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Utilisateurs");
            da.Fill(dt);
           // conn.Close();
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
        /// Methode qui permet à un utilisateur de s'authentifier
        /// </summary>
        /// <param name="login"></param>
        /// <param name="mdp"></param>
        /// <returns></returns>
        public static bool Login(string login, string mdp)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "GetLoginMDP";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramLogin = cmd.CreateParameter();
            paramLogin.ParameterName = "@Login";
            paramLogin.Value = login;
            
            SqlParameter paramMDP = cmd.CreateParameter();
            paramMDP.ParameterName = "@MDP";
            paramMDP.Value = mdp;
            
            cmd.Parameters.Add(paramLogin);
            cmd.Parameters.Add(paramMDP);
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Login");
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
    }
}
