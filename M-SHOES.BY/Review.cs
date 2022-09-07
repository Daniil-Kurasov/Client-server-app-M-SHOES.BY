using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M_SHOES.BY
{
    public partial class Review : UserControl
    {
        public float Mark { get; set; }
        public Review(string date_time, string name, string mark, string review)
        {
            InitializeComponent();
            Mark = float.Parse(mark);
            ratingStar.Value = Mark;
            nameAndDateL.Text = name + "   (" + date_time + ")";
            reviewText.Text = review;
            Height = reviewText.Location.Y + reviewText.Height;
        }

        private void RatingStar_ValueChanged(object sender, EventArgs e) => ratingStar.Value = Mark;
    }
}
