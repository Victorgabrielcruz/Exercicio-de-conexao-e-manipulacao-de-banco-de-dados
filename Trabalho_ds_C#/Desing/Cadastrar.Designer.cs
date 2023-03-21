namespace Trabalho_ds_C_.Desing
{
    partial class Cadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar));
            this.lbl_CadastrAluno = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.Tx_Id = new System.Windows.Forms.TextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.Tx_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Nota = new System.Windows.Forms.Label();
            this.Tx_Nota = new System.Windows.Forms.TextBox();
            this.lbl_Diciplina = new System.Windows.Forms.Label();
            this.Tx_Diciplina = new System.Windows.Forms.TextBox();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_CadastrAluno
            // 
            this.lbl_CadastrAluno.AutoSize = true;
            this.lbl_CadastrAluno.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_CadastrAluno.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CadastrAluno.Location = new System.Drawing.Point(86, 9);
            this.lbl_CadastrAluno.Name = "lbl_CadastrAluno";
            this.lbl_CadastrAluno.Size = new System.Drawing.Size(245, 43);
            this.lbl_CadastrAluno.TabIndex = 5;
            this.lbl_CadastrAluno.Text = "Cadastra Aluno";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(43, 86);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(24, 20);
            this.lbl_id.TabIndex = 10;
            this.lbl_id.Text = "ID:";
            // 
            // Tx_Id
            // 
            this.Tx_Id.Location = new System.Drawing.Point(47, 109);
            this.Tx_Id.MaxLength = 5;
            this.Tx_Id.Name = "Tx_Id";
            this.Tx_Id.Size = new System.Drawing.Size(167, 20);
            this.Tx_Id.TabIndex = 11;
            this.Tx_Id.TextChanged += new System.EventHandler(this.Tx_Id_TextChanged);
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.Location = new System.Drawing.Point(43, 143);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(46, 20);
            this.lbl_Nome.TabIndex = 12;
            this.lbl_Nome.Text = "Nome:";
            // 
            // Tx_Nome
            // 
            this.Tx_Nome.Location = new System.Drawing.Point(47, 166);
            this.Tx_Nome.MaxLength = 45;
            this.Tx_Nome.MinimumSize = new System.Drawing.Size(167, 20);
            this.Tx_Nome.Name = "Tx_Nome";
            this.Tx_Nome.Size = new System.Drawing.Size(167, 20);
            this.Tx_Nome.TabIndex = 13;
            // 
            // lbl_Nota
            // 
            this.lbl_Nota.AutoSize = true;
            this.lbl_Nota.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nota.Location = new System.Drawing.Point(43, 200);
            this.lbl_Nota.Name = "lbl_Nota";
            this.lbl_Nota.Size = new System.Drawing.Size(38, 20);
            this.lbl_Nota.TabIndex = 14;
            this.lbl_Nota.Text = "Nota:";
            // 
            // Tx_Nota
            // 
            this.Tx_Nota.Location = new System.Drawing.Point(47, 223);
            this.Tx_Nota.MinimumSize = new System.Drawing.Size(167, 20);
            this.Tx_Nota.Name = "Tx_Nota";
            this.Tx_Nota.Size = new System.Drawing.Size(167, 20);
            this.Tx_Nota.TabIndex = 15;
            this.Tx_Nota.TextChanged += new System.EventHandler(this.Tx_Nota_TextChanged);
            // 
            // lbl_Diciplina
            // 
            this.lbl_Diciplina.AutoSize = true;
            this.lbl_Diciplina.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Diciplina.Location = new System.Drawing.Point(43, 257);
            this.lbl_Diciplina.Name = "lbl_Diciplina";
            this.lbl_Diciplina.Size = new System.Drawing.Size(61, 20);
            this.lbl_Diciplina.TabIndex = 16;
            this.lbl_Diciplina.Text = "Diciplina:";
            // 
            // Tx_Diciplina
            // 
            this.Tx_Diciplina.Location = new System.Drawing.Point(47, 280);
            this.Tx_Diciplina.MinimumSize = new System.Drawing.Size(167, 20);
            this.Tx_Diciplina.Name = "Tx_Diciplina";
            this.Tx_Diciplina.Size = new System.Drawing.Size(167, 20);
            this.Tx_Diciplina.TabIndex = 17;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastrar.Location = new System.Drawing.Point(277, 190);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(114, 30);
            this.btn_Cadastrar.TabIndex = 18;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(277, 247);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(114, 30);
            this.btn_voltar.TabIndex = 19;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.Tx_Diciplina);
            this.Controls.Add(this.lbl_Diciplina);
            this.Controls.Add(this.Tx_Nota);
            this.Controls.Add(this.lbl_Nota);
            this.Controls.Add(this.Tx_Nome);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.Tx_Id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_CadastrAluno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CadastrAluno;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox Tx_Id;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.TextBox Tx_Nome;
        private System.Windows.Forms.Label lbl_Nota;
        private System.Windows.Forms.TextBox Tx_Nota;
        private System.Windows.Forms.Label lbl_Diciplina;
        private System.Windows.Forms.TextBox Tx_Diciplina;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button btn_voltar;
    }
}