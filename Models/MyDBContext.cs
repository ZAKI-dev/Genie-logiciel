using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Genie_logiciel.Models
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() : base("GesRes")
        {
        }
        public DbSet<Account>comptes { get; set; }
        public DbSet<Administatif>administrations { get; set; }
        public DbSet<Appel_offre> appel_Offres { get; set; }
        public DbSet<Departement> departement { get; set;}
        public DbSet<Enseignant> enseignants { get; set;}
        public DbSet<Fournisseur> fournisseurs { get; set; }
        public DbSet<Imprimante> imprimantes { get; set;}
        public DbSet<Laboratoire> laboratoires { get;set; }
        public DbSet<Ordinateur> ordinateurs { get; set;}
        public DbSet<Panne> pannes { get; set; }
        public DbSet<ResponsableRessource> responsable_de_resses { get; set; }
        public DbSet<Ressource> ressources { get; set;}
        public DbSet<ServiceMaintenance> service_de_maintenance { get; set; }  

    }
}