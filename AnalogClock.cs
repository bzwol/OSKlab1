using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class AnalogClock : Control
    {
        private Timer _timer;

        public AnalogClock()
        {
            this.DoubleBuffered = true;
            this.Size = new Size(300, 300);

            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += (s, e) => this.Invalidate();
            _timer.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Get center and radius
            int cx = Width / 2;
            int cy = Height / 2;
            int radius = Math.Min(cx, cy) - 10;

            // Get current time 
            DateTime now  = DateTime.Now;
            float seconds = now.Second;
            float minutes = now.Minute + seconds / 60f;
            float hours = now.Hour % 12 + minutes / 60f;

            // Draw face of clock
            g.FillEllipse(Brushes.WhiteSmoke, cx - radius, cy - radius, radius * 2, radius * 2);

            // Draw markers
            float inner_coeff = 0.93f;
            float outer_coeff = 0.98f;
            float angle_coeff = (float)Math.PI / 30f;

            for (int i = 0; i < 60; i++)
            {
                float outerx = cx + radius * (float)Math.Sin(i * angle_coeff) * outer_coeff;
                float outery = cy - radius * (float)Math.Cos(i * angle_coeff) * outer_coeff;
                if (i % 5 == 0) inner_coeff = 0.9f; else inner_coeff = 0.93f;
                float innerx = cx + radius * (float)Math.Sin(i * angle_coeff) * inner_coeff;
                float innery = cy - radius * (float)Math.Cos(i * angle_coeff) * inner_coeff;

                g.DrawLine(Pens.Black, (float)innerx, (float)innery, (float)outerx, (float)outery);
            }

            // Draw hands
            float seconds_angle = seconds * angle_coeff;
            float minutes_angle = minutes * angle_coeff + seconds_angle / 60 ;
            float hours_angle = hours * (float)Math.PI / 6 + minutes_angle / 60;

            DrawHand(seconds_angle, radius * 0.85f, 1,Color.Black);
            DrawHand(minutes_angle, radius * 0.8f, 2, Color.Black);
            DrawHand(hours_angle, radius * 0.7f, 3, Color.Black);

            void DrawHand(float angle, float length, int width, Color color)
            {
                float handx = cx + length * (float)Math.Sin(angle);
                float handy = cy - length * (float)Math.Cos(angle);
                using (Pen p = new Pen(color, width)) 
                {
                    g.DrawLine(p, cx, cy, handx, handy);
                }
            }          
        }
    }
}
