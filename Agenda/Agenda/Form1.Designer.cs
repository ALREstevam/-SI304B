namespace Agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.flowLayoutPanelLine = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelColumn1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelColumn2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelColumn3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelNames = new System.Windows.Forms.FlowLayoutPanel();
            this.panelName1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelName2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelName3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanelBack = new System.Windows.Forms.FlowLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonBugReport = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanelLine.SuspendLayout();
            this.flowLayoutPanelNames.SuspendLayout();
            this.panelName1.SuspendLayout();
            this.panelName2.SuspendLayout();
            this.panelName3.SuspendLayout();
            this.flowLayoutPanelBack.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonHelp);
            this.panel1.Controls.Add(this.buttonAddTask);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(85, 552);
            this.panel1.TabIndex = 0;
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.Transparent;
            this.buttonHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHelp.BackgroundImage")));
            this.buttonHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp.FlatAppearance.BorderSize = 0;
            this.buttonHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.ForeColor = System.Drawing.Color.Transparent;
            this.buttonHelp.Location = new System.Drawing.Point(3, 89);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(41, 41);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddTask.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddTask.BackgroundImage")));
            this.buttonAddTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddTask.FlatAppearance.BorderSize = 0;
            this.buttonAddTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTask.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAddTask.Location = new System.Drawing.Point(0, 0);
            this.buttonAddTask.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(86, 86);
            this.buttonAddTask.TabIndex = 0;
            this.buttonAddTask.UseVisualStyleBackColor = false;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Transparent;
            this.buttonRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.BackgroundImage")));
            this.buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.ForeColor = System.Drawing.Color.Transparent;
            this.buttonRefresh.Location = new System.Drawing.Point(41, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(41, 41);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // flowLayoutPanelLine
            // 
            this.flowLayoutPanelLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.flowLayoutPanelLine.Controls.Add(this.flowLayoutPanelColumn1);
            this.flowLayoutPanelLine.Controls.Add(this.flowLayoutPanelColumn2);
            this.flowLayoutPanelLine.Controls.Add(this.flowLayoutPanelColumn3);
            this.flowLayoutPanelLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelLine.Location = new System.Drawing.Point(0, 72);
            this.flowLayoutPanelLine.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelLine.Name = "flowLayoutPanelLine";
            this.flowLayoutPanelLine.Size = new System.Drawing.Size(705, 463);
            this.flowLayoutPanelLine.TabIndex = 1;
            // 
            // flowLayoutPanelColumn1
            // 
            this.flowLayoutPanelColumn1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelColumn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(33)))), ((int)(((byte)(26)))));
            this.flowLayoutPanelColumn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanelColumn1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelColumn1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelColumn1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelColumn1.Name = "flowLayoutPanelColumn1";
            this.flowLayoutPanelColumn1.Size = new System.Drawing.Size(200, 448);
            this.flowLayoutPanelColumn1.TabIndex = 0;
            // 
            // flowLayoutPanelColumn2
            // 
            this.flowLayoutPanelColumn2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanelColumn2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelColumn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(7)))));
            this.flowLayoutPanelColumn2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelColumn2.Location = new System.Drawing.Point(200, 0);
            this.flowLayoutPanelColumn2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelColumn2.Name = "flowLayoutPanelColumn2";
            this.flowLayoutPanelColumn2.Size = new System.Drawing.Size(200, 448);
            this.flowLayoutPanelColumn2.TabIndex = 1;
            // 
            // flowLayoutPanelColumn3
            // 
            this.flowLayoutPanelColumn3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanelColumn3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelColumn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(111)))), ((int)(((byte)(204)))));
            this.flowLayoutPanelColumn3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelColumn3.Location = new System.Drawing.Point(400, 0);
            this.flowLayoutPanelColumn3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelColumn3.Name = "flowLayoutPanelColumn3";
            this.flowLayoutPanelColumn3.Size = new System.Drawing.Size(207, 448);
            this.flowLayoutPanelColumn3.TabIndex = 2;
            // 
            // flowLayoutPanelNames
            // 
            this.flowLayoutPanelNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.flowLayoutPanelNames.Controls.Add(this.panelName1);
            this.flowLayoutPanelNames.Controls.Add(this.panelName2);
            this.flowLayoutPanelNames.Controls.Add(this.panelName3);
            this.flowLayoutPanelNames.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelNames.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelNames.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelNames.Name = "flowLayoutPanelNames";
            this.flowLayoutPanelNames.Size = new System.Drawing.Size(705, 72);
            this.flowLayoutPanelNames.TabIndex = 2;
            // 
            // panelName1
            // 
            this.panelName1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(33)))), ((int)(((byte)(26)))));
            this.panelName1.Controls.Add(this.label1);
            this.panelName1.Location = new System.Drawing.Point(0, 0);
            this.panelName1.Margin = new System.Windows.Forms.Padding(0);
            this.panelName1.Name = "panelName1";
            this.panelName1.Size = new System.Drawing.Size(200, 72);
            this.panelName1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(33)))), ((int)(((byte)(26)))));
            this.label1.Font = new System.Drawing.Font("Calibri Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(21)))), ((int)(((byte)(16)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(194, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fazer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelName2
            // 
            this.panelName2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(7)))));
            this.panelName2.Controls.Add(this.label2);
            this.panelName2.Location = new System.Drawing.Point(200, 0);
            this.panelName2.Margin = new System.Windows.Forms.Padding(0);
            this.panelName2.Name = "panelName2";
            this.panelName2.Size = new System.Drawing.Size(200, 72);
            this.panelName2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(7)))));
            this.label2.Font = new System.Drawing.Font("Calibri Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(110)))), ((int)(((byte)(6)))));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(194, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fazendo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelName3
            // 
            this.panelName3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(111)))), ((int)(((byte)(204)))));
            this.panelName3.Controls.Add(this.label3);
            this.panelName3.Location = new System.Drawing.Point(400, 0);
            this.panelName3.Margin = new System.Windows.Forms.Padding(0);
            this.panelName3.Name = "panelName3";
            this.panelName3.Size = new System.Drawing.Size(207, 72);
            this.panelName3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(111)))), ((int)(((byte)(204)))));
            this.label3.Font = new System.Drawing.Font("Calibri Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(127)))));
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(201, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "Feito";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelBack
            // 
            this.flowLayoutPanelBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.flowLayoutPanelBack.Controls.Add(this.flowLayoutPanelNames);
            this.flowLayoutPanelBack.Controls.Add(this.flowLayoutPanelLine);
            this.flowLayoutPanelBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBack.Location = new System.Drawing.Point(85, 0);
            this.flowLayoutPanelBack.Name = "flowLayoutPanelBack";
            this.flowLayoutPanelBack.Size = new System.Drawing.Size(744, 552);
            this.flowLayoutPanelBack.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(85, 530);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(744, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // buttonBugReport
            // 
            this.buttonBugReport.BackColor = System.Drawing.Color.Transparent;
            this.buttonBugReport.BackgroundImage = global::Agenda.Properties.Resources.Bug_96px;
            this.buttonBugReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBugReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBugReport.FlatAppearance.BorderSize = 0;
            this.buttonBugReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBugReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBugReport.ForeColor = System.Drawing.Color.Transparent;
            this.buttonBugReport.Location = new System.Drawing.Point(0, 5);
            this.buttonBugReport.Name = "buttonBugReport";
            this.buttonBugReport.Size = new System.Drawing.Size(41, 41);
            this.buttonBugReport.TabIndex = 3;
            this.buttonBugReport.UseVisualStyleBackColor = false;
            this.buttonBugReport.Click += new System.EventHandler(this.buttonBugReport_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonBugReport);
            this.panel2.Controls.Add(this.buttonRefresh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 506);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(85, 46);
            this.panel2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(829, 552);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.flowLayoutPanelBack);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanelLine.ResumeLayout(false);
            this.flowLayoutPanelNames.ResumeLayout(false);
            this.panelName1.ResumeLayout(false);
            this.panelName2.ResumeLayout(false);
            this.panelName3.ResumeLayout(false);
            this.flowLayoutPanelBack.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLine;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelColumn1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelColumn2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelColumn3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNames;
        private System.Windows.Forms.Panel panelName1;
        private System.Windows.Forms.Panel panelName2;
        private System.Windows.Forms.Panel panelName3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button buttonBugReport;
        private System.Windows.Forms.Panel panel2;
    }
}

