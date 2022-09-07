using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M_SHOES.BY
{
    public partial class Message2 : Form
    {
        public Message2(string message)
        {
            InitializeComponent();
            infoRTB.SelectionAlignment = HorizontalAlignment.Center;
            infoRTB.Text = message;
        }
        bool flag = false;

        private void YesB_Click(object sender, EventArgs e)
        {
            this.Hide();
            flag = true;
        }
        private void NotB_Click(object sender, EventArgs e) => this.Hide();

        public override string ToString() => flag.ToString();
    }
}
