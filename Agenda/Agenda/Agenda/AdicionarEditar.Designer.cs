namespace Agenda
{
    partial class AdicionarEditar
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.trackBarImportance = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.labelImportance = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarImportance)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(53, 8);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(318, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(15, 56);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(356, 109);
            this.textBoxDescription.TabIndex = 2;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição";
            // 
            // comboBoxState
            // 
            this.comboBoxState.Items.AddRange(new object[] {
            "Fazer",
            "Fazendo",
            "Feito"});
            this.comboBoxState.Location = new System.Drawing.Point(13, 192);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(121, 21);
            this.comboBoxState.TabIndex = 4;
            this.comboBoxState.Text = "Fazer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estado";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(405, 54);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 51);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Salvar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(405, 123);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(75, 54);
            this.buttonClean.TabIndex = 7;
            this.buttonClean.Text = "Limpar";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // trackBarImportance
            // 
            this.trackBarImportance.Location = new System.Drawing.Point(174, 197);
            this.trackBarImportance.Maximum = 5;
            this.trackBarImportance.Name = "trackBarImportance";
            this.trackBarImportance.Size = new System.Drawing.Size(159, 45);
            this.trackBarImportance.TabIndex = 8;
            this.trackBarImportance.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Importância";
            // 
            // labelImportance
            // 
            this.labelImportance.AutoSize = true;
            this.labelImportance.Location = new System.Drawing.Point(339, 200);
            this.labelImportance.Name = "labelImportance";
            this.labelImportance.Size = new System.Drawing.Size(13, 13);
            this.labelImportance.TabIndex = 10;
            this.labelImportance.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelImportance);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxDescription);
            this.panel1.Controls.Add(this.trackBarImportance);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxState);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 236);
            this.panel1.TabIndex = 11;
            // 
            // AdicionarEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 254);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.buttonSave);
            this.Name = "AdicionarEditar";
            this.Text = "AdicionarEditar";
            this.Load += new System.EventHandler(this.AdicionarEditar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarImportance)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.TrackBar trackBarImportance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelImportance;
        private System.Windows.Forms.Panel panel1;
    }
}