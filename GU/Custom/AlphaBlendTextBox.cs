using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using System.Drawing.Imaging;
using System.Text;

namespace ZBobb
{
	/// <summary>
	/// AlphaBlendTextBox: A .Net textbox that can be translucent to the background.
	/// (C) 2003 Bob Bradley / ZBobb@hotmail.com
	/// </summary>
	/// 



	public class AlphaBlendTextBox : System.Windows.Forms.TextBox
	{
		#region private variables
		//Field
		private uPictureBox myPictureBox;
		private  Bitmap myBitmap;
		private  Bitmap myAlphaBitmap;
		private Color myBackColor = Color.White;
		private Color borderColorOff = Color.White;
		private Color borderColorOn = Color.White;
		private Point myPoint = new Point(0, 0);
		private Color keyColor = Color.Red;
		private int myFontHeight = 10;
		private int myBackAlpha = 10;
		private int borderSize = 2;
		private bool isFocus = false;
		private bool check = true;
		private bool myCaretState = true;
		private bool myUpToDate = false;
		private bool myCaretUpToDate = false;
		private bool myPaintedFirstTime = false;
		private string title = "";
		private StringBuilder normalString = new StringBuilder();
		private StringBuilder passString = new StringBuilder();
		private StringBuilder myText = new StringBuilder();
		private System.Windows.Forms.Timer myTimer1 = new System.Windows.Forms.Timer();
		private System.ComponentModel.Container components = null;
		#endregion // end private variables

		//Properties
		public int BorderSize { get { return this.borderSize; } set { this.borderSize = value; this.Invalidate(); } }
		public Point MyPoint { get { return this.myPoint; } set { this.myPoint = value; this.Invalidate(); } }
		public Color KeyColor { get { return this.keyColor; } set { this.keyColor = value; this.Invalidate(); } }
		public bool IsFocus { get { return this.isFocus; } set { this.isFocus = value; this.Invalidate(); } }
		public Color BorderColorOff { get { return this.borderColorOff; } set { this.borderColorOff = value; this.Invalidate(); } }
		public Color BorderColorOn { get { return this.borderColorOn; } set { this.borderColorOn = value; this.Invalidate(); } }
		public string Title { get { return this.title; } set { this.title = value; this.Invalidate(); } }
		public StringBuilder NormalString { get { return this.normalString; } set { this.normalString = value; } }
		public StringBuilder PassString { get { return this.passString; } set { this.passString = value; } }
		#region public methods and overrides
		//Contructor
		public AlphaBlendTextBox()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
			// TODO: Add any initialization after the InitializeComponent call
			this.BackColor = myBackColor; 
			this.SetStyle(ControlStyles.UserPaint,false);
			this.SetStyle(ControlStyles.AllPaintingInWmPaint,true);
			this.SetStyle(ControlStyles.DoubleBuffer,true);
			myPictureBox = new uPictureBox();
			this.Controls.Add(myPictureBox);
			myPictureBox.Dock = DockStyle.Fill;
			myTimer1.Enabled = true;
			myTimer1.Interval = 300;
            myTimer1.Tick += MyTimer1_Tick;
		}

        private void MyTimer1_Tick(object sender, EventArgs e)
        {
			check = !check;
			this.Invalidate();
        }

        protected override void OnResize(EventArgs e)
		{
			base.OnResize (e);
			this.myBitmap = new Bitmap(this.ClientRectangle.Width,this.ClientRectangle.Height);//(this.Width,this.Height);
			this.myAlphaBitmap = new Bitmap(this.ClientRectangle.Width,this.ClientRectangle.Height);//(this.Width,this.Height);
			myUpToDate = false;
			this.Invalidate();
		}
        //Some of these should be moved to the WndProc later
        protected override void OnPaint(PaintEventArgs e)
        {
			base.OnPaint(e);
			myText.Clear();
			if (this.UseSystemPasswordChar == true)
			{
				myText.Append(PassString);
			}
			else
            {
				myText.Append(NormalString);
			}
			Size textSize = TextRenderer.MeasureText(myText.ToString(), this.Font);
			if (this.myText.ToString() == "")
			{
				if (this.IsFocus == true)
					e.Graphics.DrawString(Title, this.Font, new SolidBrush(this.BorderColorOn), myPoint.X - 4, myPoint.Y);
				else
					e.Graphics.DrawString(Title, this.Font, new SolidBrush(this.BorderColorOff), myPoint.X - 4, myPoint.Y);
			}
			if (textSize.Width <= this.Width - 1)
			{
				e.Graphics.DrawString(myText.ToString(), this.Font, new SolidBrush(this.KeyColor), MyPoint.X, MyPoint.Y);
			}	
			else
			{
				for (int i = 1; i <= myText.Length; i++)
				{
					if (TextRenderer.MeasureText(myText.ToString().Remove(0, i), this.Font).Width <= this.Width)
					{
						e.Graphics.DrawString(myText.ToString().Remove(0, i), this.Font, new SolidBrush(this.KeyColor), myPoint.X, myPoint.Y);
						break;
					}
				}
			}
			if (isFocus == true)
				e.Graphics.DrawLine(new Pen(this.BorderColorOn, BorderSize), 0, this.Height - 1, this.Width - 1, this.Height - 1);
			else
				e.Graphics.DrawLine(new Pen(this.BorderColorOff, BorderSize), 0, this.Height - 1, this.Width - 1, this.Height - 1);
			if (isFocus == true)
			{
				if (check == true)
				{
					if (textSize.Width == 0)
						e.Graphics.DrawLine(new Pen(this.KeyColor, 2), MyPoint.X, MyPoint.Y - textSize.Height, MyPoint.X, this.Height - 6);
					else if (textSize.Width >= this.Width - 2)
						e.Graphics.DrawLine(new Pen(this.KeyColor, 2), this.Width - 13, this.Height - textSize.Height, this.Width - 13, this.Height - 6);
					else
						e.Graphics.DrawLine(new Pen(this.KeyColor, 2), textSize.Width - 6, this.Height - textSize.Height, textSize.Width - 6, this.Height - 6);
				}
			}
		}
        protected override void OnGotFocus(EventArgs e)
        {
			this.IsFocus = true;
            base.OnGotFocus(e);
			this.Invalidate();
        }
        protected override void OnLostFocus(EventArgs e)
        {
			this.IsFocus = false;
			this.Text = this.NormalString.ToString();
			base.OnLostFocus(e);
			this.Invalidate();
		}
        protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown (e);
			myUpToDate = false;
			this.Invalidate();
		}
		protected override void OnKeyUp(KeyEventArgs e)
		{
			base.OnKeyUp (e);
			myUpToDate = false;
			this.Invalidate();

		}
        protected override void OnKeyPress(KeyPressEventArgs e)
		{
			base.OnKeyPress(e);
			if ((int)e.KeyChar == 8)
			{
				if (this.NormalString.ToString().Length >= 1 && this.PassString.ToString().Length >= 1)
				{
					this.NormalString.Remove(myText.Length - 1, 1);
					this.PassString.Remove(myText.Length - 1, 1);
				}
				else
				{
					return;
				}
			}
			else if ((int)e.KeyChar == 13)
				return;
			else
			{
				this.PassString.Append('•');
				this.NormalString.Append(e.KeyChar);
			}
			myUpToDate = false;
			this.Invalidate();
		}
		protected override void OnGiveFeedback(GiveFeedbackEventArgs gfbevent)
		{
			base.OnGiveFeedback (gfbevent);
			myUpToDate = false;
			this.Invalidate();
		}

		protected override void OnChangeUICues(UICuesEventArgs e)
		{
			base.OnChangeUICues (e);
			myUpToDate = false;
			this.Invalidate();
		}
		protected override void OnFontChanged(EventArgs e)
		{
			if (this.myPaintedFirstTime)
				this.SetStyle(ControlStyles.UserPaint,false);

			base.OnFontChanged (e);

			if (this.myPaintedFirstTime)
				this.SetStyle(ControlStyles.UserPaint,true);

				
			myFontHeight = GetFontHeight();


			myUpToDate = false;
			this.Invalidate();
		}

		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged (e);
			myUpToDate = false;
			this.Invalidate();
		}

		
		protected override void WndProc(ref Message m)
		{

			base.WndProc (ref m);

			// need to rewrite as a big switch

			if (m.Msg == win32.WM_PAINT)
			{
				myPaintedFirstTime = true;

				if (!myUpToDate || !myCaretUpToDate)
					GetBitmaps();
				myUpToDate = true;
				myCaretUpToDate = true;

				if (myPictureBox.Image != null) myPictureBox.Image.Dispose();
				myPictureBox.Image = (Image)myAlphaBitmap.Clone();

			}

			else if (m.Msg ==  win32.WM_HSCROLL || m.Msg == win32.WM_VSCROLL)
			{
				myUpToDate = false;
				this.Invalidate();			
			}

			else if (m.Msg == win32.WM_LBUTTONDOWN 
				|| m.Msg == win32.WM_RBUTTONDOWN
				|| m.Msg == win32.WM_LBUTTONDBLCLK
				//  || m.Msg == win32.WM_MOUSELEAVE  ///****
				)
			{
				myUpToDate = false;
				this.Invalidate();			
			}

			else if (m.Msg == win32.WM_MOUSEMOVE )
			{
				if (m.WParam.ToInt32() != 0)  //shift key or other buttons
				{
					myUpToDate = false;
					this.Invalidate();			
				}
			}


		
			//System.Diagnostics.Debug.WriteLine("Pro: " + m.Msg.ToString("X"));

		}


		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				//this.BackColor = Color.Pink;
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#endregion		//end public method and overrides


		#region public property overrides

		public new BorderStyle BorderStyle
		{
			get {return base.BorderStyle;}
			set 
			{
				if (this.myPaintedFirstTime)
					this.SetStyle(ControlStyles.UserPaint,false);

				base.BorderStyle = value;
				
				if (this.myPaintedFirstTime)
					this.SetStyle(ControlStyles.UserPaint,true);

				this.myBitmap = null;
				this.myAlphaBitmap = null;
				myUpToDate = false;
				this.Invalidate();
			}
		}

		public  new Color BackColor
		{
			get
			{
				return Color.FromArgb(base.BackColor.R, base.BackColor.G, base.BackColor.B);
			}
			set
			{
				myBackColor = value;
				base.BackColor = value;
				myUpToDate = false;
			}
		}
		public override bool Multiline
		{
			get{return base.Multiline;}
			set
			{
				if (this.myPaintedFirstTime)
					this.SetStyle(ControlStyles.UserPaint,false);
				
				base.Multiline = value;

				if (this.myPaintedFirstTime)
					this.SetStyle(ControlStyles.UserPaint,true);

				this.myBitmap = null;
				this.myAlphaBitmap = null;
				myUpToDate = false;
				this.Invalidate();
			}
		}

		
		#endregion    //end public property overrides


		#region private functions and classes

		private int GetFontHeight()
		{
			Graphics g = this.CreateGraphics();
			SizeF sf_font = g.MeasureString("X",this.Font);
			g.Dispose();
			return  (int) sf_font.Height;
		}
		
		
		private void GetBitmaps()
		{

			if (myBitmap == null
				|| myAlphaBitmap == null
				|| myBitmap.Width != Width 
				|| myBitmap.Height != Height		
				|| myAlphaBitmap.Width != Width 
				|| myAlphaBitmap.Height != Height)
			{
				myBitmap = null;
				myAlphaBitmap = null;
			}



		if (myBitmap == null)
			{
				myBitmap = new Bitmap(this.ClientRectangle.Width,this.ClientRectangle.Height);//(Width,Height);
				myUpToDate = false;
			}


			if (!myUpToDate)
			{
				//Capture the TextBox control window

				this.SetStyle(ControlStyles.UserPaint,false);
				
				win32.CaptureWindow(this,ref myBitmap);

				this.SetStyle(ControlStyles.UserPaint,true);
				this.SetStyle(ControlStyles.SupportsTransparentBackColor,true);
				this.BackColor = Color.FromArgb(myBackAlpha,myBackColor);

			}
			//--
			

		
			Rectangle r2 = new Rectangle(0,0,this.ClientRectangle.Width,this.ClientRectangle.Height);
			ImageAttributes tempImageAttr = new ImageAttributes();
						

			//Found the color map code in the MS Help

			ColorMap[] tempColorMap = new ColorMap[1];
			tempColorMap[0] = new ColorMap();
			tempColorMap[0].OldColor = Color.FromArgb(255,myBackColor); 
			tempColorMap[0].NewColor = Color.FromArgb(myBackAlpha,myBackColor);
			tempImageAttr.SetRemapTable(tempColorMap);
			if (myAlphaBitmap != null)
				myAlphaBitmap.Dispose();
			myAlphaBitmap = new Bitmap(this.ClientRectangle.Width,this.ClientRectangle.Height);//(Width,Height);
			Graphics tempGraphics1 = Graphics.FromImage(myAlphaBitmap);
			tempGraphics1.DrawImage(myBitmap,r2,0,0,this.ClientRectangle.Width,this.ClientRectangle.Height,GraphicsUnit.Pixel,tempImageAttr);
			tempGraphics1.Dispose();
			if (this.Focused && (this.SelectionLength == 0))
			{
				Graphics tempGraphics2 = Graphics.FromImage(myAlphaBitmap);
				if (myCaretState)
				{
					//Draw the caret
					Point caret = this.findCaret();
					Pen p = new Pen(this.ForeColor,3);
					tempGraphics2.DrawLine(p,caret.X,caret.Y + 0,caret.X,caret.Y + myFontHeight);
					tempGraphics2.Dispose();
				}
						
			}
		}
		private Point findCaret() 
		{
			/*  Find the caret translated from code at 
			 * http://www.vb-helper.com/howto_track_textbox_caret.html
			 * 
			 * and 
			 * 
			 * http://www.microbion.co.uk/developers/csharp/textpos2.htm
			 * 
			 * Changed to EM_POSFROMCHAR
			 * 
			 * This code still needs to be cleaned up and debugged
			 * */

			Point pointCaret = new Point(0);
			int i_char_loc = this.SelectionStart;
			IntPtr pi_char_loc = new IntPtr(i_char_loc);

			int i_point = win32.SendMessage(this.Handle,win32.EM_POSFROMCHAR,pi_char_loc,IntPtr.Zero);
			pointCaret = new Point(i_point);

			if (i_char_loc == 0) 
			{
				pointCaret = new Point(0);
			}
			else if (i_char_loc >= this.Text.Length)
			{
				pi_char_loc = new IntPtr(i_char_loc - 1);
				i_point = win32.SendMessage(this.Handle,win32.EM_POSFROMCHAR,pi_char_loc,IntPtr.Zero);
				pointCaret = new Point(i_point);

				Graphics g = this.CreateGraphics();
				String t1 = this.Text.Substring(this.Text.Length-1,1) + "X";
				SizeF sizet1 = g.MeasureString(t1,this.Font);
				SizeF sizex  = g.MeasureString("X",this.Font);
				g.Dispose();
				int xoffset = (int)(sizet1.Width - sizex.Width);
				pointCaret.X = pointCaret.X + xoffset;

				if (i_char_loc == this.Text.Length)
				{
					String slast = this.Text.Substring(Text.Length-1,1);
					if (slast == "\n")
					{
						pointCaret.X = 1;
						pointCaret.Y = pointCaret.Y + myFontHeight;
					}
				}

			}



			return pointCaret;
		}


		private void myTimer1_Tick(object sender, EventArgs e)
		{
			//Timer used to turn caret on and off for focused control

			myCaretState = !myCaretState;
			myCaretUpToDate = false;
			this.Invalidate();
		}


		private class uPictureBox : PictureBox 
		{
			public uPictureBox() 
			{
				this.SetStyle(ControlStyles.Selectable,false);
				this.SetStyle(ControlStyles.UserPaint,true);
				this.SetStyle(ControlStyles.AllPaintingInWmPaint,true);
				this.SetStyle(ControlStyles.DoubleBuffer,true);

				this.Cursor = null;
				this.Enabled = true; 
				this.SizeMode = PictureBoxSizeMode.Normal;
				
			}




			//uPictureBox
			protected override void WndProc(ref Message m)
			{
				if (m.Msg == win32.WM_LBUTTONDOWN 
					|| m.Msg == win32.WM_RBUTTONDOWN
					|| m.Msg == win32.WM_LBUTTONDBLCLK
					|| m.Msg == win32.WM_MOUSELEAVE
					|| m.Msg == win32.WM_MOUSEMOVE )
				{
					//Send the above messages back to the parent control
					win32.PostMessage(this.Parent.Handle,(uint) m.Msg,m.WParam,m.LParam);
				}

				else if (m.Msg == win32.WM_LBUTTONUP)
				{
					//??  for selects and such
					this.Parent.Invalidate();
				}


				base.WndProc (ref m);
			}


		}   // End uPictureBox Class


		#endregion  // end private functions and classes


		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
		}
		#endregion


		#region New Public Properties

		[
		Category("Appearance"),
		Description("The alpha value used to blend the control's background. Valid values are 0 through 255."),
		Browsable(true),
		DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)

		]
		public int BackAlpha
		{
			get { return myBackAlpha; }
			set 
			{
				int v = value;
				if (v > 255)
					v = 255;
				myBackAlpha = v;
				myUpToDate = false; 
				Invalidate();
			}
		}

        



        #endregion



    }  // End AlphaTextBox Class


}  // End namespace ZBobb


//----
