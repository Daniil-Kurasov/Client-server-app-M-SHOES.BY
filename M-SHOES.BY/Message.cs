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
    public partial class Message : Form
    {
        public Message(string message, bool changePicture)
        {
            InitializeComponent();
            infoRTB.Text = message;
            infoRTB.SelectionAlignment = HorizontalAlignment.Center;
            if (changePicture)
            { iconPB.Image = Properties.Resources.Ok; okB.FillColor = Color.Green; }
            else if (okB.FillColor == Color.Green)
                okB.FillColor = Color.DarkOrchid;
        }

        private void OkB_Click(object sender, EventArgs e) => this.Hide();
    }
}
