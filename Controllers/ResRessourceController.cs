using Genie_logiciel.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Genie_logiciel.Context;


namespace Genie_logiciel.Controllers
{
    public class ResRessourceController : Controller
    {
        GesResEntities dbObj = new GesResEntities();

        private SqlConnection con;
        
        //To Handle connection related activities
        private void connection()
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GesRes;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }
        SqlCommand comd = new SqlCommand();
        // GET: ResRessource
        [HttpGet]
        public ActionResult AjouterRess()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AjouterRess(Ressource rss)
        {
            {
                try
                {
                    if (ModelState.IsValid)
                    {


                        if (AjouterRes(rss))
                        {
                            ViewBag.Message = "Employee details added successfully";
                        }
                    }

                    return View();
                }
                catch
                {
                    return View();
                }
            }            

        }
        public bool AjouterRes(Ressource obj)
        {

            connection();
            SqlCommand com = new SqlCommand("AddNewRessource", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Code", obj.Code);
            com.Parameters.AddWithValue("@DateLiv", obj.DateLiv);
            com.Parameters.AddWithValue("@DureeGarantie", obj.DureeGarantie);
            com.Parameters.AddWithValue("@Type", obj.Type);
            com.Parameters.AddWithValue("@Etat", obj.Etat);
            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {

                return true;

            }
            else
            {

                return false;
            }
        }
        public ActionResult Index()
        {
            RessourceDBHandle dbhandle = new RessourceDBHandle();
            ModelState.Clear();
            return View(dbhandle.GetRessources());
        }
        public ActionResult Delete(int code)
        {
            try
            {
                RessourceDBHandle sdb = new RessourceDBHandle();
                if (sdb.DeleteRessource(code))
                {
                    ViewBag.AlertMsg = "Student Deleted Successfully";
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int code)
        {
            RessourceDBHandle sdb = new RessourceDBHandle();
            return View(sdb.GetRessources().Find(rmodel => rmodel.Code == code));
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int code, Ressource rmodel)
        {
            try
            {
                RessourceDBHandle sdb = new RessourceDBHandle();
                sdb.UpdateDetails(rmodel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(Ressource rmodel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RessourceDBHandle sdb = new RessourceDBHandle();
                    if (sdb.AddRessource(rmodel))
                    {
                        ViewBag.Message = "Student Details Added Successfully";
                        ModelState.Clear();
                    }
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
