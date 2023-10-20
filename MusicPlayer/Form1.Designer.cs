namespace MusicPlayer
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
            musicArea = new TableLayoutPanel();
            SuspendLayout();
            // 
            // musicArea
            // 
            musicArea.ColumnCount = 2;
            musicArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.5F));
            musicArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.5F));
            musicArea.Dock = DockStyle.Fill;
            musicArea.Location = new Point(0, 0);
            musicArea.Name = "musicArea";
            musicArea.RowCount = 1;
            musicArea.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            musicArea.Size = new Size(800, 450);
            musicArea.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(musicArea);
            Name = "Form1";
            Text = "AudioPlayer";
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel musicArea;
    }
}