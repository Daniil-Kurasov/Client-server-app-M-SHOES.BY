using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace M_SHOES.BY
{
    public partial class ConfirmEmail : Form
    {
        public string ConfirmCode { get; set; }

        public ConfirmEmail(string confirmCode)
        {
            InitializeComponent();
            ConfirmCode = confirmCode;
        }

        private void ConfirmB_Click(object sender, EventArgs e)
        {
            if (confirmTB.Text.Equals(ConfirmCode))
                this.Hide();
            else
                new Message("Неверный код подтверждения.", false).ShowDialog();
        }

        private void ConfirmTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
                return;
            }
            e.Handled = true;
        }

        public override string ToString() => confirmTB.Text.Equals(ConfirmCode) ? "true" : "false";
    }
}
