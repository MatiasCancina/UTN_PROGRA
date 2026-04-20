using System;
using System.Collections.Generic;
using System.Text;

namespace _20260414___Clase_09.Clases
{
	public class Obsecuente : Persona
	{
		public Obsecuente(Persona jefe)
		{
			this.Jefe = jefe;
		}
		public override bool AceptaSubir(Micro micro)
		{
			return this.Jefe.AceptaSubir(micro);
		}
	}
}
