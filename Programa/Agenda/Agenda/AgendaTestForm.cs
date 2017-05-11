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

namespace Agenda
{

    public partial class AgendaTestForm : Form
    {
        //Classe tarefa
        public class Task{
            public int id {get; set;}
            public string taskName { get; set; }
        }

        public static string connectionStr = "Data Source=Banco.db";
        private static string dbName = "Banco.db";



        private void LoadTasks()
        {
            SQLiteConnection conn = new SQLiteConnection(connectionStr);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM tb_tasks", conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            List<Task> lista = new List<Task>();

            while (dr.Read())
            {
                lista.Add(new Task
                {
                    id = Convert.ToInt32(dr["id_task"]),
                    taskName = dr["name_task"].ToString()
                });
            }
            dataGridView1.DataSource = lista;

        }

        private void executeDefault()
        {

        }


        public AgendaTestForm()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Criação do banco de dados
            if (!File.Exists(dbName)) {
                SQLiteConnection.CreateFile(dbName);
                SQLiteConnection conn = new SQLiteConnection(connectionStr);
                conn.Open();

                StringBuilder sql = new StringBuilder();
                sql.AppendLine("CREATE TABLE IF NOT EXISTS tb_tasks ([id_task] INTEGER PRIMARY KEY AUTOINCREMENT,");
                sql.AppendLine("[name_task] VARCHAR(30) NOT NULL)");

                SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao criar banco de dados: " + ex.Message);
                }
            }


            LoadTasks();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
 
            SQLiteConnection conn = new SQLiteConnection(connectionStr);

            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO tb_tasks (name_task) VALUES (@name_task)", conn);
            cmd.Parameters.AddWithValue("name_task", textBox1.Text.Trim());

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserido com sucesso");
                textBox1.Text = string.Empty;
                LoadTasks();
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao salvar registro " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddTaskForm add = new AddTaskForm();
            add.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            DynamicExample dyne = new DynamicExample();
            dyne.Show();
        }
    }
}
