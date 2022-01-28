using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations;

public class Panne {
    [Key]
    public int IdPanne { get; set; }
    public int Code { get; set; }
    public string Type { get; set; }
    public string Date_apparition { get; set; }
    public string DateApparition { get; set; }
    public string Explication { get; set; }
    public string Fréquence { get; set; }
    public string Ordre { get; set; }
}

	