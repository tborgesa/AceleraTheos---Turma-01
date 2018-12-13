﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UaiQueijos.Dominio.Fornecedor;
using UaiQueijos.Service;

namespace UaiQueijos.Swagger
{
    public partial class FormFornecedor : Form
    {
        private FornecedorService _service = new FornecedorService();

        public FormFornecedor()
        {
            InitializeComponent();
        }

        private void FormFornecedor_Load(object sender, EventArgs e)
        {
            CarregarExemploInserir();
            CarregarExemploBuscarId();
            CarregarExemploAtualizar();
            CarregarExemploExcluir();
        }

        #region Inserir
        private void CarregarExemploInserir()
        {
            FornecedorInserirViewModel fornecedorViewModel = new FornecedorInserirViewModel();
            string texto = JsonConvert.SerializeObject(fornecedorViewModel);
            textBoxExemploInserir.Text = texto;
            textBoxEntradaInserir.Text = texto;
        }

        private void buttonExecutarInserir_Click(object sender, EventArgs e)
        {
            try
            {
                var fornecedorViewModel = JsonConvert.DeserializeObject<FornecedorInserirViewModel>(textBoxEntradaInserir.Text);

                if (fornecedorViewModel == null)
                {
                    textBoxSaidaInserir.Text = $"Json inválido.";
                    return;
                }

                var fornecedorDto = _service.Inserir(fornecedorViewModel);

                textBoxSaidaInserir.Text = JsonConvert.SerializeObject(fornecedorDto);
            }
            catch (Exception ex)
            {
                textBoxSaidaInserir.Text = $"{Environment.NewLine} {ex.ToString()}";
            }
        }
        #endregion

        #region BuscarTodos
        private void buttonBuscarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                var fornecedores = _service.BuscarTodos();
                textBoxBuscarTodos.Text = JsonConvert.SerializeObject(fornecedores);
            }
            catch (Exception ex)
            {
                textBoxSaidaInserir.Text = $"{ex.ToString()}";
            }
        }
        #endregion

        #region BuscarId
        private void CarregarExemploBuscarId()
        {
            textBoxExemploId.Text = Guid.NewGuid().ToString();
            textBoxEntradaBuscarId.Text = Guid.NewGuid().ToString();
        }

        private void buttonExecutarId_Click(object sender, EventArgs e)
        {
            try
            {
                var entrada = textBoxEntradaBuscarId.Text;

                if (entrada == null)
                {
                    textBoxSaidaBuscarId.Text = "Id inválido.";
                    return;
                }

                if (!Guid.TryParse(entrada, out Guid guid))
                {
                    textBoxSaidaBuscarId.Text = "Id inválido.";
                    return;
                }


                var fornecedorDto = _service.BuscarPorId(guid);
                textBoxSaidaBuscarId.Text = JsonConvert.SerializeObject(fornecedorDto);
            }
            catch (Exception ex)
            {
                textBoxSaidaBuscarId.Text = $"{ex.ToString()}";
            }
        }
        #endregion

        #region Atualizar
        private void CarregarExemploAtualizar()
        {
            FornecedorAtualizarViewModel fornecedorViewModel = new FornecedorAtualizarViewModel();
            string texto = JsonConvert.SerializeObject(fornecedorViewModel);
            textBoxExemploAtualizar.Text = texto;
            textBoxEntradaAtualizar.Text = texto;
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                var fornecedorViewModel = JsonConvert.DeserializeObject<FornecedorAtualizarViewModel>(textBoxEntradaAtualizar.Text);

                if (fornecedorViewModel == null)
                {
                    textBoxSaidaAtualizar.Text = $"Json inválido.";
                    return;
                }

                var fornecedorDto = _service.Atualizar(fornecedorViewModel);

                textBoxSaidaAtualizar.Text = JsonConvert.SerializeObject(fornecedorDto);
            }
            catch (Exception ex)
            {
                textBoxSaidaAtualizar.Text = $"{ex.ToString()}";
            }
        }
        #endregion



        #region Excluir
        private void CarregarExemploExcluir()
        {
            textBoxExemploExcluir.Text = Guid.NewGuid().ToString();
            textBoxEntradaExcluir.Text = Guid.NewGuid().ToString();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var entrada = textBoxEntradaExcluir.Text;

                if (entrada == null)
                {
                    textBoxSaidaExcluir.Text = "Id inválido.";
                    return;
                }

                if (!Guid.TryParse(entrada, out Guid guid))
                {
                    textBoxSaidaExcluir.Text = "Id inválido.";
                    return;
                }

                _service.Excluir(guid);

                textBoxSaidaExcluir.Text = "Excluir com Sucesso.";

            }
            catch (Exception ex)
            {
                textBoxSaidaExcluir.Text = $"{ex.ToString()}";
            }
        }
        #endregion


    }
}