namespace cTClicker
{
    partial class Clicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clicker));
            this.label1 = new System.Windows.Forms.Label();
            this.clicktimeUpDown = new System.Windows.Forms.NumericUpDown();
            this.clickMode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.click_tmr = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clicktimeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "点击间隔(ms)";
            // 
            // clicktimeUpDown
            // 
            this.clicktimeUpDown.Location = new System.Drawing.Point(144, 13);
            this.clicktimeUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.clicktimeUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.clicktimeUpDown.Name = "clicktimeUpDown";
            this.clicktimeUpDown.Size = new System.Drawing.Size(140, 23);
            this.clicktimeUpDown.TabIndex = 1;
            this.clicktimeUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // clickMode
            // 
            this.clickMode.FormattingEnabled = true;
            this.clickMode.Items.AddRange(new object[] {
            "左键",
            "右键",
            "左键+右键",
            "中键"});
            this.clickMode.Location = new System.Drawing.Point(144, 52);
            this.clickMode.Margin = new System.Windows.Forms.Padding(4);
            this.clickMode.Name = "clickMode";
            this.clickMode.Size = new System.Drawing.Size(140, 25);
            this.clickMode.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "点击模式";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(15, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alt+C开始/停止点击，Ctrl+Alt+E关闭窗口\r\n              Shift+C开启防挡模式";
            // 
            // click_tmr
            // 
            this.click_tmr.Tick += new System.EventHandler(this.click_tmr_Tick);
            // 
            // Clicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(299, 136);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clickMode);
            this.Controls.Add(this.clicktimeUpDown);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Clicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Clicker";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Clicker_FormClosing);
            this.Load += new System.EventHandler(this.Clicker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clicktimeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown clicktimeUpDown;
        private System.Windows.Forms.ComboBox clickMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer click_tmr;
    }
}