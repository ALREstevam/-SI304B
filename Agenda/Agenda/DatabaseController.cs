using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace Database
{
    public class DatabaseController
    {
        private string filePath;
        private string connectionStr;

        public DatabaseController(string filePath)
        {
            this.filePath = filePath;
            this.connectionStr = "Data Source="+filePath;
        }

        public bool dbCreate()
        {
            if (!File.Exists(this.filePath))
            {
                SQLiteConnection.CreateFile(this.filePath);//Se .db não existir
                SQLiteConnection conn = dbConnect();//Conectar

                StringBuilder sql = new StringBuilder();

                sql.AppendLine("CREATE TABLE IF NOT EXISTS AgendaItem (");
                sql.AppendLine("[id] integer PRIMARY KEY AUTOINCREMENT,");
                sql.AppendLine("[name] varchar(50) DEFAULT 'Tarefa sem nome',");
                sql.AppendLine("[description] string(500) DEFAULT 'Tarefa sem descrição',");
                sql.AppendLine("[type] integer NOT NULL,");
                sql.AppendLine("[importance] integer NOT NULL");
                sql.AppendLine(");");

                if(dbExecuteQuery(sql.ToString(), conn))//Tentando criar o banco
                {
                    MessageBox.Show("O banco de dados foi criado com sucesso.","Sucesso",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else//Caso não ocorra com sucesso
                {
                    System.IO.File.Delete(this.filePath);//Deleta o arquivo criado
                    MessageBox.Show("Erro ao criar o banco de dados, o arquivo criado será deletado.\nPor favor, inclua essa mensagem num bug report.", 
                        "Erro ao criar banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                return true;
            }
            //MessageBox.Show("O banco de dados já existia", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        public SQLiteConnection dbConnect()
        {
            SQLiteConnection conn = new SQLiteConnection(this.connectionStr);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        public void dbDisconnect(SQLiteConnection conn)
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public bool dbExecuteQuery(string query, SQLiteConnection conn)
        {
            SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conn);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar comando: " + ex.Message, "Erro no banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


    }
}

