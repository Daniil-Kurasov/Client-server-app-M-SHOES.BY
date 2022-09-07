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
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
            circlePB.FillColor = Color.FromArgb(150, 0, 0, 0);
            logoPB.Parent = circlePB;
            progressL.Parent = circlePB;
        }

        SignInSignUpRemind signInSignUpRemind;
        private void LoadT_Tick(object sender, EventArgs e)
        {
            ++progressBar.Value;
            progressL.Text = progressBar.Value.ToString() + " %";
            if(progressBar.Value == 1)
            {
                signInSignUpRemind = new SignInSignUpRemind();
                signInSignUpRemind.Show();
                signInSignUpRemind.Visible = false;
            }
            if(progressBar.Value == 100)
            { this.Hide(); signInSignUpRemind.Visible = true; loadT.Stop(); }
        }
    }
}
