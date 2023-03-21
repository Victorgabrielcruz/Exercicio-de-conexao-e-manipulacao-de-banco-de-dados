/**
Arquivo que realiza os comandos de manipulação do banco de dados de acordo com os
requisitos solicitados
@author Víctor Gabriel Cruz Pereira

**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Trabalho_ds_C_.Model
{
    internal class Comandos
    {
        public bool verificacao = true, op = false,op1;
        public string mensagem;
        DataBase_Conection conn = new DataBase_Conection();
        SQLiteCommand cmd = new SQLiteCommand();
        SQLiteDataReader rd;
        DataTable dataTable = new DataTable();

/*-----------------------------------------------------------------------------------------------------------*/
        public bool Verifica(string Id)
        {
            cmd.CommandText = "select * from aluno where id =@Id";
            cmd.Parameters.AddWithValue("@Id", Id);
            try
            {
                cmd.Connection = conn.conection();
                rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    verificacao = false;
                    this.mensagem = "Ja existe um usuario com esse id";
                }
                else
                {
                    verificacao = true;
                }

            }
            catch (SQLiteException)
            {
                this.mensagem = "Erro de conexão com o banco de dados !";
            }
            finally
            {
                rd.Close();
            }

            return verificacao;
        }
/*-----------------------------------------------------------------------------------------------------------*/
        public bool Verifica_NomeDisciplina(string Nome, string disciplina)
        {
            cmd.CommandText = "select * from aluno where nome =@Nome";
            cmd.Parameters.AddWithValue("@nome", Nome);
            try
            {
                cmd.Connection = conn.conection();
                rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    verificacao = false;
                    rd.Close();
                    cmd.CommandText = "select * from aluno where disciplina =@disciplina";
                    cmd.Parameters.AddWithValue("@disciplina", disciplina);
                    cmd.Connection = conn.conection();
                    rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        verificacao = false;
                        this.mensagem = "Ja existe um usuario com esse nome e essa disciplina";
                    }
                    else
                    {
                        verificacao = true;

                    }
                }
                else
                {
                    verificacao = true;
                }

            }
            catch (SQLiteException)
            {
                this.mensagem = "Erro de conexão com o banco de dados !";
            }
            finally
            {
                rd.Close();
            }


            return verificacao;
        }
 /*-----------------------------------------------------------------------------------------------------------*/
        public string Cadastrar(String id, String nome, String nota, String disciplina)
        {
            op1 = Verifica(id);
            if (id == "" || nome == "" || nota == "" || disciplina == "")
            {
                this.mensagem = " Cadastro negado!! \n Todos os campos devem estar prenchidos para o cadastro ser realizado";
                op = false;
            }
            else 
            {
                if(double.Parse(nota)>= 0 && double.Parse(nota)<= 100)
                {
                    if (op1)
                    {
                        op1 = Verifica_NomeDisciplina(nome, disciplina);
                        if (op1)
                        {
                            cmd.CommandText = "insert into aluno values(@id, @nome, @nota, @disciplina)";
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@nome", nome);
                            cmd.Parameters.AddWithValue("@nota", nota);
                            cmd.Parameters.AddWithValue("@disciplina", disciplina);
                            try
                            {
                                cmd.Connection = conn.conection();
                                cmd.ExecuteNonQuery();
                                conn.desconection();
                                this.mensagem = "Cadastro bem sucessdido";
                                op = true;
                            }
                            catch (SQLiteException)
                            {
                                mensagem = "Erro de conexão com o banco de dados 1 !";
                            }
                        }  
                    }
                }
                else
                {
                    this.mensagem = " Cadastro negado!! \n Nota invalida";
                    op = false;
                }
                
            }
            op1 = false;
            return mensagem;
        }
/*-----------------------------------------------------------------------------------------------------------*/
        public string Limpar_Registro(String id)
        {
            op1 = Verifica(id);
            if (id == "")
            {
                this.mensagem = "Invalido ! \n Para limpar o registro prencha o campu do id";
                op = false;
            }
            else
            {
                if (!op1)
                {
                    cmd.CommandText = "DELETE FROM aluno WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id);

                    try
                    {
                        cmd.Connection = conn.conection();
                        cmd.ExecuteNonQuery();
                        conn.desconection();
                        this.mensagem = "Registro limpado com sucesso";
                        op = true;
                    }
                    catch (SQLiteException)
                    {
                        this.mensagem = "Erro de conexão com o banco de dados  1!";
                    }
                }
                else
                {
                    this.mensagem = "Não existe um usuario com esse id";

                }

            }
            return mensagem;
        }
/*-----------------------------------------------------------------------------------------------------------*/
        public DataTable Lista_aluno(String nota)
        {
            if(nota == "")
            {
                this.mensagem = "Invalido ! \n informe uma nota";
                op = false;
            }
            else
            {
                if (int.Parse(nota) >= 0 || int.Parse(nota) <= 100)
                {
                    
                    cmd.CommandText = "select * from aluno where nota >=@nota";
                    cmd.Parameters.AddWithValue("@nota", nota);

                    try
                    {
                        cmd.Connection = conn.conection();
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                        adapter.Fill(dataTable);

                        conn.desconection();
                        op = true;
                    }
                    catch (SQLiteException)
                    {
                        this.mensagem = "Erro de conexão com o banco de dados  1!";
                    }

                }

            }
            return dataTable;
        }
        

    }
    
}
