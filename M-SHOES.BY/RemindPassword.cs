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
    public partial class RemindPassword : UserControl
    {
        readonly General general;
        public static string connectString;
        public RemindPassword(FlowLayoutPanel flowLayoutPanel)
        {
            InitializeComponent();
            general = new General(flowLayoutPanel);
            connectString = general.StringConnection();
        }

        private void SignUpLabel_Click(object sender, EventArgs e) => general.SignUp();

        private void SignInLabel_Click(object sender, EventArgs e) => general.SignIn();

        private void EmailTB_TextChanged(object sender, EventArgs e) => general.TextGhanged1(emailTB);

        private void EmailTB_KeyPress(object sender, KeyPressEventArgs e) => general.KeyPress1(e);

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (general.EmailCheck2(emailTB.Text))
            {
                using (var conn = new SqlConnection(connectString))
                {
                    conn.Open();
                    var comm = new SqlCommand("SELECT password FROM Users WHERE email ='" + emailTB.Text + "'", conn);
                    object password = comm.ExecuteScalar();
                    if (password != null)
                    {
                        if (general.IsThereAnInternetConnection(true, "Отсутствует подключение к интернету.") && general.SendMessageToEmail(emailTB.Text, "Ваш пароль:", password.ToString(), false, null))
                        {
                            general.RemindPassword();
                            new Message("Пароль отправлен на электронную почту.", true).ShowDialog();
                        }
                    }
                    else
                        new Message("Пользователь не зарегистрирован.", false).ShowDialog();
                }
            }
        }
    }
}
