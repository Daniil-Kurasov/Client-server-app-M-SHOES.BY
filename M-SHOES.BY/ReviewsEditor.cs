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
    public partial class ReviewsEditor : UserControl
    {
        readonly General general;
        public string Query { get; set; }
        public string Query2 { get; set; }
        public Guna2DataGridView DataGridView { get; set; }
        public FlowLayoutPanel FlowLayoutPanel { get; set; }
        public static string connectString;
        long ID_review = 0;

        public ReviewsEditor(string query, string query2, Guna2DataGridView dataGridView, FlowLayoutPanel flowLayoutPanel)
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
                        ID_review = long.Parse(reader[0].ToString());
                        dateDTP.Value = DateTime.Parse(reader[3].ToString()).Date;
                        timeDTP.Value = DateTime.Parse(reader[3].ToString());
                        nameTB.Text = reader[4].ToString();
                        markCB.SelectedItem = reader[5].ToString().Replace(',','.');
                        reviewRTB.AppendText(reader[6].ToString());
                    }
                }
            }
        }

        private void NameTB_TextChanged(object sender, EventArgs e) => nameL.Text = $"имя ({nameTB.Text.Length} / 20)";

        private void ReviewRTB_TextChanged(object sender, EventArgs e) => reviewL.Text = $"отзыв ({reviewRTB.Text.Length} / 2000)";

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ID_review != 0)
            {
                var message2 = new Message2("Вы действительно хотите удалить данную запись?");
                message2.ShowDialog();
                if (message2.ToString().Equals("True"))
                {
                    general.ExecuteQuery($"DELETE FROM Reviews WHERE id_review = {ID_review}");
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
            FlowLayoutPanel.Controls.Add(new ReviewsEditor(Query, Query2, DataGridView, FlowLayoutPanel));
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (ID_review != 0)
            {
                if (CheckControls())
                {
                    UpdateTableEntry();
                    Clear();
                    new Message("Изменено.", true).ShowDialog();
                }
            }
            else
                new Message("Отзыв не выбран.", false).ShowDialog();
        }
        private bool CheckControls() => (general.NameCheck(nameTB.Text) && general.CheckLength(reviewRTB.Text)) ? true : false;
        public string[] Array() => new[] { dateDTP.Value.ToShortDateString() + " " + timeDTP.Value.ToLongTimeString(), nameTB.Text, markCB.Text, reviewRTB.Text };
        private void UpdateTableEntry()
        {
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var comm = new SqlCommand($"UPDATE Reviews SET date_time = @0, name = @1, mark = @2, review = @3 WHERE id_review = {ID_review}", conn);
                var array = Array();
                for (var i = 0; i < array.Length; i++)
                    comm.Parameters.AddWithValue($"@{i}", array[i]);
                comm.ExecuteNonQuery();
            }
        }

        private void NameTB_KeyPress(object sender, KeyPressEventArgs e) => general.NameKeyPress(e);
    }
}
