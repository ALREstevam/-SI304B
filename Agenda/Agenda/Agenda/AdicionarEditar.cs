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
    public partial class AdicionarEditar : Form
    {


        AgendaItem agd;
        enum frmtpy { newone, edit };
        private frmtpy type;

        public AdicionarEditar()
        {
            InitializeComponent();
            type = frmtpy.newone;
        }

        public AdicionarEditar(AgendaItem agd)
        {
            InitializeComponent();
            type = frmtpy.edit;
            this.agd = agd;

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

        }

        private void AdicionarEditar_Load(object sender, EventArgs e)
        {
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
                    return "*";
            }
        }

    }
}
