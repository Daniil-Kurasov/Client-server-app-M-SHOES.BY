using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Guna.UI2.WinForms;

namespace M_SHOES.BY
{
    public partial class OrdersEditor : UserControl
    {
        readonly General general;
        public string Query { get; set; }
        public string Query2 { get; set; }
        public Guna2DataGridView DataGridView { get; set; }
        public FlowLayoutPanel FlowLayoutPanel { get; set; }
        public static string connectString;
        public OrdersEditor(string query, string query2, Guna2DataGridView dataGridView, FlowLayoutPanel flowLayoutPanel)
        {
            InitializeComponent();
            Query = query;
            Query2 = query2;
            general = new General();
            connectString = general.StringConnection();
            DataGridView = dataGridView;
            FlowLayoutPanel = flowLayoutPanel;
            FillControls();
            general.FillAddresses(addressesCB);
        }
        private async void FillControls()
        {
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var comm = new SqlCommand(Query2, conn);
                using (var reader = await comm.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        await reader.ReadAsync();
                        idOrderTB.Text = reader.GetInt64(0).ToString();
                        FillControls2(reader.GetInt64(1));
                        general.FillOrder(flowLayoutPanelDoubleBuffered1, reader.GetInt64(1), true);
                        addressesCB.SelectedItem = general.ReturnElement($"SELECT address FROM Self_pickup_points WHERE id_self_pickup_point = {reader.GetInt64(2)}");
                        statusCB.SelectedItem = reader.GetString(3);
                        implementationDateTB.Text = reader.GetDateTime(5).ToShortDateString();
                        deliveryDateDTP.Value = reader.GetDateTime(5).Date;
                        var cost = reader.GetDecimal(6).ToString().Split(',').ToArray();
                        costTB.Text = cost[0];
                        costRealPartTB.Text = cost[1];
                    }
                }
            }
        }
        private void FillControls2(long id_order_realisation)
        {
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var comm = new SqlCommand($"SELECT name, email, phone FROM Users WHERE id_user IN (SELECT id_user FROM Order_realisation WHERE id_order_realisation = {id_order_realisation})", conn);
                using (var reader = comm.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        nameTB.Text = reader.GetString(0);
                        emailTB.Text = reader.GetString(1);
                        phoneTB.Text = reader.GetString(2);
                    }
                }
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (idOrderTB.Text != "")
            {
                var mess = new Message2("Вы действительно хотите удалить данную запись?");
                mess.ShowDialog();
                if (mess.ToString().Equals("True"))
                {
                    var id_order_realisation = general.ReturnElement($"SELECT id_order_realisation FROM Orders WHERE id_order = {idOrderTB.Text}");
                    general.ExecuteQuery($"DELETE FROM Orders WHERE id_order_realisation = {id_order_realisation}");
                    general.ExecuteQuery($"DELETE FROM Basket WHERE id_order_realisation = {id_order_realisation}");
                    general.ExecuteQuery($"DELETE FROM Order_realisation WHERE id_order_realisation = {id_order_realisation}");
                    Clear();
                    new Message("Удалено.", true).ShowDialog();
                }
            }
            else
                new Message("Отзыв не выбран.", false).ShowDialog();
        }

        private void Clear()
        {
            general.UpdateTable(DataGridView, Query);
            FlowLayoutPanel.Controls.Clear();
            FlowLayoutPanel.Controls.Add(new OrdersEditor(Query, Query2, DataGridView, FlowLayoutPanel));
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (idOrderTB.Text != "")
            {
                if (general.CheckLength(costTB.Text))
                {
                    UpdateTableEntry();
                    Clear();
                    new Message("Изменено.", true).ShowDialog();
                }
            }
            else
                new Message("Заказ не выбран.", false).ShowDialog();
        }
        public string[] Array()
        {
            return new[] { statusCB.Text,
                general.ReturnElement($"SELECT address FROM Self_pickup_points WHERE id_self_pickup_point IN (SELECT id_self_pickup_point FROM Orders WHERE id_order = {idOrderTB.Text})") == addressesCB.Text ?
                general.ReturnElement($"SELECT id_self_pickup_point FROM Orders WHERE id_order = {idOrderTB.Text}") : general.ReturnElement($"SELECT id_self_pickup_point FROM Self_pickup_points WHERE address = '{addressesCB.Text}'"),
                deliveryDateDTP.Value.Date.ToString(), costTB.Text + "." + (costRealPartTB.Text == "" ? costRealPartTB.PlaceholderText : costRealPartTB.Text) }; 
        }
        private void UpdateTableEntry()
        {
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var comm = new SqlCommand($"UPDATE Orders SET status = @0, id_self_pickup_point = @1, delivery_date = @2, cost = @3 WHERE id_order = {idOrderTB.Text}", conn);
                var array = Array();
                for (var i = 0; i < array.Length; i++)
                    comm.Parameters.AddWithValue($"@{i}", array[i]);
                comm.ExecuteNonQuery();
            }
        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            var mess = new Message2("Вы действительно хотите отменить заказ?");
            mess.ShowDialog();
            if (mess.ToString().Equals("True"))
            {
                var id_order_realisation = general.ReturnElement($"SELECT id_order_realisation FROM Orders WHERE id_order = {idOrderTB.Text}");
                general.QuantityGoods(id_order_realisation, "+=");
                general.ExecuteQuery($"DELETE FROM Orders WHERE id_order_realisation = {id_order_realisation}");
                general.ExecuteQuery($"DELETE FROM Basket WHERE id_order_realisation = {id_order_realisation}");
                general.ExecuteQuery($"DELETE FROM Order_realisation WHERE id_order_realisation = {id_order_realisation}");
                Clear();
                new Message("Заказ отменен.", true).ShowDialog();
            }
        }
    }
}
