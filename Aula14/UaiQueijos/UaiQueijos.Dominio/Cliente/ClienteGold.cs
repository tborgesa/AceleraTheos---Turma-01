﻿using System;

namespace UaiQueijos.Dominio.Cliente
{
    public class ClienteGold : ClienteSilver
    {
        public ClienteGold(DateTime dataNascimento, string cpf, string nome)
            : base(dataNascimento,cpf,nome)
        {
            
        }

        public ClienteGold(DateTime dataNascimento, string cpf, string nome, string endereco)
            : base(dataNascimento,cpf,nome, endereco)
        {
            
        }

        public override double ObterDesconto(double descontoPadrao)
        {
            return base.ObterDesconto(descontoPadrao) * 2;
        }

        public void EspecificoGold()
        {
            
        }

        public override string ToString()
        {
            return $"{Nome} - {Cpf} - Gold";
        }
    }
}