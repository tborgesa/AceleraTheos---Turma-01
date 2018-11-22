﻿using System;

namespace Theos.Biblioteca.Dominio.Setor
{
    public class Desenvolvimento : Setor
    {
        public Desenvolvimento()
            : base ("Desenvolvimento")
        {

        }

        public override Permissao GetPermissao()
        {
            Permissao permissao = base.GetPermissao();
            permissao.PermissaoAlterar();
            return permissao;
        }
    }
}