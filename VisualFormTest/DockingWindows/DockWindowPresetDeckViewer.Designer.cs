﻿namespace VisualFormTest.DockingWindows
{
    partial class DockWindowPresetDeckViewer
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
            this.presetDeckViewer1 = new VisualFormTest.UserControls.PresetDeckViewer();
            this.SuspendLayout();
            // 
            // presetDeckViewer1
            // 
            this.presetDeckViewer1.IsShown = false;
            this.presetDeckViewer1.Location = new System.Drawing.Point(0, 0);
            this.presetDeckViewer1.Name = "presetDeckViewer1";
            this.presetDeckViewer1.Size = new System.Drawing.Size(170, 150);
            this.presetDeckViewer1.TabIndex = 0;
            // 
            // DockWindowPresetDeckViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 163);
            this.Controls.Add(this.presetDeckViewer1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HideOnClose = true;
            this.Name = "DockWindowPresetDeckViewer";
            this.Text = "プリセット";
            this.DockStateChanged += new System.EventHandler(this.DockWindowPresetDeckViewer_DockStateChanged);
            this.ResumeLayout(false);

        }

        #endregion

        public UserControls.PresetDeckViewer presetDeckViewer1;

    }
}