/**
Arquivo que contém a implementação do formulário de cadastro de alunos
@author Víctor Gabriel Cruz Pereira

**/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_ds_C_.Model;

namespace Trabalho_ds_C_.Desing
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }
/*-----------------------------------------------------------------------------------------------------------*/
        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            string mensagem = controle.Cadastro(Tx_Id.Text, Tx_Nome.Text, Tx_Nota.Text, Tx_Diciplina.Text);
            if (controle.op)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tx_Diciplina.Clear();
                Tx_Id.Clear();
                Tx_Nome.Clear();
                Tx_Nota.Clear();
            }
            else
            {
                MessageBox.Show(mensagem,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
/*-----------------------------------------------------------------------------------------------------------*/
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
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
/*-----------------------------------------------------------------------------------------------------------*/
        private void Tx_Nota_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Tx_Nota.Text))
            {
                if (!double.TryParse(Tx_Nota.Text, out double result))
                {
                    Tx_Nota.Clear();
                    MessageBox.Show("Insira apenas numeros nesse campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
