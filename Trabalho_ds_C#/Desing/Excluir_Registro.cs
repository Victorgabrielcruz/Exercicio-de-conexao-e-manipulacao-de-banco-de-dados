/**
Arquivo que contém a implementação do formulário de exclusão de registro
@author Víctor Gabriel Cruz Pereira

**/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_ds_C_.Model;

namespace Trabalho_ds_C_.Desing
{
    public partial class Excluir_Registro : Form
    {
        public Excluir_Registro()
        {
            InitializeComponent();
        }
/*-----------------------------------------------------------------------------------------------------------*/
        private void btn_LimparRegistro_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            string mensagem = controle.Limpar_registro(Tx_Id.Text);
            if (controle.op)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tx_Id.Clear();
            }
            else
            {
                MessageBox.Show(mensagem, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
/*-----------------------------------------------------------------------------------------------------------*/
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
/*-----------------------------------------------------------------------------------------------------------*/
        private void Tx_Id_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Tx_Id.Text))
            {
                if (!int.TryParse(Tx_Id.Text, out int result))
                {
                    Tx_Id.Clear();
                    MessageBox.Show("Insira apenas numeros nesse campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
