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
    public partial class OrderItem2 : UserControl
    {
        readonly General general;
        public OrderItem2(byte[] picture, string name, string size, string color, string cost, string id_shoes, string amount)
        {
            InitializeComponent();
            general = new General();
            general.GetPicture(pictureBox, picture);
            nameL.Text += name;
            sizeL.Text += size;
            colorL.Text += color;
            costL.Text += cost + " р.";
            idShoesL.Text += id_shoes;
            amountL.Text += amount + " шт.";
        }
    }
}
