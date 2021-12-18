
namespace SimpleSpecs
{
    partial class SimpleSpecs
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
            this.titleLabel = new MetroFramework.Controls.MetroLabel();
            this.advancedModeToggle = new MetroFramework.Controls.MetroToggle();
            this.closeLabel = new MetroFramework.Controls.MetroLabel();
            this.cpuSectionLabel = new MetroFramework.Controls.MetroLabel();
            this.cpuLabel = new MetroFramework.Controls.MetroLabel();
            this.advancedModeLabel = new MetroFramework.Controls.MetroLabel();
            this.gpuLabel = new MetroFramework.Controls.MetroLabel();
            this.memoryLabel = new MetroFramework.Controls.MetroLabel();
            this.storageLabel = new MetroFramework.Controls.MetroLabel();
            this.gpuSectionLabel = new MetroFramework.Controls.MetroLabel();
            this.memorySectionLabel = new MetroFramework.Controls.MetroLabel();
            this.storageSectionLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.titleLabel.CustomBackground = true;
            this.titleLabel.CustomForeColor = true;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(800, 40);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Simple Specs";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseDown);
            this.titleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseMove);
            this.titleLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseUp);
            // 
            // advancedModeToggle
            // 
            this.advancedModeToggle.AutoSize = true;
            this.advancedModeToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.advancedModeToggle.CustomBackground = true;
            this.advancedModeToggle.Location = new System.Drawing.Point(412, 69);
            this.advancedModeToggle.Name = "advancedModeToggle";
            this.advancedModeToggle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.advancedModeToggle.Size = new System.Drawing.Size(80, 17);
            this.advancedModeToggle.TabIndex = 2;
            this.advancedModeToggle.Text = "Off";
            this.advancedModeToggle.UseVisualStyleBackColor = false;
            this.advancedModeToggle.CheckedChanged += new System.EventHandler(this.advancedModeToggle_CheckedChanged);
            // 
            // closeLabel
            // 
            this.closeLabel.BackColor = System.Drawing.Color.Red;
            this.closeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLabel.CustomBackground = true;
            this.closeLabel.CustomForeColor = true;
            this.closeLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.closeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.closeLabel.Location = new System.Drawing.Point(763, 8);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(25, 25);
            this.closeLabel.TabIndex = 4;
            this.closeLabel.Text = "X";
            this.closeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closeLabel_MouseClick);
            this.closeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.closeLabel_MouseDown);
            this.closeLabel.MouseLeave += new System.EventHandler(this.closeLabel_MouseLeave);
            this.closeLabel.MouseHover += new System.EventHandler(this.closeLabel_MouseHover);
            this.closeLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.closeLabel_MouseUp);
            // 
            // cpuSectionLabel
            // 
            this.cpuSectionLabel.CustomBackground = true;
            this.cpuSectionLabel.CustomForeColor = true;
            this.cpuSectionLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.cpuSectionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.cpuSectionLabel.Location = new System.Drawing.Point(12, 103);
            this.cpuSectionLabel.Name = "cpuSectionLabel";
            this.cpuSectionLabel.Size = new System.Drawing.Size(142, 40);
            this.cpuSectionLabel.TabIndex = 6;
            this.cpuSectionLabel.Text = "CPU";
            this.cpuSectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cpuLabel
            // 
            this.cpuLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpuLabel.CustomBackground = true;
            this.cpuLabel.CustomForeColor = true;
            this.cpuLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.cpuLabel.Location = new System.Drawing.Point(12, 143);
            this.cpuLabel.Name = "cpuLabel";
            this.cpuLabel.Size = new System.Drawing.Size(375, 120);
            this.cpuLabel.TabIndex = 7;
            this.cpuLabel.Text = "Loading...";
            this.cpuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // advancedModeLabel
            // 
            this.advancedModeLabel.CustomBackground = true;
            this.advancedModeLabel.CustomForeColor = true;
            this.advancedModeLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.advancedModeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.advancedModeLabel.Location = new System.Drawing.Point(270, 57);
            this.advancedModeLabel.Name = "advancedModeLabel";
            this.advancedModeLabel.Size = new System.Drawing.Size(222, 40);
            this.advancedModeLabel.TabIndex = 8;
            this.advancedModeLabel.Text = "Advanced Mode";
            this.advancedModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gpuLabel
            // 
            this.gpuLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gpuLabel.CustomBackground = true;
            this.gpuLabel.CustomForeColor = true;
            this.gpuLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.gpuLabel.Location = new System.Drawing.Point(413, 143);
            this.gpuLabel.Name = "gpuLabel";
            this.gpuLabel.Size = new System.Drawing.Size(375, 120);
            this.gpuLabel.TabIndex = 9;
            this.gpuLabel.Text = "Loading...";
            this.gpuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // memoryLabel
            // 
            this.memoryLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.memoryLabel.CustomBackground = true;
            this.memoryLabel.CustomForeColor = true;
            this.memoryLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.memoryLabel.Location = new System.Drawing.Point(12, 318);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(375, 120);
            this.memoryLabel.TabIndex = 10;
            this.memoryLabel.Text = "Loading...";
            this.memoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // storageLabel
            // 
            this.storageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.storageLabel.CustomBackground = true;
            this.storageLabel.CustomForeColor = true;
            this.storageLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.storageLabel.Location = new System.Drawing.Point(413, 318);
            this.storageLabel.Name = "storageLabel";
            this.storageLabel.Size = new System.Drawing.Size(375, 120);
            this.storageLabel.TabIndex = 11;
            this.storageLabel.Text = "Loading...";
            this.storageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gpuSectionLabel
            // 
            this.gpuSectionLabel.CustomBackground = true;
            this.gpuSectionLabel.CustomForeColor = true;
            this.gpuSectionLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.gpuSectionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.gpuSectionLabel.Location = new System.Drawing.Point(413, 103);
            this.gpuSectionLabel.Name = "gpuSectionLabel";
            this.gpuSectionLabel.Size = new System.Drawing.Size(142, 40);
            this.gpuSectionLabel.TabIndex = 12;
            this.gpuSectionLabel.Text = "GPU";
            this.gpuSectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // memorySectionLabel
            // 
            this.memorySectionLabel.CustomBackground = true;
            this.memorySectionLabel.CustomForeColor = true;
            this.memorySectionLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.memorySectionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.memorySectionLabel.Location = new System.Drawing.Point(12, 278);
            this.memorySectionLabel.Name = "memorySectionLabel";
            this.memorySectionLabel.Size = new System.Drawing.Size(142, 40);
            this.memorySectionLabel.TabIndex = 13;
            this.memorySectionLabel.Text = "Memory";
            this.memorySectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // storageSectionLabel
            // 
            this.storageSectionLabel.CustomBackground = true;
            this.storageSectionLabel.CustomForeColor = true;
            this.storageSectionLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.storageSectionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.storageSectionLabel.Location = new System.Drawing.Point(413, 278);
            this.storageSectionLabel.Name = "storageSectionLabel";
            this.storageSectionLabel.Size = new System.Drawing.Size(142, 40);
            this.storageSectionLabel.TabIndex = 14;
            this.storageSectionLabel.Text = "Storage";
            this.storageSectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SimpleSpecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.storageSectionLabel);
            this.Controls.Add(this.memorySectionLabel);
            this.Controls.Add(this.gpuSectionLabel);
            this.Controls.Add(this.storageLabel);
            this.Controls.Add(this.memoryLabel);
            this.Controls.Add(this.gpuLabel);
            this.Controls.Add(this.advancedModeToggle);
            this.Controls.Add(this.advancedModeLabel);
            this.Controls.Add(this.cpuLabel);
            this.Controls.Add(this.cpuSectionLabel);
            this.Controls.Add(this.closeLabel);
            this.Controls.Add(this.titleLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "SimpleSpecs";
            this.Text = "Simple Specs";
            this.Load += new System.EventHandler(this.SimpleSpecs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel titleLabel;
        private MetroFramework.Controls.MetroToggle advancedModeToggle;
        private MetroFramework.Controls.MetroLabel closeLabel;
        private MetroFramework.Controls.MetroLabel cpuSectionLabel;
        private MetroFramework.Controls.MetroLabel cpuLabel;
        private MetroFramework.Controls.MetroLabel advancedModeLabel;
        private MetroFramework.Controls.MetroLabel gpuLabel;
        private MetroFramework.Controls.MetroLabel memoryLabel;
        private MetroFramework.Controls.MetroLabel storageLabel;
        private MetroFramework.Controls.MetroLabel gpuSectionLabel;
        private MetroFramework.Controls.MetroLabel memorySectionLabel;
        private MetroFramework.Controls.MetroLabel storageSectionLabel;
    }
}

