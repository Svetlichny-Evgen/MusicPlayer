namespace MusicPlayer.Components
{
    partial class AudioPlayerControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TLPAudioKontrol = new TableLayoutPanel();
            TLPControlMain = new TableLayoutPanel();
            TLPControlButton = new TableLayoutPanel();
            TLPControlBar = new TableLayoutPanel();
            trackBar = new TrackBar();
            currentTime = new Label();
            endTime = new Label();
            trackInfo1 = new TrackInfo();
            audioTimer = new System.Windows.Forms.Timer(components);
            TLPAudioKontrol.SuspendLayout();
            TLPControlMain.SuspendLayout();
            TLPControlBar.SuspendLayout();
            SuspendLayout();
            // 
            // TLPAudioKontrol
            // 
            TLPAudioKontrol.BackColor = SystemColors.ControlLight;
            TLPAudioKontrol.ColumnCount = 3;
            TLPAudioKontrol.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLPAudioKontrol.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 612F));
            TLPAudioKontrol.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLPAudioKontrol.Controls.Add(TLPControlMain, 1, 0);
            TLPAudioKontrol.Controls.Add(trackInfo1, 0, 0);
            TLPAudioKontrol.Dock = DockStyle.Fill;
            TLPAudioKontrol.Location = new Point(0, 0);
            TLPAudioKontrol.Margin = new Padding(3, 2, 3, 2);
            TLPAudioKontrol.Name = "TLPAudioKontrol";
            TLPAudioKontrol.RowCount = 1;
            TLPAudioKontrol.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLPAudioKontrol.Size = new Size(872, 74);
            TLPAudioKontrol.TabIndex = 0;
            // 
            // TLPControlMain
            // 
            TLPControlMain.ColumnCount = 1;
            TLPControlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLPControlMain.Controls.Add(TLPControlButton, 0, 0);
            TLPControlMain.Controls.Add(TLPControlBar, 0, 1);
            TLPControlMain.Dock = DockStyle.Fill;
            TLPControlMain.Location = new Point(133, 2);
            TLPControlMain.Margin = new Padding(3, 2, 3, 2);
            TLPControlMain.Name = "TLPControlMain";
            TLPControlMain.Padding = new Padding(4);
            TLPControlMain.RowCount = 2;
            TLPControlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 56.9892464F));
            TLPControlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 43.0107536F));
            TLPControlMain.Size = new Size(606, 70);
            TLPControlMain.TabIndex = 0;
            // 
            // TLPControlButton
            // 
            TLPControlButton.BackColor = SystemColors.ControlLight;
            TLPControlButton.ColumnCount = 7;
            TLPControlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLPControlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            TLPControlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            TLPControlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            TLPControlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            TLPControlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            TLPControlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLPControlButton.Dock = DockStyle.Fill;
            TLPControlButton.Location = new Point(7, 6);
            TLPControlButton.Margin = new Padding(3, 2, 3, 2);
            TLPControlButton.Name = "TLPControlButton";
            TLPControlButton.RowCount = 1;
            TLPControlButton.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLPControlButton.Size = new Size(592, 31);
            TLPControlButton.TabIndex = 0;
            // 
            // TLPControlBar
            // 
            TLPControlBar.ColumnCount = 3;
            TLPControlBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLPControlBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 472F));
            TLPControlBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLPControlBar.Controls.Add(trackBar, 1, 0);
            TLPControlBar.Controls.Add(currentTime, 0, 0);
            TLPControlBar.Controls.Add(endTime, 2, 0);
            TLPControlBar.Dock = DockStyle.Fill;
            TLPControlBar.Location = new Point(7, 41);
            TLPControlBar.Margin = new Padding(3, 2, 3, 2);
            TLPControlBar.Name = "TLPControlBar";
            TLPControlBar.RowCount = 1;
            TLPControlBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLPControlBar.Size = new Size(592, 23);
            TLPControlBar.TabIndex = 1;
            // 
            // trackBar
            // 
            trackBar.Dock = DockStyle.Fill;
            trackBar.HeightPadding = 7;
            trackBar.Location = new Point(63, 2);
            trackBar.Margin = new Padding(3, 2, 3, 2);
            trackBar.Max = 100F;
            trackBar.Name = "trackBar";
            trackBar.Size = new Size(466, 19);
            trackBar.TabIndex = 0;
            trackBar.Value = 50F;
            // 
            // currentTime
            // 
            currentTime.AutoSize = true;
            currentTime.Dock = DockStyle.Right;
            currentTime.Location = new Point(27, 0);
            currentTime.Name = "currentTime";
            currentTime.Size = new Size(30, 23);
            currentTime.TabIndex = 1;
            currentTime.Text = "--:--";
            currentTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // endTime
            // 
            endTime.AutoSize = true;
            endTime.Dock = DockStyle.Left;
            endTime.Location = new Point(535, 0);
            endTime.Name = "endTime";
            endTime.Size = new Size(30, 23);
            endTime.TabIndex = 2;
            endTime.Text = "--:--";
            endTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trackInfo1
            // 
            trackInfo1.BackColor = SystemColors.Control;
            trackInfo1.Dock = DockStyle.Fill;
            trackInfo1.Image = null;
            trackInfo1.Location = new Point(3, 3);
            trackInfo1.Name = "trackInfo1";
            trackInfo1.Singer = "Discription";
            trackInfo1.Size = new Size(124, 68);
            trackInfo1.Source = null;
            trackInfo1.TabIndex = 1;
            trackInfo1.Title = "TrackTitle";
            // 
            // audioTimer
            // 
            audioTimer.Enabled = true;
            audioTimer.Interval = 1000;
            audioTimer.Tick += audioTimer_Tick;
            // 
            // AudioPlayerControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TLPAudioKontrol);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AudioPlayerControl";
            Size = new Size(872, 74);
            TLPAudioKontrol.ResumeLayout(false);
            TLPControlMain.ResumeLayout(false);
            TLPControlBar.ResumeLayout(false);
            TLPControlBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TLPAudioKontrol;
        private TableLayoutPanel TLPControlMain;
        private TableLayoutPanel TLPControlButton;
        private TableLayoutPanel TLPControlBar;
        private TrackBar trackBar;
        private Label currentTime;
        private Label endTime;
        private System.Windows.Forms.Timer audioTimer;
        private PlayList musicInfo;
        private TrackInfo trackInfo1;
    }
}
