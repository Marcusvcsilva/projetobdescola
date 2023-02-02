namespace ProjetinhoEscola
{
    partial class F_GerenciamentoUsuario
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
            this.lb_nome = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lb_senha = new System.Windows.Forms.Label();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.lb_status = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.lb_nivel = new System.Windows.Forms.Label();
            this.numupdn_nivel = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.dgv_gerenciamento = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.bt_atualizar = new System.Windows.Forms.Button();
            this.bt_novo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numupdn_nivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gerenciamento)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(9, 10);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(35, 13);
            this.lb_nome.TabIndex = 0;
            this.lb_nome.Text = "Nome";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(12, 26);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(315, 20);
            this.tb_nome.TabIndex = 1;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(9, 54);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(55, 13);
            this.lb_username.TabIndex = 2;
            this.lb_username.Text = "Username";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(12, 70);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(315, 20);
            this.tb_username.TabIndex = 3;
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Location = new System.Drawing.Point(9, 97);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(38, 13);
            this.lb_senha.TabIndex = 4;
            this.lb_senha.Text = "Senha";
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(12, 126);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(315, 20);
            this.tb_senha.TabIndex = 5;
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(9, 171);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(37, 13);
            this.lb_status.TabIndex = 6;
            this.lb_status.Text = "Status";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(12, 186);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(121, 21);
            this.cb_status.TabIndex = 7;
            // 
            // lb_nivel
            // 
            this.lb_nivel.AutoSize = true;
            this.lb_nivel.Location = new System.Drawing.Point(204, 171);
            this.lb_nivel.Name = "lb_nivel";
            this.lb_nivel.Size = new System.Drawing.Size(31, 13);
            this.lb_nivel.TabIndex = 8;
            this.lb_nivel.Text = "Nivel";
            // 
            // numupdn_nivel
            // 
            this.numupdn_nivel.Location = new System.Drawing.Point(207, 187);
            this.numupdn_nivel.Name = "numupdn_nivel";
            this.numupdn_nivel.Size = new System.Drawing.Size(120, 20);
            this.numupdn_nivel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "A: Ativo B: Bloqueado";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(9, 239);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(18, 13);
            this.lb_id.TabIndex = 11;
            this.lb_id.Text = "ID";
            // 
            // tb_id
            // 
            this.tb_id.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_id.Location = new System.Drawing.Point(12, 255);
            this.tb_id.Multiline = true;
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(52, 20);
            this.tb_id.TabIndex = 12;
            // 
            // dgv_gerenciamento
            // 
            this.dgv_gerenciamento.AllowUserToAddRows = false;
            this.dgv_gerenciamento.AllowUserToDeleteRows = false;
            this.dgv_gerenciamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gerenciamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_gerenciamento.EnableHeadersVisualStyles = false;
            this.dgv_gerenciamento.Location = new System.Drawing.Point(385, 37);
            this.dgv_gerenciamento.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_gerenciamento.MultiSelect = false;
            this.dgv_gerenciamento.Name = "dgv_gerenciamento";
            this.dgv_gerenciamento.ReadOnly = true;
            this.dgv_gerenciamento.RowHeadersVisible = false;
            this.dgv_gerenciamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_gerenciamento.Size = new System.Drawing.Size(240, 238);
            this.dgv_gerenciamento.TabIndex = 7;
            this.dgv_gerenciamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_gerenciamento_CellContentClick);
            this.dgv_gerenciamento.SelectionChanged += new System.EventHandler(this.dgv_gerenciamento_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_fechar);
            this.panel1.Controls.Add(this.bt_excluir);
            this.panel1.Controls.Add(this.bt_limpar);
            this.panel1.Controls.Add(this.bt_atualizar);
            this.panel1.Controls.Add(this.bt_novo);
            this.panel1.Location = new System.Drawing.Point(12, 281);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 27);
            this.panel1.TabIndex = 13;
            // 
            // bt_fechar
            // 
            this.bt_fechar.Location = new System.Drawing.Point(327, 0);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(75, 23);
            this.bt_fechar.TabIndex = 14;
            this.bt_fechar.Text = "Fechar";
            this.bt_fechar.UseVisualStyleBackColor = true;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.Location = new System.Drawing.Point(246, 0);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(75, 23);
            this.bt_excluir.TabIndex = 14;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.Location = new System.Drawing.Point(165, 0);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(75, 23);
            this.bt_limpar.TabIndex = 14;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // bt_atualizar
            // 
            this.bt_atualizar.Location = new System.Drawing.Point(81, 0);
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.Size = new System.Drawing.Size(75, 23);
            this.bt_atualizar.TabIndex = 1;
            this.bt_atualizar.Text = "Atualizar";
            this.bt_atualizar.UseVisualStyleBackColor = true;
            this.bt_atualizar.Click += new System.EventHandler(this.bt_atualizar_Click);
            // 
            // bt_novo
            // 
            this.bt_novo.Location = new System.Drawing.Point(0, 1);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(75, 23);
            this.bt_novo.TabIndex = 0;
            this.bt_novo.Text = "Novo";
            this.bt_novo.UseVisualStyleBackColor = true;
            this.bt_novo.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_GerenciamentoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 312);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_gerenciamento);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numupdn_nivel);
            this.Controls.Add(this.lb_nivel);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.lb_senha);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lb_nome);
            this.Name = "F_GerenciamentoUsuario";
            this.Text = "Gerenciamento";
            this.Load += new System.EventHandler(this.F_Gerenciamento_Load);
            this.SizeChanged += new System.EventHandler(this.F_Gerenciamento_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.numupdn_nivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gerenciamento)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb_nome;
        public System.Windows.Forms.TextBox tb_nome;
        public System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.TextBox tb_username;
        public System.Windows.Forms.Label lb_senha;
        public System.Windows.Forms.TextBox tb_senha;
        public System.Windows.Forms.Label lb_status;
        public System.Windows.Forms.ComboBox cb_status;
        public System.Windows.Forms.Label lb_nivel;
        private System.Windows.Forms.NumericUpDown numupdn_nivel;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.DataGridView dgv_gerenciamento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.Button bt_atualizar;
        private System.Windows.Forms.Button bt_novo;
        private System.Windows.Forms.Button bt_fechar;
    }
}