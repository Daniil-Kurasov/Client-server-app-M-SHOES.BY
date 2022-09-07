using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M_SHOES.BY
{
    public partial class PicturesView : UserControl
    {
        readonly General general;
        public string Query { get; set; }
        public static string connectString;
        public PicturesView(string query)
        {
            InitializeComponent();
            Query = query;
            general = new General();
            connectString = general.StringConnection();
            FillControls();
        }

        private void FillControls()
        {
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var comm = new SqlCommand(Query, conn);
                using (var reader = comm.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        general.GetPicture(pictureBox, (byte[])reader[2]);
                    }
                }
            }
        }
    }
}
