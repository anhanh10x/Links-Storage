using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Gui.CustomControl
{
    public class CustomPanel : Panel
    {

        //Field
        private int radius = 1;
        private int borderSize = 0;
        private Color borderColor = Color.White;
        private Color backgroundColor = Color.White;
        private Color leftTopColor = Color.White;
        private Color leftBottomColor = Color.White;
        private Color rightTopColor = Color.White;
        private Color rightBottomColor = Color.White;
       
        //Properties
        public int Radius
        {
            get { return this.radius; }
            set { this.radius = value; this.Invalidate(); }
        }
        public int BorderSize
        {
            get { return this.borderSize; }
            set { this.borderSize = value; this.Invalidate(); }
        }
        public Color LeftTopColor
        {
            get { return this.leftTopColor; }
            set { this.leftTopColor = value; this.Invalidate(); }
        }
        public Color BorderColor
        {
            get { return this.borderColor; }
            set { this.borderColor = value; this.Invalidate(); }
        }
        public Color BackgroundColor
        {
            get { return this.backgroundColor; }
            set { this.backgroundColor = value; this.Invalidate(); }
        }
        public Color LeftBottomColor
        {
            get { return this.leftBottomColor; }
            set { this.leftBottomColor = value; this.Invalidate(); }
        }
        public Color RightTopColor
        {
            get { return this.rightTopColor; }
            set { this.rightTopColor = value; this.Invalidate(); }
        }
        public Color RightBottomColor
        {
            get { return this.rightBottomColor; }
            set { this.rightBottomColor = value; this.Invalidate(); }
        }

        public CustomPanel ()
        {
            this.Dock = DockStyle.Fill;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle motherRect = new Rectangle(0, 0, this.Width, this.Height);
            e.Graphics.FillRectangle(new SolidBrush(this.LeftTopColor), new Rectangle(0, 0, this.Radius, this.Radius));
            e.Graphics.FillRectangle(new SolidBrush(this.LeftBottomColor), new Rectangle(0, motherRect.Height - this.Radius, this.Radius, this.Radius));
            e.Graphics.FillRectangle(new SolidBrush(this.RightTopColor), new Rectangle(motherRect.Width - this.Radius, 0, this.Radius, this.Radius));
            e.Graphics.FillRectangle(new SolidBrush(this.RightBottomColor), new Rectangle(motherRect.Width - this.Radius, motherRect.Height - this.Radius, this.Radius, this.Radius));
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, this.Radius * 2, this.Radius * 2), 180, 90);
            path.AddArc(new Rectangle(motherRect.Width - this.Radius*2, 0, this.Radius * 2, this.Radius * 2), 270, 90);
            path.AddArc(new Rectangle(motherRect.Width - this.Radius*2, motherRect.Height - this.Radius*2, this.Radius * 2, this.Radius * 2), 0, 90);
            path.AddArc(new Rectangle(0, motherRect.Height - this.Radius * 2, this.Radius * 2, this.Radius * 2), 90, 90);
            path.CloseFigure();

            e.Graphics.FillPath(new SolidBrush(this.BackgroundColor), path);
            if (this.BorderSize >= 1) { e.Graphics.DrawPath(new Pen(this.BorderColor, this.BorderSize), path); }
            base.OnPaint(e);
        }
    }
}
