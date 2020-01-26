namespace ViewProject
{
    partial class FormFornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelTextBox = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_cnpj = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.dataGridView_FormFornecedores = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelTextBox.SuspendLayout();
            this.tableLayoutPanelBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_FormFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelTextBox
            // 
            this.tableLayoutPanelTextBox.ColumnCount = 2;
            this.tableLayoutPanelTextBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.86224F));
            this.tableLayoutPanelTextBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.13776F));
            this.tableLayoutPanelTextBox.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelTextBox.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanelTextBox.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanelTextBox.Controls.Add(this.txt_id, 1, 0);
            this.tableLayoutPanelTextBox.Controls.Add(this.txt_nome, 1, 1);
            this.tableLayoutPanelTextBox.Controls.Add(this.txt_cnpj, 1, 2);
            this.tableLayoutPanelTextBox.Location = new System.Drawing.Point(7, 2);
            this.tableLayoutPanelTextBox.Name = "tableLayoutPanelTextBox";
            this.tableLayoutPanelTextBox.RowCount = 3;
            this.tableLayoutPanelTextBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTextBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTextBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelTextBox.Size = new System.Drawing.Size(784, 118);
            this.tableLayoutPanelTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CNPJ :";
            // 
            // txt_id
            // 
            this.txt_id.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(95, 4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(138, 20);
            this.txt_id.TabIndex = 3;
            // 
            // txt_nome
            // 
            this.txt_nome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_nome.Location = new System.Drawing.Point(95, 33);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(670, 20);
            this.txt_nome.TabIndex = 4;
            // 
            // txt_cnpj
            // 
            this.txt_cnpj.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_cnpj.Location = new System.Drawing.Point(95, 78);
            this.txt_cnpj.Name = "txt_cnpj";
            this.txt_cnpj.Size = new System.Drawing.Size(211, 20);
            this.txt_cnpj.TabIndex = 5;
            // 
            // tableLayoutPanelBotoes
            // 
            this.tableLayoutPanelBotoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelBotoes.ColumnCount = 4;
            this.tableLayoutPanelBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelBotoes.Controls.Add(this.btn_Novo, 0, 0);
            this.tableLayoutPanelBotoes.Controls.Add(this.btn_Gravar, 1, 0);
            this.tableLayoutPanelBotoes.Controls.Add(this.btn_Cancelar, 2, 0);
            this.tableLayoutPanelBotoes.Controls.Add(this.btn_Remover, 3, 0);
            this.tableLayoutPanelBotoes.Location = new System.Drawing.Point(7, 126);
            this.tableLayoutPanelBotoes.Name = "tableLayoutPanelBotoes";
            this.tableLayoutPanelBotoes.RowCount = 1;
            this.tableLayoutPanelBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBotoes.Size = new System.Drawing.Size(784, 51);
            this.tableLayoutPanelBotoes.TabIndex = 1;
            // 
            // btn_Novo
            // 
            this.btn_Novo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Novo.Location = new System.Drawing.Point(54, 7);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(87, 37);
            this.btn_Novo.TabIndex = 0;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Gravar.Location = new System.Drawing.Point(250, 7);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(87, 37);
            this.btn_Gravar.TabIndex = 1;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancelar.Location = new System.Drawing.Point(446, 7);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(87, 37);
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Remover
            // 
            this.btn_Remover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Remover.Location = new System.Drawing.Point(642, 7);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(87, 37);
            this.btn_Remover.TabIndex = 3;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // dataGridView_FormFornecedores
            // 
            this.dataGridView_FormFornecedores.AllowUserToAddRows = false;
            this.dataGridView_FormFornecedores.AllowUserToDeleteRows = false;
            this.dataGridView_FormFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_FormFornecedores.Location = new System.Drawing.Point(7, 193);
            this.dataGridView_FormFornecedores.Name = "dataGridView_FormFornecedores";
            this.dataGridView_FormFornecedores.ReadOnly = true;
            this.dataGridView_FormFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_FormFornecedores.Size = new System.Drawing.Size(784, 245);
            this.dataGridView_FormFornecedores.TabIndex = 2;
            this.dataGridView_FormFornecedores.SelectionChanged += new System.EventHandler(this.dataGridView_FormFornecedores_SelectionChanged);
            // 
            // FormFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.dataGridView_FormFornecedores);
            this.Controls.Add(this.tableLayoutPanelBotoes);
            this.Controls.Add(this.tableLayoutPanelTextBox);
            this.Name = "FormFornecedor";
            this.Text = "Manutenção em Dados de Fornecedores";
            this.tableLayoutPanelTextBox.ResumeLayout(false);
            this.tableLayoutPanelTextBox.PerformLayout();
            this.tableLayoutPanelBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_FormFornecedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_cnpj;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBotoes;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.DataGridView dataGridView_FormFornecedores;
    }
}