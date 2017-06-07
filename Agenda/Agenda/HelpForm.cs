using System;
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

            /*string html = Properties.Resources.manual;
            webBrowser1.DocumentText = html;*/

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

            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("grupo8corp@gmail.com", "gcorp@78");

            MailMessage mm = new MailMessage(mailFrom, "grupo8corp@gmail.com", "Agenda - Bug report", message);
            mm.BodyEncoding = UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.Send(mm);






            MessageBox.Show("Mensagem enviada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://a166348.000webhostapp.com/Manual%20do%20Usu%C3%A1rio.pdf");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string manualLink = "http://a166348.000webhostapp.com/Manual%20do%20Usu%C3%A1rio.pdf";
            Clipboard.SetData(DataFormats.Text, (Object)manualLink);
            System.Diagnostics.Process.Start(manualLink);
        }
    }
}
