/**
Arquivo de controle entre o banco de dados e o formulario
de modo que seja um intermediario entre os dois recebendo e mandando as informações necessarias
@author Víctor Gabriel Cruz Pereira

**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Xml.Linq;
using System.Data;

namespace Trabalho_ds_C_.Model
{
    internal class Controle
    {
        public string menssagem;
        public bool op;
        public DataTable dataTable = new DataTable();
/*-----------------------------------------------------------------------------------------------------------*/
        public string Cadastro(String ID, String Name, String Nota, String Diciplina)
        {
            Comandos comand = new Comandos();
            this.menssagem = comand.Cadastrar(ID, Name, Nota, Diciplina);
            this.op = comand.op;
            return menssagem;
        }
/*-----------------------------------------------------------------------------------------------------------*/
        public string Limpar_registro(String id)
        {
            Comandos comand = new Comandos();
            this.menssagem = comand.Limpar_Registro(id);
            this.op = comand.op;
            return menssagem;
        }
/*-----------------------------------------------------------------------------------------------------------*/
        public string Lista_aluno(String Nota)
        {
            Comandos comand = new Comandos();
            this.dataTable = comand.Lista_aluno(Nota);
            this.op = comand.op;
            this.menssagem = comand.mensagem;
            return menssagem;
        }

    }
}
