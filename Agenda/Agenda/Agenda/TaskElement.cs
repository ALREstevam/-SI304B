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

namespace Agenda
{
    public partial class TaskElement : UserControl
    {
        AgendaItem agd;
        public TaskElement(AgendaItem agd)
        {
            this.agd = agd;
            InitializeComponent();
        }

        private void buttonMoveRight_Click(object sender, EventArgs e)
        {
            
        }

        public void resize()
        {
            this.Width = Parent.Width-30;
            this.labelDescription.MaximumSize = new Size(this.tableLayoutPanel1.Width, 0);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

            AdicionarEditar addedit = new AdicionarEditar(agd);
            addedit.Show();
        }

        private void ToDoElement_Load(object sender, EventArgs e)
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
        ///**///
    }
}
