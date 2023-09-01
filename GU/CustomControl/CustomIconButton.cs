
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FontAwesome.Sharp;
namespace Gui.CustomControl
{
    public class CustomIconButton : IconButton
    {
        private Color focusColor = Color.White;
        public Color FocusColor
        {
            get { return focusColor; }
            set { focusColor = value; }
        }
        private bool isFocus = false;
        public bool IsFocus
        {
            get { return isFocus; }
            set { isFocus = value; }
        }
    }
}
