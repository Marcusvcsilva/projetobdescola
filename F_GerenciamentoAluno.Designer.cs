namespace ProjetinhoEscola
{
    partial class F_GerenciamentoAluno
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
            this.tb_numero = new System.Windows.Forms.TextBox();
            this.lb_numero = new System.Windows.Forms.Label();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_cep = new System.Windows.Forms.TextBox();
            this.lb_cep = new System.Windows.Forms.Label();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.lb_sexo = new System.Windows.Forms.Label();
            this.lb_rg = new System.Windows.Forms.Label();
            this.tb_rg = new System.Windows.Forms.TextBox();
            this.tb_cpf = new System.Windows.Forms.TextBox();
            this.lb_cpf = new System.Windows.Forms.Label();
            this.tb_telefone = new System.Windows.Forms.TextBox();
            this.lb_telefone = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.lb_nome = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.bt_atualizar = new System.Windows.Forms.Button();
            this.bt_novo = new System.Windows.Forms.Button();
            this.dgv_gerenciamentoaluno = new System.Windows.Forms.DataGridView();
            this.tb_idcurso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gerenciamentoaluno)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_numero
            // 
            this.tb_numero.Location = new System.Drawing.Point(12, 334);
            this.tb_numero.Name = "tb_numero";
            this.tb_numero.PasswordChar = '*';
            this.tb_numero.Size = new System.Drawing.Size(75, 20);
            this.tb_numero.TabIndex = 40;
            // 
            // lb_numero
            // 
            this.lb_numero.AutoSize = true;
            this.lb_numero.Location = new System.Drawing.Point(9, 317);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(44, 13);
            this.lb_numero.TabIndex = 39;
            this.lb_numero.Text = "Número";
            // 
            // tb_endereco
            // 
            this.tb_endereco.Location = new System.Drawing.Point(12, 294);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.PasswordChar = '*';
            this.tb_endereco.Size = new System.Drawing.Size(237, 20);
            this.tb_endereco.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Endereço";
            // 
            // tb_cep
            // 
            this.tb_cep.Location = new System.Drawing.Point(12, 255);
            this.tb_cep.Name = "tb_cep";
            this.tb_cep.PasswordChar = '*';
            this.tb_cep.Size = new System.Drawing.Size(237, 20);
            this.tb_cep.TabIndex = 36;
            // 
            // lb_cep
            // 
            this.lb_cep.AutoSize = true;
            this.lb_cep.Location = new System.Drawing.Point(9, 239);
            this.lb_cep.Name = "lb_cep";
            this.lb_cep.Size = new System.Drawing.Size(28, 13);
            this.lb_cep.TabIndex = 35;
            this.lb_cep.Text = "CEP";
            // 
            // cb_sexo
            // 
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Prefiro não responder"});
            this.cb_sexo.Location = new System.Drawing.Point(105, 333);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(144, 21);
            this.cb_sexo.TabIndex = 34;
            // 
            // lb_sexo
            // 
            this.lb_sexo.AutoSize = true;
            this.lb_sexo.Location = new System.Drawing.Point(218, 317);
            this.lb_sexo.Name = "lb_sexo";
            this.lb_sexo.Size = new System.Drawing.Size(31, 13);
            this.lb_sexo.TabIndex = 33;
            this.lb_sexo.Text = "Sexo";
            // 
            // lb_rg
            // 
            this.lb_rg.AutoSize = true;
            this.lb_rg.Location = new System.Drawing.Point(9, 191);
            this.lb_rg.Name = "lb_rg";
            this.lb_rg.Size = new System.Drawing.Size(23, 13);
            this.lb_rg.TabIndex = 32;
            this.lb_rg.Text = "RG";
            // 
            // tb_rg
            // 
            this.tb_rg.Location = new System.Drawing.Point(12, 207);
            this.tb_rg.Name = "tb_rg";
            this.tb_rg.Size = new System.Drawing.Size(237, 20);
            this.tb_rg.TabIndex = 31;
            // 
            // tb_cpf
            // 
            this.tb_cpf.Location = new System.Drawing.Point(12, 162);
            this.tb_cpf.Name = "tb_cpf";
            this.tb_cpf.Size = new System.Drawing.Size(237, 20);
            this.tb_cpf.TabIndex = 30;
            // 
            // lb_cpf
            // 
            this.lb_cpf.AutoSize = true;
            this.lb_cpf.Location = new System.Drawing.Point(9, 146);
            this.lb_cpf.Name = "lb_cpf";
            this.lb_cpf.Size = new System.Drawing.Size(27, 13);
            this.lb_cpf.TabIndex = 29;
            this.lb_cpf.Text = "CPF";
            // 
            // tb_telefone
            // 
            this.tb_telefone.Location = new System.Drawing.Point(12, 121);
            this.tb_telefone.Name = "tb_telefone";
            this.tb_telefone.Size = new System.Drawing.Size(237, 20);
            this.tb_telefone.TabIndex = 28;
            // 
            // lb_telefone
            // 
            this.lb_telefone.AutoSize = true;
            this.lb_telefone.Location = new System.Drawing.Point(9, 104);
            this.lb_telefone.Name = "lb_telefone";
            this.lb_telefone.Size = new System.Drawing.Size(49, 13);
            this.lb_telefone.TabIndex = 27;
            this.lb_telefone.Text = "Telefone";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(12, 78);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(237, 20);
            this.tb_email.TabIndex = 26;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(9, 62);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(32, 13);
            this.lb_email.TabIndex = 25;
            this.lb_email.Text = "Email";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(12, 29);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(237, 20);
            this.tb_nome.TabIndex = 24;
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(9, 13);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(35, 13);
            this.lb_nome.TabIndex = 23;
            this.lb_nome.Text = "Nome";
            // 
            // tb_id
            // 
            this.tb_id.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_id.Location = new System.Drawing.Point(12, 381);
            this.tb_id.Multiline = true;
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(52, 20);
            this.tb_id.TabIndex = 42;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(9, 365);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(18, 13);
            this.lb_id.TabIndex = 41;
            this.lb_id.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_fechar);
            this.panel1.Controls.Add(this.bt_excluir);
            this.panel1.Controls.Add(this.bt_limpar);
            this.panel1.Controls.Add(this.bt_atualizar);
            this.panel1.Controls.Add(this.bt_novo);
            this.panel1.Location = new System.Drawing.Point(12, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 27);
            this.panel1.TabIndex = 44;
            // 
            // bt_fechar
            // 
            this.bt_fechar.Location = new System.Drawing.Point(324, -1);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(75, 28);
            this.bt_fechar.TabIndex = 14;
            this.bt_fechar.Text = "Fechar";
            this.bt_fechar.UseVisualStyleBackColor = true;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.Location = new System.Drawing.Point(243, 0);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(75, 28);
            this.bt_excluir.TabIndex = 14;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.Location = new System.Drawing.Point(162, 0);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(75, 28);
            this.bt_limpar.TabIndex = 14;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // bt_atualizar
            // 
            this.bt_atualizar.Location = new System.Drawing.Point(81, -1);
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.Size = new System.Drawing.Size(75, 28);
            this.bt_atualizar.TabIndex = 1;
            this.bt_atualizar.Text = "Atualizar";
            this.bt_atualizar.UseVisualStyleBackColor = true;
            this.bt_atualizar.Click += new System.EventHandler(this.bt_atualizar_Click);
            // 
            // bt_novo
            // 
            this.bt_novo.Location = new System.Drawing.Point(0, 0);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(75, 28);
            this.bt_novo.TabIndex = 0;
            this.bt_novo.Text = "Novo";
            this.bt_novo.UseVisualStyleBackColor = true;
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
            // 
            // dgv_gerenciamentoaluno
            // 
            this.dgv_gerenciamentoaluno.AllowUserToAddRows = false;
            this.dgv_gerenciamentoaluno.AllowUserToDeleteRows = false;
            this.dgv_gerenciamentoaluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gerenciamentoaluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_gerenciamentoaluno.EnableHeadersVisualStyles = false;
            this.dgv_gerenciamentoaluno.Location = new System.Drawing.Point(284, 29);
            this.dgv_gerenciamentoaluno.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_gerenciamentoaluno.MultiSelect = false;
            this.dgv_gerenciamentoaluno.Name = "dgv_gerenciamentoaluno";
            this.dgv_gerenciamentoaluno.ReadOnly = true;
            this.dgv_gerenciamentoaluno.RowHeadersVisible = false;
            this.dgv_gerenciamentoaluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_gerenciamentoaluno.Size = new System.Drawing.Size(188, 349);
            this.dgv_gerenciamentoaluno.TabIndex = 45;
            this.dgv_gerenciamentoaluno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_gerenciamentoaluno_CellContentClick);
            this.dgv_gerenciamentoaluno.SelectionChanged += new System.EventHandler(this.dgv_gerenciamentoaluno_SelectionChanged);
            // 
            // tb_idcurso
            // 
            this.tb_idcurso.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_idcurso.Location = new System.Drawing.Point(221, 381);
            this.tb_idcurso.Multiline = true;
            this.tb_idcurso.Name = "tb_idcurso";
            this.tb_idcurso.Size = new System.Drawing.Size(52, 20);
            this.tb_idcurso.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "ID CURSO";
            // 
            // F_GerenciamentoAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 451);
            this.Controls.Add(this.tb_idcurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_gerenciamentoaluno);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.tb_numero);
            this.Controls.Add(this.lb_numero);
            this.Controls.Add(this.tb_endereco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_cep);
            this.Controls.Add(this.lb_cep);
            this.Controls.Add(this.cb_sexo);
            this.Controls.Add(this.lb_sexo);
            this.Controls.Add(this.lb_rg);
            this.Controls.Add(this.tb_rg);
            this.Controls.Add(this.tb_cpf);
            this.Controls.Add(this.lb_cpf);
            this.Controls.Add(this.tb_telefone);
            this.Controls.Add(this.lb_telefone);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lb_nome);
            this.Name = "F_GerenciamentoAluno";
            this.Text = "F_GerenciamentoAluno";
            this.Load += new System.EventHandler(this.F_GerenciamentoAluno_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gerenciamentoaluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tb_numero;
        public System.Windows.Forms.Label lb_numero;
        public System.Windows.Forms.TextBox tb_endereco;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tb_cep;
        public System.Windows.Forms.Label lb_cep;
        public System.Windows.Forms.ComboBox cb_sexo;
        public System.Windows.Forms.Label lb_sexo;
        public System.Windows.Forms.Label lb_rg;
        public System.Windows.Forms.TextBox tb_rg;
        public System.Windows.Forms.TextBox tb_cpf;
        public System.Windows.Forms.Label lb_cpf;
        public System.Windows.Forms.TextBox tb_telefone;
        public System.Windows.Forms.Label lb_telefone;
        public System.Windows.Forms.TextBox tb_email;
        public System.Windows.Forms.Label lb_email;
        public System.Windows.Forms.TextBox tb_nome;
        public System.Windows.Forms.Label lb_nome;
        public System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.Button bt_atualizar;
        private System.Windows.Forms.Button bt_novo;
        private System.Windows.Forms.DataGridView dgv_gerenciamentoaluno;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tb_id;
        public System.Windows.Forms.TextBox tb_idcurso;
    }
}