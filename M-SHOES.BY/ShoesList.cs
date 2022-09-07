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
    public partial class ShoesList : UserControl
    {
        readonly General general;
        public long ID_shoes { get; set; }
        public long ID_user { get; set; }
        bool flag = false;
        public ShoesList(long id_user, long id_shoes, string name, string brand, string price, string discount, byte[] picture)
        {
            InitializeComponent();
            general = new General();
            ID_shoes = id_shoes;
            general.GetPicture(pictureBox, picture);
            likedIB.Parent = pictureBox;
            starPB.Parent = pictureBox;
            ratingL.Parent = pictureBox;
            brandAndNameL.Text = brand + @" / " + name;
            if(int.Parse(discount) != 0)
            {
                discountL.Text = discount + "%";
                discountL.Visible = true;
                priceL.ForeColor = Color.Brown;
                priceL.Text = Math.Round(float.Parse(price) - float.Parse(price) * float.Parse(discount) / 100, 2) + " р.";
            }
            else
                priceL.Text = price + " р.";
            ID_user = id_user;
            ratingL.Text = float.Parse(general.ReturnElement($"SELECT round(AVG(mark),2) FROM Reviews WHERE id_shoes = {ID_shoes}")).ToString();
            if (!general.ReturnElement($"SELECT id_liked FROM Liked where id_user = {ID_user} AND id_shoes = {ID_shoes}").Equals("0"))
            {
                likedIB.Image = Properties.Resources.HeartRed;
                flag = true;
            }
        }
        private void ShoesListP_Click(object sender, EventArgs e) => ShowItem();
        private void PictureBox_Click(object sender, EventArgs e) => ShowItem();
        private void BrandAndNameL_Click(object sender, EventArgs e) => ShowItem();
        private void PriceL_Click(object sender, EventArgs e) => ShowItem();
        private void ShowItem() => new ShoesItem(ID_user, ID_shoes).ShowDialog();
        private void DiscountL_Click(object sender, EventArgs e) => ShowItem();
        private void PriceAndDiscountFLP_Click(object sender, EventArgs e) => ShowItem();
        private void PictureBox_MouseMove(object sender, MouseEventArgs e) => shoesListP.BorderColor = Color.RoyalBlue;
        private void PictureBox_MouseLeave(object sender, EventArgs e) => shoesListP.BorderColor = Color.Gray;
        private void PriceAndDiscountFLP_MouseMove(object sender, MouseEventArgs e) => shoesListP.BorderColor = Color.RoyalBlue;
        private void PriceAndDiscountFLP_MouseLeave(object sender, EventArgs e) => shoesListP.BorderColor = Color.Gray;
        private void BrandAndNameL_MouseMove(object sender, MouseEventArgs e) => shoesListP.BorderColor = Color.RoyalBlue;
        private void BrandAndNameL_MouseLeave(object sender, EventArgs e) => shoesListP.BorderColor = Color.Gray;
        private void DiscountL_MouseMove(object sender, MouseEventArgs e) => shoesListP.BorderColor = Color.RoyalBlue;
        private void DiscountL_MouseLeave(object sender, EventArgs e) => shoesListP.BorderColor = Color.Gray;
        private void PriceL_MouseMove(object sender, MouseEventArgs e) => shoesListP.BorderColor = Color.RoyalBlue;
        private void PriceL_MouseLeave(object sender, EventArgs e) => shoesListP.BorderColor = Color.Gray;
        private void StarPB_MouseMove(object sender, MouseEventArgs e) => shoesListP.BorderColor = Color.RoyalBlue;
        private void StarPB_MouseLeave(object sender, EventArgs e) => shoesListP.BorderColor = Color.Gray;
        private void LikedIB_MouseMove(object sender, MouseEventArgs e) => shoesListP.BorderColor = Color.RoyalBlue;
        private void LikedIB_MouseLeave(object sender, EventArgs e) => shoesListP.BorderColor = Color.Gray;
        private void RatingL_MouseMove(object sender, MouseEventArgs e) => shoesListP.BorderColor = Color.RoyalBlue;
        private void RatingL_MouseLeave(object sender, EventArgs e) => shoesListP.BorderColor = Color.Gray;
        private void LikedIB_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                likedIB.Image = Properties.Resources.HeartRed;
                flag = true;
                general.InsertIntoTable("Liked", new string[] { ID_user.ToString(), ID_shoes.ToString() });
            }
            else
            {
                likedIB.Image = Properties.Resources.HeartTransparent;
                flag = false;
                general.ExecuteQuery($"DELETE FROM Liked WHERE id_user = {ID_user} AND id_shoes = {ID_shoes}");
            }
        }
    }
}
