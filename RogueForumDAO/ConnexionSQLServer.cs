using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueForumDAO
{
    public static class ConnexionSQLServer
    {
        private static string connexionString = Properties.Settings.Default.InfoConnexion;
        

        /// <summary>
        /// Methode static qui renvoi une connexion  à la base de données
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnexion()
        {
            SqlConnection connexion = new SqlConnection();
            connexion.ConnectionString = connexionString;
           
            return connexion;
        }

       
    }
}
