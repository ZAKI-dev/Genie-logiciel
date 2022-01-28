namespace Genie_logiciel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGesRes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administatifs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        pwd = c.String(),
                        Nom = c.String(),
                        type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Appel_offre",
                c => new
                    {
                        IdOffre = c.Int(nullable: false, identity: true),
                        Date = c.String(),
                        Heure = c.String(),
                        Besoins = c.String(),
                    })
                .PrimaryKey(t => t.IdOffre);
            
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pwd = c.String(),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Departements",
                c => new
                    {
                        Id_d = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                    })
                .PrimaryKey(t => t.Id_d);
            
            CreateTable(
                "dbo.Enseignants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pwd = c.String(),
                        Nom = c.String(),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Fournisseurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pwd = c.String(),
                        NomSociete = c.String(),
                        Lieu = c.String(),
                        Adresse = c.String(),
                        NomGerant = c.String(),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Imprimantes",
                c => new
                    {
                        Code = c.Int(nullable: false, identity: true),
                        DateLiv = c.String(),
                        DureeGarantie = c.String(),
                        VitesseImp = c.String(),
                        Resolution = c.String(),
                        Marque = c.String(),
                        Type = c.String(),
                        Etat = c.String(),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.Laboratoires",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ordinateurs",
                c => new
                    {
                        Code = c.Int(nullable: false, identity: true),
                        DateLiv = c.String(),
                        DureeGarantie = c.String(),
                        Marque = c.String(),
                        Cpu = c.String(),
                        Ram = c.String(),
                        DisqueDur = c.String(),
                        Ecran = c.String(),
                        Type = c.String(),
                        Etat = c.String(),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.Pannes",
                c => new
                    {
                        IdPanne = c.Int(nullable: false, identity: true),
                        Code = c.Int(nullable: false),
                        Type = c.String(),
                        Date_apparition = c.String(),
                        DateApparition = c.String(),
                        Explication = c.String(),
                        Fréquence = c.String(),
                        Ordre = c.String(),
                    })
                .PrimaryKey(t => t.IdPanne);
            
            CreateTable(
                "dbo.ResponsableRessources",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        pwd = c.String(),
                        Nom = c.String(),
                        type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ressources",
                c => new
                    {
                        Code = c.Int(nullable: false, identity: true),
                        DateLiv = c.String(),
                        DureeGarantie = c.String(),
                        Type = c.String(),
                        Etat = c.String(),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.ServiceMaintenances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        pwd = c.String(),
                        Nom = c.String(),
                        type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ServiceMaintenances");
            DropTable("dbo.Ressources");
            DropTable("dbo.ResponsableRessources");
            DropTable("dbo.Pannes");
            DropTable("dbo.Ordinateurs");
            DropTable("dbo.Laboratoires");
            DropTable("dbo.Imprimantes");
            DropTable("dbo.Fournisseurs");
            DropTable("dbo.Enseignants");
            DropTable("dbo.Departements");
            DropTable("dbo.Accounts");
            DropTable("dbo.Appel_offre");
            DropTable("dbo.Administatifs");
        }
    }
}
