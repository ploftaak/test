namespace Escaperoom
{
    partial class Scenario
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
            this.comboBoxScenario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSelecteerScenario = new System.Windows.Forms.Button();
            this.richTextBoxScenarioBeschrijving = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxScenario
            // 
            this.comboBoxScenario.FormattingEnabled = true;
            this.comboBoxScenario.Location = new System.Drawing.Point(9, 30);
            this.comboBoxScenario.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxScenario.Name = "comboBoxScenario";
            this.comboBoxScenario.Size = new System.Drawing.Size(290, 21);
            this.comboBoxScenario.TabIndex = 0;
            this.comboBoxScenario.SelectedIndexChanged += new System.EventHandler(this.ComboBoxScenario_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kies een scenario:";
            // 
            // buttonSelecteerScenario
            // 
            this.buttonSelecteerScenario.Location = new System.Drawing.Point(116, 312);
            this.buttonSelecteerScenario.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelecteerScenario.Name = "buttonSelecteerScenario";
            this.buttonSelecteerScenario.Size = new System.Drawing.Size(86, 54);
            this.buttonSelecteerScenario.TabIndex = 2;
            this.buttonSelecteerScenario.Text = "Selecteer";
            this.buttonSelecteerScenario.UseVisualStyleBackColor = true;
            this.buttonSelecteerScenario.Click += new System.EventHandler(this.ButtonSelecteerScenario_Click);
            // 
            // richTextBox1
            // 
            this.richTextBoxScenarioBeschrijving.Location = new System.Drawing.Point(9, 80);
            this.richTextBoxScenarioBeschrijving.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxScenarioBeschrijving.Name = "richTextBox1";
            this.richTextBoxScenarioBeschrijving.ReadOnly = true;
            this.richTextBoxScenarioBeschrijving.Size = new System.Drawing.Size(290, 218);
            this.richTextBoxScenarioBeschrijving.TabIndex = 3;
            this.richTextBoxScenarioBeschrijving.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Beschrijving:";
            // 
            // Scenario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 375);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxScenarioBeschrijving);
            this.Controls.Add(this.buttonSelecteerScenario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxScenario);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Scenario";
            this.Text = "Scenario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Scenario_FormClosed);
            this.Load += new System.EventHandler(this.Scenario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxScenario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSelecteerScenario;
        private System.Windows.Forms.RichTextBox richTextBoxScenarioBeschrijving;
        private System.Windows.Forms.Label label2;
    }
}

