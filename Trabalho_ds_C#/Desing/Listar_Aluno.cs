/**
Arquivo que contém a implementação do formulário que lista os alunos por nota
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
    public partial class Listar_Aluno : Form
    {
        public Listar_Aluno()
        {
            InitializeComponent();
        }
/*-----------------------------------------------------------------------------------------------------------*/
        private void button1_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            string mensagem;
            mensagem = controle.Lista_aluno(Tx_Nota.Text);
            if (controle.op)
            {
                dataGridView1.DataSource = controle.dataTable;
                Tx_Nota.Clear();
            }
            else
            {
                MessageBox.Show(mensagem, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
/*-----------------------------------------------------------------------------------------------------------*/
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataGridView1.DataSource = dataTable;
        }
/*-----------------------------------------------------------------------------------------------------------*/
        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();


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
