namespace Hybrid_H5F_Tool
{
    partial class Form_FPS
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
            this.FpsInput = new System.Windows.Forms.NumericUpDown();
            this.FpsTrackBar = new System.Windows.Forms.TrackBar();
            this.FpsDefault = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FpsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FpsTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // FpsInput
            // 
            this.FpsInput.DecimalPlaces = 2;
            this.FpsInput.Location = new System.Drawing.Point(6, 6);
            this.FpsInput.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.FpsInput.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.FpsInput.Name = "FpsInput";
            this.FpsInput.Size = new System.Drawing.Size(128, 20);
            this.FpsInput.TabIndex = 9;
            this.FpsInput.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.FpsInput.ValueChanged += new System.EventHandler(this.FpsInput_ValueChanged);
            // 
            // FpsTrackBar
            // 
            this.FpsTrackBar.Location = new System.Drawing.Point(-2, 28);
            this.FpsTrackBar.Maximum = 300;
            this.FpsTrackBar.Minimum = 30;
            this.FpsTrackBar.Name = "FpsTrackBar";
            this.FpsTrackBar.Size = new System.Drawing.Size(280, 45);
            this.FpsTrackBar.TabIndex = 13;
            this.FpsTrackBar.Value = 60;
            this.FpsTrackBar.ValueChanged += new System.EventHandler(this.FpsTrackBar_Scroll);
            // 
            // FpsDefault
            // 
            this.FpsDefault.Location = new System.Drawing.Point(142, 6);
            this.FpsDefault.Name = "FpsDefault";
            this.FpsDefault.Size = new System.Drawing.Size(130, 20);
            this.FpsDefault.TabIndex = 12;
            this.FpsDefault.Text = "Default";
            this.FpsDefault.UseVisualStyleBackColor = true;
            this.FpsDefault.Click += new System.EventHandler(this.FpsDefault_Click);
            // 
            // Form_FPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 61);
            this.Controls.Add(this.FpsTrackBar);
            this.Controls.Add(this.FpsDefault);
            this.Controls.Add(this.FpsInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_FPS";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Frames per Second Cap";
            this.Load += new System.EventHandler(this.Form_FPS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FpsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FpsTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown FpsInput;
        private System.Windows.Forms.TrackBar FpsTrackBar;
        private System.Windows.Forms.Button FpsDefault;
    }
}