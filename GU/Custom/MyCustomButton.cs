using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Gui.CustomControl
{
    public class MyCustomButton : Button
    {
        //Field
        private Color backGroundColor;
        private Color borderColor;
        private int borderSize;
        private int lengthEdge;
        private int outerLength=30;
        private int innerLength=30;
        private int outerHigh=30;
        private int innerHigh=30;
        private Image icon;
        private bool isHaveIcon = false;
        //Properties
        public Color BackGroundColor
        {
            get { return this.backGroundColor; }
            set { this.backGroundColor = value; this.Invalidate(); }
        }
        public Color BorderColor
        {
            get { return this.borderColor; }
            set { this.borderColor = value; this.Invalidate(); }
        }
        public int BorderSize
        {
            get { return this.borderSize; }
            set { this.borderSize = value; this.Invalidate(); }
        }
        public int LengthEdge
        {
            get { return this.lengthEdge; }
            set { this.lengthEdge = value; this.Invalidate(); }
        }
        public int InnerLength
        {
            get { return this.innerLength; }
            set { this.innerLength = value; this.Invalidate(); }
        }
        public int OuterLength
        {
            get { return this.outerLength; }
            set { this.outerLength = value; this.Invalidate(); }
        }
        public int InnerHigh
        {
            get { return this.innerHigh; }
            set { this.innerHigh = value; this.Invalidate(); }
        }
        public int OuterHigh
        {
            get { return this.outerHigh; }
            set { this.outerHigh = value; this.Invalidate(); }
        }
        public Image Icon
        {
            get { return this.icon; }
            set { this.icon = value; this.Invalidate(); }
        }
        public bool IsHaveIcon
        {
            set { this.isHaveIcon = value; this.Invalidate(); }
            get { return this.isHaveIcon;}
        }
    //Contructor
        public MyCustomButton()
        {
            this.AutoSize = false;
            this.backGroundColor = Color.Aqua;
            this.borderColor = Color.FloralWhite;
            this.borderSize = 3;
            this.lengthEdge = 30;
            this.innerLength = 30;
            this.outerLength = 20;
            this.Size = new Size(50, 50);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Text = "";
            
        }
        //Method
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            GraphicsPath path = new GraphicsPath();
            Pen pen = new Pen(this.BorderColor, this.BorderSize);
            Rectangle motherRect = new Rectangle(0, 0, this.Width, this.Width);
            Rectangle outerRect = new Rectangle(motherRect.X, motherRect.X, OuterLength, OuterHigh);
            Rectangle innerRect = new Rectangle(motherRect.X, motherRect.Y, InnerLength, InnerHigh);
            path.StartFigure();
            path.AddRectangle(outerRect);
            path.CloseFigure();
            if (BorderSize != 0)
                pevent.Graphics.DrawPath(pen, path);
            if (isHaveIcon == true)
            {
                pevent.Graphics.DrawImage(Icon, innerRect);
            }
        }

    }
}