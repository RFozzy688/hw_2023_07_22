namespace hw_2023_07_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush sb = new SolidBrush(Color.FromArgb(2, 198, 2));
            g.FillEllipse(sb, 130, 120, 200, 300);

            sb.Color = Color.FromArgb(1, 240, 1);
            g.FillEllipse(sb, 140, 130, 180, 280);
            g.FillEllipse(sb, 175, 80, 110, 90);
            g.FillEllipse(sb, 190, 50, 80, 80);
            g.FillEllipse(sb, 105, 300, 50, 50);
            g.FillEllipse(sb, 300, 300, 50, 50);
            g.FillRectangle(sb, 190, 390, 30, 100);
            g.FillRectangle(sb, 240, 390, 30, 100);

            sb.Color = Color.FromArgb(170, 0, 247);
            g.FillRectangle(sb, 190, 460, 30, 20);
            g.FillRectangle(sb, 240, 460, 30, 20);
            g.FillRectangle(sb, 190, 60, 80, 20);

            sb.Color = Color.FromArgb(234, 255, 0);
            g.FillRectangle(sb, 180, 170, 100, 150);
            g.FillEllipse(sb, 180, 270, 100, 100);

            sb.Color = Color.FromArgb(130, 130, 8);
            g.FillRectangle(sb, 320, 60, 20, 430);

            sb.Color = Color.FromArgb(180, 180, 180);
            g.FillRectangle(sb, 320, 260, 20, 100);
        }
    }
}