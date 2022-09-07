using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M_SHOES.BY
{
    public partial class SignIn : UserControl
    {
        readonly General general;
        public static string connectString;
        public SignIn(FlowLayoutPanel flowLayoutPanel)
        {
            InitializeComponent();
            general = new General(flowLayoutPanel);
            connectString = general.StringConnection();
        }

        private void RemindPasswordLabel_Click(object sender, EventArgs e) => general.RemindPassword();

        private void SignUpLabel_Click(object sender, EventArgs e) => general.SignUp();

        private void PasswordTB_IconRightClick(object sender, EventArgs e) => general.ShowAndHide(passwordTB);

        private void EmailTB_TextChanged(object sender, EventArgs e) => general.TextGhanged1(emailTB);

        private void EmailTB_KeyPress(object sender, KeyPressEventArgs e) => general.KeyPress1(e);

        private void PasswordTB_TextChanged(object sender, EventArgs e) => general.TextGhanged1(passwordTB);

        private void PasswordTB_KeyPress(object sender, KeyPressEventArgs e) => general.KeyPress1(e);

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if(general.EmailCheck2(emailTB.Text) && general.PasswordCheck(passwordTB.Text))
            {
                using (var conn = new SqlConnection(connectString))
                {
                    conn.Open();
                    var comm = new SqlCommand($"SELECT id_user FROM Users WHERE email = '{emailTB.Text}' AND password = '{passwordTB.Text}'", conn);
                    using (var reader = comm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            Form.ActiveForm.Hide();
                            new Main(long.Parse(reader[0].ToString())).Show();
                        }
                        else
                            new Message("Пользователь не найден.", false).ShowDialog();
                    }
                }
            }
        }
    }
}
