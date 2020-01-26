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

namespace ViewProject
{
    public partial class FormProduto : Form
    {
        private ProdutoController controller;

        public FormProduto(ProdutoController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
