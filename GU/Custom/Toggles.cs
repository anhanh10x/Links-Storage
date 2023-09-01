using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui.CustomControl
{
    public class Toggles : CheckBox
    {
        //Field 
        private Color onBackColor;
        [Category("Toggle")]
        public Color OnBackColor
        {
            get { return this.onBackColor; }
            set { this.onBackColor = value; this.Invalidate(); }
        }
        private Color onToggleColor;
        [Category("Toggle")]
        public Color OnToggleColor
        {
            get { return this.onToggleColor; }
            set { this.onToggleColor = value; this.Invalidate(); }
        }
        private Color offBackColor;
        [Category("Toggle")]
        public Color OffBackColor
        {
            get{ return this.offBackColor; }
            set{ this.offBackColor = value; this.Invalidate(); }
        }
        private Color offToggleColor;
        [Category("Toggle")]
        public Color OffToggleColor
        {
            get { return this.offToggleColor; }
            set { this.offToggleColor = value; this.Invalidate(); }
        }
        private bool solidStyle;
        [Category("Toggle")]
        public bool SolidStyle
        {
            set { this.solidStyle = value; this.Invalidate(); }
            get { return this.solidStyle; }
        }
        [Category("Toggle")]
        public int ToggleHeight
        {
            get { return this.Height; }
            set { this.Height = value; this.Invalidate(); }
        }
        [Category("Toggle")]
        public int ToggleWidth
        {
            get { return this.Width; }
            set { this.Width = value; this.Invalidate(); }
        }
        [Category("Toggle")]
        public bool ToggleAutoSize
        {
            get
            {
                return this.AutoSize;
            }
            set
            {
                this.AutoSize = value;
                this.Invalidate();
            }
        }
        //Contructor
        public Toggles()
        {
            solidStyle = false;
            offToggleColor = Color.Gainsboro;
            offBackColor = Color.Gray;
            onToggleColor = Color.WhiteSmoke;
            onBackColor = Color.MediumSlateBlue;
            this.MinimumSize = new Size(45, 22);
        }

        //Method
        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height-1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc,270,180);
            path.CloseFigure();
            return path;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height-5;
            pevent.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            pevent.Graphics.Clear(this.Parent.BackColor);
            if (this.Checked) //ON
            {
                //Draw the control surface
                if (solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
                else pevent.Graphics.DrawPath(new Pen(onBackColor, 2), GetFigurePath());
                //Draw the toggle
                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor),
                  new Rectangle(this.Width - this.Height+1, 2, toggleSize, toggleSize));
            }
            else //OFF
            {
                //Draw the control surface
                if (solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                else pevent.Graphics.DrawPath(new Pen(offBackColor, 5), GetFigurePath());
                //Draw the toggle
                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor),
                  new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }
    }
}
