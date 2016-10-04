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
    /// <summary>
    /// DAO Classe permettant de récuperer les rubriques en base de données
    /// </summary>
    public static class RubriqueDAO
    {
        private static SqlConnection conn = ConnexionSQLServer.GetConnexion();
       
        public static Rubrique GetRubriqueByID (int id)
        {
           // conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = string.Format("SELECT ID_RUBRIQUE, NOM_RUBRIQUE FROM RUBRIQUE WHERE ID_RUBRIQUE = {0}", id);
            Rubrique rubrique;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Rubrique");
            da.Fill(dt);
           // conn.Close();
            if (dt.Rows.Count == 1)
            {

                DataRow row = dt.Rows[0];
                rubrique = new Rubrique(id, row["NOM_RUBRIQUE"].ToString());
                return rubrique;
            }

            return null;
            
        }

        public static List<Rubrique> GetAllRubriques()
        {
           // conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ID_RUBRIQUE, NOM_RUBRIQUE FROM RUBRIQUE";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Rubriques");
            da.Fill(dt);
           // conn.Close();
            if (dt.Rows.Count >= 1)
            {
                List<Rubrique> _Rubriques = new List<Rubrique>();
                foreach (DataRow row in dt.Rows)
                {
                    Rubrique rubrique = new Rubrique(int.Parse(row["ID_RUBRIQUE"].ToString()), row["NOM_RUBRIQUE"].ToString());
                    rubrique.Id = int.Parse(row["ID_RUBRIQUE"].ToString());
                    _Rubriques.Add(rubrique);

                }
                return _Rubriques;
            }
            return null;   
        }
    }
}
