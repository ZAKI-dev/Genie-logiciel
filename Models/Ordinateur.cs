using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations;

public class Ordinateur{
	[Key]
	public int Code { get; set; }
	public string DateLiv { get; set; }
	public string DureeGarantie { get; set; }
	public string Marque { get; set; }
	public string Cpu { get; set; }
	public string Ram { get; set; }
	public string DisqueDur { get; set; }
	public string Ecran { get; set; }
	public string Type { get; set; }
	public string Etat { get; set; }
}

