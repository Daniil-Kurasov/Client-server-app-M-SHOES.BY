using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M_SHOES.BY
{
    public class FlowLayoutPanelDoubleBuffered : FlowLayoutPanel
    {
        public FlowLayoutPanelDoubleBuffered() : base()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnScroll(System.Windows.Forms.ScrollEventArgs se)
        {
            this.Invalidate();
            base.OnScroll(se);
        }
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            this.Invalidate();
            base.OnMouseWheel(e);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
    }
}
