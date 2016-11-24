
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
        /// Methode d'accés aux données permettant de récupérer l'utilisateur dont l'identifiant est passé en parametre
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataTable GetUtilisateurByID(int id)
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
            return dt;
          
        }

        /// <summary>
        /// Methode qui permet à un utilisateur de s'authentifier
        /// </summary>
        /// <param name="login"></param>
        /// <param name="mdp"></param>
        /// <returns></returns>
        public static DataTable Login(string login, string mdp)
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
            return dt;
        }

        /// <summary>
        /// Methode permettant à l'utilisateur connecté de changer son mdp
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="mdp"></param>
        /// <returns></returns>
        public static int ChangeMDP(string login, string mdp)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "ChangeMDP";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramUserID= cmd.CreateParameter();
            paramUserID.ParameterName = "@LOGIN";
            paramUserID.Value = login;

            SqlParameter paramMDP = cmd.CreateParameter();
            paramMDP.ParameterName = "@MDP";
            paramMDP.Value = mdp;
            cmd.Parameters.Add(paramUserID);
            cmd.Parameters.Add(paramMDP);

            conn.Open();
            int nbLigne = cmd.ExecuteNonQuery();
            conn.Close();
            return nbLigne;
        }

        /// <summary>
        /// Appel la procédure stocké permettant de savoir si la combinaison Login/Mail correspond afin d'autoriser la génération d'un nouveau mdp
        /// </summary>
        /// <param name="login"></param>
        /// <param name="mail"></param>
        /// <returns>Le nombre de lignes affectées (1 si tout va bien)</returns>
        public static DataTable GetUserByLoginMail(string login, string mail)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "GetUserByLoginMail";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramUserID = cmd.CreateParameter();
            paramUserID.ParameterName = "@LOGIN";
            paramUserID.Value = login;

            SqlParameter paramMail = cmd.CreateParameter();
            paramMail.ParameterName = "@MAIL";
            paramMail.Value = mail;
            cmd.Parameters.Add(paramUserID);
            cmd.Parameters.Add(paramMail);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Mail");
            da.Fill(dt);
            return dt;
        }
    }
}
