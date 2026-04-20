using System;
using System.Collections.Generic;
using System.Text;

namespace _20260414___Clase_09.Clases
{
	public class Apurado : Persona
	{
		public override bool AceptaSubir(Micro micro)
		{
			if (micro.HayLugar())
			{
				Console.WriteLine("Puede ingresar al micro porque hay lugar.");
				return true;
			}
			else
			{
				Console.WriteLine("No puede ingresar al micro porque no hay lugar.");
				return false;
			}
		}
	}
}
