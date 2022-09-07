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
    public partial class Workspace : UserControl
    {
        public long ID_user { get; set; }
        public Workspace(long id_user)
        {
            InitializeComponent();
            ID_user = id_user;
        }

        private void TableEditorB_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
            new TableEditor(ID_user).Show();
        }
    }
}
