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
    public class CustomProgress : ProgressBar
    {
        //Field 
        private Image icon;
        private Color channelColor = Color.White;
        private Color sliderColor = Color.Red;
        private Color borderColor = Color.Red;
        private int lenghtChannel = 80;
        private int highChannel = 20;
        private int highSlider = 20;
        private int valueCustom = 0;
        private int boderSize = 2;
        private int iconSize = 20;
        private int yIcon = 0;
        private bool isFinishChannel = false;
        private bool isFinishSlider = false;
        private bool isAllowIcon = false;
        private Point locationCustom = new Point(10, 10);
        //Properties 
        public Color ChannelColor
        {
            get { return this.channelColor; }
            set { this.channelColor = value; this.Invalidate(); }
        }
        public Color SliderColor
        {
            get { return this.sliderColor; }
            set { this.sliderColor = value; this.Invalidate(); }
        }
        public Color BorderColor
        {
            get { return this.borderColor; }
            set { this.borderColor = value; this.Invalidate(); }
        }
        public int LengthChannel
        {
            get { return this.lenghtChannel; }
            set { this.lenghtChannel = value; this.Invalidate(); }
        }
        public int ValueCustom
        {
            get { return this.valueCustom; }
            set { this.valueCustom = value; this.Invalidate(); }
        }
        public int BorderSize
        {
            get { return this.boderSize; }
            set { this.boderSize = value; this.Invalidate(); }
        }
        public Point LocationCustom
        {
            get { return this.locationCustom; }
            set { this.locationCustom = value; this.Invalidate(); }
        }
        public int HighChannel
        {
            get { return this.highChannel; }
            set { this.highChannel = value; this.Invalidate(); }
        }
        public int HighSlider
        {
            get { return this.highSlider; }
            set { this.highSlider = value; this.Invalidate(); }
        }
        public bool IsFinishSlider
        {
            get { return this.isFinishSlider; }
        }
        public bool IsAllowIcon
        {
            get { return this.isAllowIcon; }
            set { this.isAllowIcon = value; this.Invalidate(); }
        }
        public Image Icon
        {
            get { return this.icon; }
            set { this.icon = value; this.Invalidate(); }
        }
        public int IconSize
        {
            get { return this.iconSize; }
            set { this.iconSize = value; this.Invalidate(); }
        }
        public int YIcon
        {
            get { return this.yIcon; }
            set { this.yIcon = value; this.Invalidate(); }
        }
        //Contructor
        public CustomProgress()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.ForeColor = Color.White;
            this.Maximum = 100;
        }

        //Method
        protected override void OnPaint(PaintEventArgs pevent)
        {
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.BackColor);
            if (this.ValueCustom <= this.Maximum)
            {
                base.OnPaint(pevent);
                GraphicsPath path = new GraphicsPath();
                Rectangle channelRect = new Rectangle(LocationCustom.X, LocationCustom.Y, LengthChannel, HighChannel);
                path.StartFigure();
                path.AddRectangle(channelRect);
                path.CloseFigure();
                if (isFinishChannel == false)
                {
                    pevent.Graphics.FillRectangle(new SolidBrush(this.ChannelColor), channelRect);
                    pevent.Graphics.DrawRectangle(new Pen(this.BorderColor, this.BorderSize), channelRect);
                }
                int Scale = (int)(ValueCustom * ((float)LengthChannel / this.Maximum)) + 1;
                Rectangle sliderRect = new Rectangle(LocationCustom.X, LocationCustom.Y, Scale, HighSlider);
                Rectangle rectIcon = new Rectangle(Scale, YIcon, this.IconSize, this.IconSize);
                pevent.Graphics.FillRectangle(new SolidBrush(this.SliderColor), sliderRect);
                if(IsAllowIcon==true)
                    pevent.Graphics.DrawImage(Icon, rectIcon);
                this.isFinishSlider = false;
                if (this.ValueCustom == this.Maximum)
                    this.isFinishSlider = true;
            }
        }
    }

}
