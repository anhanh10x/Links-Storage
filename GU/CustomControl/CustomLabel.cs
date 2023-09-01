using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Gui.CustomControl
{
    public class CustomLabel : Label 
    {
        private bool isClick = false;
        public bool IsClick { get { return isClick; } set { this.isClick = value; } }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            isClick = true;
            this.Invalidate();
        }
    }
}
