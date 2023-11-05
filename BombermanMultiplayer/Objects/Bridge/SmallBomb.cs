using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Media;
using System.Diagnostics;

public class SmallBomb : BombAbstraction
{
    public SmallBomb(BombRendererImplementor renderer) : base(renderer) { }

    public override void DropBomb()
    {
        Console.WriteLine("Dropping a small bomb.");
        bombRenderer.Render();
    }
}