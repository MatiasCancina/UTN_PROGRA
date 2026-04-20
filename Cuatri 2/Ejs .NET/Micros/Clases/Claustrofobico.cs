using System;
using System.Collections.Generic;
using System.Text;

namespace _20260414___Clase_09.Clases
{
	public class Claustrofobico : Persona
	{
		public static readonly double Volumen_Minimo = 120;
		public override bool AceptaSubir(Micro micro)
		{
			if (micro.Volumen >= Volumen_Minimo)
			{
				Console.WriteLine("Puede ingresar al micro porque su volumen es de " + micro.Volumen);
				return true;
			}
			else
			{
				Console.WriteLine("No puede ingresar al micro porque su volumen es de " + micro.Volumen);
				return false;
			}
		}
	}
}
