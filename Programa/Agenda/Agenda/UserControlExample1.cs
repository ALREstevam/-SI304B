using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class UserControlExample1 : UserControl
    {
        public int rcvdid;
        public UserControlExample1(int myid)
        {
            rcvdid = myid;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void UserControlExample1_Load(object sender, EventArgs e)
        {
            labelID.Text = rcvdid.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
