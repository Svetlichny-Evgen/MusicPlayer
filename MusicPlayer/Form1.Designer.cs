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
            PlayListArea = new FlowLayoutPanel();
            musicCardsArea = new FlowLayoutPanel();
            musicArea.SuspendLayout();
            PlayListArea.SuspendLayout();
            musicCardsArea.SuspendLayout();
            SuspendLayout();
            // 
            // musicArea
            // 
            musicArea.ColumnCount = 2;
            musicArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            musicArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            musicArea.Controls.Add(PlayListArea, 0, 0);
            musicArea.Controls.Add(musicCardsArea, 1, 0);
            musicArea.Dock = DockStyle.Fill;
            musicArea.Location = new Point(0, 0);
            musicArea.Name = "musicArea";
            musicArea.RowCount = 1;
            musicArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            musicArea.Size = new Size(800, 450);
            musicArea.TabIndex = 0;
            // 
            // PlayListArea
            // 
            PlayListArea.Dock = DockStyle.Fill;
            PlayListArea.Location = new Point(3, 2);
            PlayListArea.Margin = new Padding(3, 2, 3, 2);
            PlayListArea.Name = "PlayListArea";
            PlayListArea.Size = new Size(194, 446);
            PlayListArea.TabIndex = 0;
            // 
            // musicCardsArea
            // 
            musicCardsArea.Dock = DockStyle.Fill;
            musicCardsArea.Location = new Point(203, 3);
            musicCardsArea.Name = "musicCardsArea";
            musicCardsArea.Size = new Size(594, 444);
            musicCardsArea.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(musicArea);
            Name = "Form1";
            Text = "AudioPlayer";
            Load += Form1_Load;
            musicArea.ResumeLayout(false);
            PlayListArea.ResumeLayout(false);
            musicCardsArea.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel musicArea;
        private FlowLayoutPanel PlayListArea;
        private FlowLayoutPanel musicCardsArea;
    }
}