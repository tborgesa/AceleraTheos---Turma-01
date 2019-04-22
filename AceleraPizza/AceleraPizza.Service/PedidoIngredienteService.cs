﻿using System;
using System.Collections.Generic;
using AceleraPizza.Dominio.PedidoIngrediente;
using AceleraPizza.Dominio.PedidoIngrediente.Interfaces;

namespace AceleraPizza.Service
{
    public class PedidoIngredienteService : IPedidoIngredienteService
    {
        private IPedidoIngredienteRepositorio _repositorio;

        public PedidoIngredienteService(IPedidoIngredienteRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public PedidoIngredienteDtoReturn Inserir(PedidoIngredienteInserirViewModel pedidoIngredienteViewModel)
        {
            var pedidoIngrediente = new _PedidoIngrediente(
                pedidoIngredienteViewModel.Id,
                pedidoIngredienteViewModel.IdIngrediente,
                pedidoIngredienteViewModel.Quantidade
                );

            if (!pedidoIngrediente.Valido())
                return new PedidoIngredienteDtoReturn(pedidoIngrediente.GetErros());

            pedidoIngrediente.GerarId();
            _repositorio.Inserir(pedidoIngrediente);

            return new PedidoIngredienteDtoReturn(BuscarPorId(pedidoIngrediente.Id));
        }

        public PedidoIngredienteDto BuscarPorId(Guid id)
        {
            _PedidoIngrediente pedidoIngrediente = _repositorio.BuscarPorId(id);

            if (pedidoIngrediente == null)
                return null;

            return new PedidoIngredienteDto
            {
                Id = pedidoIngrediente.Id,
                IdIngrediente = pedidoIngrediente.IdIngrediente,
                 Quantidade= pedidoIngrediente.Quantidade
            };
        }

        public PedidoIngredienteDtoReturn Atualizar(PedidoIngredienteAtualizarViewModel pedidoIngredienteAtualizarViewModel)
        {
            var pedidoIngrediente = _repositorio.BuscarPorId(pedidoIngredienteAtualizarViewModel.Id);

            if (pedidoIngrediente == null)
            {
                List<string> erros = new List<string>
                {
                    "PedidoIngrediente não existe."
                };
                return new PedidoIngredienteDtoReturn(erros);
            }

            if (!pedidoIngrediente.Valido())
                return new PedidoIngredienteDtoReturn(pedidoIngrediente.GetErros());

            _repositorio.Atualizar(pedidoIngrediente);

            return new PedidoIngredienteDtoReturn(BuscarPorId(pedidoIngrediente.Id));
        }

        public void Excluir(Guid id)
        {
            _repositorio.Excluir(id);
        }
    }
}