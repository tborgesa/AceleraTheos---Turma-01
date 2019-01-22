﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theos.SistemaEscolar.Comum
{
    public static class InputHelper
    {
        public static int GetInputInt(string texto, string mensagemInvalido, bool limparTela = true)
        {
            while (true)
            {
                if (limparTela)
                    Console.Clear();

                Console.WriteLine(texto);

                string numeroDigitado = Console.ReadLine();
                if (!int.TryParse(numeroDigitado, out var numero))
                {
                    MensagemUsuario(mensagemInvalido);
                }
                else
                    return numero;
            }
        }

        public static void MensagemUsuario(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.ReadKey();
        }

        public static double GetInputDouble(string texto, string mensagemInvalido, bool limparTela = true)
        {
            while (true)
            {
                if (limparTela)
                    Console.Clear();

                Console.WriteLine(texto);

                string numeroDigitado = Console.ReadLine();
                if (!double.TryParse(numeroDigitado, out var numero))
                {
                    MensagemUsuario(mensagemInvalido);
                }
                else
                    return numero;
            }
        }

        public static string GetInputString(string texto, bool limparTela = true)
        {
            while (true)
            {
                if (limparTela)
                    Console.Clear();

                Console.WriteLine(texto);

                return Console.ReadLine();
            }
        }
    }

}