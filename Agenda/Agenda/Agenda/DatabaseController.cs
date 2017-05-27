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

        public string dbCreate()
        {
            if (!File.Exists(this.filePath))
            {
                SQLiteConnection.CreateFile(this.filePath);
                SQLiteConnection conn = dbConnect(this.connectionStr);

                StringBuilder sql = new StringBuilder();
                /*sql.AppendLine("CREATE TABLE IF NOT EXISTS tb_tasks ([id_task] INTEGER PRIMARY KEY AUTOINCREMENT,");
                sql.AppendLine("[name_task] VARCHAR(30) NOT NULL)");*/

                sql.AppendLine("CREATE TABLE IF NOT EXISTS AgendaItem (");
                sql.AppendLine("[id] integer PRIMARY KEY AUTOINCREMENT,");
                sql.AppendLine("[name] varchar(50),");
                sql.AppendLine("[description] string(500),");
                sql.AppendLine("[type] integer, NOT NUL");
                sql.AppendLine("[importance] integer NOT NULL");
                sql.AppendLine(");");

                dbExecuteQuery(sql.ToString(), conn);
                return "BANCO DE DADOS NÃO EXISTIA";
            }
            return "BANCO DE DADOS JÁ EXISTIA";
        }

        public SQLiteConnection dbConnect(string connectionStr)
        {
            SQLiteConnection conn = new SQLiteConnection(connectionStr);
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

        public void dbExecuteQuery(string query, SQLiteConnection conn)
        {
            SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar comando: " + ex.Message);
            }
        }


    }
}

