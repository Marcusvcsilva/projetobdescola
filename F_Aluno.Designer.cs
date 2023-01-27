namespace ProjetinhoEscola
{
    partial class F_Aluno
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
            this.lb_email = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lb_telefone = new System.Windows.Forms.Label();
            this.tb_telefone = new System.Windows.Forms.TextBox();
            this.lb_cpf = new System.Windows.Forms.Label();
            this.tb_cpf = new System.Windows.Forms.TextBox();
            this.tb_rg = new System.Windows.Forms.TextBox();
            this.lb_rg = new System.Windows.Forms.Label();
            this.lb_sexo = new System.Windows.Forms.Label();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.lb_senha = new System.Windows.Forms.Label();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.lb_cep = new System.Windows.Forms.Label();
            this.tb_cep = new System.Windows.Forms.TextBox();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.lb_numero = new System.Windows.Forms.Label();
            this.tb_numero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(9, 12);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(35, 13);
            this.lb_nome.TabIndex = 0;
            this.lb_nome.Text = "Nome";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(12, 28);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(237, 20);
            this.tb_nome.TabIndex = 1;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(9, 61);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(32, 13);
            this.lb_email.TabIndex = 2;
            this.lb_email.Text = "Email";
            this.lb_email.Click += new System.EventHandler(this.lb_email_Click);
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(12, 77);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(237, 20);
            this.tb_email.TabIndex = 3;
            // 
            // lb_telefone
            // 
            this.lb_telefone.AutoSize = true;
            this.lb_telefone.Location = new System.Drawing.Point(9, 103);
            this.lb_telefone.Name = "lb_telefone";
            this.lb_telefone.Size = new System.Drawing.Size(49, 13);
            this.lb_telefone.TabIndex = 4;
            this.lb_telefone.Text = "Telefone";
            // 
            // tb_telefone
            // 
            this.tb_telefone.Location = new System.Drawing.Point(12, 120);
            this.tb_telefone.Name = "tb_telefone";
            this.tb_telefone.Size = new System.Drawing.Size(237, 20);
            this.tb_telefone.TabIndex = 5;
            // 
            // lb_cpf
            // 
            this.lb_cpf.AutoSize = true;
            this.lb_cpf.Location = new System.Drawing.Point(9, 145);
            this.lb_cpf.Name = "lb_cpf";
            this.lb_cpf.Size = new System.Drawing.Size(27, 13);
            this.lb_cpf.TabIndex = 6;
            this.lb_cpf.Text = "CPF";
            // 
            // tb_cpf
            // 
            this.tb_cpf.Location = new System.Drawing.Point(12, 161);
            this.tb_cpf.Name = "tb_cpf";
            this.tb_cpf.Size = new System.Drawing.Size(237, 20);
            this.tb_cpf.TabIndex = 7;
            // 
            // tb_rg
            // 
            this.tb_rg.Location = new System.Drawing.Point(12, 206);
            this.tb_rg.Name = "tb_rg";
            this.tb_rg.Size = new System.Drawing.Size(237, 20);
            this.tb_rg.TabIndex = 8;
            // 
            // lb_rg
            // 
            this.lb_rg.AutoSize = true;
            this.lb_rg.Location = new System.Drawing.Point(9, 190);
            this.lb_rg.Name = "lb_rg";
            this.lb_rg.Size = new System.Drawing.Size(23, 13);
            this.lb_rg.TabIndex = 9;
            this.lb_rg.Text = "RG";
            // 
            // lb_sexo
            // 
            this.lb_sexo.AutoSize = true;
            this.lb_sexo.Location = new System.Drawing.Point(218, 361);
            this.lb_sexo.Name = "lb_sexo";
            this.lb_sexo.Size = new System.Drawing.Size(31, 13);
            this.lb_sexo.TabIndex = 10;
            this.lb_sexo.Text = "Sexo";
            // 
            // cb_sexo
            // 
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Prefiro não responder"});
            this.cb_sexo.Location = new System.Drawing.Point(105, 377);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(144, 21);
            this.cb_sexo.TabIndex = 11;
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Location = new System.Drawing.Point(9, 238);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(38, 13);
            this.lb_senha.TabIndex = 12;
            this.lb_senha.Text = "Senha";
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(12, 254);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(237, 20);
            this.tb_senha.TabIndex = 13;
            // 
            // lb_cep
            // 
            this.lb_cep.AutoSize = true;
            this.lb_cep.Location = new System.Drawing.Point(9, 283);
            this.lb_cep.Name = "lb_cep";
            this.lb_cep.Size = new System.Drawing.Size(28, 13);
            this.lb_cep.TabIndex = 14;
            this.lb_cep.Text = "CEP";
            // 
            // tb_cep
            // 
            this.tb_cep.Location = new System.Drawing.Point(12, 299);
            this.tb_cep.Name = "tb_cep";
            this.tb_cep.PasswordChar = '*';
            this.tb_cep.Size = new System.Drawing.Size(237, 20);
            this.tb_cep.TabIndex = 15;
            // 
            // bt_salvar
            // 
            this.bt_salvar.Location = new System.Drawing.Point(12, 446);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(75, 23);
            this.bt_salvar.TabIndex = 16;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.Location = new System.Drawing.Point(93, 446);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(75, 23);
            this.bt_limpar.TabIndex = 17;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            // 
            // bt_fechar
            // 
            this.bt_fechar.Location = new System.Drawing.Point(175, 446);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(75, 23);
            this.bt_fechar.TabIndex = 18;
            this.bt_fechar.Text = "Fechar";
            this.bt_fechar.UseVisualStyleBackColor = true;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Endereço";
            // 
            // tb_endereco
            // 
            this.tb_endereco.Location = new System.Drawing.Point(12, 338);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.PasswordChar = '*';
            this.tb_endereco.Size = new System.Drawing.Size(237, 20);
            this.tb_endereco.TabIndex = 20;
            this.tb_endereco.TextChanged += new System.EventHandler(this.tb_endereco_TextChanged);
            // 
            // lb_numero
            // 
            this.lb_numero.AutoSize = true;
            this.lb_numero.Location = new System.Drawing.Point(9, 361);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(44, 13);
            this.lb_numero.TabIndex = 21;
            this.lb_numero.Text = "Número";
            // 
            // tb_numero
            // 
            this.tb_numero.Location = new System.Drawing.Point(12, 378);
            this.tb_numero.Name = "tb_numero";
            this.tb_numero.PasswordChar = '*';
            this.tb_numero.Size = new System.Drawing.Size(75, 20);
            this.tb_numero.TabIndex = 22;
            // 
            // F_Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 479);
            this.Controls.Add(this.tb_numero);
            this.Controls.Add(this.lb_numero);
            this.Controls.Add(this.tb_endereco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_fechar);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.tb_cep);
            this.Controls.Add(this.lb_cep);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.lb_senha);
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
            this.Name = "F_Aluno";
            this.Text = "F_Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb_nome;
        public System.Windows.Forms.TextBox tb_nome;
        public System.Windows.Forms.Label lb_email;
        public System.Windows.Forms.TextBox tb_email;
        public System.Windows.Forms.Label lb_telefone;
        public System.Windows.Forms.TextBox tb_telefone;
        public System.Windows.Forms.Label lb_cpf;
        public System.Windows.Forms.TextBox tb_cpf;
        public System.Windows.Forms.TextBox tb_rg;
        public System.Windows.Forms.Label lb_rg;
        public System.Windows.Forms.Label lb_sexo;
        public System.Windows.Forms.ComboBox cb_sexo;
        public System.Windows.Forms.Label lb_senha;
        public System.Windows.Forms.TextBox tb_senha;
        public System.Windows.Forms.Label lb_cep;
        public System.Windows.Forms.TextBox tb_cep;
        public System.Windows.Forms.Button bt_salvar;
        public System.Windows.Forms.Button bt_limpar;
        public System.Windows.Forms.Button bt_fechar;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tb_endereco;
        public System.Windows.Forms.Label lb_numero;
        public System.Windows.Forms.TextBox tb_numero;
    }
}