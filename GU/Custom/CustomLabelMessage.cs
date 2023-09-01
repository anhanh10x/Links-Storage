using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace Gui.CustomControl
{
    public class CustomLabelMessage : Label
    {
        //Field
        private string customText = "";
        private Image icon;
        private bool isShow = true;
        private int length = 20;
        private Point point = new Point(0, 0);
        public string CustomText
        {
            get { return this.customText; }
            set { this.customText = value; }
        }
        public Image Icon
        {
            get { return this.icon; }
            set { this.icon = value; this.Invalidate(); }
        }
        public bool IsShow
        {
            get { return this.isShow; }
            set {this.isShow = value; this.Invalidate(); }
        }
        public int Length
        {
            get { return this.length; }
            set { this.length = value; this.Invalidate(); }
        }
        public Point Point
        {
            get { return this.point; }
            set { this.point = value; this.Invalidate(); }
        }
        //Contructor
        public CustomLabelMessage()
        {
            this.AutoSize = false;
            this.BackColor = Color.Transparent;
            this.Text = "";
        }

        //Override Method
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (this.IsShow == true)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Rectangle rectIcon = new Rectangle(point.X, point.Y, this.Length, this.Length);
                e.Graphics.DrawImage(Icon, rectIcon);
                e.Graphics.DrawString(CustomText, this.Font, new SolidBrush(this.ForeColor), this.Length + 6, 2);
            }
        }
    }
}
