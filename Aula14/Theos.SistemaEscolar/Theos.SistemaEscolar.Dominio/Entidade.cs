﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theos.SistemaEscolar.Dominio
{
    public class Entidade
    {
        public Guid Id { get; private set; }
        public DateTime DataInsercao { get; set; }
        public DateTime DataAlteracao { get; private set; }

        public Entidade()
        {
            DataAlteracao = DateTime.Now;
        }

        public void GerarId()
        {
            Id = Guid.NewGuid();
        }

        public void SetarAlteracao()
        {
            DataAlteracao = DateTime.Now;
        }
    }
}
