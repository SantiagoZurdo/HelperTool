﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace HelperToolRenovado
{
    public class ToggleButton : CheckBox
    {
        public Color onBackColor = Color.MediumSlateBlue;
        public Color onToggleColor = Color.WhiteSmoke;
        public Color offBackColor = Color.Gray;
        public Color offToggleColor = Color.Gainsboro;
        public bool solidStyle = true;
        public Color OnBackColor
        {
            get { return onBackColor; }
            set
            {
                onBackColor = value;
                this.Invalidate();
            }
        }
        public Color OnToggleColor
        {
            get { return onToggleColor; }
            set
            {
                onToggleColor = value;
                this.Invalidate();
            }
        }
        public Color OffBackColor
        {
            get { return offBackColor; }
            set
            {
                offBackColor = value;
                this.Invalidate();
            }
        }
        public Color OffToggleColor
        {
            get { return offToggleColor; }
            set
            {
                offToggleColor = value;
                this.Invalidate();
            }
        }
        public override string Text
        {
            get { return base.Text; }
            set { }
        }
        public bool SolidStyle
        {
            get { return solidStyle; }
            set
            {
                solidStyle = value;
                this.Invalidate();
            }
        }
        public Color OnBackColor1 { get => onBackColor; set => onBackColor = value; }
        public Color OnToggleColor1 { get => onToggleColor; set => onToggleColor = value; }
        public Color OffBackColor1 { get => offBackColor; set => offBackColor = value; }
        public Color OffToggleColor1 { get => offToggleColor; set => offToggleColor = value; }
        public bool SolidStyle1 { get => solidStyle; set => solidStyle = value; }
        public ToggleButton()
        {
            this.MinimumSize = new Size(30,17);
        }
        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();
            return path;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);
            if (this.Checked)
            {
                if (solidStyle)
                {
                    pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
                }
                else
                {
                    pevent.Graphics.DrawPath(new Pen(onBackColor, 2), GetFigurePath());
                } 
                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor),
                new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
            }
            else
            {
                if (solidStyle)
                {
                    pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                }
                else
                {
                    pevent.Graphics.DrawPath(new Pen(offBackColor, 2), GetFigurePath());
                }
                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor),
                new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }
    }
}
