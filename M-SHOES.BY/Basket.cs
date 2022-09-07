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
    public partial class Basket : UserControl
    {
        public long ID_user { get; set; }
        readonly General general;
        public static string connectString;

        public Basket(long id_user)
        {
            InitializeComponent();
            general = new General();
            connectString = general.StringConnection();
            ID_user = id_user;
            FillBasket();
        }

        private async void FillBasket()
        {
            var amount = general.ReturnElement($"SELECT COUNT(*) FROM Order_realisation INNER JOIN Basket ON Order_realisation.id_order_realisation = Basket.id_order_realisation WHERE {ID_user} = Order_realisation.id_user AND Order_realisation.realized = 0");
            if(!amount.Equals("0"))
                basketFLP.Controls.Clear(); 
            countBasketL.Text = $"Корзина ({amount}/10):";
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var comm = new SqlCommand($"SELECT id_size,amount,cost,id_basket FROM Order_realisation INNER JOIN Basket ON Order_realisation.id_order_realisation = Basket.id_order_realisation WHERE {ID_user} = Order_realisation.id_user AND Order_realisation.realized = 0 ORDER BY Basket.id_basket DESC", conn);
                using (var reader = comm.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var name = general.ReturnElement($"SELECT CONCAT(brand, ' / ', name) FROM Shoes WHERE id_shoes = " + $"{general.ReturnElement($"SELECT id_shoes FROM Sizes WHERE id_size = {reader[0]}")}");
                            var size = $"{general.ReturnElement($"SELECT size FROM Sizes WHERE id_size = {reader[0]}")}";
                            var color = general.ReturnElement($"SELECT color FROM Shoes WHERE id_shoes = " + $"{general.ReturnElement($"SELECT id_shoes FROM Sizes WHERE id_size = {reader[0]}")}");
                            var id_shoes = general.ReturnElement($"SELECT id_shoes FROM Sizes WHERE id_size = {reader[0]}");
                            await Task.Run(async () =>{ await Task.Delay(5); });
                            basketFLP.Controls.Add(new BasketItem(general.GetPictureFromByte(reader.GetInt64(0)), name, id_shoes, size, color, reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), basketFLP, basketFLP.Controls.Count, ID_user, countBasketL, basketPB));
                            basketFLP.Controls[basketFLP.Controls.Count - 1].Name = $"{basketFLP.Controls.Count - 1}";
                            basketFLP.Refresh();
                        }
                    }
                }
            }
        }
        private void MenuB_Click(object sender, EventArgs e) => menuAnimate.Enabled = true;

        private void ClearBasketB_Click(object sender, EventArgs e)
        {
            general.ExecuteQuery($"DELETE Basket FROM Basket INNER JOIN Order_realisation ON Basket.id_order_realisation = Order_realisation.id_order_realisation WHERE {ID_user} = Order_realisation.id_user AND Order_realisation.realized = 0");
            general.ClearBasket(basketFLP,countBasketL,ID_user,menuAnimate,menuB, basketPB);
        }

        private void MenuAnimate_Tick(object sender, EventArgs e)
        {
            if (menuP.Width != 500)
            {
                while (menuP.Width != 500)
                {
                    menuP.Width += 5;
                    countBasketL.Left += 5;
                }
                menuAnimate.Enabled = false;
            }
            else
            {
                while (menuP.Width != 90)
                {
                    menuP.Width -= 5;
                    countBasketL.Left -= 5;
                }
                menuAnimate.Enabled = false;
            }
        }

        private void OrderB_Click(object sender, EventArgs e) => new OrderRealisation(ID_user, countBasketL, basketFLP, menuAnimate, menuB, basketPB).ShowDialog();
    }
}
