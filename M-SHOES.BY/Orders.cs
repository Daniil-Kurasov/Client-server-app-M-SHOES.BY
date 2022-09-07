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
    public partial class Orders : UserControl
    {
        public long ID_user { get; set; }
        readonly General general;
        public static string connectString;
        public Orders(long id_user)
        {
            InitializeComponent();
            general = new General();
            connectString = general.StringConnection();
            ID_user = id_user;
            FillOrders();
        }

        public async void FillOrders()
        {
            var amount = general.ReturnElement($"SELECT COUNT(*) FROM Orders INNER JOIN Order_realisation ON Orders.id_order_realisation = Order_realisation.id_order_realisation WHERE Order_realisation.id_user = {ID_user} AND Order_realisation.realized = 1");
            if (!amount.Equals("0"))
                ordersFLP.Controls.Clear();
            countOrdersL.Text = $"Заказы ({amount}):";
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var comm = new SqlCommand($"SELECT Orders.id_order, Orders.status, Orders.id_self_pickup_point, Orders.delivery_date, Orders.cost, Orders.id_order_realisation FROM Orders INNER JOIN Order_realisation ON Orders.id_order_realisation = Order_realisation.id_order_realisation WHERE Order_realisation.id_user = {ID_user} AND Order_realisation.realized = 1 ORDER BY Orders.id_order DESC", conn);
                using (var reader = comm.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        var c = 0;
                        while (reader.Read())
                        {
                            ++c;
                            string address = general.ReturnElement($"SELECT address FROM Self_pickup_points WHERE id_self_pickup_point = {reader[2]}");
                            await Task.Run(async () => { await Task.Delay(5); });
                            ordersFLP.Controls.Add(new Order(reader[0].ToString(), reader[1].ToString(), address, reader.GetDateTime(3).ToLongDateString(), reader[4].ToString(), reader[5].ToString(), ID_user));
                            if(c == 2)
                            { ordersFLP.Refresh(); c = 0; }
                        }
                    }   
                }
            }
        }

    }
}
