using System.Drawing;
using System.Windows.Forms;

namespace Multithreads
{
    partial class SchedulerStrongForm : Form 
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
            this.textBoxPossibility = new System.Windows.Forms.TextBox();
            this.timer1MSec = new System.Windows.Forms.Timer(this.components);
            this.timer10Sec = new System.Windows.Forms.Timer(this.components);
            this.timer1Sec = new System.Windows.Forms.Timer(this.components);
            this.listQueue1 = new System.Windows.Forms.ListView();
            this.columnHeaderQueue11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQueue12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQueue13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonMainPage = new System.Windows.Forms.Button();
            this.listQueue2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listQueue3 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listQueue4 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listQueue5 = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listPossibility = new System.Windows.Forms.ListView();
            this.columnHeaderPossibility1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPossibility2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPossibility3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPossibility4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxComplexity = new System.Windows.Forms.TextBox();
            this.textBoxQueue1 = new System.Windows.Forms.TextBox();
            this.textBoxQueue2 = new System.Windows.Forms.TextBox();
            this.textBoxQueue3 = new System.Windows.Forms.TextBox();
            this.textBoxQueue4 = new System.Windows.Forms.TextBox();
            this.textBoxQueue5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lESE = new System.Windows.Forms.Label();
            this.lESEquoted = new System.Windows.Forms.Label();
            this.lTasksNumber = new System.Windows.Forms.Label();
            this.lOperationsCompleted = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPossibility
            // 
            this.textBoxPossibility.Location = new System.Drawing.Point(666, 15);
            this.textBoxPossibility.Name = "textBoxPossibility";
            this.textBoxPossibility.Size = new System.Drawing.Size(52, 22);
            this.textBoxPossibility.TabIndex = 48;
            this.textBoxPossibility.Text = "1";
            this.textBoxPossibility.TextChanged += new System.EventHandler(this.textBoxPossibility_TextChanged);
            // 
            // timer1MSec
            // 
            this.timer1MSec.Interval = 50;
            this.timer1MSec.Tick += new System.EventHandler(this.timerTick);
            // 
            // timer10Sec
            // 
            this.timer10Sec.Interval = 10000;
            this.timer10Sec.Tick += new System.EventHandler(this.buttonStopClick);
            // 
            // timer1Sec
            // 
            this.timer1Sec.Interval = 1000;
            this.timer1Sec.Tick += new System.EventHandler(this.timerTick1Sec);
            // 
            // listQueue1
            // 
            this.listQueue1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderQueue11,
            this.columnHeaderQueue12,
            this.columnHeaderQueue13});
            this.listQueue1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listQueue1.GridLines = true;
            this.listQueue1.HideSelection = false;
            this.listQueue1.Location = new System.Drawing.Point(12, 196);
            this.listQueue1.Name = "listQueue1";
            this.listQueue1.Size = new System.Drawing.Size(423, 155);
            this.listQueue1.TabIndex = 2;
            this.listQueue1.UseCompatibleStateImageBehavior = false;
            this.listQueue1.View = System.Windows.Forms.View.Details;
            this.listQueue1.SelectedIndexChanged += new System.EventHandler(this.listQueue1_SelectedIndexChanged);
            // 
            // columnHeaderQueue11
            // 
            this.columnHeaderQueue11.Text = "CAPABLE UNITS";
            this.columnHeaderQueue11.Width = 91;
            // 
            // columnHeaderQueue12
            // 
            this.columnHeaderQueue12.Text = "COMPLEXITY";
            this.columnHeaderQueue12.Width = 91;
            // 
            // columnHeaderQueue13
            // 
            this.columnHeaderQueue13.Text = "UNIT WORKLOAD";
            this.columnHeaderQueue13.Width = 91;
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timer.ForeColor = System.Drawing.Color.Black;
            this.timer.Location = new System.Drawing.Point(941, 369);
            this.timer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(350, 52);
            this.timer.TabIndex = 0;
            this.timer.Text = "Seconds left: 10";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.buttonStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Location = new System.Drawing.Point(24, 21);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(131, 33);
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
            this.buttonStop.Location = new System.Drawing.Point(161, 21);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(131, 33);
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
            this.buttonClear.Location = new System.Drawing.Point(298, 21);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(131, 33);
            this.buttonClear.TabIndex = 0;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClearClick);
            // 
            // buttonMainPage
            // 
            this.buttonMainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.buttonMainPage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.buttonMainPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMainPage.Location = new System.Drawing.Point(298, 69);
            this.buttonMainPage.Name = "buttonMainPage";
            this.buttonMainPage.Size = new System.Drawing.Size(131, 33);
            this.buttonMainPage.TabIndex = 1;
            this.buttonMainPage.Text = "<< MAIN PAGE";
            this.buttonMainPage.UseVisualStyleBackColor = false;
            this.buttonMainPage.Click += new System.EventHandler(this.buttonMainPageClick);
            // 
            // listQueue2
            // 
            this.listQueue2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listQueue2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listQueue2.GridLines = true;
            this.listQueue2.HideSelection = false;
            this.listQueue2.Location = new System.Drawing.Point(477, 240);
            this.listQueue2.Name = "listQueue2";
            this.listQueue2.Size = new System.Drawing.Size(423, 137);
            this.listQueue2.TabIndex = 3;
            this.listQueue2.UseCompatibleStateImageBehavior = false;
            this.listQueue2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CAPABLE UNITS";
            this.columnHeader1.Width = 91;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "COMPLEXITY";
            this.columnHeader2.Width = 91;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "UNIT WORKLOAD";
            this.columnHeader3.Width = 91;
            // 
            // listQueue3
            // 
            this.listQueue3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listQueue3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listQueue3.GridLines = true;
            this.listQueue3.HideSelection = false;
            this.listQueue3.Location = new System.Drawing.Point(12, 438);
            this.listQueue3.Name = "listQueue3";
            this.listQueue3.Size = new System.Drawing.Size(423, 152);
            this.listQueue3.TabIndex = 4;
            this.listQueue3.UseCompatibleStateImageBehavior = false;
            this.listQueue3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "CAPABLE UNITS";
            this.columnHeader4.Width = 91;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "COMPLEXITY";
            this.columnHeader5.Width = 91;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "UNIT WORKLOAD";
            this.columnHeader6.Width = 91;
            // 
            // listQueue4
            // 
            this.listQueue4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listQueue4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listQueue4.GridLines = true;
            this.listQueue4.HideSelection = false;
            this.listQueue4.Location = new System.Drawing.Point(477, 438);
            this.listQueue4.Name = "listQueue4";
            this.listQueue4.Size = new System.Drawing.Size(423, 152);
            this.listQueue4.TabIndex = 5;
            this.listQueue4.UseCompatibleStateImageBehavior = false;
            this.listQueue4.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "CAPABLE UNITS";
            this.columnHeader7.Width = 91;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "COMPLEXITY";
            this.columnHeader8.Width = 91;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "UNIT WORKLOAD";
            this.columnHeader9.Width = 91;
            // 
            // listQueue5
            // 
            this.listQueue5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listQueue5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listQueue5.GridLines = true;
            this.listQueue5.HideSelection = false;
            this.listQueue5.Location = new System.Drawing.Point(942, 196);
            this.listQueue5.Name = "listQueue5";
            this.listQueue5.Size = new System.Drawing.Size(423, 155);
            this.listQueue5.TabIndex = 6;
            this.listQueue5.UseCompatibleStateImageBehavior = false;
            this.listQueue5.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "CAPABLE UNITS";
            this.columnHeader10.Width = 91;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "COMPLEXITY";
            this.columnHeader11.Width = 91;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "UNIT WORKLOAD";
            this.columnHeader12.Width = 91;
            // 
            // listPossibility
            // 
            this.listPossibility.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPossibility1,
            this.columnHeaderPossibility2,
            this.columnHeaderPossibility3,
            this.columnHeaderPossibility4});
            this.listPossibility.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPossibility.GridLines = true;
            this.listPossibility.HideSelection = false;
            this.listPossibility.Location = new System.Drawing.Point(466, 47);
            this.listPossibility.Name = "listPossibility";
            this.listPossibility.Size = new System.Drawing.Size(599, 137);
            this.listPossibility.TabIndex = 7;
            this.listPossibility.UseCompatibleStateImageBehavior = false;
            this.listPossibility.View = System.Windows.Forms.View.Details;
            this.listPossibility.SelectedIndexChanged += new System.EventHandler(this.listPossibility_SelectedIndexChanged);
            // 
            // columnHeaderPossibility1
            // 
            this.columnHeaderPossibility1.Text = "POSSIBILITY";
            this.columnHeaderPossibility1.Width = 100;
            // 
            // columnHeaderPossibility2
            // 
            this.columnHeaderPossibility2.Text = "GENERATED";
            this.columnHeaderPossibility2.Width = 91;
            // 
            // columnHeaderPossibility3
            // 
            this.columnHeaderPossibility3.Text = "CAPABLE UNITS";
            this.columnHeaderPossibility3.Width = 125;
            // 
            // columnHeaderPossibility4
            // 
            this.columnHeaderPossibility4.Text = "COMPLEXITY";
            this.columnHeaderPossibility4.Width = 100;
            // 
            // textBoxComplexity
            // 
            this.textBoxComplexity.Location = new System.Drawing.Point(914, 16);
            this.textBoxComplexity.Name = "textBoxComplexity";
            this.textBoxComplexity.Size = new System.Drawing.Size(52, 22);
            this.textBoxComplexity.TabIndex = 49;
            // 
            // textBoxQueue1
            // 
            this.textBoxQueue1.Location = new System.Drawing.Point(231, 162);
            this.textBoxQueue1.Name = "textBoxQueue1";
            this.textBoxQueue1.Size = new System.Drawing.Size(52, 22);
            this.textBoxQueue1.TabIndex = 50;
            // 
            // textBoxQueue2
            // 
            this.textBoxQueue2.Location = new System.Drawing.Point(848, 208);
            this.textBoxQueue2.Name = "textBoxQueue2";
            this.textBoxQueue2.Size = new System.Drawing.Size(52, 22);
            this.textBoxQueue2.TabIndex = 51;
            // 
            // textBoxQueue3
            // 
            this.textBoxQueue3.Location = new System.Drawing.Point(1266, 150);
            this.textBoxQueue3.Name = "textBoxQueue3";
            this.textBoxQueue3.Size = new System.Drawing.Size(52, 22);
            this.textBoxQueue3.TabIndex = 52;
            // 
            // textBoxQueue4
            // 
            this.textBoxQueue4.Location = new System.Drawing.Point(231, 399);
            this.textBoxQueue4.Name = "textBoxQueue4";
            this.textBoxQueue4.Size = new System.Drawing.Size(52, 22);
            this.textBoxQueue4.TabIndex = 53;
            // 
            // textBoxQueue5
            // 
            this.textBoxQueue5.Location = new System.Drawing.Point(777, 395);
            this.textBoxQueue5.Name = "textBoxQueue5";
            this.textBoxQueue5.Size = new System.Drawing.Size(52, 22);
            this.textBoxQueue5.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 369);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 29);
            this.label4.TabIndex = 55;
            this.label4.Text = "PROCESSOR #4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 56;
            this.label1.Text = "PROCESSOR #1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(472, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 29);
            this.label2.TabIndex = 57;
            this.label2.Text = "PROCESSOR #2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1162, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 29);
            this.label3.TabIndex = 58;
            this.label3.Text = "PROCESSOR #3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(472, 392);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 29);
            this.label5.TabIndex = 59;
            this.label5.Text = "PROCESSOR #5";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(749, 16);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 18);
            this.label12.TabIndex = 60;
            this.label12.Text = "INPUT COMPLEXITY";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(505, 17);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 18);
            this.label11.TabIndex = 61;
            this.label11.Text = "INPUT POSSIBILITY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 163);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 18);
            this.label7.TabIndex = 62;
            this.label7.Text = "PERFORMANCE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(704, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 18);
            this.label6.TabIndex = 63;
            this.label6.Text = "PERFORMANCE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1128, 154);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 18);
            this.label8.TabIndex = 64;
            this.label8.Text = "PERFORMANCE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(622, 399);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 18);
            this.label9.TabIndex = 65;
            this.label9.Text = "PERFORMANCE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(75, 403);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 18);
            this.label10.TabIndex = 66;
            this.label10.Text = "PERFORMANCE";
            // 
            // lESE
            // 
            this.lESE.AutoSize = true;
            this.lESE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lESE.ForeColor = System.Drawing.Color.Black;
            this.lESE.Location = new System.Drawing.Point(933, 428);
            this.lESE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lESE.Name = "lESE";
            this.lESE.Size = new System.Drawing.Size(0, 31);
            this.lESE.TabIndex = 50;
            // 
            // lESEquoted
            // 
            this.lESEquoted.AutoSize = true;
            this.lESEquoted.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lESEquoted.ForeColor = System.Drawing.Color.Black;
            this.lESEquoted.Location = new System.Drawing.Point(933, 463);
            this.lESEquoted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lESEquoted.Name = "lESEquoted";
            this.lESEquoted.Size = new System.Drawing.Size(0, 31);
            this.lESEquoted.TabIndex = 54;
            // 
            // lTasksNumber
            // 
            this.lTasksNumber.AutoSize = true;
            this.lTasksNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTasksNumber.ForeColor = System.Drawing.Color.Black;
            this.lTasksNumber.Location = new System.Drawing.Point(933, 498);
            this.lTasksNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTasksNumber.Name = "lTasksNumber";
            this.lTasksNumber.Size = new System.Drawing.Size(0, 31);
            this.lTasksNumber.TabIndex = 53;
            // 
            // lOperationsCompleted
            // 
            this.lOperationsCompleted.AutoSize = true;
            this.lOperationsCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOperationsCompleted.ForeColor = System.Drawing.Color.Black;
            this.lOperationsCompleted.Location = new System.Drawing.Point(933, 533);
            this.lOperationsCompleted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lOperationsCompleted.Name = "lOperationsCompleted";
            this.lOperationsCompleted.Size = new System.Drawing.Size(0, 31);
            this.lOperationsCompleted.TabIndex = 59;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 69);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(211, 40);
            this.label13.TabIndex = 67;
            this.label13.Text = "Created by Dmytro Rozhko\nKV-81";
            // 
            // SchedulerStrongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 635);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxQueue5);
            this.Controls.Add(this.textBoxQueue4);
            this.Controls.Add(this.textBoxQueue3);
            this.Controls.Add(this.textBoxQueue2);
            this.Controls.Add(this.textBoxQueue1);
            this.Controls.Add(this.textBoxComplexity);
            this.Controls.Add(this.listPossibility);
            this.Controls.Add(this.listQueue5);
            this.Controls.Add(this.listQueue4);
            this.Controls.Add(this.listQueue3);
            this.Controls.Add(this.listQueue2);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonMainPage);
            this.Controls.Add(this.listQueue1);
            this.Controls.Add(this.textBoxPossibility);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.lESE);
            this.Controls.Add(this.lESEquoted);
            this.Controls.Add(this.lTasksNumber);
            this.Controls.Add(this.lOperationsCompleted);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SchedulerStrongForm";
            this.Text = "SchedulerStrong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonStart;
        private Button buttonStop;
        private Button buttonClear;
        private Button buttonMainPage;

        private Timer timer1MSec;
        private Timer timer10Sec;
        private Timer timer1Sec;

        private ListView listQueue1;

        private ColumnHeader columnHeaderQueue11;
        private ColumnHeader columnHeaderQueue12;
        private ColumnHeader columnHeaderQueue13;

        private TextBox textBoxPossibility;
        private Label timer;
        private ListView listQueue2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListView listQueue3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ListView listQueue4;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ListView listQueue5;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ListView listPossibility;
        private ColumnHeader columnHeaderPossibility1;
        private ColumnHeader columnHeaderPossibility2;
        private ColumnHeader columnHeaderPossibility3;
        private ColumnHeader columnHeaderPossibility4;
        private TextBox textBoxComplexity;
        private TextBox textBoxQueue1;
        private TextBox textBoxQueue2;
        private TextBox textBoxQueue3;
        private TextBox textBoxQueue4;
        private TextBox textBoxQueue5;
        private Label lESE;
        private Label lESEquoted;
        private Label lTasksNumber;
        private Label lOperationsCompleted;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label12;
        private Label label11;
        private Label label7;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label13;
    }
}