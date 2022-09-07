using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace M_SHOES.BY
{
    public partial class AccountSettings : UserControl
    {
        readonly General general;
        public static string connectString;
        bool flag;
        public long ID_user { get; set; }
        public Label NameL { get; set; }
        public Guna2CirclePictureBox PictureBoxMain { get; set; }
        public AccountSettings(long id_user, Label nameL, Guna2CirclePictureBox pictureBoxMain)
        {
            InitializeComponent();
            general = new General();
            connectString = general.StringConnection();
            pictureBox.AllowDrop = true;
            ID_user = id_user;
            PictureBoxMain = pictureBoxMain;
            NameL = nameL;
            FillControls();
        }
        private void FillControls()
        {
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var comm = new SqlCommand($"SELECT email, password, name, phone, picture FROM Users WHERE id_user = {ID_user}", conn);
                using (var reader = comm.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        id_user.Text = ID_user.ToString();
                        emailTB.Text = reader[0].ToString();
                        passwordTB.Text = reader[1].ToString();
                        nameTB.Text = reader[2].ToString();
                        phoneTB.Text = reader[3].ToString();
                        if(!reader.IsDBNull(4))
                            general.GetPicture(pictureBox, (byte[])reader[4]);
                    }
                }
            }
        }
        private void EmailTB_KeyPress(object sender, KeyPressEventArgs e) => general.KeyPress1(e);

        private void EmailTB_TextChanged(object sender, EventArgs e) => general.TextGhanged1(emailTB);

        private void PasswordTB_IconRightClick(object sender, EventArgs e) => general.ShowAndHide(passwordTB);

        private void PasswordTB_KeyPress(object sender, KeyPressEventArgs e) => general.KeyPress1(e);

        private void PasswordTB_TextChanged(object sender, EventArgs e) => general.TextGhanged1(passwordTB);

        private void NameTB_KeyPress(object sender, KeyPressEventArgs e) => general.NameKeyPress(e);

        private void PhoneTB_KeyPress(object sender, KeyPressEventArgs e) => general.PhoneKeyPress(e);

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (CheckAll() && general.CheckEmail(general.ReturnElement($"SELECT email FROM Users WHERE id_user = {ID_user}"), emailTB.Text) && general.PasswordCheck(passwordTB.Text) && general.NameCheck(nameTB.Text) && general.CheckPhone(general.ReturnElement($"SELECT phone FROM Users WHERE id_user = {ID_user}"), phoneTB.Text))
            {
                general.UpdateTableEntry(pictureBox, new List<object>() {general.ReturnElement($"SELECT role FROM Users WHERE id_user = {ID_user}"), emailTB.Text, passwordTB.Text, nameTB.Text, phoneTB.Text }, ID_user);
                if (pictureBox.Image != null)
                    general.ImageToNull(pictureBox);
                else
                    general.ExecuteQuery($"UPDATE Users SET picture = NULL WHERE id_user = {ID_user}");

                if (!general.ReturnElement($"SELECT picture FROM Users WHERE id_user = {ID_user}").Equals("0"))
                {
                    using (var conn = new SqlConnection(connectString))
                    {
                        conn.Open();
                        var cmd = new SqlCommand($"SELECT picture FROM Users WHERE id_user = {ID_user}", conn);
                        general.GetPicture(pictureBox, (byte[])cmd.ExecuteScalar());
                        general.GetPicture(PictureBoxMain, (byte[])cmd.ExecuteScalar());
                    }
                }
                else
                {
                    if (PictureBoxMain.Image != null)
                    {
                        PictureBoxMain.Image.Dispose();
                        PictureBoxMain.Image = null;
                        PictureBoxMain.BackgroundImage = Properties.Resources.Avatar;
                    }
                }
                NameL.Text = nameTB.Text;
                flag = false;
                new Message("Изменено.", true).ShowDialog();
            }
        }
        private bool CheckAll()
        {
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var comm = new SqlCommand($"SELECT IIF(email = '{emailTB.Text}', 'true', 'false'), IIF(password = '{passwordTB.Text}', 'true', 'false'), IIF(name = '{nameTB.Text}', 'true', 'false'),IIF(phone = '{phoneTB.Text}', 'true', 'false') FROM Users WHERE id_user = {ID_user}", conn);
                using (var reader = comm.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        if(reader[0].ToString().Equals("true") && reader[1].ToString().Equals("true") && reader[2].ToString().Equals("true") && reader[3].ToString().Equals("true") && !flag)
                        {
                            new Message("Ничего не изменено.", false).ShowDialog();
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        private void PictureBox_DragDrop(object sender, DragEventArgs e)
        {
            if (general.PictureBoxDragDrop(pictureBox, e))
                flag = true;
        }

        private void PictureBox_DragEnter(object sender, DragEventArgs e) => e.Effect = DragDropEffects.Copy;

        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if(general.PictureBoxMouseClick(pictureBox, e))
                flag = true;
        }
        private void DragDropIB_MouseMove(object sender, MouseEventArgs e) => dragDropIB.BringToFront(); 

        private void LBM_IB_MouseMove(object sender, MouseEventArgs e) => LBM_IB.BringToFront();

        private void RBM_IB_MouseMove(object sender, MouseEventArgs e) => RBM_IB.BringToFront();
    }
}
