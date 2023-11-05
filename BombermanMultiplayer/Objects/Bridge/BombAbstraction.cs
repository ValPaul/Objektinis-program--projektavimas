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

public abstract class BombAbstraction
{
    protected BombRendererImplementor bombRenderer;

    public BombAbstraction(BombRendererImplementor renderer)
    {
        this.bombRenderer = renderer;
    }

    public abstract void DropBomb();
}

public interface BombRendererImplementor
{
    void Render();
}