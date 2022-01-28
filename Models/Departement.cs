using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations;

public class Departement {
    [Key]
    public int Id_d { get; set; }
    public string Nom { get; set; }
}

	