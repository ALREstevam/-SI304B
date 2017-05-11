using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class DynamicExample : Form
    {
        private int topId = 0;
        public DynamicExample()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;

            flowLayoutPanel1.Controls.Add(
                new UserControlExample1(topId)
                {
                    Parent = flowLayoutPanel1
                });

            topId++;
        }
    }
}
