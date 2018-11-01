﻿using System;

namespace Theos.Biblioteca.Domininio.Livro
{
    public class Livro
    {
        public Livro(string nome)
        {
            Nome = nome;
        }

        private string Nome { get; }
        public string Assunto { get; private set; }
        public string Editora { get; private set; }
        public string Autor { get; set; }

        public void AlteraAssunto(string assunto)
        {
            Assunto = assunto;
        }

        public void AlteraEditora(string editora)
        {
            Editora = editora;
        }
    }
}
