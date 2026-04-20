using System;
using System.Collections.Generic;
using System.Text;

namespace _20260414___Clase_09.Clases
{
	public class Moderado : Persona
	{

		private int _cantidadMinima;

		public int CantidadMinima
		{
			get { return _cantidadMinima; }
			set { _cantidadMinima = value; }
		}

		public Moderado(int cantidadMinima)
		{
			this.CantidadMinima = cantidadMinima;
		}

		public override bool AceptaSubir(Micro micro)
		{

			if (micro.LugaresLibres() >= this.CantidadMinima)
			{
				Console.WriteLine("El moderado acepta subir...");	
				return true;

			}
			else
			{
				Console.WriteLine("El moderado no acepta subir...");
				return false;
			}


			//if (micro.HayLugarSentados() || micro.HayLugar())
			//{
			//	Console.WriteLine("Puede ingresar al micro porque hay lugar.");
			//	return true;
			//}
			//else
			//{
			//	Console.WriteLine("No puede ingresar al micro porque no hay lugar.");
			//	return false;
			//}
		}
	}
}
