namespace OregonCardGameWindowsApp
{
    partial class RulesScreen
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
            this.buttonToStart = new System.Windows.Forms.Button();
            this.textBoxRules = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonToStart
            // 
            this.buttonToStart.AutoSize = true;
            this.buttonToStart.Location = new System.Drawing.Point(713, 297);
            this.buttonToStart.Name = "buttonToStart";
            this.buttonToStart.Size = new System.Drawing.Size(83, 25);
            this.buttonToStart.TabIndex = 0;
            this.buttonToStart.Text = "Back to Start";
            this.buttonToStart.UseVisualStyleBackColor = true;
            this.buttonToStart.Click += new System.EventHandler(this.buttonToStart_Click);
            // 
            // textBoxRules
            // 
            this.textBoxRules.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxRules.Location = new System.Drawing.Point(0, 0);
            this.textBoxRules.Multiline = true;
            this.textBoxRules.Name = "textBoxRules";
            this.textBoxRules.PlaceholderText = "Rules go here.";
            this.textBoxRules.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRules.Size = new System.Drawing.Size(800, 291);
            this.textBoxRules.TabIndex = 1;
            // 
            // RulesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 332);
            this.Controls.Add(this.textBoxRules);
            this.Controls.Add(this.buttonToStart);
            this.Name = "RulesScreen";
            this.Text = "Oregon Solitaire Rules";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonToStart;
        private TextBox textBoxRules;
    }
}