namespace ProjetinhoEscola
{
    partial class F_GerenciamentoProfessor
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
            this.lb_sexo = new System.Windows.Forms.Label();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.tb_telefone = new System.Windows.Forms.TextBox();
            this.lb_telefone = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.tb_birthdate = new System.Windows.Forms.TextBox();
            this.lb_birthdate = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.lb_nome = new System.Windows.Forms.Label();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_sexo
            // 
            this.lb_sexo.AutoSize = true;
            this.lb_sexo.Location = new System.Drawing.Point(9, 173);
            this.lb_sexo.Name = "lb_sexo";
            this.lb_sexo.Size = new System.Drawing.Size(31, 13);
            this.lb_sexo.TabIndex = 19;
            this.lb_sexo.Text = "Sexo";
            // 
            // cb_sexo
            // 
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cb_sexo.Location = new System.Drawing.Point(12, 189);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(241, 21);
            this.cb_sexo.TabIndex = 18;
            // 
            // tb_telefone
            // 
            this.tb_telefone.Location = new System.Drawing.Point(12, 149);
            this.tb_telefone.Name = "tb_telefone";
            this.tb_telefone.Size = new System.Drawing.Size(241, 20);
            this.tb_telefone.TabIndex = 17;
            // 
            // lb_telefone
            // 
            this.lb_telefone.AutoSize = true;
            this.lb_telefone.Location = new System.Drawing.Point(9, 133);
            this.lb_telefone.Name = "lb_telefone";
            this.lb_telefone.Size = new System.Drawing.Size(49, 13);
            this.lb_telefone.TabIndex = 16;
            this.lb_telefone.Text = "Telefone";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(12, 109);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(241, 20);
            this.tb_email.TabIndex = 15;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(9, 93);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(32, 13);
            this.lb_email.TabIndex = 14;
            this.lb_email.Text = "Email";
            // 
            // tb_birthdate
            // 
            this.tb_birthdate.Location = new System.Drawing.Point(12, 71);
            this.tb_birthdate.Name = "tb_birthdate";
            this.tb_birthdate.Size = new System.Drawing.Size(241, 20);
            this.tb_birthdate.TabIndex = 13;
            // 
            // lb_birthdate
            // 
            this.lb_birthdate.AutoSize = true;
            this.lb_birthdate.Location = new System.Drawing.Point(9, 55);
            this.lb_birthdate.Name = "lb_birthdate";
            this.lb_birthdate.Size = new System.Drawing.Size(104, 13);
            this.lb_birthdate.TabIndex = 12;
            this.lb_birthdate.Text = "Data de Nascimento";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(12, 29);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(241, 20);
            this.tb_nome.TabIndex = 11;
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(9, 13);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(35, 13);
            this.lb_nome.TabIndex = 10;
            this.lb_nome.Text = "Nome";
            // 
            // bt_fechar
            // 
            this.bt_fechar.Location = new System.Drawing.Point(175, 251);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(75, 23);
            this.bt_fechar.TabIndex = 22;
            this.bt_fechar.Text = "Fechar";
            this.bt_fechar.UseVisualStyleBackColor = true;
            // 
            // bt_limpar
            // 
            this.bt_limpar.Location = new System.Drawing.Point(93, 251);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(75, 23);
            this.bt_limpar.TabIndex = 21;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            // 
            // bt_salvar
            // 
            this.bt_salvar.Location = new System.Drawing.Point(12, 251);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(75, 23);
            this.bt_salvar.TabIndex = 20;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            // 
            // F_GerenciamentoProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_fechar);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.lb_sexo);
            this.Controls.Add(this.cb_sexo);
            this.Controls.Add(this.tb_telefone);
            this.Controls.Add(this.lb_telefone);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.tb_birthdate);
            this.Controls.Add(this.lb_birthdate);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lb_nome);
            this.Name = "F_GerenciamentoProfessor";
            this.Text = "F_GerenciamentoProfessor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb_sexo;
        public System.Windows.Forms.ComboBox cb_sexo;
        public System.Windows.Forms.TextBox tb_telefone;
        public System.Windows.Forms.Label lb_telefone;
        public System.Windows.Forms.TextBox tb_email;
        public System.Windows.Forms.Label lb_email;
        public System.Windows.Forms.TextBox tb_birthdate;
        public System.Windows.Forms.Label lb_birthdate;
        public System.Windows.Forms.TextBox tb_nome;
        public System.Windows.Forms.Label lb_nome;
        public System.Windows.Forms.Button bt_fechar;
        public System.Windows.Forms.Button bt_limpar;
        public System.Windows.Forms.Button bt_salvar;
    }
}