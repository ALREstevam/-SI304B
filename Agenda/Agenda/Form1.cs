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
            dbToUi();

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            responsiveDesignUpdate();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            responsiveDesignUpdate();
        }

        public void dbToUi()
        {
            flowLayoutPanelColumn1.Controls.Clear();
            flowLayoutPanelColumn2.Controls.Clear();
            flowLayoutPanelColumn3.Controls.Clear();


            updateStatus("Conectando ao banco de dados");
            DatabaseController dbcontr = new DatabaseController("database.db");

            if (dbcontr.dbCreate())
            {
                updateStatus("Criando banco");
                HelpForm hlp = new HelpForm(2);
                hlp.Show();

            }
            

            AgendaItem agd = new AgendaItem();
            List<AgendaItem> lista = new List<AgendaItem>();
            lista = agd.getAllFromDb();

            flowLayoutPanelColumn1.AutoScroll = true;
            flowLayoutPanelColumn1.WrapContents = false;
            flowLayoutPanelColumn1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;

            flowLayoutPanelColumn2.AutoScroll = true;
            flowLayoutPanelColumn2.WrapContents = false;
            flowLayoutPanelColumn2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;

            flowLayoutPanelColumn3.AutoScroll = true;
            flowLayoutPanelColumn3.WrapContents = false;
            flowLayoutPanelColumn3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;


            updateStatus("Imprimindo dados do banco");
            foreach (AgendaItem elem in lista)
            {
                switch (elem.itemType)
                {
                    case 1:
                        flowLayoutPanelColumn1.Controls.Add(
                            new TaskElement(elem, this) { Parent = flowLayoutPanelColumn1 }
                        );
                        break;
                    case 2:
                        flowLayoutPanelColumn2.Controls.Add(
                            new TaskElement(elem, this) { Parent = flowLayoutPanelColumn2 }
                        );
                        break;
                    case 3:
                        flowLayoutPanelColumn3.Controls.Add(
                            new TaskElement(elem, this) { Parent = flowLayoutPanelColumn3 }
                        );
                        break;
                }
            }

            


        }

        private void responsiveDesignUpdate()
        {
            updateStatus("Redimensionando quadros");
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

            foreach (TaskElement elem in flowLayoutPanelColumn2.Controls)
            {
                elem.resize();
            }

            foreach (TaskElement elem in flowLayoutPanelColumn3.Controls)
            {
                elem.resize();
            }
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            updateStatus("Abrindo janela para adicionar tarefa");
            AdicionarEditar addedit = new AdicionarEditar(this);
            addedit.Show();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            updateStatus("Abrindo janela de ajuda");
            HelpForm hlp = new HelpForm(0);
            hlp.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            updateStatus("Recarregando dados");
            dbToUi();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buttonBugReport_Click(object sender, EventArgs e)
        {
            updateStatus("Abrindo janela de bug report");
            HelpForm hlp = new HelpForm(3);
            hlp.Show();
        }

        public void updateStatus(string newStatus)
        {
            toolStripStatusLabel1.Text = "Último status: " + newStatus + ".";
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            buttonAddTask.PerformClick();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            buttonAddTask.PerformClick();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            buttonAddTask.PerformClick();
        }
    }
}
