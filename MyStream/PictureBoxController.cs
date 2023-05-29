using CefSharp.Structs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStream
{
    public class PictureBoxController:PictureBox
    {
        public PictureBoxController(IContainer container)
        { 
            container.Add(this); 
        }

        System.Drawing.Point point;
        protected override void OnMouseDown(MouseEventArgs e)
        {
            point = e.Location;
            base.OnMouseDown(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left) 
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
            base.OnMouseDown(e);
        }
    }
}
