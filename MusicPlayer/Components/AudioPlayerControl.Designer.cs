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
            TLPAudioKontrol = new TableLayoutPanel();
            TLPControlMain = new TableLayoutPanel();
            TLPControlButton = new TableLayoutPanel();
            TLPControlBar = new TableLayoutPanel();
            trackBar1 = new TrackBar();
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
            TLPAudioKontrol.Paint += tableLayoutPanel1_Paint;
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
            TLPControlBar.Controls.Add(trackBar1, 1, 0);
            TLPControlBar.Dock = DockStyle.Fill;
            TLPControlBar.Location = new Point(8, 55);
            TLPControlBar.Name = "TLPControlBar";
            TLPControlBar.RowCount = 1;
            TLPControlBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLPControlBar.Size = new Size(678, 30);
            TLPControlBar.TabIndex = 1;
            // 
            // trackBar1
            // 
            trackBar1.Dock = DockStyle.Fill;
            trackBar1.Location = new Point(72, 3);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(534, 24);
            trackBar1.TabIndex = 0;
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
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TLPAudioKontrol;
        private TableLayoutPanel TLPControlMain;
        private TableLayoutPanel TLPControlButton;
        private TableLayoutPanel TLPControlBar;
        private TrackBar trackBar1;
    }
}
