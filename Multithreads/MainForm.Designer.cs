using System.Drawing;
using System.Windows.Forms;

namespace lab1
{
    partial class MainForm : Form
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
            this.buttonTask1 = new System.Windows.Forms.Button();
            this.buttonTask2 = new System.Windows.Forms.Button();
            this.buttonTask3 = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.creators = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonTask1
            // 
            this.buttonTask1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonTask1.Location = new System.Drawing.Point(15, 15);
            this.buttonTask1.Name = "buttonTask1";
            this.buttonTask1.Size = new System.Drawing.Size(100, 40);
            this.buttonTask1.TabIndex = 0;
            this.buttonTask1.Text = "TASK #1";
            this.buttonTask1.Click += new System.EventHandler(this.task1Click);
            this.buttonTask1.BackColor = Color.FromArgb(0, 153, 0);
            this.buttonTask1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.buttonTask1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // 
            // buttonTask2
            // 
            this.buttonTask2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonTask2.Location = new System.Drawing.Point(15, 61);
            this.buttonTask2.Name = "buttonTask2";
            this.buttonTask2.Size = new System.Drawing.Size(100, 40);
            this.buttonTask2.TabIndex = 0;
            this.buttonTask2.Text = "TASK #2";
            this.buttonTask2.Click += new System.EventHandler(this.task2Click);
            this.buttonTask2.BackColor = Color.FromArgb(0, 153, 0);
            this.buttonTask2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.buttonTask2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // 
            // buttonTask3
            // 
            this.buttonTask3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonTask3.Location = new System.Drawing.Point(15, 107);
            this.buttonTask3.Name = "buttonTask3";
            this.buttonTask3.Size = new System.Drawing.Size(100, 40);
            this.buttonTask3.TabIndex = 0;
            this.buttonTask3.Text = "TASK #3";
            this.buttonTask3.Click += new System.EventHandler(this.task3Click);
            this.buttonTask3.BackColor = Color.FromArgb(0, 153, 0);
            this.buttonTask3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.buttonTask3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonClose.Location = new System.Drawing.Point(285, 117);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(81, 30);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "CLOSE";
            this.buttonClose.Click += new System.EventHandler(this.buttonCloseClick);
            this.buttonClose.BackColor = Color.FromArgb(230, 0, 0);
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // 
            // creators
            // 
            this.creators.Location = new System.Drawing.Point(161, 36);
            this.creators.Name = "creators";
            this.creators.Size = new System.Drawing.Size(157, 78);
            this.creators.TabIndex = 1;
            this.creators.Text = "Created by students:\nDmytro Rozhko,\n,\n";
            this.creators.Click += new System.EventHandler(this.creators_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 167);
            this.Controls.Add(this.buttonTask1);
            this.Controls.Add(this.buttonTask2);
            this.Controls.Add(this.buttonTask3);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.creators);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonTask1;
        private Button buttonTask2;
        private Button buttonTask3;
        private Button buttonClose;

        private Label creators;
    }
}