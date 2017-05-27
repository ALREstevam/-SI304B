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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonAddTask = new System.Windows.Forms.Button();
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
            this.panel1.SuspendLayout();
            this.flowLayoutPanelLine.SuspendLayout();
            this.flowLayoutPanelNames.SuspendLayout();
            this.panelName1.SuspendLayout();
            this.panelName2.SuspendLayout();
            this.panelName3.SuspendLayout();
            this.flowLayoutPanelBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.buttonHelp);
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.buttonAddTask);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(54, 533);
            this.panel1.TabIndex = 0;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(3, 112);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(48, 44);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(3, 62);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(48, 44);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "->";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Location = new System.Drawing.Point(3, 12);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(48, 44);
            this.buttonAddTask.TabIndex = 0;
            this.buttonAddTask.Text = "+";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // flowLayoutPanelLine
            // 
            this.flowLayoutPanelLine.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flowLayoutPanelLine.Controls.Add(this.flowLayoutPanelColumn1);
            this.flowLayoutPanelLine.Controls.Add(this.flowLayoutPanelColumn2);
            this.flowLayoutPanelLine.Controls.Add(this.flowLayoutPanelColumn3);
            this.flowLayoutPanelLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelLine.Location = new System.Drawing.Point(0, 56);
            this.flowLayoutPanelLine.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelLine.Name = "flowLayoutPanelLine";
            this.flowLayoutPanelLine.Size = new System.Drawing.Size(705, 463);
            this.flowLayoutPanelLine.TabIndex = 1;
            // 
            // flowLayoutPanelColumn1
            // 
            this.flowLayoutPanelColumn1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelColumn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(228)))), ((int)(((byte)(225)))));
            this.flowLayoutPanelColumn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanelColumn1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.flowLayoutPanelColumn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(217)))));
            this.flowLayoutPanelColumn2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.flowLayoutPanelColumn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(250)))), ((int)(((byte)(234)))));
            this.flowLayoutPanelColumn3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelColumn3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelColumn3.Location = new System.Drawing.Point(400, 0);
            this.flowLayoutPanelColumn3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelColumn3.Name = "flowLayoutPanelColumn3";
            this.flowLayoutPanelColumn3.Size = new System.Drawing.Size(207, 448);
            this.flowLayoutPanelColumn3.TabIndex = 2;
            // 
            // flowLayoutPanelNames
            // 
            this.flowLayoutPanelNames.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flowLayoutPanelNames.Controls.Add(this.panelName1);
            this.flowLayoutPanelNames.Controls.Add(this.panelName2);
            this.flowLayoutPanelNames.Controls.Add(this.panelName3);
            this.flowLayoutPanelNames.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelNames.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelNames.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelNames.Name = "flowLayoutPanelNames";
            this.flowLayoutPanelNames.Size = new System.Drawing.Size(705, 56);
            this.flowLayoutPanelNames.TabIndex = 2;
            // 
            // panelName1
            // 
            this.panelName1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(228)))), ((int)(((byte)(225)))));
            this.panelName1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelName1.Controls.Add(this.label1);
            this.panelName1.Location = new System.Drawing.Point(0, 0);
            this.panelName1.Margin = new System.Windows.Forms.Padding(0);
            this.panelName1.Name = "panelName1";
            this.panelName1.Size = new System.Drawing.Size(200, 56);
            this.panelName1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(228)))), ((int)(((byte)(225)))));
            this.label1.Font = new System.Drawing.Font("Calibri Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(192, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fazer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelName2
            // 
            this.panelName2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(217)))));
            this.panelName2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelName2.Controls.Add(this.label2);
            this.panelName2.Location = new System.Drawing.Point(200, 0);
            this.panelName2.Margin = new System.Windows.Forms.Padding(0);
            this.panelName2.Name = "panelName2";
            this.panelName2.Size = new System.Drawing.Size(200, 56);
            this.panelName2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(217)))));
            this.label2.Font = new System.Drawing.Font("Calibri Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(192, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fazendo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelName3
            // 
            this.panelName3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(250)))), ((int)(((byte)(234)))));
            this.panelName3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelName3.Controls.Add(this.label3);
            this.panelName3.Location = new System.Drawing.Point(400, 0);
            this.panelName3.Margin = new System.Windows.Forms.Padding(0);
            this.panelName3.Name = "panelName3";
            this.panelName3.Size = new System.Drawing.Size(207, 56);
            this.panelName3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(250)))), ((int)(((byte)(234)))));
            this.label3.Font = new System.Drawing.Font("Calibri Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(199, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Feito";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelBack
            // 
            this.flowLayoutPanelBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flowLayoutPanelBack.Controls.Add(this.flowLayoutPanelNames);
            this.flowLayoutPanelBack.Controls.Add(this.flowLayoutPanelLine);
            this.flowLayoutPanelBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBack.Location = new System.Drawing.Point(54, 0);
            this.flowLayoutPanelBack.Name = "flowLayoutPanelBack";
            this.flowLayoutPanelBack.Size = new System.Drawing.Size(720, 533);
            this.flowLayoutPanelBack.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(774, 533);
            this.Controls.Add(this.flowLayoutPanelBack);
            this.Controls.Add(this.panel1);
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
            this.ResumeLayout(false);

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
    }
}

