namespace ProjetinhoEscola
{
    partial class F_Curso
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
            this.lb_status = new System.Windows.Forms.Label();
            this.lb_area = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.cb_area = new System.Windows.Forms.ComboBox();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(15, 17);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(44, 16);
            this.lb_nome.TabIndex = 0;
            this.lb_nome.Text = "Nome";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(15, 36);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(240, 20);
            this.tb_nome.TabIndex = 1;
            this.tb_nome.TextChanged += new System.EventHandler(this.tb_nome_TextChanged);
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.Location = new System.Drawing.Point(211, 87);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(44, 16);
            this.lb_status.TabIndex = 2;
            this.lb_status.Text = "Status";
            // 
            // lb_area
            // 
            this.lb_area.AutoSize = true;
            this.lb_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_area.Location = new System.Drawing.Point(13, 87);
            this.lb_area.Name = "lb_area";
            this.lb_area.Size = new System.Drawing.Size(36, 16);
            this.lb_area.TabIndex = 4;
            this.lb_area.Text = "Area";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "Inscrições Abertas",
            "Ativo",
            "Inativo"});
            this.cb_status.Location = new System.Drawing.Point(143, 106);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(112, 21);
            this.cb_status.TabIndex = 7;
            this.cb_status.SelectedIndexChanged += new System.EventHandler(this.cb_status_SelectedIndexChanged);
            // 
            // cb_area
            // 
            this.cb_area.FormattingEnabled = true;
            this.cb_area.Items.AddRange(new object[] {
            "Comunicação e Marketing",
            "Gestão e Negócios",
            "Tecnologia da Informação "});
            this.cb_area.Location = new System.Drawing.Point(18, 106);
            this.cb_area.Name = "cb_area";
            this.cb_area.Size = new System.Drawing.Size(112, 21);
            this.cb_area.TabIndex = 8;
            // 
            // bt_salvar
            // 
            this.bt_salvar.Location = new System.Drawing.Point(18, 142);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(75, 23);
            this.bt_salvar.TabIndex = 9;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.Location = new System.Drawing.Point(99, 142);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(75, 23);
            this.bt_limpar.TabIndex = 10;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // bt_fechar
            // 
            this.bt_fechar.Location = new System.Drawing.Point(180, 142);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(75, 23);
            this.bt_fechar.TabIndex = 11;
            this.bt_fechar.Text = "Fechar";
            this.bt_fechar.UseVisualStyleBackColor = true;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // F_Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 176);
            this.Controls.Add(this.bt_fechar);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.cb_area);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.lb_area);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lb_nome);
            this.Name = "F_Curso";
            this.Text = "F_Curso";
            this.Load += new System.EventHandler(this.F_Curso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb_nome;
        public System.Windows.Forms.TextBox tb_nome;
        public System.Windows.Forms.Label lb_status;
        public System.Windows.Forms.Label lb_area;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.ComboBox cb_area;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.Button bt_fechar;
    }
}