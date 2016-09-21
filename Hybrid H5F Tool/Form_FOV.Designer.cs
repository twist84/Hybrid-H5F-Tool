namespace Hybrid_H5F_Tool
{
    partial class Form_FOV
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
            this.FovInput = new System.Windows.Forms.NumericUpDown();
            this.FovTrackBar = new System.Windows.Forms.TrackBar();
            this.FovDefault = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FovInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FovTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // FovInput
            // 
            this.FovInput.DecimalPlaces = 2;
            this.FovInput.Location = new System.Drawing.Point(6, 6);
            this.FovInput.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.FovInput.Minimum = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.FovInput.Name = "FovInput";
            this.FovInput.Size = new System.Drawing.Size(128, 20);
            this.FovInput.TabIndex = 9;
            this.FovInput.Value = new decimal(new int[] {
            78,
            0,
            0,
            0});
            this.FovInput.ValueChanged += new System.EventHandler(this.FovInput_ValueChanged);
            // 
            // FovTrackBar
            // 
            this.FovTrackBar.Location = new System.Drawing.Point(-2, 28);
            this.FovTrackBar.Maximum = 150;
            this.FovTrackBar.Minimum = 65;
            this.FovTrackBar.Name = "FovTrackBar";
            this.FovTrackBar.Size = new System.Drawing.Size(280, 45);
            this.FovTrackBar.TabIndex = 13;
            this.FovTrackBar.Value = 78;
            this.FovTrackBar.ValueChanged += new System.EventHandler(this.FovTrackBar_Scroll);
            // 
            // FovDefault
            // 
            this.FovDefault.Location = new System.Drawing.Point(142, 6);
            this.FovDefault.Name = "FovDefault";
            this.FovDefault.Size = new System.Drawing.Size(130, 20);
            this.FovDefault.TabIndex = 12;
            this.FovDefault.Text = "Default";
            this.FovDefault.UseVisualStyleBackColor = true;
            this.FovDefault.Click += new System.EventHandler(this.FovDefault_Click);
            // 
            // Form_FOV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 61);
            this.Controls.Add(this.FovTrackBar);
            this.Controls.Add(this.FovDefault);
            this.Controls.Add(this.FovInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_FOV";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Field of View";
            this.Load += new System.EventHandler(this.Form_FOV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FovInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FovTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar FovTrackBar;
        private System.Windows.Forms.Button FovDefault;
        private System.Windows.Forms.NumericUpDown FovInput;
    }
}