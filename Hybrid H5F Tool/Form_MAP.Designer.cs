namespace Hybrid_H5F_Tool
{
    partial class Form_MAP
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
            this.TutorialMapChangerChange = new System.Windows.Forms.Button();
            this.TutorialMapChangerMaps = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TutorialMapChangerChange
            // 
            this.TutorialMapChangerChange.Location = new System.Drawing.Point(182, 6);
            this.TutorialMapChangerChange.Name = "TutorialMapChangerChange";
            this.TutorialMapChangerChange.Size = new System.Drawing.Size(90, 21);
            this.TutorialMapChangerChange.TabIndex = 3;
            this.TutorialMapChangerChange.Text = "Change Map";
            this.TutorialMapChangerChange.UseVisualStyleBackColor = true;
            this.TutorialMapChangerChange.Click += new System.EventHandler(this.TutorialMapChangerChange_Click);
            // 
            // TutorialMapChangerMaps
            // 
            this.TutorialMapChangerMaps.FormattingEnabled = true;
            this.TutorialMapChangerMaps.Location = new System.Drawing.Point(6, 6);
            this.TutorialMapChangerMaps.Name = "TutorialMapChangerMaps";
            this.TutorialMapChangerMaps.Size = new System.Drawing.Size(165, 21);
            this.TutorialMapChangerMaps.TabIndex = 2;
            // 
            // Form_MAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 40);
            this.Controls.Add(this.TutorialMapChangerChange);
            this.Controls.Add(this.TutorialMapChangerMaps);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_MAP";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutorial Map";
            this.Load += new System.EventHandler(this.Form_MAP_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TutorialMapChangerChange;
        private System.Windows.Forms.ComboBox TutorialMapChangerMaps;
    }
}