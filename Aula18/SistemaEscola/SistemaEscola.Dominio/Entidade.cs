﻿using System;
using System.Collections.Generic;

namespace SistemaEscola.Dominio
{
    public abstract class Entidade
    {
        public Guid Id { get; private set; }
        public DateTime DataInsercao { get; }
        public DateTime DataAlteracao { get; private set; }
        private List<string> _erros = new List<string>();

        public Entidade()
        {
            DataInsercao = DateTime.Now;
        }

        public void GerarId()
        {
            Id = Guid.NewGuid();
        }

        public void SetarAlteracao()
        {
            DataAlteracao = DateTime.Now;
        }

        public void AdicionarErro(string erro)
        {
            if(!_erros.Exists(e => e == erro)) {
                _erros.Add (erro);
            }
        }

        public bool Valido()
        {
            return _erros.Count == 0;
        }
    }
}
