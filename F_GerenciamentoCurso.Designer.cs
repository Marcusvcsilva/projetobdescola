namespace ProjetinhoEscola
{
    partial class F_GerenciamentoCurso
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
            this.bt_fechar = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.cb_area = new System.Windows.Forms.ComboBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.lb_area = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.lb_nome = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_fechar
            // 
            this.bt_fechar.Location = new System.Drawing.Point(177, 307);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(75, 23);
            this.bt_fechar.TabIndex = 20;
            this.bt_fechar.Text = "Fechar";
            this.bt_fechar.UseVisualStyleBackColor = true;
            // 
            // bt_limpar
            // 
            this.bt_limpar.Location = new System.Drawing.Point(96, 307);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(75, 23);
            this.bt_limpar.TabIndex = 19;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            // 
            // bt_salvar
            // 
            this.bt_salvar.Location = new System.Drawing.Point(15, 307);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(75, 23);
            this.bt_salvar.TabIndex = 18;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            // 
            // cb_area
            // 
            this.cb_area.FormattingEnabled = true;
            this.cb_area.Items.AddRange(new object[] {
            "Comunicação e Marketing",
            "Gestão e Negócios",
            "Tecnologia da Informação "});
            this.cb_area.Location = new System.Drawing.Point(14, 70);
            this.cb_area.Name = "cb_area";
            this.cb_area.Size = new System.Drawing.Size(112, 21);
            this.cb_area.TabIndex = 17;
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "Inscrições Abertas",
            "Ativo",
            "Inativo"});
            this.cb_status.Location = new System.Drawing.Point(139, 70);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(112, 21);
            this.cb_status.TabIndex = 16;
            // 
            // lb_area
            // 
            this.lb_area.AutoSize = true;
            this.lb_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_area.Location = new System.Drawing.Point(9, 51);
            this.lb_area.Name = "lb_area";
            this.lb_area.Size = new System.Drawing.Size(36, 16);
            this.lb_area.TabIndex = 15;
            this.lb_area.Text = "Area";
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.Location = new System.Drawing.Point(207, 51);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(44, 16);
            this.lb_status.TabIndex = 14;
            this.lb_status.Text = "Status";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(12, 28);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(239, 20);
            this.tb_nome.TabIndex = 13;
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(12, 9);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(44, 16);
            this.lb_nome.TabIndex = 12;
            this.lb_nome.Text = "Nome";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(237, 204);
            this.dataGridView1.TabIndex = 21;
            // 
            // F_GerenciamentoCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 342);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_fechar);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.cb_area);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.lb_area);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lb_nome);
            this.Name = "F_GerenciamentoCurso";
            this.Text = "Gerenciamento de Cursos";
            this.Load += new System.EventHandler(this.F_GerenciamentoCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.ComboBox cb_area;
        private System.Windows.Forms.ComboBox cb_status;
        public System.Windows.Forms.Label lb_area;
        public System.Windows.Forms.Label lb_status;
        public System.Windows.Forms.TextBox tb_nome;
        public System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}