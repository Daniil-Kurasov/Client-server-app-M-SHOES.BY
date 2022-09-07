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
    public partial class ConfirmPassword : Form
    {
        readonly General general;
        public long ID_user { get; set; }
        public ConfirmPassword(long id_user)
        {
            InitializeComponent();
            general = new General();
            ID_user = id_user;
        }

        private void ConfirmB_Click(object sender, EventArgs e)
        {
            if (general.PasswordCheck(passwordTB.Text))
            {
                if (passwordTB.Text.Equals(general.ReturnElement($"SELECT password FROM Users WHERE id_user = {ID_user}")))
                    this.Hide();
                else
                    new Message("Неверный пароль.", false).ShowDialog();
            }
        }

        public override string ToString() => passwordTB.Text.Equals(general.ReturnElement($"SELECT password FROM Users WHERE id_user = {ID_user}")) ? "true" : "false";

        private void PasswordTB_IconRightClick(object sender, EventArgs e) => general.ShowAndHide(passwordTB);

        private void PasswordTB_KeyPress(object sender, KeyPressEventArgs e) => general.KeyPress1(e);

        private void PasswordTB_TextChanged(object sender, EventArgs e) => general.TextGhanged1(passwordTB);
    }
}
