using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Genie_logiciel.Models;
using Genie_logiciel.BusinessLayer;
using System.Data.SqlClient;
namespace Genie_logiciel.Controllers
{
    public class AccountController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand comd = new SqlCommand();
        SqlDataReader dr;
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        void connecionString()
        {
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GesRes;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
        [HttpPost]
        public ActionResult Login(Account acc)
        {
            connecionString();
            con.Open();
            comd.Connection = con;
            comd.CommandText = "select * from Accounts where Email='"+acc.Email+"'and Pwd='"+acc.Pwd+"' ";
            dr = comd.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return View("~/Views/ResRessource/ResRessource.cshtml");
            }
            else
            {
                con.Close();
                return View("Wrong");
            }
            
        }
        [HttpGet]
        public ActionResult Good()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Good(Account acc)
        {
            return View();
        }
    }
}
