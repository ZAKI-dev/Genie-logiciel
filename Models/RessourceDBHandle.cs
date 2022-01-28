using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Genie_logiciel.Models
{
    public class RessourceDBHandle
    {
        private SqlConnection con;
        private void connection()
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GesRes;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }
        public List<Ressource> GetRessources()
        {
            connection();
            List<Ressource> ressourcelist = new List<Ressource>();

            SqlCommand cmd = new SqlCommand("GetRessourcesDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            sd.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                ressourcelist.Add(
                    new Ressource
                    {
                        Code = Convert.ToInt32(dr["Code"]),
                        DateLiv = Convert.ToString(dr["DateLiv"]),
                        DureeGarantie = Convert.ToString(dr["DureeGarantie"]),
                        Type = Convert.ToString(dr["Type"]),
                        Etat = Convert.ToString(dr["Etat"])
                    });
            }
            return ressourcelist;
        }
        public bool DeleteRessource(int code)
        {
            connection();
            SqlCommand cmd = new SqlCommand("DeleteRess", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@RssCode", code);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

        public bool UpdateDetails(Ressource rmodel)
        {
            connection();
            SqlCommand cmd = new SqlCommand("UpdateRessourceDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Code", rmodel.Code);
            cmd.Parameters.AddWithValue("@DateLiv", rmodel.DateLiv);
            cmd.Parameters.AddWithValue("@DureeGarantie", rmodel.DureeGarantie);
            cmd.Parameters.AddWithValue("@Type", rmodel.Type);
            cmd.Parameters.AddWithValue("@Etat", rmodel.Etat);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

        public bool AddRessource(Ressource rmodel)
        {
            connection();
            SqlCommand cmd = new SqlCommand("AddNewRessource", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Code", rmodel.Code);
            cmd.Parameters.AddWithValue("@DateLiv", rmodel.DateLiv);
            cmd.Parameters.AddWithValue("@DureeGarantie", rmodel.DureeGarantie);
            cmd.Parameters.AddWithValue("@Type", rmodel.Type);
            cmd.Parameters.AddWithValue("@Etat", rmodel.Etat);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }
    }
}