using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace M_SHOES.BY
{
    public partial class BasketItem : UserControl
    {
        readonly General general;

        public long ID_basket { get; set; }
        public long ID_user { get; set; }
        public long ID_shoes { get; set; }
        public FlowLayoutPanel BasketFLP { get; set; }
        public int Count { get; set; }
        public Label CountBasketL {get;set;}
        public Guna2PictureBox BasketPB { get; set; }
        public BasketItem(byte[] picture, string name, string id_shoes, string size, string color, string amount, string cost, string id_basket, FlowLayoutPanel basketFLP, int count, long id_user, Label countBasketL, Guna2PictureBox basketPB)
        {
            InitializeComponent();
            general = new General();
            general.GetPicture(pictureBox, picture);
            ID_shoes = long.Parse(id_shoes);
            idShoesL.Text += ID_shoes.ToString();
            nameL.Text += name;
            sizeL.Text += size;
            colorL.Text += color;
            amount = CheckAmount(size, amount);
            amountL.Text += amount + " шт.";
            costL.Text += cost +" р.";
            ID_basket = long.Parse(id_basket);
            BasketFLP = basketFLP;
            Count = count;
            ID_user = id_user;
            CountBasketL = countBasketL;
            amountNUD.Value = int.Parse(amount);
            BasketPB = basketPB;
        }
        private string CheckAmount(string size, string amount)
        {
            long.TryParse(general.ReturnElement($"SELECT amount FROM Sizes WHERE id_size IN (SELECT id_size FROM Sizes WHERE id_shoes = {ID_shoes} AND size = {size.Replace(",", ".")})"), out long count);
            if (long.Parse(amount) > count)
            {
                general.ExecuteQuery($"UPDATE Basket SET amount = {count}, cost = {count} * (SELECT IIF((discount <> 0),round(price - price * discount / 100, 2),price) FROM Shoes WHERE id_shoes = {ID_shoes}) WHERE id_basket = {ID_basket}");
                amountNUD.Maximum = count;
                return count.ToString();
            }
            else if (count <= 10)
            {
                remainderL.Text = $"Осталось {count} шт.";
                remainderL.Visible = true;
                amountNUD.Maximum = count;
            }
            return amount;
        }

        private void AmountNUD_ValueChanged(object sender, EventArgs e)
        {
            general.ExecuteQuery($"UPDATE Basket SET amount = {amountNUD.Value}, cost = {amountNUD.Value} * (SELECT IIF((discount <> 0),round(price - price * discount / 100, 2),price) FROM Shoes WHERE id_shoes = {ID_shoes}) WHERE id_basket = {ID_basket}");
            amountL.Text = "Количество:  " + general.ReturnElement($"SELECT amount FROM Basket WHERE id_basket = {ID_basket}") + " шт.";
            costL.Text = "Стоимость:  " + general.ReturnElement($"SELECT cost FROM Basket WHERE id_basket = {ID_basket}") + " р.";
        }

        private void DeleteIB_Click(object sender, EventArgs e)
        {
            var message2 = new Message2("Убрать из корзины?");
            message2.ShowDialog();
            if (message2.ToString().Equals("True"))
            {
                general.ExecuteQuery($"DELETE FROM Basket WHERE id_basket = {ID_basket}");
                BasketFLP.Controls.RemoveByKey(Count.ToString());
                var amount = general.ReturnElement($"SELECT COUNT(*) FROM Order_realisation INNER JOIN Basket ON Order_realisation.id_order_realisation = Basket.id_order_realisation WHERE {ID_user} = Order_realisation.id_user AND Order_realisation.realized = 0");
                if (amount.Equals("0"))
                    BasketFLP.Controls.Add(BasketPB);
                CountBasketL.Text = $"Корзина ({amount}/10):";
            }
        }
    }
}
