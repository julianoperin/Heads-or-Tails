using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Head_or_Tails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHeads_Click(object sender, EventArgs e)
        {
            picTails.Visible = false;
            picHead.Visible = true;
        }

        private void btnTails_Click(object sender, EventArgs e)
        {
            picHead.Visible = false;
            picTails.Visible = true;
        }

        private void btnBoth_Click(object sender, EventArgs e)
        {
            picTails.Visible = true;
            picHead.Visible = true;
        }

        private void picHead_Click(object sender, EventArgs e)
        {

        }
    }
}
