namespace Trabalho_ds_C_.Desing
{
    partial class Listar_Aluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listar_Aluno));
            this.lbl_ListarAluno = new System.Windows.Forms.Label();
            this.lbl_Nota = new System.Windows.Forms.Label();
            this.Tx_Nota = new System.Windows.Forms.TextBox();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_listar = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ListarAluno
            // 
            this.lbl_ListarAluno.AutoSize = true;
            this.lbl_ListarAluno.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_ListarAluno.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ListarAluno.Location = new System.Drawing.Point(108, 9);
            this.lbl_ListarAluno.Name = "lbl_ListarAluno";
            this.lbl_ListarAluno.Size = new System.Drawing.Size(200, 43);
            this.lbl_ListarAluno.TabIndex = 6;
            this.lbl_ListarAluno.Text = "Listar aluno ";
            // 
            // lbl_Nota
            // 
            this.lbl_Nota.AutoSize = true;
            this.lbl_Nota.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nota.Location = new System.Drawing.Point(12, 80);
            this.lbl_Nota.Name = "lbl_Nota";
            this.lbl_Nota.Size = new System.Drawing.Size(38, 20);
            this.lbl_Nota.TabIndex = 15;
            this.lbl_Nota.Text = "Nota:";
            // 
            // Tx_Nota
            // 
            this.Tx_Nota.Location = new System.Drawing.Point(16, 103);
            this.Tx_Nota.MinimumSize = new System.Drawing.Size(167, 29);
            this.Tx_Nota.Name = "Tx_Nota";
            this.Tx_Nota.Size = new System.Drawing.Size(167, 20);
            this.Tx_Nota.TabIndex = 16;
            this.Tx_Nota.TextChanged += new System.EventHandler(this.Tx_Nota_TextChanged);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.Location = new System.Drawing.Point(16, 320);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(114, 29);
            this.btn_Limpar.TabIndex = 19;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(331, 150);
            this.dataGridView1.TabIndex = 20;
            // 
            // btn_listar
            // 
            this.btn_listar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listar.Location = new System.Drawing.Point(161, 320);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(114, 29);
            this.btn_listar.TabIndex = 21;
            this.btn_listar.Text = "Listar";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar.Location = new System.Drawing.Point(308, 320);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(114, 29);
            this.btn_Voltar.TabIndex = 22;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // Listar_Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.Tx_Nota);
            this.Controls.Add(this.lbl_Nota);
            this.Controls.Add(this.lbl_ListarAluno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Listar_Aluno";
            this.Text = "Listar_Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ListarAluno;
        private System.Windows.Forms.Label lbl_Nota;
        private System.Windows.Forms.TextBox Tx_Nota;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.Button btn_Voltar;
    }
}