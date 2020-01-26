using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControllerProject;
using ModelProject;

namespace ViewProject
{
    public partial class FormFornecedor : Form
    {
        private FornecedorController controller;

        public FormFornecedor(FornecedorController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void ClearControls()
        {
            dataGridView_FormFornecedores.ClearSelection();
            txt_id.Text = string.Empty;
            txt_nome.Text = string.Empty;
            txt_cnpj.Text = string.Empty;
            txt_nome.Focus();
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            var fornecedor = new Fornecedor()
            {
                Id = (txt_id.Text == string.Empty ? Guid.NewGuid() : new Guid(txt_id.Text)),
                Nome = txt_nome.Text,
                CNPJ = txt_cnpj.Text

            };
            fornecedor = (txt_id.Text == string.Empty ? this.controller.Insert(fornecedor) : this.controller.Update(fornecedor));
            dataGridView_FormFornecedores.DataSource = null;
            dataGridView_FormFornecedores.DataSource = this.controller.GetAll();
            ClearControls();
        }
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void dataGridView_FormFornecedores_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_FormFornecedores.SelectedRows.Count > 0)
            {
                txt_id.Text = dataGridView_FormFornecedores.CurrentRow.Cells[0].Value.ToString();
                txt_nome.Text = dataGridView_FormFornecedores.CurrentRow.Cells[1].Value.ToString();
                txt_cnpj.Text = dataGridView_FormFornecedores.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == string.Empty)
            {
                MessageBox.Show("Selecione	o	FORNECEDOR	a ser	removido no GRID");

            }
            else
            {
                this.controller.Remove(
                new Fornecedor()
                {
                    Id = new Guid(txt_id.Text)
                }
                );
                dataGridView_FormFornecedores.DataSource = null;
                dataGridView_FormFornecedores.DataSource = this.controller.GetAll();
                ClearControls();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
    }
}

