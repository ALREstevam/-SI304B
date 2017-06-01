﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Agenda
{
    public partial class HelpForm : Form
    {
        int iniTab;
        public HelpForm(int initialTab)
        {
            this.iniTab = initialTab;
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = this.iniTab;
            imageUpdate();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            imageUpdate();
        }

        private void imageUpdate()
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = Agenda.Properties.Resources.About_96px;
                    break;
                case 1:
                    pictureBox1.Image = Agenda.Properties.Resources.Todo_List_96px;
                    break;
                case 2:
                    pictureBox1.Image = Agenda.Properties.Resources.Plus_96px;
                    break;
                case 3:
                    pictureBox1.Image = Agenda.Properties.Resources.Bug_96px;
                    break;
            }
        }

        private bool isMailValid(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mailFrom = textBoxMail.Text; 
            string message = textBoxMessage.Text;

            if (!isMailValid(mailFrom)) {
                MessageBox.Show("E-mail não é válido!", "Erro ao reportar bug", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            MessageBox.Show("Mensagem enviada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}