
namespace Multithreads
{
    partial class StartForm
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
            this.FIFOButton = new System.Windows.Forms.Button();
            this.SchedulerWeakButtom = new System.Windows.Forms.Button();
            this.SchedulerStrongButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FIFOButton
            // 
            this.FIFOButton.Location = new System.Drawing.Point(56, 12);
            this.FIFOButton.Name = "FIFOButton";
            this.FIFOButton.Size = new System.Drawing.Size(147, 48);
            this.FIFOButton.TabIndex = 0;
            this.FIFOButton.Text = "Fisrt in Last out";
            this.FIFOButton.UseVisualStyleBackColor = true;
            this.FIFOButton.Click += new System.EventHandler(this.FIFOButton_Click);
            // 
            // SchedulerWeakButtom
            // 
            this.SchedulerWeakButtom.Location = new System.Drawing.Point(56, 60);
            this.SchedulerWeakButtom.Name = "SchedulerWeakButtom";
            this.SchedulerWeakButtom.Size = new System.Drawing.Size(147, 48);
            this.SchedulerWeakButtom.TabIndex = 1;
            this.SchedulerWeakButtom.Text = "SchedulerWeak";
            this.SchedulerWeakButtom.UseVisualStyleBackColor = true;
            this.SchedulerWeakButtom.Click += new System.EventHandler(this.SchedulerWeakButtom_Click);
            // 
            // SchedulerStrongButton
            // 
            this.SchedulerStrongButton.Location = new System.Drawing.Point(56, 108);
            this.SchedulerStrongButton.Name = "SchedulerStrongButton";
            this.SchedulerStrongButton.Size = new System.Drawing.Size(147, 48);
            this.SchedulerStrongButton.TabIndex = 2;
            this.SchedulerStrongButton.Text = "SchedulerStrong";
            this.SchedulerStrongButton.UseVisualStyleBackColor = true;
            this.SchedulerStrongButton.Click += new System.EventHandler(this.SchedulerStrongButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 169);
            this.Controls.Add(this.SchedulerStrongButton);
            this.Controls.Add(this.SchedulerWeakButtom);
            this.Controls.Add(this.FIFOButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FIFOButton;
        private System.Windows.Forms.Button SchedulerWeakButtom;
        private System.Windows.Forms.Button SchedulerStrongButton;
    }
}