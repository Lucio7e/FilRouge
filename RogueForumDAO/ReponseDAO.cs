﻿using RogueForumDLL;
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
    }
}
