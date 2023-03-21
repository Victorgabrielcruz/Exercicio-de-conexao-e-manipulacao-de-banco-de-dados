namespace Trabalho_ds_C_.Desing
{
    partial class Excluir_Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Excluir_Registro));
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_Excluir = new System.Windows.Forms.Label();
            this.Tx_Id = new System.Windows.Forms.TextBox();
            this.btn_LimparRegistro = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(54, 85);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(24, 20);
            this.lbl_id.TabIndex = 11;
            this.lbl_id.Text = "ID:";
            // 
            // lbl_Excluir
            // 
            this.lbl_Excluir.AutoSize = true;
            this.lbl_Excluir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Excluir.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Excluir.Location = new System.Drawing.Point(84, 26);
            this.lbl_Excluir.Name = "lbl_Excluir";
            this.lbl_Excluir.Size = new System.Drawing.Size(253, 43);
            this.lbl_Excluir.TabIndex = 12;
            this.lbl_Excluir.Text = "Limpar Registro";
            // 
            // Tx_Id
            // 
            this.Tx_Id.Location = new System.Drawing.Point(58, 117);
            this.Tx_Id.MaxLength = 5;
            this.Tx_Id.Name = "Tx_Id";
            this.Tx_Id.Size = new System.Drawing.Size(167, 20);
            this.Tx_Id.TabIndex = 13;
            this.Tx_Id.TextChanged += new System.EventHandler(this.Tx_Id_TextChanged);
            // 
            // btn_LimparRegistro
            // 
            this.btn_LimparRegistro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LimparRegistro.Location = new System.Drawing.Point(111, 163);
            this.btn_LimparRegistro.Name = "btn_LimparRegistro";
            this.btn_LimparRegistro.Size = new System.Drawing.Size(114, 36);
            this.btn_LimparRegistro.TabIndex = 14;
            this.btn_LimparRegistro.Text = "Limpar Registro";
            this.btn_LimparRegistro.UseVisualStyleBackColor = true;
            this.btn_LimparRegistro.Click += new System.EventHandler(this.btn_LimparRegistro_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(247, 166);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(114, 30);
            this.btn_voltar.TabIndex = 20;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // Excluir_Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 243);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_LimparRegistro);
            this.Controls.Add(this.Tx_Id);
            this.Controls.Add(this.lbl_Excluir);
            this.Controls.Add(this.lbl_id);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Excluir_Registro";
            this.Text = "Excluir_Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_Excluir;
        private System.Windows.Forms.TextBox Tx_Id;
        private System.Windows.Forms.Button btn_LimparRegistro;
        private System.Windows.Forms.Button btn_voltar;
    }
}