namespace DeskWarden
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.titleBar = new System.Windows.Forms.Panel();
            this.minBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.advancedBtn = new System.Windows.Forms.Button();
            this.state1Btn = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.interval1UpDown = new System.Windows.Forms.NumericUpDown();
            this.interval1Slider = new System.Windows.Forms.TrackBar();
            this.saveBtn = new System.Windows.Forms.Button();
            this.dimPanel = new System.Windows.Forms.Panel();
            this.titleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interval1UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interval1Slider)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Desk Warden";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(432, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(0, -1);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(120, 21);
            this.title.TabIndex = 1;
            this.title.Text = "Desk Warden";
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_MouseDown);
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_MouseMove);
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.titleBar.Controls.Add(this.minBtn);
            this.titleBar.Controls.Add(this.title);
            this.titleBar.Controls.Add(this.exitBtn);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(600, 20);
            this.titleBar.TabIndex = 2;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseMove);
            // 
            // minBtn
            // 
            this.minBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.minBtn.FlatAppearance.BorderSize = 0;
            this.minBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.minBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.minBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minBtn.Location = new System.Drawing.Point(560, 0);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(20, 20);
            this.minBtn.TabIndex = 1;
            this.minBtn.TabStop = false;
            this.minBtn.Text = "-";
            this.minBtn.UseVisualStyleBackColor = false;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            this.minBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.minBtn_Paint);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Location = new System.Drawing.Point(580, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(20, 20);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.TabStop = false;
            this.exitBtn.Text = "x";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            this.exitBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.exitBtn_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.advancedBtn);
            this.panel1.Controls.Add(this.state1Btn);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.interval1UpDown);
            this.panel1.Controls.Add(this.interval1Slider);
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 300);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // advancedBtn
            // 
            this.advancedBtn.Location = new System.Drawing.Point(3, 274);
            this.advancedBtn.Name = "advancedBtn";
            this.advancedBtn.Size = new System.Drawing.Size(75, 23);
            this.advancedBtn.TabIndex = 5;
            this.advancedBtn.Text = "Advanced";
            this.advancedBtn.UseVisualStyleBackColor = true;
            this.advancedBtn.Click += new System.EventHandler(this.advancedBtn_Click);
            // 
            // state1Btn
            // 
            this.state1Btn.AutoSize = true;
            this.state1Btn.Checked = true;
            this.state1Btn.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.state1Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.state1Btn.ForeColor = System.Drawing.Color.White;
            this.state1Btn.Location = new System.Drawing.Point(10, 12);
            this.state1Btn.Name = "state1Btn";
            this.state1Btn.Size = new System.Drawing.Size(32, 17);
            this.state1Btn.TabIndex = 0;
            this.state1Btn.TabStop = false;
            this.state1Btn.Text = "?";
            this.state1Btn.UseVisualStyleBackColor = true;
            this.state1Btn.CheckStateChanged += new System.EventHandler(this.state1Btn_CheckStateChanged);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(98, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 10);
            this.panel4.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(97, 10);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 10);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono NL", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(143, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "minute(s)";
            // 
            // interval1UpDown
            // 
            this.interval1UpDown.BackColor = System.Drawing.SystemColors.Window;
            this.interval1UpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.interval1UpDown.Location = new System.Drawing.Point(113, 38);
            this.interval1UpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.interval1UpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.interval1UpDown.Name = "interval1UpDown";
            this.interval1UpDown.Size = new System.Drawing.Size(30, 16);
            this.interval1UpDown.TabIndex = 4;
            this.interval1UpDown.TabStop = false;
            this.interval1UpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.interval1UpDown.ValueChanged += new System.EventHandler(this.interval1UpDown_ValueChanged);
            // 
            // interval1Slider
            // 
            this.interval1Slider.Cursor = System.Windows.Forms.Cursors.Default;
            this.interval1Slider.LargeChange = 0;
            this.interval1Slider.Location = new System.Drawing.Point(3, 26);
            this.interval1Slider.Maximum = 59;
            this.interval1Slider.Minimum = 1;
            this.interval1Slider.Name = "interval1Slider";
            this.interval1Slider.Size = new System.Drawing.Size(104, 45);
            this.interval1Slider.TabIndex = 4;
            this.interval1Slider.TabStop = false;
            this.interval1Slider.TickFrequency = 0;
            this.interval1Slider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.interval1Slider.Value = 59;
            this.interval1Slider.ValueChanged += new System.EventHandler(this.interval1Slider_ValueChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.AutoSize = true;
            this.saveBtn.Location = new System.Drawing.Point(513, 365);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // dimPanel
            // 
            this.dimPanel.Location = new System.Drawing.Point(4, 23);
            this.dimPanel.Name = "dimPanel";
            this.dimPanel.Size = new System.Drawing.Size(20, 20);
            this.dimPanel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.dimPanel);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(150, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interval1UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interval1Slider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button minBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox state1Btn;
        private System.Windows.Forms.TrackBar interval1Slider;
        private System.Windows.Forms.NumericUpDown interval1UpDown;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button advancedBtn;
        private System.Windows.Forms.Panel dimPanel;
    }
}

