using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations;
using Genie_logiciel.Models;

public class Fournisseur {

    public int Id { get; set; }
    public string Pwd { get; set; }
    public string NomSociete { get; set; }
    public string Lieu { get; set; }
    public string Adresse { get; set; }
    public string NomGerant { get; set; }
    public string Type { get; set; }
}

  