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
    public partial class SelfPickUpPoints : UserControl
    {
        readonly General general;
        public static string connectString;
        public SelfPickUpPoints()
        {
            InitializeComponent();
            general = new General();
            connectString = general.StringConnection();
            LoadAddresses();
        }
        private void LoadAddresses()
        {
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var comm = new SqlCommand("SELECT address FROM Self_pickup_points ORDER BY address ASC", conn);
                using (var reader = comm.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                            addressesLB.Items.Add(reader[0].ToString());
                    }
                }
            }
            addressesLB.SelectedIndex = 0;
        }

        private void AddressesLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (addressesLB.SelectedIndex != -1)
            {
                using (var conn = new SqlConnection(connectString))
                {
                    conn.Open();
                    var comm = new SqlCommand("SELECT information FROM Self_pickup_points WHERE address = '" + addressesLB.SelectedItem.ToString() + "'", conn);
                    informationRTB.Text = comm.ExecuteScalar().ToString();
                }
                LoadLocation($"{addressesLB.SelectedItem.ToString().Replace(' ', '+')}");
            }
        }
        private async void LoadLocation(string address)
        {
            progressBar.Value = 0;
            if (general.IsThereAnInternetConnection(false, string.Empty))
            {
                webBrowser1.Visible = false;
                progressBar.Visible = true;
                connectInternetL.Visible = false;
                await Task.Run(async () =>
                {
                    await Task.Delay(100);
                    webBrowser1.Navigate("https://www.google.com/maps/place/" + $"{address}");
                });
            }
            else
            {
                webBrowser1.Navigate("");
                webBrowser1.Visible = true;
                connectInternetL.Visible = true;
                progressBar.Visible = false;
            } 
        }
        private void LoadT_Tick(object sender, EventArgs e)
        {
            ++progressBar.Value;
            progressL.Text = progressBar.Value.ToString() + " %";
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.Visible = true;
            progressBar.Visible = false;
        }
    }
}
