using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations;

public class Imprimante {
	[Key]
	public int Code { get; set; }
	public string DateLiv { get; set; }
	public string DureeGarantie { get; set; }
	public string VitesseImp { get; set; }
	public string Resolution { get; set; }
	public string Marque { get; set; }
	public string Type { get; set; }
	public string Etat { get; set; }
}

   