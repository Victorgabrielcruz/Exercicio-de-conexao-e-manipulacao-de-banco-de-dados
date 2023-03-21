namespace Trabalho_ds_C_
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.lbl_Menu = new System.Windows.Forms.Label();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btn_ListarAluno = new System.Windows.Forms.Button();
            this.btn_LimparRegistro = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Menu
            // 
            this.lbl_Menu.AutoSize = true;
            this.lbl_Menu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Menu.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Menu.Location = new System.Drawing.Point(137, 9);
            this.lbl_Menu.Name = "lbl_Menu";
            this.lbl_Menu.Size = new System.Drawing.Size(128, 57);
            this.lbl_Menu.TabIndex = 5;
            this.lbl_Menu.Text = "Menu";
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastrar.Location = new System.Drawing.Point(278, 103);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(114, 30);
            this.btn_Cadastrar.TabIndex = 7;
            this.btn_Cadastrar.Text = "Inserir novo";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // btn_ListarAluno
            // 
            this.btn_ListarAluno.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListarAluno.Location = new System.Drawing.Point(278, 148);
            this.btn_ListarAluno.Name = "btn_ListarAluno";
            this.btn_ListarAluno.Size = new System.Drawing.Size(114, 30);
            this.btn_ListarAluno.TabIndex = 8;
            this.btn_ListarAluno.Text = "Listar Aluno";
            this.btn_ListarAluno.UseVisualStyleBackColor = true;
            this.btn_ListarAluno.Click += new System.EventHandler(this.btn_ListarAluno_Click);
            // 
            // btn_LimparRegistro
            // 
            this.btn_LimparRegistro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LimparRegistro.Location = new System.Drawing.Point(278, 193);
            this.btn_LimparRegistro.Name = "btn_LimparRegistro";
            this.btn_LimparRegistro.Size = new System.Drawing.Size(114, 36);
            this.btn_LimparRegistro.TabIndex = 9;
            this.btn_LimparRegistro.Text = "Limpar Registro";
            this.btn_LimparRegistro.UseVisualStyleBackColor = true;
            this.btn_LimparRegistro.Click += new System.EventHandler(this.btn_LimparRegistro_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(278, 249);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(114, 30);
            this.btn_sair.TabIndex = 10;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_LimparRegistro);
            this.Controls.Add(this.btn_ListarAluno);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.lbl_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Menu;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button btn_ListarAluno;
        private System.Windows.Forms.Button btn_LimparRegistro;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

