using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskItems;
using Database;
using System.Data.SQLite;

namespace Agenda
{
    public partial class TaskElement : UserControl
    {
        AgendaItem agd;
        Form1 myparent;
        public TaskElement(AgendaItem agdr, Form1 parent)
        {
            this.agd = agdr;
            InitializeComponent();
            this.myparent = parent;
        }
        public void resize()
        {
            this.Width = Parent.Width-30;
            this.textBoxDescription.MaximumSize = new Size(this.tableLayoutPanel1.Width, 0);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DatabaseController contr = new DatabaseController("database.db");
            SQLiteConnection conn = contr.dbConnect();
            contr.dbExecuteQuery(agd.toSqlDeleteString(), conn);

            this.Dispose();
            myparent.updateStatus("Deletando tarefa");

            myparent.dbToUi();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            AdicionarEditar addedit = new AdicionarEditar(agd, myparent);
            addedit.Show();
            myparent.updateStatus("Editando tarefa");
        }

        private void TaskElement_Load(object sender, EventArgs e)
        {
            
            switch (this.agd.itemType)
            {
                case 1:
                    this.tableLayoutPanel1.BackColor = Color.FromArgb(255, 115, 109);
                    this.textBoxDescription.BackColor = Color.FromArgb(255, 115, 109);
                    this.textBoxDescription.ForeColor = Color.FromArgb(46, 0, 0);
                    this.labelTitle.ForeColor = Color.FromArgb(46, 0, 0);
                    this.buttonMoveLeft.Dispose();
                    break;
                case 2:
                    this.tableLayoutPanel1.BackColor = Color.FromArgb(255, 235, 105);
                    this.textBoxDescription.BackColor = Color.FromArgb(255, 235, 105);
                    this.textBoxDescription.ForeColor = Color.FromArgb(76, 36, 4);
                    this.labelTitle.ForeColor = Color.FromArgb(76, 36, 4);
                    break;
                case 3:
                    this.tableLayoutPanel1.BackColor = Color.FromArgb(125, 182, 255);
                    this.textBoxDescription.BackColor = Color.FromArgb(125, 182, 255);
                    this.textBoxDescription.ForeColor = Color.FromArgb(0, 0, 46);
                    this.labelTitle.ForeColor = Color.FromArgb(0, 0, 46);
                    this.buttonMoveRight.Dispose();
                    break;
            }
            this.resize();

            labelTitle.Text = this.agd.itemName;
            textBoxDescription.Text = this.agd.itemDescription;
        }

        private void buttonMoveLeft_Click(object sender, EventArgs e)
        {
            agd.itemType--;

            DatabaseController contr = new DatabaseController("database.db");
            SQLiteConnection conn = contr.dbConnect();
            contr.dbExecuteQuery(agd.toSqlUpdateString(), conn);

            myparent.dbToUi();
            myparent.updateStatus("Movendo tarefa para esquerda");
        }

        private void buttonMoveRight_Click(object sender, EventArgs e)
        {
            agd.itemType++;

            DatabaseController contr = new DatabaseController("database.db");
            SQLiteConnection conn = contr.dbConnect();
            contr.dbExecuteQuery(agd.toSqlUpdateString(), conn);

            myparent.dbToUi();
            myparent.updateStatus("Movendo tarefa para direita");
        }

        private void labelTitle_DoubleClick(object sender, EventArgs e)
        {
            buttonEdit.PerformClick();
        }

        private void textBoxDescription_DoubleClick(object sender, EventArgs e)
        {
            buttonEdit.PerformClick();
        }

        ///**///
    }
}
