namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pic_left.BackColor = Color.Blue;
            }
            if (e.Button == MouseButtons.Middle)
            {
                pic_mid.BackColor = Color.Blue;
            }
            if (e.Button == MouseButtons.Right)
            {
                pic_right.BackColor = Color.Blue;
            }

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            pic_right.BackColor = Color.LightBlue;
            pic_mid.BackColor = Color.LightBlue;
            pic_left.BackColor = Color.LightBlue;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            Test.Location = e.Location; 
        }
    }
}
