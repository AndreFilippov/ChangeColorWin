using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ChangeColor
{
    public partial class OpenImage : Form
    {
        public Color chColor;
        public Form mainForm;

        public Color GetColor()
        {
            return this.chColor;
        }
        
        public void setMainForm(Form form)
        {
            this.mainForm = form;
        }
        public OpenImage()
        {
            InitializeComponent();
        }

        public void ShowImage(string file)
        {
            PictureBox pb = new PictureBox();
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            pb.Image = new Bitmap(file);
            pb.AutoSize = true;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(pb);
            pb.MouseClick += Pb_click;
            MessageBox.Show("Кликните по цвету который нужно заменить:");
        }

        private void Pb_click(object sender, MouseEventArgs  e)
        {
            PictureBox pb = (PictureBox)sender;
            Bitmap b = new Bitmap(pb.Image);
            Color color = b.GetPixel(e.X, e.Y);
            this.chColor = color;
            DialogResult result = MessageBox.Show(color.ToString(),"Сообщение",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Form mainForm = this.mainForm;
                Control panel1 = mainForm.Controls.Find("panel1", false)[0];
                panel1.BackColor = color;
                this.Hide();
            }

            /*throw new NotImplementedException();*/
        }

        private void OpenImage_Load(object sender, EventArgs e)
        {
            /*throw new System.NotImplementedException();*/
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            /*throw new System.NotImplementedException();*/
        }
    }
}