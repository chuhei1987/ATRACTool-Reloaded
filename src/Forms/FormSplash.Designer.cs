﻿namespace ATRACTool_Reloaded
{
    partial class FormSplash
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
            this.label_log = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_log
            // 
            this.label_log.AutoEllipsis = true;
            this.label_log.Location = new System.Drawing.Point(13, 130);
            this.label_log.Name = "label_log";
            this.label_log.Size = new System.Drawing.Size(273, 23);
            this.label_log.TabIndex = 0;
            this.label_log.Text = "Loading...";
            this.label_log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATRACTool_Reloaded.Properties.Resources.SIE;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(300, 160);
            this.ControlBox = false;
            this.Controls.Add(this.label_log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSplash";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading...";
            this.Load += new System.EventHandler(this.FormSplash_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label_log;
    }
}