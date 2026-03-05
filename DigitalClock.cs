using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public class DigitalClock : Control
	{
		private Timer _timer;
		private Color _bck = SystemColors.Control;
		public Color bck
        {
			get => _bck;
            set { _bck = value; Invalidate(); }
        }
		private Color _f1c = SystemColors.ButtonFace;
		public Color f1c
		{
			get => _f1c;
			set { _f1c = value; Invalidate(); }
		}
		private Color _f2c = Color.White;
		public Color f2c
		{
			get => _f2c;
			set { _f2c = value; Invalidate(); }
		}
		private Color _dtc = Color.Black;
		public Color dtc
		{
			get => _dtc;
			set { _dtc = value; Invalidate(); }
		}

		private Point[] segmentPoints =
		{
			new Point(5,5),		// LeftCentre
			new Point(10, 0),	// LeftTop
			new Point(30,0),	// RightTop
			new Point(35,5),	// RightCentre
			new Point(30,10),	// RightBottom
			new Point(10,10)	// LeftBottom
		};

		private byte[] digitCode =			
			{	
			0x3F,	// 0
            0x06,	// 1
			0x5B,	// 2
			0x4F,	// 3
			0x66,	// 4
			0x6D,	// 5
			0x7D,	// 6
			0x07,	// 7
			0xFF,	// 8
			0x6F	// 9
		};

		public DigitalClock()
		{
			this.DoubleBuffered = true;
			this.Size = new Size(500, 500);

			_timer = new Timer();
			_timer.Interval = 1000;
			_timer.Tick += (s, e) => this.Invalidate();
			_timer.Start();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.SmoothingMode = SmoothingMode.AntiAlias;

			DateTime now = DateTime.Now;
			int seconds = now.Second;
			int minutes = now.Minute;
			int hours = now.Hour;
			int h1 = hours /10;
			int h2 = hours % 10;
			int min1 = minutes / 10;
			int min2 = minutes % 10;

            DrawDigit(g, h1, new Point(0, 0));
			DrawDigit(g, h2, new Point(50, 0));
			DrawColon(g, new Point(100, 0), seconds);
			DrawDigit(g, min1, new Point(120, 0));
			DrawDigit(g, min2, new Point(170, 0));

		}
		void DrawDigit(Graphics g, int digit, Point loc)
		{
			/// Kodowanie wyœwietlacza siedmiosegmentowego:
			/// 
			///		A
			///	F		B
			///		G
			///	E		C
			///		D
			///		

			byte mask = digitCode[digit];

			DrawSegment(g, loc.X, loc.Y, false, (mask & 0x01) != 0);			// A
			DrawSegment(g, loc.X + 40, loc.Y + 4 , true, (mask & 0x02) != 0);	// B
			DrawSegment(g, loc.X + 40, loc.Y + 42, true, (mask & 0x04) != 0);	// C
			DrawSegment(g, loc.X, loc.Y + 76, false, (mask & 0x08) != 0);		// D
			DrawSegment(g, loc.X + 10, loc.Y + 42, true, (mask & 0x10) != 0);	// E
			DrawSegment(g, loc.X + 10, loc.Y + 4, true, (mask & 0x20) != 0);	// F
			DrawSegment(g, loc.X, loc.Y + 38, false, (mask & 0x40) != 0);		// G
		}


		void DrawSegment(Graphics g, int x, int y, bool rotate, bool on)
		{
			GraphicsState state = g.Save();
            g.TranslateTransform(x, y);
            if (rotate)
			{
				g.RotateTransform(90);
			}
			using (Brush b = new SolidBrush(on ? f1c : f2c)) g.FillPolygon(b, segmentPoints);

			g.Restore(state);
		}
		void DrawColon(Graphics g, Point loc, int seconds)
		{
			using (Brush b = new SolidBrush((seconds % 2 == 0) ? f1c : f2c))
			{
				g.FillEllipse(b, loc.X, loc.Y + 25, 10, 10);
				g.FillEllipse(b, loc.X, loc.Y + 50, 10, 10);
			}
		}
	}
}