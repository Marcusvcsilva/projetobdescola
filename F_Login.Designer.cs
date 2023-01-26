namespace ProjetinhoEscola
{
    partial class F_Login
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
            this.tb_user = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.tbsenha = new System.Windows.Forms.TextBox();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.buttoncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(12, 67);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(239, 20);
            this.tb_user.TabIndex = 0;
            this.tb_user.Text = "diogo";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(9, 42);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(43, 13);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Usuário";
            this.lb1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(12, 99);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(38, 13);
            this.lb2.TabIndex = 2;
            this.lb2.Text = "Senha";
            // 
            // tbsenha
            // 
            this.tbsenha.Location = new System.Drawing.Point(12, 127);
            this.tbsenha.Name = "tbsenha";
            this.tbsenha.PasswordChar = '*';
            this.tbsenha.Size = new System.Drawing.Size(239, 20);
            this.tbsenha.TabIndex = 3;
            this.tbsenha.Text = "1234";
            this.tbsenha.TextChanged += new System.EventHandler(this.tbsenha_TextChanged);
            // 
            // buttonlogin
            // 
            this.buttonlogin.Location = new System.Drawing.Point(12, 194);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(238, 27);
            this.buttonlogin.TabIndex = 4;
            this.buttonlogin.Text = "Login";
            this.buttonlogin.UseVisualStyleBackColor = true;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // buttoncancelar
            // 
            this.buttoncancelar.Location = new System.Drawing.Point(12, 227);
            this.buttoncancelar.Name = "buttoncancelar";
            this.buttoncancelar.Size = new System.Drawing.Size(237, 27);
            this.buttoncancelar.TabIndex = 5;
            this.buttoncancelar.Text = "Cancelar";
            this.buttoncancelar.UseVisualStyleBackColor = true;
            this.buttoncancelar.Click += new System.EventHandler(this.buttoncancelar_Click);
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 266);
            this.Controls.Add(this.buttoncancelar);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.tbsenha);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.tb_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.F_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox tbsenha;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Button buttoncancelar;
    }
}