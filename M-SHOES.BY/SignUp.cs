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
    public partial class SignUp : UserControl
    {
        readonly General general;

        public SignUp(FlowLayoutPanel flowLayoutPanel)
        {
            InitializeComponent();
            general = new General(flowLayoutPanel);
        }

        private void RemindPasswordLabel_Click(object sender, EventArgs e) => general.RemindPassword();

        private void SignInLabel_Click(object sender, EventArgs e) => general.SignIn();

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (general.EmailCheck(emailTB.Text) && general.PasswordAndReenterPasswordCheck(passwordTB.Text, reenterPasswordTB.Text) && general.NameCheck(nameTB.Text) && general.PhoneCheck(phoneTB.Text) && general.IsThereAnInternetConnection(true, "Отсутствует подключение к интернету."))
            {
                var confirmCode = GenerateConfirmCode();
                if (general.SendMessageToEmail(emailTB.Text, "Ваш код подтверждения:", confirmCode, false, null))
                {
                    var confirmEmail = new ConfirmEmail(confirmCode);
                    confirmEmail.ShowDialog();
                    if (confirmEmail.ToString().Equals("true"))
                    {
                        general.InsertIntoTable("Users", new[] { "пользователь", emailTB.Text, passwordTB.Text, nameTB.Text, phoneTB.Text, null });
                        general.SignUp();
                        new Message("Вы были успешно зарегистрированы.", true).ShowDialog();
                    }
                }
            }
        }

        private string GenerateConfirmCode()
        {
            var random = new Random();
            string lettersAndNumbers = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var stringBuilder = new StringBuilder(5);
            for (var i = 0; i < 5; i++)
                stringBuilder.Append(lettersAndNumbers[random.Next(0, lettersAndNumbers.Length)]);
            return stringBuilder.ToString();
        }

        private void PasswordTB_IconRightClick(object sender, EventArgs e) => general.ShowAndHide(passwordTB);

        private void ReenterPasswordTB_IconRightClick(object sender, EventArgs e) => general.ShowAndHide(reenterPasswordTB);

        private void EmailTB_TextChanged(object sender, EventArgs e) => general.TextGhanged1(emailTB);

        private void EmailTB_KeyPress(object sender, KeyPressEventArgs e) => general.KeyPress1(e);

        private void PasswordTB_TextChanged(object sender, EventArgs e) => general.TextGhanged1(passwordTB);

        private void PasswordTB_KeyPress(object sender, KeyPressEventArgs e) => general.KeyPress1(e);

        private void ReenterPasswordTB_TextChanged(object sender, EventArgs e) => general.TextGhanged1(reenterPasswordTB);

        private void ReenterPasswordTB_KeyPress(object sender, KeyPressEventArgs e) => general.KeyPress1(e);

        private void PhoneTB_KeyPress(object sender, KeyPressEventArgs e) => general.PhoneKeyPress(e);

        private void NameTB_KeyPress(object sender, KeyPressEventArgs e) => general.NameKeyPress(e);
    }
}
