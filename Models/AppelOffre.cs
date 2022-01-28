using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations;

public class Appel_offre {
    [Key]
    public int IdOffre { get; set; }
    public string Date { get; set; }
    public string Heure { get; set; }
    public string Besoins { get; set; }
}


    