﻿using System;

namespace Petshop.Dominio
{
	public class Gato : Animal
	{
		public Gato(string nome, double peso)
			: base (nome, peso)
		{

		}

		public override double CalcularValorServico()
		{
			return Peso * 1.6;
		}
	}
}
