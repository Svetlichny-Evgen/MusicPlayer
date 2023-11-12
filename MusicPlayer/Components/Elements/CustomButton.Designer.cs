namespace MusicPlayer.Components
{
    partial class CustomButton
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)buttonImage).BeginInit();
            SuspendLayout();
            // 
            // buttonImage
            // 
            buttonImage.Cursor = Cursors.Hand;
            buttonImage.Dock = DockStyle.Fill;
            buttonImage.Location = new Point(5, 5);
            buttonImage.Name = "buttonImage";
            buttonImage.Size = new Size(35, 35);
            buttonImage.SizeMode = PictureBoxSizeMode.Zoom;
            buttonImage.TabIndex = 0;
            buttonImage.TabStop = false;
            buttonImage.Click += buttonImage_Click;
            buttonImage.MouseLeave += buttonImage_MouseLeave;
            buttonImage.MouseHover += buttonImage_MouseHover;
            // 
            // CustomButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonImage);
            Name = "CustomButton";
            Padding = new Padding(5);
            Size = new Size(45, 45);
            ((System.ComponentModel.ISupportInitialize)buttonImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox buttonImage;
    }
}
