namespace Hybrid_H5F_Tool
{
    partial class Form_RES
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
            this.ResTrackBarHeight = new System.Windows.Forms.TrackBar();
            this.ResInputHeight = new System.Windows.Forms.NumericUpDown();
            this.ResTrackBarWidth = new System.Windows.Forms.TrackBar();
            this.ResDefault = new System.Windows.Forms.Button();
            this.ResInputWidth = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ResTrackBarHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResInputHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResTrackBarWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResInputWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // ResTrackBarHeight
            // 
            this.ResTrackBarHeight.Location = new System.Drawing.Point(-2, 59);
            this.ResTrackBarHeight.Maximum = 4320;
            this.ResTrackBarHeight.Minimum = 480;
            this.ResTrackBarHeight.Name = "ResTrackBarHeight";
            this.ResTrackBarHeight.Size = new System.Drawing.Size(280, 45);
            this.ResTrackBarHeight.TabIndex = 13;
            this.ResTrackBarHeight.Value = 1080;
            this.ResTrackBarHeight.ValueChanged += new System.EventHandler(this.ResTrackBarHeight_Scroll);
            // 
            // ResInputHeight
            // 
            this.ResInputHeight.Location = new System.Drawing.Point(92, 6);
            this.ResInputHeight.Maximum = new decimal(new int[] {
            4320,
            0,
            0,
            0});
            this.ResInputHeight.Minimum = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.ResInputHeight.Name = "ResInputHeight";
            this.ResInputHeight.Size = new System.Drawing.Size(80, 20);
            this.ResInputHeight.TabIndex = 10;
            this.ResInputHeight.Value = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.ResInputHeight.ValueChanged += new System.EventHandler(this.ResInputHeight_ValueChanged);
            // 
            // ResTrackBarWidth
            // 
            this.ResTrackBarWidth.Location = new System.Drawing.Point(-2, 28);
            this.ResTrackBarWidth.Maximum = 7680;
            this.ResTrackBarWidth.Minimum = 840;
            this.ResTrackBarWidth.Name = "ResTrackBarWidth";
            this.ResTrackBarWidth.Size = new System.Drawing.Size(280, 45);
            this.ResTrackBarWidth.TabIndex = 9;
            this.ResTrackBarWidth.Value = 1920;
            this.ResTrackBarWidth.ValueChanged += new System.EventHandler(this.ResTrackBarWidth_Scroll);
            // 
            // ResDefault
            // 
            this.ResDefault.Location = new System.Drawing.Point(178, 6);
            this.ResDefault.Name = "ResDefault";
            this.ResDefault.Size = new System.Drawing.Size(89, 20);
            this.ResDefault.TabIndex = 8;
            this.ResDefault.Text = "Default";
            this.ResDefault.UseVisualStyleBackColor = true;
            this.ResDefault.Click += new System.EventHandler(this.ResDefault_Click);
            // 
            // ResInputWidth
            // 
            this.ResInputWidth.Location = new System.Drawing.Point(6, 6);
            this.ResInputWidth.Maximum = new decimal(new int[] {
            7680,
            0,
            0,
            0});
            this.ResInputWidth.Minimum = new decimal(new int[] {
            840,
            0,
            0,
            0});
            this.ResInputWidth.Name = "ResInputWidth";
            this.ResInputWidth.Size = new System.Drawing.Size(80, 20);
            this.ResInputWidth.TabIndex = 7;
            this.ResInputWidth.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.ResInputWidth.ValueChanged += new System.EventHandler(this.ResInputWidth_ValueChanged);
            // 
            // Form_RES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 91);
            this.Controls.Add(this.ResTrackBarHeight);
            this.Controls.Add(this.ResInputHeight);
            this.Controls.Add(this.ResTrackBarWidth);
            this.Controls.Add(this.ResDefault);
            this.Controls.Add(this.ResInputWidth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_RES";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resolution";
            this.Load += new System.EventHandler(this.Form_RES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResTrackBarHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResInputHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResTrackBarWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResInputWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar ResTrackBarHeight;
        private System.Windows.Forms.NumericUpDown ResInputHeight;
        private System.Windows.Forms.TrackBar ResTrackBarWidth;
        private System.Windows.Forms.Button ResDefault;
        private System.Windows.Forms.NumericUpDown ResInputWidth;
    }
}