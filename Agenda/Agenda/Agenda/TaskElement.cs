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
            this.labelDescription.MaximumSize = new Size(this.tableLayoutPanel1.Width, 0);
        }

        private void buttonDelete_Click(object sender, EventArgs e)//#
        {
            DatabaseController contr = new DatabaseController("database.db");
            SQLiteConnection conn = contr.dbConnect();
            contr.dbExecuteQuery(agd.toSqlDeleteString(), conn);

            this.Dispose();
            //myparent.dbToUi();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            AdicionarEditar addedit = new AdicionarEditar(agd, myparent);
            addedit.Show();
        }

        private void TaskElement_Load(object sender, EventArgs e)
        {
            
            switch (this.agd.itemType)
            {
                case 1:
                    this.BackColor = Color.Red;
                    this.buttonMoveLeft.Dispose();
                    break;
                case 2:
                    this.BackColor = Color.Yellow;
                    break;
                case 3:
                    this.BackColor = Color.Green;
                    this.buttonMoveRight.Dispose();
                    break;
            }
            this.resize();

            labelTitle.Text = this.agd.itemName;
            labelDescription.Text = this.agd.itemDescription;
        }

        private void buttonMoveLeft_Click(object sender, EventArgs e)
        {
            agd.itemType--;

            DatabaseController contr = new DatabaseController("database.db");
            SQLiteConnection conn = contr.dbConnect();
            contr.dbExecuteQuery(agd.toSqlUpdateString(), conn);

            myparent.dbToUi();
        }

        private void buttonMoveRight_Click(object sender, EventArgs e)
        {
            agd.itemType++;

            DatabaseController contr = new DatabaseController("database.db");
            SQLiteConnection conn = contr.dbConnect();
            contr.dbExecuteQuery(agd.toSqlUpdateString(), conn);

            myparent.dbToUi();
        }

        ///**///
    }
}
