using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class ctrCircularPictureBox : PictureBox
{
    protected override void OnPaint(PaintEventArgs pe)
    {
        base.OnPaint(pe);

        GraphicsPath gp = new GraphicsPath();
        gp.AddEllipse(0, 0, this.Width - 1, this.Height - 1);

        this.Region = new Region(gp);

        pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        using (Pen pen = new Pen(Color.Black, 2))
        {
            pe.Graphics.DrawEllipse(pen, 0, 0, this.Width - 1, this.Height - 1);
        }
    }
}