using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDesktop.Winforms
{
    public class CustomToolStripRenderer : ToolStripRenderer
    {
        public static Color selectionColor = Color.FromArgb(119, 120, 128);
        Brush selectionBrush = new SolidBrush(selectionColor);
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected)
            {
                e.Graphics.FillRectangle(selectionBrush, e.Item.ContentRectangle);
            }
            else
            {
                base.OnRenderMenuItemBackground(e);
            }
        }
    }
}
