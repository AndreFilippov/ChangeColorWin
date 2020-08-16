using System.ComponentModel;
using System.Windows.Forms;

namespace ChangeColor
{
    partial class ChangeColor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.UploadButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ChangeColorButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DirectoryButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(15, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(763, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Приветствую в программе для изменения цвета. \r\nВыберите изображения:";
            // 
            // UploadButton
            // 
            this.UploadButton.ForeColor = System.Drawing.Color.Red;
            this.UploadButton.Location = new System.Drawing.Point(21, 76);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(756, 46);
            this.UploadButton.TabIndex = 1;
            this.UploadButton.Text = "Загрузить";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(22, 139);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(754, 225);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.MouseDoubleClick += new MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // ChangeColorButton
            // 
            this.ChangeColorButton.ForeColor = System.Drawing.Color.Red;
            this.ChangeColorButton.Location = new System.Drawing.Point(24, 478);
            this.ChangeColorButton.Name = "ChangeColorButton";
            this.ChangeColorButton.Size = new System.Drawing.Size(754, 46);
            this.ChangeColorButton.TabIndex = 3;
            this.ChangeColorButton.Text = "Изменить цвет";
            this.ChangeColorButton.UseVisualStyleBackColor = true;
            this.ChangeColorButton.Click += new System.EventHandler(this.ChangeColorButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(23, 395);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 30);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(63, 395);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(30, 30);
            this.panel2.TabIndex = 5;
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 452);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(672, 20);
            this.textBox1.TabIndex = 6;
            // 
            // DirectoryButton
            // 
            this.DirectoryButton.Location = new System.Drawing.Point(702, 452);
            this.DirectoryButton.Name = "DirectoryButton";
            this.DirectoryButton.Size = new System.Drawing.Size(76, 20);
            this.DirectoryButton.TabIndex = 7;
            this.DirectoryButton.Text = "...";
            this.DirectoryButton.UseVisualStyleBackColor = true;
            this.DirectoryButton.Click += new System.EventHandler(this.DirectoryButton_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(670, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Куда загрузить файлы";
            // 
            // ChangeColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DirectoryButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ChangeColorButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.label1);
            this.Name = "ChangeColor";
            this.Text = "ChangeColor";
            this.Load += new System.EventHandler(this.ChangeColor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button DirectoryButton;

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.ColorDialog colorDialog2;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.ColorDialog colorDialog1;

        private System.Windows.Forms.Button ChangeColorButton;

        private System.Windows.Forms.ListBox listBox1;

        private System.Windows.Forms.Button UploadButton;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}