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
            this.comboBoxScenarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSelecteerScenario = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxScenarios
            // 
            this.comboBoxScenarios.FormattingEnabled = true;
            this.comboBoxScenarios.Location = new System.Drawing.Point(9, 30);
            this.comboBoxScenarios.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxScenarios.Name = "comboBoxScenarios";
            this.comboBoxScenarios.Size = new System.Drawing.Size(290, 21);
            this.comboBoxScenarios.TabIndex = 0;
            this.comboBoxScenarios.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.richTextBox1.Location = new System.Drawing.Point(9, 80);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(290, 218);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
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
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonSelecteerScenario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxScenarios);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Scenario";
            this.Text = "Scenario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Scenario_FormClosed);
            this.Load += new System.EventHandler(this.Scenario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxScenarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSelecteerScenario;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
    }
}

