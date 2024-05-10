namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pic_left = new PictureBox();
            pic_mid = new PictureBox();
            pic_right = new PictureBox();
            panel1 = new Panel();
            Test = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pic_left).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_mid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_right).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Test).BeginInit();
            SuspendLayout();
            // 
            // pic_left
            // 
            pic_left.BackColor = SystemColors.ActiveCaption;
            pic_left.Location = new Point(35, 12);
            pic_left.Name = "pic_left";
            pic_left.Size = new Size(142, 165);
            pic_left.TabIndex = 0;
            pic_left.TabStop = false;
            // 
            // pic_mid
            // 
            pic_mid.BackColor = SystemColors.ActiveCaption;
            pic_mid.Location = new Point(183, 12);
            pic_mid.Name = "pic_mid";
            pic_mid.Size = new Size(69, 165);
            pic_mid.TabIndex = 1;
            pic_mid.TabStop = false;
            // 
            // pic_right
            // 
            pic_right.BackColor = SystemColors.ActiveCaption;
            pic_right.Location = new Point(258, 12);
            pic_right.Name = "pic_right";
            pic_right.Size = new Size(154, 165);
            pic_right.TabIndex = 2;
            pic_right.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(Test);
            panel1.Location = new Point(35, 411);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 3;
            // 
            // Test
            // 
            Test.Image = (Image)resources.GetObject("Test.Image");
            Test.Location = new Point(42, 28);
            Test.Name = "Test";
            Test.Size = new Size(100, 50);
            Test.SizeMode = PictureBoxSizeMode.StretchImage;
            Test.TabIndex = 0;
            Test.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Location = new Point(450, 411);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 4;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 523);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pic_right);
            Controls.Add(pic_mid);
            Controls.Add(pic_left);
            Name = "Form1";
            Text = "Form1";
            MouseDown += Form1_MouseDown;
            MouseUp += Form1_MouseUp;
            ((System.ComponentModel.ISupportInitialize)pic_left).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_mid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_right).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Test).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pic_left;
        private PictureBox pic_mid;
        private PictureBox pic_right;
        private Panel panel1;
        private Panel panel2;
        private PictureBox Test;
    }
}
