using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Guna.UI2.WinForms;

namespace M_SHOES.BY
{
    public partial class UsersEditor : UserControl
    {
        readonly General general;
        public string Query { get; set; }
        public string Query2 { get; set; }
        public Guna2DataGridView DataGridView { get; set; }
        public FlowLayoutPanel FlowLayoutPanel { get; set; }

        public static string connectString;
        long ID_user = 0;
        string path = string.Empty;
        public UsersEditor(string query, string query2, Guna2DataGridView dataGridView, FlowLayoutPanel flowLayoutPanel)
        {
            InitializeComponent();
            pictureBox.AllowDrop = true;
            Query = query;
            Query2 = query2;
            general = new General();
            connectString = general.StringConnection();
            DataGridView = dataGridView;
            FlowLayoutPanel = flowLayoutPanel;
            FillControls();
        }
        public UsersEditor(string query, Guna2DataGridView dataGridView, FlowLayoutPanel flowLayoutPanel)
        {
            InitializeComponent();
            pictureBox.AllowDrop = true;
            general = new General();
            Query = query;
            connectString = general.StringConnection();
            DataGridView = dataGridView;
            FlowLayoutPanel = flowLayoutPanel;
        }

        private void FillControls()
        {
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var comm = new SqlCommand(Query2, conn);
                using (var reader = comm.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        ID_user = long.Parse(reader[0].ToString());
                        roleCB.SelectedItem = reader[1].ToString();
                        emailTB.Text = reader[2].ToString();
                        passwordTB.Text = reader[3].ToString();
                        nameTB.Text = reader[4].ToString();
                        phoneTB.Text = reader[5].ToString();
                        if (!reader.IsDBNull(6))
                            general.GetPicture(pictureBox,(byte[])reader[6]);
                    }
                }
            }
        }

        private void EmailTB_KeyPress(object sender, KeyPressEventArgs e) => general.KeyPress1(e);

        private void EmailTB_TextChanged(object sender, EventArgs e)
        {
            general.TextGhanged1(emailTB);
            emailL.Text = $"электронная почта ({emailTB.Text.Length} / 350)";
        }

        private void PasswordTB_KeyPress(object sender, KeyPressEventArgs e) => general.KeyPress1(e);

        private void PasswordTB_TextChanged(object sender, EventArgs e)
        {
            general.TextGhanged1(passwordTB);
            passwordL.Text = $"пароль ({passwordTB.Text.Length} / 30)";
        }

        private void NameTB_KeyPress(object sender, KeyPressEventArgs e) => general.NameKeyPress(e);

        private void PhoneTB_KeyPress(object sender, KeyPressEventArgs e) => general.PhoneKeyPress(e);

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (general.CheckLength(roleCB.Text) && general.EmailCheck(emailTB.Text) && general.PasswordCheck(passwordTB.Text) && general.NameCheck(nameTB.Text) && general.PhoneCheck(phoneTB.Text))
            {
                if (pictureBox.Image != null)
                {
                    general.InsertIntoTable("Users", new object[] { roleCB.Text, emailTB.Text, passwordTB.Text, nameTB.Text, phoneTB.Text, general.PicturesConverter(pictureBox) });
                    general.ImageToNull(pictureBox);
                }
                else
                    general.InsertIntoTable("Users", new object[] { roleCB.Text, emailTB.Text, passwordTB.Text, nameTB.Text, phoneTB.Text, null});
                ClearButton_Click(sender, e);
                new Message("Добавлено.", true).ShowDialog();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            general.UpdateTable(DataGridView, Query);
            FlowLayoutPanel.Controls.Clear();
            FlowLayoutPanel.Controls.Add(new UsersEditor(Query, DataGridView, FlowLayoutPanel));
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ID_user != 0)
            {
                var message2 = new Message2("Вы действительно хотите удалить данную запись?");
                message2.ShowDialog();
                if (message2.ToString().Equals("True"))
                {
                    general.ExecuteQuery($"DELETE FROM Orders WHERE id_order_realisation IN (SELECT id_order_realisation FROM Order_realisation WHERE id_user = {ID_user})");
                    general.ExecuteQuery($"DELETE FROM Basket WHERE id_order_realisation IN (SELECT id_order_realisation FROM Order_realisation WHERE id_user = {ID_user})");
                    general.ExecuteQuery($"DELETE FROM Order_realisation WHERE id_user = {ID_user}");
                    general.ExecuteQuery($"DELETE FROM Reviews WHERE id_user = {ID_user}");
                    general.ExecuteQuery($"DELETE FROM Liked WHERE id_user = {ID_user}");
                    general.ExecuteQuery($"DELETE FROM Users WHERE id_user = {ID_user}");
                    ClearButton_Click(sender, e);
                    new Message("Удалено.", true).ShowDialog();
                }
            }
            else
                new Message("Пользователь не выбран.", false).ShowDialog();
        }

        private void PictureBox_DragDrop(object sender, DragEventArgs e) => general.PictureBoxDragDrop(pictureBox, e);

        private void PictureBox_DragEnter(object sender, DragEventArgs e) => e.Effect = DragDropEffects.Copy;

        private void PictureBox_MouseClick(object sender, MouseEventArgs e) => general.PictureBoxMouseClick(pictureBox, e);

        private void NameTB_TextChanged(object sender, EventArgs e) => nameL.Text = $"имя ({nameTB.Text.Length} / 20)";

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (ID_user != 0)
            {
                if (general.CheckLength(roleCB.Text) && general.CheckEmail(general.ReturnElement($"SELECT email FROM Users WHERE id_user = {ID_user}"), emailTB.Text) && general.PasswordCheck(passwordTB.Text) && general.NameCheck(nameTB.Text) && general.CheckPhone(general.ReturnElement($"SELECT phone FROM Users WHERE id_user = {ID_user}"), phoneTB.Text))
                {
                    general.UpdateTableEntry(pictureBox, new List<object>() {roleCB.Text, emailTB.Text, passwordTB.Text, nameTB.Text, phoneTB.Text }, ID_user);
                    if (pictureBox.Image != null)
                        general.ImageToNull(pictureBox);
                    else
                        general.ExecuteQuery($"UPDATE Users SET picture = NULL WHERE id_user = {ID_user}");

                    ClearButton_Click(sender, e);
                    new Message("Изменено.", true).ShowDialog();
                }
            }
            else
                new Message("Пользователь не выбран.", false).ShowDialog();
        }
    }
}
