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
    public partial class SelfPickupPointsEditor : UserControl
    {
        readonly General general;
        public string Query { get; set; }
        public string Query2 { get; set; }
        public Guna2DataGridView DataGridView { get; set; }
        public FlowLayoutPanel FlowLayoutPanel { get; set; }
        public static string connectString;
        long ID_SelfPickupPoint = 0;
        public SelfPickupPointsEditor(string query, string query2, Guna2DataGridView dataGridView, FlowLayoutPanel flowLayoutPanel)
        {
            InitializeComponent();
            Query = query;
            Query2 = query2;
            general = new General();
            connectString = general.StringConnection();
            DataGridView = dataGridView;
            FlowLayoutPanel = flowLayoutPanel;
            FillControls();
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
                        ID_SelfPickupPoint = long.Parse(reader[0].ToString());
                        addressRTB.AppendText(reader[1].ToString());
                        informationRTB.AppendText(reader[2].ToString());
                    }
                }
            }
        }
        public SelfPickupPointsEditor(string query, Guna2DataGridView dataGridView, FlowLayoutPanel flowLayoutPanel)
        {
            InitializeComponent();
            general = new General();
            Query = query;
            connectString = general.StringConnection();
            DataGridView = dataGridView;
            FlowLayoutPanel = flowLayoutPanel;
        }

        private void AddressRTB_TextChanged(object sender, EventArgs e) => addressL.Text = $"адрес ({addressRTB.Text.Length} / 500)";

        private void ClearButton_Click(object sender, EventArgs e)
        {
            general.UpdateTable(DataGridView, Query);
            FlowLayoutPanel.Controls.Clear();
            FlowLayoutPanel.Controls.Add(new SelfPickupPointsEditor(Query, DataGridView, FlowLayoutPanel));
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ID_SelfPickupPoint != 0)
            {
                var message2 = new Message2("Вы действительно хотите удалить данную запись?");
                message2.ShowDialog();
                if (message2.ToString().Equals("True"))
                {
                    using(var conn = new SqlConnection(connectString))
                    {
                        conn.Open();
                        var cmd = new SqlCommand($"SELECT DISTINCT id_order_realisation FROM Order_realisation WHERE id_order_realisation IN (SELECT id_order_realisation FROM Orders WHERE id_self_pickup_point = {ID_SelfPickupPoint})", conn);
                        using(var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    general.ExecuteQuery($"DELETE FROM Basket WHERE id_order_realisation = {reader[0]}");
                                    general.ExecuteQuery($"DELETE FROM Orders WHERE id_order_realisation = {reader[0]}");
                                    general.ExecuteQuery($"DELETE FROM Order_realisation WHERE id_order_realisation = {reader[0]}");
                                }
                            }
                        }
                    }
                    general.ExecuteQuery($"DELETE FROM Self_pickup_points WHERE id_self_pickup_point = {ID_SelfPickupPoint}");                    
                    ClearButton_Click(sender, e);
                    new Message("Удалено.", true).ShowDialog();
                }
            }
            else
                new Message("Пункт самовывоза не выбран.", false).ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (CheckControls())
            {
                general.InsertIntoTable("Self_pickup_points", Array());
                ClearButton_Click(sender, e);
                new Message("Добавлено.", true).ShowDialog();
            }
        }
        private bool CheckControls() => (general.CheckLength(addressRTB.Text) && general.CheckLength(informationRTB.Text)) ? true : false;

        public string[] Array() => new[] { addressRTB.Text, informationRTB.Text };

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (ID_SelfPickupPoint != 0)
            {
                if (CheckControls())
                {
                    UpdateTableEntry();
                    ClearButton_Click(sender, e);
                    new Message("Изменено.", true).ShowDialog();
                }
            }
            else
                new Message("Пункт самовывоза не выбран.", false).ShowDialog();
        }
        private void UpdateTableEntry()
        {
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var comm = new SqlCommand($"UPDATE Self_pickup_points SET address = @0, information = @1 WHERE id_self_pickup_point = {ID_SelfPickupPoint}", conn);
                var array = Array();
                for (var i = 0; i < array.Length; i++)
                    comm.Parameters.AddWithValue($"@{i}", array[i]);
                comm.ExecuteNonQuery();
            }
        } 
        private void InformationRTB_TextChanged(object sender, EventArgs e) => informationL.Text = $"информация ({informationRTB.Text.Length} / 4000)";
    }
}
