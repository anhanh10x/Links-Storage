using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui.CustomControl
{
    public partial class CustomPictureBox : UserControl
    {
        private Color borderColor = Color.White;
        public Color BorderColor
        {
            get { return this.borderColor; }
            set { this.borderColor = value; this.Invalidate(); }
        }
        private int borderSize = 2;
        public int BorderSize
        {
            get { return this.borderSize; }
            set { this.borderSize = value; this.Invalidate(); }
        }
        private Image icon;
        public Image Icon
        {
            get { return this.icon; }
            set { this.icon = value; this.Invalidate(); }
        }
        private int length = 3;
        public int Length
        {
            get { return this.length; }
            set { this.length = value; this.Invalidate(); }
        }
        private bool isDrawBorder = true;
        public bool IsDrawBorder
        {
            get { return this.isDrawBorder; }
            set { this.isDrawBorder = value; this.Invalidate(); }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle rect = Rectangle.Inflate(ClientRectangle, -this.Length, -this.Length);
            e.Graphics.DrawImage(Icon, rect);
            if (IsDrawBorder == true)
                e.Graphics.DrawRectangle(new Pen(BorderColor, BorderSize), rect);
        }
    }
}