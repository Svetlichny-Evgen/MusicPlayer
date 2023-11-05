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
            musicCardsArea = new FlowLayoutPanel();
            PlayListArea = new FlowLayoutPanel();
            audioPlayerControl1 = new Components.AudioPlayerControl();
            SuspendLayout();
            // 
            // musicCardsArea
            // 
            musicCardsArea.AutoScroll = true;
            musicCardsArea.Dock = DockStyle.Fill;
            musicCardsArea.Location = new Point(254, 0);
            musicCardsArea.Margin = new Padding(3, 4, 3, 4);
            musicCardsArea.Name = "musicCardsArea";
            musicCardsArea.Size = new Size(983, 513);
            musicCardsArea.TabIndex = 1;
            // 
            // PlayListArea
            // 
            PlayListArea.Dock = DockStyle.Left;
            PlayListArea.Location = new Point(0, 0);
            PlayListArea.Name = "PlayListArea";
            PlayListArea.Size = new Size(254, 513);
            PlayListArea.TabIndex = 0;
            // 
            // audioPlayerControl1
            // 
            audioPlayerControl1.Dock = DockStyle.Bottom;
            audioPlayerControl1.Location = new Point(0, 513);
            audioPlayerControl1.Name = "audioPlayerControl1";
            audioPlayerControl1.Size = new Size(1237, 87);
            audioPlayerControl1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 600);
            Controls.Add(musicCardsArea);
            Controls.Add(PlayListArea);
            Controls.Add(audioPlayerControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "AudioPlayer";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel musicCardsArea;
        private FlowLayoutPanel PlayListArea;
        private Components.AudioPlayerControl audioPlayerControl1;
    }
}