/**
Arquivo que realiza a conexão com o banco de dados
@author Víctor Gabriel Cruz Pereira

**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace Trabalho_ds_C_.Model
{
    internal class DataBase_Conection
    {
        public SQLiteConnection conn = new SQLiteConnection("Data Source=aluno.db");
/*-----------------------------------------------------------------------------------------------------------*/
        public SQLiteConnection conection()
        {
            if(conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();

            }
            return conn;
        }
/*-----------------------------------------------------------------------------------------------------------*/
        public void desconection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Close();

            }
        }
    }
}

