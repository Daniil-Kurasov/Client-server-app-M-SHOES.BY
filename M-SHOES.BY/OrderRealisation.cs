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
using Guna.UI2.WinForms;

namespace M_SHOES.BY
{
    public partial class OrderRealisation : Form
    {
        readonly General general;
        public static string connectString;
        public Label CountBasketL { get; set; }
        public FlowLayoutPanel BasketFLP { get; set; }
        public Timer MenuAnimate { get; set; }
        public Guna2Button MenuB { get; set; }
        public Guna2PictureBox BasketPB { get; set; }

        long ID_user { get; set; }
        public OrderRealisation(long id_user, Label countBasketL,FlowLayoutPanel basketFLP, Timer menuAnimate, Guna2Button menuB, Guna2PictureBox basketPB)
        {
            InitializeComponent();
            general = new General();
            ID_user = id_user;
            connectString = general.StringConnection();
            general.FillAddresses(addressesCB);
            general.FillDate(dateCB);
            CountBasketL = countBasketL;
            BasketFLP = basketFLP;
            MenuAnimate = menuAnimate;
            MenuB = menuB;
            BasketPB = basketPB;
            costL.Text += general.ReturnElement($"SELECT sum(Basket.cost) FROM Order_realisation INNER JOIN Basket ON Order_realisation.id_order_realisation = Basket.id_order_realisation " + $"WHERE Order_realisation.id_user = {ID_user} AND Order_realisation.realized = 0") + " р.";
        }

        bool flag = false;
        private void SendIB_Click(object sender, EventArgs e) => general.IsSendToEmail(ref flag, sendIB);

        private void OrderB_Click(object sender, EventArgs e)
        {
            if (general.CheckLength(addressesCB.SelectedItem == null ? "" : "true") && general.CheckLength(dateCB.SelectedItem == null ? "" : "true"))
            {
                if (!general.ReturnElement($"SELECT COUNT(*) FROM Order_realisation INNER JOIN Basket ON Order_realisation.id_order_realisation = Basket.id_order_realisation WHERE {ID_user} = Order_realisation.id_user AND Order_realisation.realized = 0").Equals("0"))
                {
                    general.InsertIntoTable("Orders", new[] { general.ReturnElement($"SELECT id_order_realisation FROM Order_realisation WHERE id_user = {ID_user} AND realized = 0"),
            general.ReturnElement($"SELECT id_self_pickup_point FROM Self_pickup_points WHERE address = '"+addressesCB.SelectedItem.ToString()+"'"), "активен", DateTime.Now.ToShortDateString(),
            DateTime.Parse(dateCB.SelectedItem.ToString()).ToShortDateString(), general.ReturnElement($"SELECT sum(Basket.cost) FROM Order_realisation INNER JOIN Basket ON Order_realisation.id_order_realisation = Basket.id_order_realisation " +
            $"WHERE Order_realisation.id_user = {ID_user} AND Order_realisation.realized = 0").Replace(",",".")});
                    general.ExecuteQuery($"UPDATE Order_realisation SET realized = 1 WHERE id_user = {ID_user} AND realized = 0");
                    var id_order_realisation = general.ReturnElement($"SELECT id_order_realisation FROM Order_realisation WHERE id_user = {ID_user} AND realized = 1 ORDER BY id_order_realisation DESC");
                    general.QuantityGoods(id_order_realisation, "-=");
                    general.ClearBasket(BasketFLP, CountBasketL, ID_user, MenuAnimate, MenuB, BasketPB);
                    if (!flag)
                        general.SendToEmail(long.Parse(id_order_realisation), ID_user);
                    this.Hide();
                    new Message(@"Заказ можно посмотреть в разделе ""Заказы"".", true).ShowDialog();
                }
                else
                    new Message("Корзина пуста.", false).ShowDialog();
            }
        }
    }
}
