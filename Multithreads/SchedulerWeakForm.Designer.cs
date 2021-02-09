
namespace Multithreads
{
    partial class SchedulerWeakForm
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
            this.Unit1Label = new System.Windows.Forms.Label();
            this.Unit2Label = new System.Windows.Forms.Label();
            this.Unit3Label = new System.Windows.Forms.Label();
            this.Unit4Label = new System.Windows.Forms.Label();
            this.Unit5Label = new System.Windows.Forms.Label();
            this.Unit1Box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Unit2Box = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Unit3Box = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Unit4Box = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Unit5Box = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProbabilityBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.TickTimer = new System.Windows.Forms.Timer(this.components);
            this.OneSecondTimer = new System.Windows.Forms.Timer(this.components);
            this.SecondsLeftlabel = new System.Windows.Forms.Label();
            this.TasksDoneLabel = new System.Windows.Forms.Label();
            this.OperationsDoneLabel = new System.Windows.Forms.Label();
            this.EfficiencyLabel = new System.Windows.Forms.Label();
            this.TasksListView = new System.Windows.Forms.ListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitListView1 = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitListView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitListView3 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitListView4 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitListView5 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Unit1Label
            // 
            this.Unit1Label.AutoSize = true;
            this.Unit1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Unit1Label.Location = new System.Drawing.Point(98, 31);
            this.Unit1Label.Name = "Unit1Label";
            this.Unit1Label.Size = new System.Drawing.Size(57, 24);
            this.Unit1Label.TabIndex = 5;
            this.Unit1Label.Text = "Unit1";
            this.Unit1Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Unit2Label
            // 
            this.Unit2Label.AutoSize = true;
            this.Unit2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Unit2Label.Location = new System.Drawing.Point(300, 31);
            this.Unit2Label.Name = "Unit2Label";
            this.Unit2Label.Size = new System.Drawing.Size(57, 24);
            this.Unit2Label.TabIndex = 6;
            this.Unit2Label.Text = "Unit2";
            // 
            // Unit3Label
            // 
            this.Unit3Label.AutoSize = true;
            this.Unit3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Unit3Label.Location = new System.Drawing.Point(495, 31);
            this.Unit3Label.Name = "Unit3Label";
            this.Unit3Label.Size = new System.Drawing.Size(57, 24);
            this.Unit3Label.TabIndex = 7;
            this.Unit3Label.Text = "Unit3";
            // 
            // Unit4Label
            // 
            this.Unit4Label.AutoSize = true;
            this.Unit4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Unit4Label.Location = new System.Drawing.Point(706, 31);
            this.Unit4Label.Name = "Unit4Label";
            this.Unit4Label.Size = new System.Drawing.Size(57, 24);
            this.Unit4Label.TabIndex = 8;
            this.Unit4Label.Text = "Unit4";
            // 
            // Unit5Label
            // 
            this.Unit5Label.AutoSize = true;
            this.Unit5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Unit5Label.Location = new System.Drawing.Point(917, 31);
            this.Unit5Label.Name = "Unit5Label";
            this.Unit5Label.Size = new System.Drawing.Size(57, 24);
            this.Unit5Label.TabIndex = 9;
            this.Unit5Label.Text = "Unit5";
            // 
            // Unit1Box
            // 
            this.Unit1Box.FormattingEnabled = true;
            this.Unit1Box.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Unit1Box.Location = new System.Drawing.Point(169, 396);
            this.Unit1Box.Name = "Unit1Box";
            this.Unit1Box.Size = new System.Drawing.Size(51, 21);
            this.Unit1Box.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Performance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(249, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Performance";
            // 
            // Unit2Box
            // 
            this.Unit2Box.FormattingEnabled = true;
            this.Unit2Box.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Unit2Box.Location = new System.Drawing.Point(372, 396);
            this.Unit2Box.Name = "Unit2Box";
            this.Unit2Box.Size = new System.Drawing.Size(51, 21);
            this.Unit2Box.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(453, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Performance";
            // 
            // Unit3Box
            // 
            this.Unit3Box.FormattingEnabled = true;
            this.Unit3Box.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Unit3Box.Location = new System.Drawing.Point(576, 396);
            this.Unit3Box.Name = "Unit3Box";
            this.Unit3Box.Size = new System.Drawing.Size(51, 21);
            this.Unit3Box.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(653, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Performance";
            // 
            // Unit4Box
            // 
            this.Unit4Box.FormattingEnabled = true;
            this.Unit4Box.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Unit4Box.Location = new System.Drawing.Point(776, 396);
            this.Unit4Box.Name = "Unit4Box";
            this.Unit4Box.Size = new System.Drawing.Size(51, 21);
            this.Unit4Box.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(858, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Performance";
            // 
            // Unit5Box
            // 
            this.Unit5Box.FormattingEnabled = true;
            this.Unit5Box.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Unit5Box.Location = new System.Drawing.Point(981, 396);
            this.Unit5Box.Name = "Unit5Box";
            this.Unit5Box.Size = new System.Drawing.Size(51, 21);
            this.Unit5Box.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(85, 770);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Generate probability";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ProbabilityBox
            // 
            this.ProbabilityBox.FormattingEnabled = true;
            this.ProbabilityBox.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.ProbabilityBox.Location = new System.Drawing.Point(317, 771);
            this.ProbabilityBox.Name = "ProbabilityBox";
            this.ProbabilityBox.Size = new System.Drawing.Size(51, 21);
            this.ProbabilityBox.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(530, 669);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 83);
            this.button1.TabIndex = 28;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopButton.Location = new System.Drawing.Point(739, 669);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(142, 83);
            this.StopButton.TabIndex = 29;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // TickTimer
            // 
            this.TickTimer.Interval = 1;
            this.TickTimer.Tick += new System.EventHandler(this.TickTimer_Tick);
            // 
            // OneSecondTimer
            // 
            this.OneSecondTimer.Interval = 1000;
            this.OneSecondTimer.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // SecondsLeftlabel
            // 
            this.SecondsLeftlabel.AutoSize = true;
            this.SecondsLeftlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondsLeftlabel.Location = new System.Drawing.Point(548, 606);
            this.SecondsLeftlabel.Name = "SecondsLeftlabel";
            this.SecondsLeftlabel.Size = new System.Drawing.Size(115, 20);
            this.SecondsLeftlabel.TabIndex = 30;
            this.SecondsLeftlabel.Text = "Seconds left:";
            // 
            // TasksDoneLabel
            // 
            this.TasksDoneLabel.AutoSize = true;
            this.TasksDoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TasksDoneLabel.Location = new System.Drawing.Point(548, 555);
            this.TasksDoneLabel.Name = "TasksDoneLabel";
            this.TasksDoneLabel.Size = new System.Drawing.Size(106, 20);
            this.TasksDoneLabel.TabIndex = 31;
            this.TasksDoneLabel.Text = "Tasks done:";
            // 
            // OperationsDoneLabel
            // 
            this.OperationsDoneLabel.AutoSize = true;
            this.OperationsDoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OperationsDoneLabel.Location = new System.Drawing.Point(548, 508);
            this.OperationsDoneLabel.Name = "OperationsDoneLabel";
            this.OperationsDoneLabel.Size = new System.Drawing.Size(147, 20);
            this.OperationsDoneLabel.TabIndex = 32;
            this.OperationsDoneLabel.Text = "Operations done:";
            // 
            // EfficiencyLabel
            // 
            this.EfficiencyLabel.AutoSize = true;
            this.EfficiencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EfficiencyLabel.Location = new System.Drawing.Point(548, 460);
            this.EfficiencyLabel.Name = "EfficiencyLabel";
            this.EfficiencyLabel.Size = new System.Drawing.Size(92, 20);
            this.EfficiencyLabel.TabIndex = 33;
            this.EfficiencyLabel.Text = "Efficiency:";
            // 
            // TasksListView
            // 
            this.TasksListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.TasksListView.BackColor = System.Drawing.SystemColors.Window;
            this.TasksListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TasksListView.CheckBoxes = true;
            this.TasksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader16,
            this.columnHeader17});
            this.TasksListView.Cursor = System.Windows.Forms.Cursors.Cross;
            this.TasksListView.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TasksListView.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TasksListView.GridLines = true;
            this.TasksListView.HideSelection = false;
            this.TasksListView.HoverSelection = true;
            this.TasksListView.Location = new System.Drawing.Point(50, 441);
            this.TasksListView.Name = "TasksListView";
            this.TasksListView.Size = new System.Drawing.Size(353, 311);
            this.TasksListView.TabIndex = 42;
            this.TasksListView.UseCompatibleStateImageBehavior = false;
            this.TasksListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "ID";
            this.columnHeader14.Width = 80;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Complexity";
            this.columnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader16.Width = 95;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Units able to handle";
            this.columnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader17.Width = 152;
            // 
            // unitListView1
            // 
            this.unitListView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.unitListView1.BackColor = System.Drawing.SystemColors.Window;
            this.unitListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unitListView1.CheckBoxes = true;
            this.unitListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
            this.unitListView1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.unitListView1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitListView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.unitListView1.GridLines = true;
            this.unitListView1.HideSelection = false;
            this.unitListView1.HoverSelection = true;
            this.unitListView1.Location = new System.Drawing.Point(50, 73);
            this.unitListView1.Name = "unitListView1";
            this.unitListView1.Size = new System.Drawing.Size(187, 311);
            this.unitListView1.TabIndex = 43;
            this.unitListView1.UseCompatibleStateImageBehavior = false;
            this.unitListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ID";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Complexity";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 95;
            // 
            // unitListView2
            // 
            this.unitListView2.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.unitListView2.BackColor = System.Drawing.SystemColors.Window;
            this.unitListView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unitListView2.CheckBoxes = true;
            this.unitListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.unitListView2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.unitListView2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitListView2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.unitListView2.GridLines = true;
            this.unitListView2.HideSelection = false;
            this.unitListView2.HoverSelection = true;
            this.unitListView2.Location = new System.Drawing.Point(253, 73);
            this.unitListView2.Name = "unitListView2";
            this.unitListView2.Size = new System.Drawing.Size(187, 311);
            this.unitListView2.TabIndex = 44;
            this.unitListView2.UseCompatibleStateImageBehavior = false;
            this.unitListView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Complexity";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 95;
            // 
            // unitListView3
            // 
            this.unitListView3.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.unitListView3.BackColor = System.Drawing.SystemColors.Window;
            this.unitListView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unitListView3.CheckBoxes = true;
            this.unitListView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.unitListView3.Cursor = System.Windows.Forms.Cursors.Cross;
            this.unitListView3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitListView3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.unitListView3.GridLines = true;
            this.unitListView3.HideSelection = false;
            this.unitListView3.HoverSelection = true;
            this.unitListView3.Location = new System.Drawing.Point(457, 73);
            this.unitListView3.Name = "unitListView3";
            this.unitListView3.Size = new System.Drawing.Size(187, 311);
            this.unitListView3.TabIndex = 45;
            this.unitListView3.UseCompatibleStateImageBehavior = false;
            this.unitListView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Complexity";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 95;
            // 
            // unitListView4
            // 
            this.unitListView4.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.unitListView4.BackColor = System.Drawing.SystemColors.Window;
            this.unitListView4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unitListView4.CheckBoxes = true;
            this.unitListView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.unitListView4.Cursor = System.Windows.Forms.Cursors.Cross;
            this.unitListView4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitListView4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.unitListView4.GridLines = true;
            this.unitListView4.HideSelection = false;
            this.unitListView4.HoverSelection = true;
            this.unitListView4.Location = new System.Drawing.Point(657, 73);
            this.unitListView4.Name = "unitListView4";
            this.unitListView4.Size = new System.Drawing.Size(187, 311);
            this.unitListView4.TabIndex = 46;
            this.unitListView4.UseCompatibleStateImageBehavior = false;
            this.unitListView4.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Complexity";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 95;
            // 
            // unitListView5
            // 
            this.unitListView5.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.unitListView5.BackColor = System.Drawing.SystemColors.Window;
            this.unitListView5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unitListView5.CheckBoxes = true;
            this.unitListView5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.unitListView5.Cursor = System.Windows.Forms.Cursors.Cross;
            this.unitListView5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitListView5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.unitListView5.GridLines = true;
            this.unitListView5.HideSelection = false;
            this.unitListView5.HoverSelection = true;
            this.unitListView5.Location = new System.Drawing.Point(862, 73);
            this.unitListView5.Name = "unitListView5";
            this.unitListView5.Size = new System.Drawing.Size(187, 311);
            this.unitListView5.TabIndex = 47;
            this.unitListView5.UseCompatibleStateImageBehavior = false;
            this.unitListView5.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Complexity";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 95;
            // 
            // SchedulerWeakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 814);
            this.Controls.Add(this.unitListView5);
            this.Controls.Add(this.unitListView4);
            this.Controls.Add(this.unitListView3);
            this.Controls.Add(this.unitListView2);
            this.Controls.Add(this.unitListView1);
            this.Controls.Add(this.TasksListView);
            this.Controls.Add(this.EfficiencyLabel);
            this.Controls.Add(this.OperationsDoneLabel);
            this.Controls.Add(this.TasksDoneLabel);
            this.Controls.Add(this.SecondsLeftlabel);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProbabilityBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Unit5Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Unit4Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Unit3Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Unit2Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Unit1Box);
            this.Controls.Add(this.Unit5Label);
            this.Controls.Add(this.Unit4Label);
            this.Controls.Add(this.Unit3Label);
            this.Controls.Add(this.Unit2Label);
            this.Controls.Add(this.Unit1Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SchedulerWeakForm";
            this.Text = "Scheduler Weak ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SchedulerWeakForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Unit1Label;
        private System.Windows.Forms.Label Unit2Label;
        private System.Windows.Forms.Label Unit3Label;
        private System.Windows.Forms.Label Unit4Label;
        private System.Windows.Forms.Label Unit5Label;
        private System.Windows.Forms.ComboBox Unit1Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Unit2Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Unit3Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Unit4Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Unit5Box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ProbabilityBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Timer TickTimer;
        private System.Windows.Forms.Timer OneSecondTimer;
        private System.Windows.Forms.Label SecondsLeftlabel;
        private System.Windows.Forms.Label TasksDoneLabel;
        private System.Windows.Forms.Label OperationsDoneLabel;
        private System.Windows.Forms.Label EfficiencyLabel;
        private System.Windows.Forms.ListView TasksListView;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ListView unitListView1;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ListView unitListView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView unitListView3;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView unitListView4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView unitListView5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}

