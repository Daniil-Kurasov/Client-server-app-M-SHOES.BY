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
    public partial class Order : UserControl
    {
        readonly General general;
        public long ID_order_realisation { get; set; }
        public static string connectString;
        long ID_user { get; set; }
        public Order(string id_order,string status, string address, string delivery_date, string cost, string id_order_realisation, long id_user)
        {
            InitializeComponent();
            general = new General();
            connectString = general.StringConnection();
            orderNumberL.Text += id_order;
            if (status.Equals("активен"))
            {
                statusL.ForeColor = Color.MediumSeaGreen;
                orderP.BorderColor = Color.MediumSeaGreen;
            }
            statusL.Text += status;
            addressL.Text += address;
            deliveryDateL.Text += delivery_date;
            costL.Text += cost + " р.";
            ID_order_realisation = long.Parse(id_order_realisation);
            detailsB.Name = general.ReturnElement($"SELECT COUNT(*) FROM Basket WHERE id_order_realisation = {ID_order_realisation}");
            ID_user = id_user;
        }

        private void DetailsB_Click(object sender, EventArgs e)
        {
            if (this.Height != 215 + int.Parse(detailsB.Name) * 210)
            {
                detailsB.Image = Properties.Resources.Close;
                orderFLP.Height += int.Parse(detailsB.Name) * 210;
                this.Height += int.Parse(detailsB.Name) * 210;
                general.FillOrder(orderFLP, ID_order_realisation, false);
                guna2HtmlToolTip1.SetToolTip(detailsB, "Скрыть");
            }
            else
            {
                detailsB.Image = Properties.Resources.Open;
                orderFLP.Height -= int.Parse(detailsB.Name) * 210;
                this.Height = 215;
                for (int i = 0; i < int.Parse(detailsB.Name); i++)
                    orderFLP.Controls.RemoveAt(orderFLP.Controls.Count - 1);
                guna2HtmlToolTip1.SetToolTip(detailsB, "Раскрыть");
            }
        }

        private void DownloadIB_Click(object sender, EventArgs e)
        {
            if(this.Height != 215 + int.Parse(detailsB.Name) * 210)
                DetailsB_Click(sender, e);
            var saveFileDialog = new SaveFileDialog { Filter = "Image Files(*.JPG; *.JPEG;*.BMP,*.PNG)|*.JPG; *.JPEG;*.BMP; *.PNG", DefaultExt = "JPG", FileName = "Заказ" };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var bitmap = new Bitmap(orderP.Width, orderP.Height);
                orderP.DrawToBitmap(bitmap, orderP.Bounds);
                bitmap.Save(saveFileDialog.FileName);
            }
            DetailsB_Click(sender, e);
        }
        public Bitmap OrderP()
        {
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var comm = new SqlCommand($"SELECT id_size, cost, amount FROM Basket WHERE id_order_realisation = {ID_order_realisation}", conn);
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
                            orderFLP.Controls.Add(new OrderItem(general.GetPictureFromByte(reader.GetInt64(0)), name, size, color, reader[1].ToString(), id_shoes, reader[2].ToString()));
                        }
                    }
                }
            }
            detailsB.Image = Properties.Resources.Close;
            orderFLP.Height += int.Parse(detailsB.Name) * 210;
            this.Height += int.Parse(detailsB.Name) * 210;
            var bitmap = new Bitmap(orderP.Width, orderP.Height);
            orderP.DrawToBitmap(bitmap, orderP.Bounds);
            return bitmap;
        }
        private void SendToEmail_Click(object sender, EventArgs e)
        {
            var message2 = new Message2("Вы действительно хотите отправить на почту?");
            message2.ShowDialog();
            if (message2.ToString().Equals("True"))
                general.SendToEmail(ID_order_realisation, ID_user);
        }
    }
}
