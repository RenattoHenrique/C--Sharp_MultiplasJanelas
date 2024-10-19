using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MultiplasJanelas
{
    internal class GradientBackground
    {
        private Color color1;
        private Color color2;
        private float position1;
        private float position2;
        private float angle;

        public GradientBackground(Color c1, Color c2, float pos1, float pos2, float angle)
        {
            if (pos1 < 0 || pos1 > 1 || pos2 < 0 || pos2 > 1)
                throw new ArgumentOutOfRangeException("As posições devem estar entre 0 e 1.");

            color1 = c1;
            color2 = c2;
            position1 = pos1;
            position2 = pos2;
            this.angle = angle;
        }

        public void ApplyGradient(PaintEventArgs e, Rectangle clientRectangle)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(clientRectangle, color1, color2, angle))
            {
                e.Graphics.FillRectangle(brush, clientRectangle);
            }
        }
    }
}
