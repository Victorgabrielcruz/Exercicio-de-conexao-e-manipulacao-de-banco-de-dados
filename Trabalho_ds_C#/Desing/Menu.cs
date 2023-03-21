/**
Arquivo que contém a implementação do formulário do menu
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
using Trabalho_ds_C_.Desing;

namespace Trabalho_ds_C_
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
/*-----------------------------------------------------------------------------------------------------------*/
        private void Menu_Load(object sender, EventArgs e)
        {

        }
/*-----------------------------------------------------------------------------------------------------------*/
        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cadastrar = new Cadastrar();
            cadastrar.ShowDialog();
        }
/*-----------------------------------------------------------------------------------------------------------*/
        private void btn_ListarAluno_Click(object sender, EventArgs e)
        {
            Listar_Aluno listar_Aluno = new Listar_Aluno();
            listar_Aluno.ShowDialog();
        }
/*-----------------------------------------------------------------------------------------------------------*/
        private void btn_LimparRegistro_Click(object sender, EventArgs e)
        {
            Excluir_Registro excluir_Registro = new Excluir_Registro();
            excluir_Registro.ShowDialog();
        }
/*-----------------------------------------------------------------------------------------------------------*/
        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
