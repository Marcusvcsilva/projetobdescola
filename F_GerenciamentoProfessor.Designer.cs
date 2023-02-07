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
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.dgv_gerenciamentoprofessor = new System.Windows.Forms.DataGridView();
            this.tb_idprofessor = new System.Windows.Forms.TextBox();
            this.lb_idprofessor = new System.Windows.Forms.Label();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.bt_atualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gerenciamentoprofessor)).BeginInit();
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
            this.bt_fechar.Location = new System.Drawing.Point(303, 282);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(75, 23);
            this.bt_fechar.TabIndex = 22;
            this.bt_fechar.Text = "Fechar";
            this.bt_fechar.UseVisualStyleBackColor = true;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.Location = new System.Drawing.Point(231, 282);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(75, 23);
            this.bt_excluir.TabIndex = 21;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_salvar
            // 
            this.bt_salvar.Location = new System.Drawing.Point(15, 282);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(75, 23);
            this.bt_salvar.TabIndex = 20;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // dgv_gerenciamentoprofessor
            // 
            this.dgv_gerenciamentoprofessor.AllowUserToAddRows = false;
            this.dgv_gerenciamentoprofessor.AllowUserToDeleteRows = false;
            this.dgv_gerenciamentoprofessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gerenciamentoprofessor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_gerenciamentoprofessor.EnableHeadersVisualStyles = false;
            this.dgv_gerenciamentoprofessor.Location = new System.Drawing.Point(279, 30);
            this.dgv_gerenciamentoprofessor.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_gerenciamentoprofessor.MultiSelect = false;
            this.dgv_gerenciamentoprofessor.Name = "dgv_gerenciamentoprofessor";
            this.dgv_gerenciamentoprofessor.ReadOnly = true;
            this.dgv_gerenciamentoprofessor.RowHeadersVisible = false;
            this.dgv_gerenciamentoprofessor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_gerenciamentoprofessor.Size = new System.Drawing.Size(256, 245);
            this.dgv_gerenciamentoprofessor.TabIndex = 23;
            this.dgv_gerenciamentoprofessor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_gerenciamentoprofessor_CellContentClick);
            this.dgv_gerenciamentoprofessor.SelectionChanged += new System.EventHandler(this.dgv_gerenciamentoprofessor_SelectionChanged);
            // 
            // tb_idprofessor
            // 
            this.tb_idprofessor.Location = new System.Drawing.Point(12, 238);
            this.tb_idprofessor.Name = "tb_idprofessor";
            this.tb_idprofessor.Size = new System.Drawing.Size(100, 20);
            this.tb_idprofessor.TabIndex = 24;
            // 
            // lb_idprofessor
            // 
            this.lb_idprofessor.AutoSize = true;
            this.lb_idprofessor.Location = new System.Drawing.Point(12, 222);
            this.lb_idprofessor.Name = "lb_idprofessor";
            this.lb_idprofessor.Size = new System.Drawing.Size(18, 13);
            this.lb_idprofessor.TabIndex = 25;
            this.lb_idprofessor.Text = "ID";
            // 
            // bt_limpar
            // 
            this.bt_limpar.Location = new System.Drawing.Point(156, 282);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(75, 23);
            this.bt_limpar.TabIndex = 26;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // bt_atualizar
            // 
            this.bt_atualizar.Location = new System.Drawing.Point(85, 282);
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.Size = new System.Drawing.Size(75, 23);
            this.bt_atualizar.TabIndex = 27;
            this.bt_atualizar.Text = "Atualizar";
            this.bt_atualizar.UseVisualStyleBackColor = true;
            this.bt_atualizar.Click += new System.EventHandler(this.bt_atualizar_Click);
            // 
            // F_GerenciamentoProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 317);
            this.Controls.Add(this.bt_atualizar);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.lb_idprofessor);
            this.Controls.Add(this.tb_idprofessor);
            this.Controls.Add(this.dgv_gerenciamentoprofessor);
            this.Controls.Add(this.bt_fechar);
            this.Controls.Add(this.bt_excluir);
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
            this.Load += new System.EventHandler(this.F_GerenciamentoProfessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gerenciamentoprofessor)).EndInit();
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
        public System.Windows.Forms.Button bt_excluir;
        public System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.DataGridView dgv_gerenciamentoprofessor;
        private System.Windows.Forms.TextBox tb_idprofessor;
        private System.Windows.Forms.Label lb_idprofessor;
        public System.Windows.Forms.Button bt_limpar;
        public System.Windows.Forms.Button bt_atualizar;
    }
}