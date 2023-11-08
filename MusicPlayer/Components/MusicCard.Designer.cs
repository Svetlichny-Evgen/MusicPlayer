namespace MusicPlayer.Components
{
    partial class MusicCard
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
            musicCardArea = new TableLayoutPanel();
            lbSinger = new Label();
            pbMusicImage = new PictureBox();
            lbMusicTitle = new Label();
            musicCardArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMusicImage).BeginInit();
            SuspendLayout();
            // 
            // musicCardArea
            // 
            musicCardArea.ColumnCount = 1;
            musicCardArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            musicCardArea.Controls.Add(lbSinger, 0, 2);
            musicCardArea.Controls.Add(pbMusicImage, 0, 0);
            musicCardArea.Controls.Add(lbMusicTitle, 0, 1);
            musicCardArea.Dock = DockStyle.Fill;
            musicCardArea.Location = new Point(0, 0);
            musicCardArea.Margin = new Padding(0);
            musicCardArea.Name = "musicCardArea";
            musicCardArea.Padding = new Padding(20);
            musicCardArea.RowCount = 3;
            musicCardArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            musicCardArea.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            musicCardArea.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            musicCardArea.Size = new Size(181, 251);
            musicCardArea.TabIndex = 0;
            // 
            // lbSinger
            // 
            lbSinger.AutoSize = true;
            lbSinger.BackColor = Color.Transparent;
            lbSinger.ForeColor = SystemColors.ControlDark;
            lbSinger.Location = new Point(25, 196);
            lbSinger.Margin = new Padding(5);
            lbSinger.Name = "lbSinger";
            lbSinger.Size = new Size(38, 15);
            lbSinger.TabIndex = 2;
            lbSinger.Text = "label2";
            // 
            // pbMusicImage
            // 
            pbMusicImage.Dock = DockStyle.Fill;
            pbMusicImage.Location = new Point(25, 25);
            pbMusicImage.Margin = new Padding(5);
            pbMusicImage.Name = "pbMusicImage";
            pbMusicImage.Size = new Size(131, 121);
            pbMusicImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbMusicImage.TabIndex = 0;
            pbMusicImage.TabStop = false;
            // 
            // lbMusicTitle
            // 
            lbMusicTitle.AutoSize = true;
            lbMusicTitle.BackColor = Color.Transparent;
            lbMusicTitle.Font = new Font("Bahnschrift SemiLight", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbMusicTitle.ForeColor = Color.FromArgb(150, 60, 96);
            lbMusicTitle.Location = new Point(25, 156);
            lbMusicTitle.Margin = new Padding(5);
            lbMusicTitle.Name = "lbMusicTitle";
            lbMusicTitle.Size = new Size(58, 23);
            lbMusicTitle.TabIndex = 1;
            lbMusicTitle.Text = "label1";
            // 
            // MusicCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(musicCardArea);
            Name = "MusicCard";
            Size = new Size(181, 251);
            Enter += MusicCard_Enter;
            Leave += MusicCard_Leave;
            musicCardArea.ResumeLayout(false);
            musicCardArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbMusicImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel musicCardArea;
        private Label lbSinger;
        private PictureBox pbMusicImage;
        private Label lbMusicTitle;
    }
}
