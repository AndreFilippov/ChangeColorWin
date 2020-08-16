using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ChangeColor
{
    public partial class ChangeColor : Form
    {
        public List<string> photos = new List<string>();
        public ChangeColor()
        {
            InitializeComponent();
        }

        private void ChangeColor_Load(object sender, EventArgs e)
        {
            /*throw new System.NotImplementedException();*/
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|All files (*.*)|*.*";
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in dialog.FileNames)
                {
                    listBox1.Items.Add(Path.GetFileName(file));
                    this.photos.Add(file);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*throw new System.NotImplementedException();*/
        }

        private  void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string fa = this.photos[index];
                var f = new OpenImage();
                f.ShowImage(fa);
                f.setMainForm(this);
                f.Show();
            }
        }
        
        private void ChangeColorButton_Click(object sender, EventArgs e)
        {
            Color color_1 = panel1.BackColor;
            Color color_2 = panel2.BackColor;
            string[] photos = this.photos.ToArray();
            Button button = (Button)sender;
            button.Text = "Ожидайте...";
            button.Enabled = false;
            Program.changeColorPhoto(color_1, color_2, photos,textBox1.Text);
            /*throw new System.NotImplementedException();*/
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                panel2.BackColor = colorDialog1.Color;
            }
        }

        private void DirectoryButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}