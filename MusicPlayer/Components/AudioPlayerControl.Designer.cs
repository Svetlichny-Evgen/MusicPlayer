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
            TLPAudioKontrol.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 700F));
            TLPAudioKontrol.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLPAudioKontrol.Controls.Add(TLPControlMain, 1, 0);
            TLPAudioKontrol.Dock = DockStyle.Fill;
            TLPAudioKontrol.Location = new Point(0, 0);
            TLPAudioKontrol.Name = "TLPAudioKontrol";
            TLPAudioKontrol.RowCount = 1;
            TLPAudioKontrol.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLPAudioKontrol.Size = new Size(996, 99);
            TLPAudioKontrol.TabIndex = 0;
            // 
            // TLPControlMain
            // 
            TLPControlMain.ColumnCount = 1;
            TLPControlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLPControlMain.Controls.Add(TLPControlButton, 0, 0);
            TLPControlMain.Controls.Add(TLPControlBar, 0, 1);
            TLPControlMain.Dock = DockStyle.Fill;
            TLPControlMain.Location = new Point(151, 3);
            TLPControlMain.Name = "TLPControlMain";
            TLPControlMain.Padding = new Padding(5);
            TLPControlMain.RowCount = 2;
            TLPControlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 56.9892464F));
            TLPControlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 43.0107536F));
            TLPControlMain.Size = new Size(694, 93);
            TLPControlMain.TabIndex = 0;
            // 
            // TLPControlButton
            // 
            TLPControlButton.BackColor = SystemColors.ControlLight;
            TLPControlButton.ColumnCount = 7;
            TLPControlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLPControlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            TLPControlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            TLPControlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            TLPControlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            TLPControlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            TLPControlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLPControlButton.Dock = DockStyle.Fill;
            TLPControlButton.Location = new Point(8, 8);
            TLPControlButton.Name = "TLPControlButton";
            TLPControlButton.RowCount = 1;
            TLPControlButton.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLPControlButton.Size = new Size(678, 41);
            TLPControlButton.TabIndex = 0;
            // 
            // TLPControlBar
            // 
            TLPControlBar.ColumnCount = 3;
            TLPControlBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLPControlBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 540F));
            TLPControlBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLPControlBar.Controls.Add(trackBar, 1, 0);
            TLPControlBar.Controls.Add(currentTime, 0, 0);
            TLPControlBar.Controls.Add(endTime, 2, 0);
            TLPControlBar.Dock = DockStyle.Fill;
            TLPControlBar.Location = new Point(8, 55);
            TLPControlBar.Name = "TLPControlBar";
            TLPControlBar.RowCount = 1;
            TLPControlBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLPControlBar.Size = new Size(678, 30);
            TLPControlBar.TabIndex = 1;
            // 
            // trackBar
            // 
            trackBar.Dock = DockStyle.Fill;
            trackBar.HeightPadding = 7;
            trackBar.Location = new Point(72, 3);
            trackBar.Max = 100F;
            trackBar.Name = "trackBar";
            trackBar.Size = new Size(534, 24);
            trackBar.TabIndex = 0;
            trackBar.Value = 50F;
            // 
            // currentTime
            // 
            currentTime.AutoSize = true;
            currentTime.Dock = DockStyle.Right;
            currentTime.Location = new Point(30, 0);
            currentTime.Name = "currentTime";
            currentTime.Size = new Size(36, 30);
            currentTime.TabIndex = 1;
            currentTime.Text = "--:--";
            currentTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // endTime
            // 
            endTime.AutoSize = true;
            endTime.Dock = DockStyle.Left;
            endTime.Location = new Point(612, 0);
            endTime.Name = "endTime";
            endTime.Size = new Size(36, 30);
            endTime.TabIndex = 2;
            endTime.Text = "--:--";
            endTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // audioTimer
            // 
            audioTimer.Enabled = true;
            audioTimer.Interval = 1000;
            audioTimer.Tick += audioTimer_Tick;
            // 
            // AudioPlayerControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TLPAudioKontrol);
            Name = "AudioPlayerControl";
            Size = new Size(996, 99);
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
    }
}
