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
    public class MyToggle : CheckBox
    {
        //Field 
        private Color onBackGround = Color.White;
        private Color offBackGround = Color.White;
        private Image iconRight;
        private Image iconLeft;
        private Color borderColor = Color.Black;
        private int borderSize= 1;
        private int length = 80;
        private int high = 50;
        private int xLeft=0;
        private int yLeft=0;
        private int xRight = 0;
        private int yRight = 0;
        private int sizeIconLeft = 0;
        private int sizeIconRight = 0;
        private int radiusArc = 20;
        
        //properties 
        public Image IconRight
        {
            get { return this.iconRight; }
            set { this.iconRight = value; this.Invalidate(); }
        }
        public Image IconLeft
        {
            get { return this.iconLeft; }
            set { this.iconLeft = value; this.Invalidate(); }
        }
        public int BorderSize
        {
            get { return this.borderSize; }
            set { this.borderSize = value; this.Invalidate(); }
        }
        public int Length
        {
            get { return this.length; }
            set { this.length = value; this.Invalidate(); }
        }
        public int High
        {
            get { return this.high; }
            set { this.high = value; this.Invalidate(); }
        }
        public int RadiusArc
        {
            get { return this.radiusArc; }
            set { this.radiusArc = value; this.Invalidate(); }
        }
        public Color BorderColor
        {
            get { return this.borderColor; }
            set { this.borderColor = value; this.Invalidate(); }
        }

        public int XLeft
        {
            get { return this.xLeft; }
            set { xLeft = value; this.Invalidate(); }
        }
        public int YLeft
        {
            get { return this.yLeft; }
            set { this.yLeft = value; this.Invalidate(); }
        }
        public int SizeIconLeft
        {
            get { return this.sizeIconLeft; }
            set { sizeIconLeft = value; this.Invalidate(); }
        }
        public int YRight
        {
            get { return this.yRight; }
            set { this.yRight = value; this.Invalidate(); }
        }
        public int XRight
        {
            get { return this.xRight; }
            set { this.xRight = value; this.Invalidate(); }
        }
        public int SizeIconRight
        {
            get { return this.sizeIconRight; }
            set { sizeIconRight = value; this.Invalidate(); }
        }
        public Color OnBackGround
        {
            get { return this.onBackGround; }
            set { this.onBackGround = value; this.Invalidate(); }
        }
        public Color OffBackGround
        {
            get { return this.offBackGround; }
            set { this.offBackGround = value; this.Invalidate(); }
        }
        //Contructor
        public MyToggle()
        {
            this.Text = "";
            this.FlatAppearance.BorderSize = 0;
            this.AutoSize = false;
            this.FlatStyle = FlatStyle.Flat;
            this.MinimumSize = new Size(10, 10);
        }

        //Method
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.Clear(this.Parent.BackColor);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Pen pen = new Pen(this.BorderColor, this.BorderSize);
            GraphicsPath path = new GraphicsPath();
            Rectangle leftRect = new Rectangle(10, 10, this.RadiusArc, this.High-11);
            Rectangle rightRect = new Rectangle(this.Length - this.RadiusArc+10, 10, this.RadiusArc, this.High-11);
            path.StartFigure();
            path.AddArc(leftRect,90,180);
            path.AddArc(rightRect, 270, 180);
            path.CloseFigure();
            if(BorderSize>0)
                pevent.Graphics.DrawPath(pen, path);
            if(this.Checked==true)
            {
                pevent.Graphics.FillPath(new SolidBrush(OnBackGround), path);
                Rectangle Icon = new Rectangle(XRight, YRight, SizeIconRight, SizeIconRight);
                pevent.Graphics.DrawImage(IconRight, Icon);
            }
            else
            {
                pevent.Graphics.FillPath(new SolidBrush(OffBackGround), path);
                Rectangle Icon = new Rectangle(XLeft, YLeft, SizeIconLeft, SizeIconLeft);
                pevent.Graphics.DrawImage(IconLeft, Icon);
            }
        }
    }
}
