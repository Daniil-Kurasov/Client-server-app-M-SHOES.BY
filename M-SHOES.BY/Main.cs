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
using Guna.UI2.WinForms;

namespace M_SHOES.BY
{
    public partial class Main : Form
    {
        readonly General general;
        public static string connectString;
        public long ID_user { get; set; }

        public Main(long id_user)
        {
            InitializeComponent(); 
            general = new General();
            connectString = general.StringConnection();
            ID_user = id_user;
        }

        private void FillControls()
        {
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var comm = new SqlCommand($"SELECT name, picture, role FROM Users WHERE id_user = {ID_user}", conn);
                using (var reader = comm.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        nameL.Text = reader[0].ToString();
                        if (!reader.IsDBNull(1))
                            general.GetPicture(avatarPB, (byte[])reader[1]);
                        if (reader[2].ToString().Equals("администратор"))
                            workspaceB.Visible = true;
                    }
                }
            }
        }
        private void ExitControlBox_Click(object sender, EventArgs e) => Application.Exit();

        private void AccountSettingsB_Click(object sender, EventArgs e)
        {
            ChangeAndClear(accountSettingsB);
            var confirmPassword = new ConfirmPassword(ID_user);
            confirmPassword.ShowDialog();
            if (confirmPassword.ToString().Equals("true"))
                mainFLP.Controls.Add(new AccountSettings(ID_user, nameL, avatarPB));
        }

        private void SelfPickUpPointsB_Click(object sender, EventArgs e)
        {
            ChangeAndClear(selfPickUpPointsB);
            mainFLP.Controls.Add(new SelfPickUpPoints());
        }

        private void ExitB_Click(object sender, EventArgs e)
        {
            ChangeColor();
            exitB.FillColor = Color.Gainsboro;
            var message2 = new Message2("Вы действительно хотите выйти из аккаунта?");
            message2.ShowDialog();
            if (message2.ToString().Equals("True"))
            {
                Hide();
                new SignInSignUpRemind().Show();
            }
        }

        public void WorkspaceB_Click(object sender, EventArgs e)
        {
            ChangeAndClear(workspaceB);
            mainFLP.Controls.Add(new Workspace(ID_user));
            workspaceB.FillColor = Color.Gainsboro;
        }

        private void ShoesB_Click(object sender, EventArgs e)
        {
            ChangeAndClear(shoesB);
            mainFLP.Controls.Add(new Shoes(ID_user, true));
        }

        private void OrdersB_Click(object sender, EventArgs e)
        {
            ChangeAndClear(ordersB);
            mainFLP.Controls.Add(new Orders(ID_user));
        }

        private void BasketB_Click(object sender, EventArgs e)
        {
            ChangeAndClear(basketB);
            mainFLP.Controls.Add(new Basket(ID_user));
        }
        private void ChangeAndClear(Guna2Button button)
        {
            ChangeColor();
            button.FillColor = Color.Gainsboro;
            mainFLP.Controls.Clear();
        }
        private void ChangeColor()
        {
            basketB.FillColor = Color.White;
            ordersB.FillColor = Color.White;
            shoesB.FillColor = Color.White;
            workspaceB.FillColor = Color.White;
            exitB.FillColor = Color.White;
            selfPickUpPointsB.FillColor = Color.White;
            accountSettingsB.FillColor = Color.White;
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            GC.Collect();
            FillControls();
            GC.Collect();
            await Task.Run(() => Task.Delay(200));
            if (workspaceB.FillColor != Color.Gainsboro)
            {
                mainFLP.Controls.Add(new Shoes(ID_user, true));
                shoesB.FillColor = Color.Gainsboro;
            }
        }

        private void LikedB_Click(object sender, EventArgs e)
        {
            ChangeAndClear(shoesB);
            var shoes = new Shoes(ID_user, false);
            shoes.SelectLiked();
            mainFLP.Controls.Add(shoes);
        }
    }
}
