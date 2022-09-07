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
    public partial class ShoesItem : Form
    {
        readonly General general;
        public long ID_user { get; set; }
        public long ID_shoes { get; set; }
        public static string connectString;

        List<byte[]> pictures;
        int counter = 0;
        public ShoesItem(long id_user, long id_shoes)
        {
            InitializeComponent();
            general = new General();
            connectString = general.StringConnection();
            ID_user = id_user;
            ID_shoes = id_shoes;
        }
        private void ShoesItem_Load(object sender, EventArgs e)
        {
            FillPictureBox();
            FillShoesItem();
            FillSizes();
            general.FillAddresses(addressesCB);
            FillReviews();
            general.FillDate(dateCB);
            IsExistReview2();
        }
        private void FillAmount(Guna2ComboBox size, Guna2ComboBox amount)
        {
            if (size.SelectedIndex != -1)
            {
                amount.Items.Clear();
                long.TryParse(general.ReturnElement($"SELECT amount FROM Sizes WHERE id_size IN (SELECT id_size FROM Sizes WHERE id_shoes = {ID_shoes} AND size = {size.SelectedItem.ToString().Replace(",", ".")})"), out long count);
                if (count >= 10)
                {
                    for (int i = 0; i < 10; i++)
                        amount.Items.Insert(i, i + 1);
                }
                else
                {
                    for (int i = 0; i < count; i++)
                        amount.Items.Insert(i, i + 1);
                }
            }
        }

        private void FillPictureBox()
        {
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var comm = new SqlCommand($"SELECT picture FROM Pictures WHERE id_shoes = {ID_shoes}", conn);
                using (var reader = comm.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        pictures = new List<byte[]>();
                        while (reader.Read())
                            pictures.Add((byte[])reader[0]);
                    }
                }
            }
            general.GetPicture(pictureBox, pictures.ElementAt(counter));
            listL.Text = $"{counter + 1} / {pictures.Count}";
        }
        private void FillShoesItem()
        {
            ratingStar1.Value = float.Parse(general.ReturnElement($"SELECT round(AVG(mark),2) FROM Reviews WHERE id_shoes = {ID_shoes}"));
            ratingL.Text = Math.Round(ratingStar1.Value,2).ToString();
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var comm = new SqlCommand($"SELECT name, brand, price, discount, production_country, type, color, material, season, gender, description FROM Shoes WHERE id_shoes = {ID_shoes}", conn);
                using (var reader = comm.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        idShoesTB.Text += ID_shoes.ToString();
                        nameTB.Text = reader[0].ToString();
                        brandTB.Text = reader[1].ToString();
                        if (int.Parse(reader[3].ToString()) != 0)
                        {
                            priceL.Text = reader[2].ToString() + " р.";
                            priceWithDiscountL.Text = Math.Round(float.Parse(reader[2].ToString()) - float.Parse(reader[2].ToString()) * float.Parse(reader[3].ToString()) / 100, 2) + " р.";
                            discountL.Text = reader[3].ToString() + " %";
                            discountL.Visible = true;
                            priceWithDiscountL.Visible = true;
                        }
                        else
                            priceL.Text = reader[2].ToString() + " р.";
                        descriptionL.Text = reader[10].ToString();
                        genderL.Text += reader[9].ToString();
                        typeL.Text += reader[5].ToString();
                        materialL.Text += reader[7].ToString().Replace(",",", ");
                        seasonL.Text += reader[8].ToString();
                        colorL.Text += reader[6].ToString();
                        productionCountryL.Text += reader[4].ToString();
                    }
                }
            }
        }
        private void FillSizes()
        {
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var comm = new SqlCommand($"SELECT size FROM Sizes WHERE id_shoes = {ID_shoes} AND amount != 0 ORDER BY size ASC", conn);
                using (var reader = comm.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            sizesL.Text += reader[0].ToString() + "  ";
                            sizesCB.Items.Add(reader[0].ToString());
                            sizes2CB.Items.Add(reader[0].ToString());
                        }
                    }
                }
            }
        }
        private void FillReviews()
        {
            countReviewsL.Text = "Отзывы (" + general.ReturnElement($"SELECT COUNT(*) FROM Reviews WHERE id_shoes = {ID_shoes}") + ")";
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var comm = new SqlCommand($"SELECT date_time, name, mark, review FROM Reviews WHERE id_shoes = {ID_shoes}", conn);
                using (var reader = comm.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                            reviewsFLP.Controls.Add(new Review(DateTime.Parse(reader[0].ToString()).ToLongDateString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString()));
                    }
                }
            }
        }
        private void BackPictureB_Click(object sender, EventArgs e)
        {
            if (counter != 0)
                general.GetPicture(pictureBox, pictures.ElementAt(--counter));
            else
            {
                counter = pictures.Count - 1;
                general.GetPicture(pictureBox, pictures.ElementAt(counter));
            }
            listL.Text = $"{counter + 1} / {pictures.Count}";
        }
        private void ForwardPictureB_Click(object sender, EventArgs e)
        {
            if (counter != pictures.Count - 1)
                general.GetPicture(pictureBox, pictures.ElementAt(++counter));
            else
            {
                counter = 0;
                general.GetPicture(pictureBox, pictures.ElementAt(counter));
            }
            listL.Text = $"{counter + 1} / {pictures.Count}";
        }

        private void RatingStar2_ValueChanged(object sender, EventArgs e) => markL.Text = ratingStar2.Value.ToString();

        private void ReviewRTB_TextChanged(object sender, EventArgs e) => reviewL.Text = $"отзыв ({reviewRTB.Text.Length} / 2000)";

        private string Message() => general.ReturnElement($"SELECT COUNT(*) FROM Reviews WHERE id_user = {ID_user} AND id_shoes = {ID_shoes}").Equals("0") ? "Вы действительно хотите оставить отзыв?" : "Вы действительно хотите изменить отзыв?"; 
        private void ConfirmB_Click(object sender, EventArgs e)
        {
            if (general.CheckLength(reviewRTB.Text))
            {
                var message2 = new Message2(Message());
                message2.ShowDialog();
                if (message2.ToString().Equals("True"))
                {
                    if (IsExistReview())
                    {
                        general.InsertIntoTable("Reviews", new[] {ID_user.ToString(), ID_shoes.ToString(),
                        DateTime.Now.ToLocalTime().ToString(), general.ReturnElement($"SELECT name FROM Users WHERE id_user = {ID_user}"), ratingStar2.Value.ToString().Replace(",","."), reviewRTB.Text});
                        confirmB.Text = "Изменить";
                    }
                    else
                    {
                        using (var conn = new SqlConnection(connectString))
                        {
                            conn.Open();
                            var comm = new SqlCommand($"UPDATE Reviews SET mark = @1, review = @2 WHERE id_user = {ID_user} AND id_shoes = {ID_shoes}", conn);
                            comm.Parameters.AddWithValue("@1", ratingStar2.Value.ToString().Replace(",", "."));
                            comm.Parameters.AddWithValue("@2", reviewRTB.Text);
                            comm.ExecuteNonQuery();
                        }
                    }
                    reviewsFLP.Controls.Clear();
                    FillReviews();
                    RatingStar1_ValueChanged(sender, e);
                    ratingL.Text = Math.Round(ratingStar1.Value, 2).ToString();
                }
            }
        }

        private bool IsExistReview() => !general.ReturnElement($"SELECT COUNT(*) FROM Reviews WHERE id_user = {ID_user} AND id_shoes = {ID_shoes}").Equals("0") ? false : true;

        private void IsExistReview2()
        {
            if (!general.ReturnElement($"SELECT COUNT(*) FROM Reviews WHERE id_user = {ID_user} AND id_shoes = {ID_shoes}").Equals("0"))
            {
                confirmB.Text = "Изменить";
                ratingStar2.Value = float.Parse(general.ReturnElement($"SELECT mark FROM Reviews WHERE id_user = {ID_user} AND id_shoes = {ID_shoes}"));
                reviewRTB.Text = general.ReturnElement($"SELECT review FROM Reviews WHERE id_user = {ID_user} AND id_shoes = {ID_shoes}");
            }
        }

        private void ReviewRTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (reviewRTB.Text.Length == 0 && char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void RatingStar1_ValueChanged(object sender, EventArgs e) => ratingStar1.Value = float.Parse(general.ReturnElement($"SELECT AVG(mark) FROM Reviews WHERE id_shoes = {ID_shoes}"));

        private void SizesCB_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

        private void AddressesCB_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

        private void DateCB_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

        private void Sizes2CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillAmount(sizes2CB, amount2CB);
            cost2L.Text = "Стоимость:  0 р.";
        }

        private void SizesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillAmount(sizesCB,amountCB);
            costL.Text = "Стоимость заказа:  0 р.";
        }

        private void BasketB_Click(object sender, EventArgs e)
        {
            if (general.CheckLength(sizes2CB.SelectedItem == null ? "" : "true") && general.CheckLength(amount2CB.SelectedItem == null ? "" : "true"))
            {
                if (!general.ReturnElement($"SELECT COUNT(*) FROM Basket WHERE id_order_realisation IN (SELECT id_order_realisation FROM Order_realisation WHERE id_user = {ID_user} AND realized = 0)").Equals("10"))
                {
                    if (!general.ReturnElement($"SELECT COUNT(*) FROM Basket WHERE id_size IN (SELECT id_size FROM Sizes WHERE id_shoes = {ID_shoes} AND size = {sizes2CB.SelectedItem.ToString().Replace(",", ".")}) " +
                        $"AND id_order_realisation IN (SELECT id_order_realisation FROM Order_realisation WHERE id_user = {ID_user} AND realized = 0)").Equals("1"))
                    {
                        if (general.ReturnElement($"SELECT COUNT(*) FROM Order_realisation WHERE id_user = {ID_user} AND realized = 0").Equals("0"))
                            general.InsertIntoTable("Order_realisation", new[] { ID_user.ToString(), "0" });
                        general.InsertIntoTable("Basket", new[] { general.ReturnElement($"SELECT id_order_realisation FROM Order_realisation WHERE id_user = {ID_user} AND realized = 0"),
                        general.ReturnElement($"SELECT id_size FROM Sizes WHERE id_shoes = {ID_shoes} AND size = {sizes2CB.SelectedItem.ToString().Replace(",", ".")}"), amount2CB.SelectedItem.ToString(),
                    discountL.Visible == true ? (int.Parse(amount2CB.SelectedItem.ToString()) * decimal.Parse(priceWithDiscountL.Text.Replace(" р.", ""))).ToString().Replace(",",".") : (int.Parse(amount2CB.SelectedItem.ToString()) * decimal.Parse(priceL.Text.Replace(" р.", ""))).ToString().Replace(",",".")});
                        sizes2CB.SelectedIndex = -1;
                        amount2CB.SelectedIndex = -1;
                        new Message("Добавлено в корзину.", true).ShowDialog();
                    }
                    else
                        new Message("Данный товар с заданным размером уже в корзине.", false).ShowDialog();
                }
                else
                    new Message("Корзина переполнена.", false).ShowDialog();
            }
        }
        bool flag = false;
        private void OrderB_Click(object sender, EventArgs e)
        {
            if (general.CheckLength(sizesCB.SelectedItem == null ? "" : "true") && general.CheckLength(addressesCB.SelectedItem == null ? "" : "true") && general.CheckLength(dateCB.SelectedItem == null ? "" : "true") && general.CheckLength(amountCB.SelectedItem == null ? "" : "true"))
            {
                var message2 = new Message2("Вы действительно хотите сделать заказ?");
                message2.ShowDialog();
                if (message2.ToString().Equals("True"))
                {
                    general.InsertIntoTable("Order_realisation", new[] { ID_user.ToString(), "1" });
                    var id_order_realisation = general.ReturnElement($"SELECT id_order_realisation FROM Order_realisation WHERE id_user = {ID_user} AND realized = 1 ORDER BY id_order_realisation DESC");
                    general.InsertIntoTable("Basket", new[] { id_order_realisation, general.ReturnElement($"SELECT id_size FROM Sizes WHERE id_shoes = {ID_shoes} AND size = {sizesCB.SelectedItem.ToString().Replace(",", ".")}"), amountCB.SelectedItem.ToString(),
                    discountL.Visible == true ? (int.Parse(amountCB.SelectedItem.ToString()) * decimal.Parse(priceWithDiscountL.Text.Replace(" р.", ""))).ToString().Replace(",",".") : (int.Parse(amountCB.SelectedItem.ToString()) * decimal.Parse(priceL.Text.Replace(" р.", ""))).ToString().Replace(",",".")});
                    general.InsertIntoTable("Orders", new[] { id_order_realisation, general.ReturnElement($"SELECT id_self_pickup_point FROM Self_pickup_points WHERE address = '"+addressesCB.SelectedItem.ToString()+"'"),  "активен", DateTime.Now.ToShortDateString(),
                    DateTime.Parse(dateCB.SelectedItem.ToString()).ToShortDateString(), general.ReturnElement($"SELECT sum(Basket.cost) FROM Basket WHERE Basket.id_order_realisation IN (SELECT TOP 1 id_order_realisation FROM Order_realisation WHERE id_user = {ID_user} AND realized = 1 ORDER BY id_order_realisation DESC)").Replace(",",".")});
                    general.ExecuteQuery($"UPDATE Sizes SET amount -= {amountCB.SelectedItem} WHERE id_size IN (SELECT id_size FROM Sizes WHERE id_shoes = {ID_shoes} AND size = {sizesCB.SelectedItem.ToString().Replace(",", ".")})");
                    sizesCB.SelectedIndex = -1;
                    addressesCB.SelectedIndex = -1;
                    dateCB.SelectedIndex = -1;
                    amountCB.SelectedIndex = -1;
                    if (!flag)
                        general.SendToEmail(long.Parse(id_order_realisation), ID_user);
                    else
                        general.IsSendToEmail(ref flag, sendIB);
                    new Message(@"Заказ можно посмотреть в разделе ""Заказы"".", true).ShowDialog();
                }
            }
        }

        private void AmountCB_SelectedIndexChanged(object sender, EventArgs e) => CostString(amountCB, costL, "Стоимость заказа:  ");
        private void Amount2CB_SelectedIndexChanged(object sender, EventArgs e) => CostString(amount2CB, cost2L, "Стоимость:  ");
        private void CostString(Guna2ComboBox amount, Label cost, string text)
        {
            if (amount.SelectedIndex != -1)
            {
                if (discountL.Visible == true)
                    cost.Text = $"{text}{int.Parse(amount.SelectedItem.ToString()) * float.Parse(priceWithDiscountL.Text.Substring(0, priceWithDiscountL.Text.Length - 3))} р.";
                else
                    cost.Text = $"{text}{int.Parse(amount.SelectedItem.ToString()) * float.Parse(priceL.Text.Substring(0, priceL.Text.Length - 3))} р.";
            }
        }
        private void SendIB_Click(object sender, EventArgs e) => general.IsSendToEmail(ref flag, sendIB);
    }
}
