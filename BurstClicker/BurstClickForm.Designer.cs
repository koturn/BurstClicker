namespace BurstClicker
{
    partial class BurstClickForm
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
            System.Windows.Forms.TableLayoutPanel tableLayoutPanelWindow;
            System.Windows.Forms.GroupBox groupBoxConfig;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanelConfig;
            System.Windows.Forms.Label labelHotKey;
            System.Windows.Forms.Label labelFramerate;
            this._numericUpDownFramerate = new System.Windows.Forms.NumericUpDown();
            this._comboBoxHotKey = new System.Windows.Forms.ComboBox();
            this._labelStatus = new System.Windows.Forms.Label();
            tableLayoutPanelWindow = new System.Windows.Forms.TableLayoutPanel();
            groupBoxConfig = new System.Windows.Forms.GroupBox();
            tableLayoutPanelConfig = new System.Windows.Forms.TableLayoutPanel();
            labelHotKey = new System.Windows.Forms.Label();
            labelFramerate = new System.Windows.Forms.Label();
            tableLayoutPanelWindow.SuspendLayout();
            groupBoxConfig.SuspendLayout();
            tableLayoutPanelConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownFramerate)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelWindow
            // 
            tableLayoutPanelWindow.AutoSize = true;
            tableLayoutPanelWindow.ColumnCount = 1;
            tableLayoutPanelWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanelWindow.Controls.Add(groupBoxConfig, 0, 1);
            tableLayoutPanelWindow.Controls.Add(this._labelStatus, 0, 0);
            tableLayoutPanelWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanelWindow.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanelWindow.Name = "tableLayoutPanelWindow";
            tableLayoutPanelWindow.RowCount = 2;
            tableLayoutPanelWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanelWindow.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanelWindow.Size = new System.Drawing.Size(264, 161);
            tableLayoutPanelWindow.TabIndex = 0;
            // 
            // groupBoxConfig
            // 
            groupBoxConfig.AutoSize = true;
            groupBoxConfig.Controls.Add(tableLayoutPanelConfig);
            groupBoxConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBoxConfig.Location = new System.Drawing.Point(3, 78);
            groupBoxConfig.Name = "groupBoxConfig";
            groupBoxConfig.Size = new System.Drawing.Size(258, 80);
            groupBoxConfig.TabIndex = 2;
            groupBoxConfig.TabStop = false;
            groupBoxConfig.Text = "Config";
            // 
            // tableLayoutPanelConfig
            // 
            tableLayoutPanelConfig.AutoSize = true;
            tableLayoutPanelConfig.ColumnCount = 3;
            tableLayoutPanelConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanelConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanelConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanelConfig.Controls.Add(labelHotKey, 0, 0);
            tableLayoutPanelConfig.Controls.Add(labelFramerate, 0, 1);
            tableLayoutPanelConfig.Controls.Add(this._numericUpDownFramerate, 1, 1);
            tableLayoutPanelConfig.Controls.Add(this._comboBoxHotKey, 1, 0);
            tableLayoutPanelConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanelConfig.Location = new System.Drawing.Point(3, 19);
            tableLayoutPanelConfig.Name = "tableLayoutPanelConfig";
            tableLayoutPanelConfig.RowCount = 2;
            tableLayoutPanelConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanelConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanelConfig.Size = new System.Drawing.Size(252, 58);
            tableLayoutPanelConfig.TabIndex = 3;
            // 
            // labelHotKey
            // 
            labelHotKey.AutoSize = true;
            labelHotKey.Dock = System.Windows.Forms.DockStyle.Fill;
            labelHotKey.Location = new System.Drawing.Point(3, 0);
            labelHotKey.Name = "labelHotKey";
            labelHotKey.Size = new System.Drawing.Size(58, 29);
            labelHotKey.TabIndex = 4;
            labelHotKey.Text = "Hot Key";
            labelHotKey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFramerate
            // 
            labelFramerate.AutoSize = true;
            labelFramerate.Dock = System.Windows.Forms.DockStyle.Fill;
            labelFramerate.Location = new System.Drawing.Point(3, 29);
            labelFramerate.Name = "labelFramerate";
            labelFramerate.Size = new System.Drawing.Size(58, 29);
            labelFramerate.TabIndex = 6;
            labelFramerate.Text = "Framerate";
            labelFramerate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _numericUpDownFramerate
            // 
            this._numericUpDownFramerate.Dock = System.Windows.Forms.DockStyle.Fill;
            this._numericUpDownFramerate.Location = new System.Drawing.Point(67, 32);
            this._numericUpDownFramerate.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this._numericUpDownFramerate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._numericUpDownFramerate.Name = "_numericUpDownFramerate";
            this._numericUpDownFramerate.Size = new System.Drawing.Size(48, 23);
            this._numericUpDownFramerate.TabIndex = 7;
            this._numericUpDownFramerate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._numericUpDownFramerate.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // _comboBoxHotKey
            // 
            this._comboBoxHotKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this._comboBoxHotKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxHotKey.FormattingEnabled = true;
            this._comboBoxHotKey.Items.AddRange(new object[] {
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this._comboBoxHotKey.Location = new System.Drawing.Point(67, 3);
            this._comboBoxHotKey.Name = "_comboBoxHotKey";
            this._comboBoxHotKey.Size = new System.Drawing.Size(48, 23);
            this._comboBoxHotKey.TabIndex = 5;
            this._comboBoxHotKey.SelectedIndexChanged += new System.EventHandler(this.ComboBoxHotKey_SelectedIndexChanged);
            // 
            // _labelStatus
            // 
            this._labelStatus.AutoSize = true;
            this._labelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelStatus.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._labelStatus.Location = new System.Drawing.Point(3, 0);
            this._labelStatus.Name = "_labelStatus";
            this._labelStatus.Size = new System.Drawing.Size(258, 75);
            this._labelStatus.TabIndex = 1;
            this._labelStatus.Text = "Inactive";
            this._labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BurstClickForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 161);
            this.Controls.Add(tableLayoutPanelWindow);
            this.Name = "BurstClickForm";
            this.Text = "BurstClicker: Inactive";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BurstClickForm_FormClosing);
            this.Load += new System.EventHandler(this.BurstClickForm_Load);
            tableLayoutPanelWindow.ResumeLayout(false);
            tableLayoutPanelWindow.PerformLayout();
            groupBoxConfig.ResumeLayout(false);
            groupBoxConfig.PerformLayout();
            tableLayoutPanelConfig.ResumeLayout(false);
            tableLayoutPanelConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownFramerate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown _numericUpDownFramerate;
        private System.Windows.Forms.ComboBox _comboBoxHotKey;
        private System.Windows.Forms.Label _labelStatus;
    }
}