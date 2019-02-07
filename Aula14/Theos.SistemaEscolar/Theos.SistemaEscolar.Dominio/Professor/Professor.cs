﻿
using System.Collections.Generic;
using Theos.SistemaEscolar.Dominio.Enumerador;

namespace Theos.SistemaEscolar.Dominio.Professor
{
    public abstract class Professor : Entidade
    {

        public string Nome { get; private set; }
        public string Cpf { get; private set; }

        public Professor(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
            ValidarNomeProfessor();
        }

        public Professor()
        {

        }

        public abstract decimal CalcularSalario();

        public void Alterar(string nome, string cpf)
        {
            Cpf = cpf;
            Nome = nome;
        }

        private void ValidarNomeProfessor()
        {
            if (string.IsNullOrWhiteSpace(Nome))
                AdicionarErro("Preencha o nome do professor");
        }
    }
}
