using System.Drawing;
using System.Windows.Forms;

namespace lab1
{
    partial class FormTask3 : Form
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
            this.components = new System.ComponentModel.Container();

            this.timer = new Timer(this.components);

            this.l = new Label();

            this.buttonStart = new Button();
            this.buttonStop = new Button();
            this.buttonClear = new Button();
            this.buttonMainPage = new Button();
            this.SuspendLayout();
            //
            // timer
            //
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timerTick);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.l.Location = new System.Drawing.Point(61, 63);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(479, 36);
            this.l.TabIndex = 0;
            this.l.Text = "Do you want to submit this project?";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.buttonStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Location = new System.Drawing.Point(12, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 33);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStartClick);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonStop.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Location = new System.Drawing.Point(102, 12);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 33);
            this.buttonStop.TabIndex = 0;
            this.buttonStop.Text = "STOP";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStopClick);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Location = new System.Drawing.Point(200, 12);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 33);
            this.buttonClear.TabIndex = 0;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClearClick);
            // 
            // buttonMainPage
            // 
            this.buttonMainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.buttonMainPage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.buttonMainPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMainPage.Location = new System.Drawing.Point(297, 12);
            this.buttonMainPage.Name = "buttonMainPage";
            this.buttonMainPage.Size = new System.Drawing.Size(131, 33);
            this.buttonMainPage.TabIndex = 1;
            this.buttonMainPage.Text = "<< MAIN PAGE";
            this.buttonMainPage.UseVisualStyleBackColor = false;
            this.buttonMainPage.Click += new System.EventHandler(this.buttonMainPageClick);
            // 
            // FormTask3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonMainPage);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTask3";
            this.Text = "LAB 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonStart;
        private Button buttonStop;
        private Button buttonClear;
        private Button buttonMainPage;

        private Timer timer;

        private TextBox textBoxQueue0;
        private TextBox textBoxQueue1;
        private TextBox textBoxQueue2;
        private TextBox textBoxQueue3;
        private TextBox textBoxQueue4;
        private Label l;
    }
}

