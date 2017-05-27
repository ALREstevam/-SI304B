using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskItems;
using Database;


namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            responsiveDesignUpdate();
            DatabaseController dbcontr = new DatabaseController("database");


        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
           responsiveDesignUpdate();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            responsiveDesignUpdate();
        }


        private void responsiveDesignUpdate()
        {
            //Altura e largura das colunas
            flowLayoutPanelColumn1.Height = flowLayoutPanelLine.Height - 10;
            flowLayoutPanelColumn2.Height = flowLayoutPanelLine.Height - 10;
            flowLayoutPanelColumn3.Height = flowLayoutPanelLine.Height - 10;

            flowLayoutPanelColumn1.Width = (flowLayoutPanelLine.Width - 20) / 3;
            flowLayoutPanelColumn2.Width = (flowLayoutPanelLine.Width - 20) / 3;
            flowLayoutPanelColumn3.Width = (flowLayoutPanelLine.Width - 20) / 3;

            //Largura dos painéis de classificação de tarefas
            panelName1.Width = (flowLayoutPanelLine.Width - 20) / 3;
            panelName2.Width = (flowLayoutPanelLine.Width - 20) / 3;
            panelName3.Width = (flowLayoutPanelLine.Width - 20) / 3;

            //Largura da área dos painéis de classificação de tarefas
            flowLayoutPanelNames.Width = flowLayoutPanelBack.Width - 10;

            //Largura e altura da área de colunas
            flowLayoutPanelLine.Width = flowLayoutPanelBack.Width - 10;
            flowLayoutPanelLine.Height = (flowLayoutPanelBack.Height - flowLayoutPanelNames.Height) - 10;

            foreach (TaskElement elem in flowLayoutPanelColumn1.Controls)
            {
  
                elem.resize();
            }
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            AdicionarEditar addedit = new AdicionarEditar();
            addedit.Show();
           
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            flowLayoutPanelColumn1.AutoScroll = true;
            flowLayoutPanelColumn1.WrapContents = false;
            flowLayoutPanelColumn1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;

            AgendaItem agd = new AgendaItem();
            agd.setItem("Um nome qualquer", "texto texto texto texto", 1, 1, 3);



            flowLayoutPanelColumn1.Controls.Add(
               new TaskElement(agd) { Parent = flowLayoutPanelColumn1}
              );

            ///////////****////////////
        }
    }
}
