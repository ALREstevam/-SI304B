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
using System.Data.SQLite;


namespace Agenda
{
    public partial class AdicionarEditar : Form
    {
        AgendaItem agd;
        Form1 myparent;
        enum frmtpy { newone, edit };
        private frmtpy type;

        public AdicionarEditar(Form1 parent)
        {
            InitializeComponent();
            type = frmtpy.newone;
            agd = new AgendaItem();
            agd.itemId = 0;
            this.myparent = parent;
        }

        public AdicionarEditar(AgendaItem agd, Form1 parent)
        {
            InitializeComponent();
            type = frmtpy.edit;
            this.agd = agd;
            this.myparent = parent;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelImportance.Text = trackBarImportance.Value.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxState.Text == "")
            {
                MessageBox.Show("Você não escolheu um valor para o estado");
                return;
            }



            agd.setItem(textBoxName.Text, textBoxDescription.Text, itemTypeStrToNum(comboBoxState.Text), agd.itemId,trackBarImportance.Value);
            DatabaseController dc = new DatabaseController("database.db");
            SQLiteConnection conn = dc.dbConnect();
            if (type == frmtpy.edit)
            {
                if (dc.dbExecuteQuery(agd.toSqlUpdateString(), conn))
                {
                    //MessageBox.Show("Atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                if (dc.dbExecuteQuery(agd.toSqlInsertString(), conn))
                {
                    //MessageBox.Show("Salvo com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            myparent.dbToUi();
        }

        private void AdicionarEditar_Load(object sender, EventArgs e)
        {
            comboBoxState.SelectedIndex = 0;

            if (type == frmtpy.edit)
            {
                this.Text = "Editar";
                textBoxName.Text = agd.itemName;
                textBoxDescription.Text = agd.itemDescription;
                comboBoxState.Text = itemTypeNumToStr(agd.itemType);
                trackBarImportance.Value = agd.itemImportance;
                labelImportance.Text = agd.itemImportance.ToString();
            }else
            {
                this.Text = "Adicionar";
            }
           
        }

        private string itemTypeNumToStr(int num)
        {
            switch(num){
                case 1:
                    return "Fazer";
                case 2:
                    return "Fazendo";
                case 3:
                    return "Feito";
                default:
                    return "Fazer";
            }
        }

        private int itemTypeStrToNum(string str)
        {
            switch (str)
            {
                case "Fazer":
                    return 1;
                case "Fazendo":
                    return 2;
                case "Feito":
                    return 3;
                default:
                    return 1;
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxDescription.Text = "";
            comboBoxState.Text = "Fazer";
            trackBarImportance.Value = 0;
            labelImportance.Text = 0.ToString();
        }
    }
}
