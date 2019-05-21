﻿using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Cliente.Interfaces
{
    public interface IClienteRepositorio
    {
        void Inserir(Cliente cliente);
        void Atualizar(Cliente cliente);
        void Excluir(Guid id);
        Cliente BuscarPorId(Guid id);
        List<Cliente> BuscarTodos();
    }
}