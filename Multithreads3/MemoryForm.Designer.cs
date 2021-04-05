
using System.Data;
using System.Windows.Forms;

namespace Multithreads3
{
    partial class MemoryForm
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
            this.startButton = new System.Windows.Forms.Button();
            this.buttonTact0 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxStrategy = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.errorMessega = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonTact1 = new System.Windows.Forms.Button();
            this.buttonTact2 = new System.Windows.Forms.Button();
            this.buttonTact3 = new System.Windows.Forms.Button();
            this.buttonTact4 = new System.Windows.Forms.Button();
            this.buttonTact5 = new System.Windows.Forms.Button();
            this.buttonTact6 = new System.Windows.Forms.Button();
            this.buttonTact7 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelChooseStrategy = new System.Windows.Forms.Label();
            this.ilabelInit = new System.Windows.Forms.Label();
            this.comboBoxRoutine = new System.Windows.Forms.ComboBox();
            this.labelRoutine = new System.Windows.Forms.Label();
            this.tableProcess = new System.Windows.Forms.DataGridView();
            this.columnProcess1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProcess2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startButton.Location = new System.Drawing.Point(637, 662);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(190, 86);
            this.startButton.TabIndex = 0;
            this.startButton.Text = " Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonTact0
            // 
            this.buttonTact0.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonTact0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTact0.Location = new System.Drawing.Point(171, 44);
            this.buttonTact0.Name = "buttonTact0";
            this.buttonTact0.Size = new System.Drawing.Size(78, 35);
            this.buttonTact0.TabIndex = 1;
            this.buttonTact0.Text = "X";
            this.buttonTact0.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(586, 437);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "Choose strategy";
            // 
            // comboBoxStrategy
            // 
            this.comboBoxStrategy.FormattingEnabled = true;
            this.comboBoxStrategy.Items.AddRange(new object[] {
            "Optimal strategy",
            "Allow latency strategy",
            "Greedy strategy"});
            this.comboBoxStrategy.Location = new System.Drawing.Point(745, 433);
            this.comboBoxStrategy.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxStrategy.Name = "comboBoxStrategy";
            this.comboBoxStrategy.Size = new System.Drawing.Size(145, 24);
            this.comboBoxStrategy.TabIndex = 62;
            this.comboBoxStrategy.Text = "Optimal strategy";
            this.comboBoxStrategy.SelectedIndexChanged += new System.EventHandler(this.comboBoxStrategy_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(369, 690);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 25);
            this.label11.TabIndex = 69;
            // 
            // errorMessega
            // 
            this.errorMessega.AutoSize = true;
            this.errorMessega.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorMessega.ForeColor = System.Drawing.Color.Red;
            this.errorMessega.Location = new System.Drawing.Point(244, 277);
            this.errorMessega.Name = "errorMessega";
            this.errorMessega.Size = new System.Drawing.Size(0, 29);
            this.errorMessega.TabIndex = 72;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(27, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(882, 220);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.buttonTact0, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonTact1, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonTact2, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttonTact3, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttonTact4, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonTact5, 6, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonTact6, 7, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttonTact7, 8, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBox3, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBox4, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox5, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox6, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox7, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox8, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox9, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox10, 5, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBox11, 6, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBox12, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox13, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox14, 7, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox15, 8, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox16, 8, 3);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label14, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label15, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label16, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label17, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label18, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label19, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.label20, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.label21, 8, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(21, 34);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(842, 164);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonTact1
            // 
            this.buttonTact1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonTact1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTact1.Location = new System.Drawing.Point(255, 85);
            this.buttonTact1.Name = "buttonTact1";
            this.buttonTact1.Size = new System.Drawing.Size(78, 35);
            this.buttonTact1.TabIndex = 2;
            this.buttonTact1.Text = "X";
            this.buttonTact1.UseVisualStyleBackColor = false;
            // 
            // buttonTact2
            // 
            this.buttonTact2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonTact2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTact2.Location = new System.Drawing.Point(339, 126);
            this.buttonTact2.Name = "buttonTact2";
            this.buttonTact2.Size = new System.Drawing.Size(78, 35);
            this.buttonTact2.TabIndex = 3;
            this.buttonTact2.Text = "X";
            this.buttonTact2.UseVisualStyleBackColor = false;
            // 
            // buttonTact3
            // 
            this.buttonTact3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonTact3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTact3.Location = new System.Drawing.Point(423, 126);
            this.buttonTact3.Name = "buttonTact3";
            this.buttonTact3.Size = new System.Drawing.Size(78, 35);
            this.buttonTact3.TabIndex = 4;
            this.buttonTact3.Text = "X";
            this.buttonTact3.UseVisualStyleBackColor = false;
            // 
            // buttonTact4
            // 
            this.buttonTact4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonTact4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTact4.Location = new System.Drawing.Point(507, 44);
            this.buttonTact4.Name = "buttonTact4";
            this.buttonTact4.Size = new System.Drawing.Size(78, 35);
            this.buttonTact4.TabIndex = 5;
            this.buttonTact4.Text = "X";
            this.buttonTact4.UseVisualStyleBackColor = false;
            // 
            // buttonTact5
            // 
            this.buttonTact5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonTact5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTact5.Location = new System.Drawing.Point(591, 85);
            this.buttonTact5.Name = "buttonTact5";
            this.buttonTact5.Size = new System.Drawing.Size(78, 35);
            this.buttonTact5.TabIndex = 6;
            this.buttonTact5.Text = "X";
            this.buttonTact5.UseVisualStyleBackColor = false;
            // 
            // buttonTact6
            // 
            this.buttonTact6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonTact6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTact6.Location = new System.Drawing.Point(675, 126);
            this.buttonTact6.Name = "buttonTact6";
            this.buttonTact6.Size = new System.Drawing.Size(78, 35);
            this.buttonTact6.TabIndex = 7;
            this.buttonTact6.Text = "X";
            this.buttonTact6.UseVisualStyleBackColor = false;
            // 
            // buttonTact7
            // 
            this.buttonTact7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonTact7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTact7.Location = new System.Drawing.Point(759, 44);
            this.buttonTact7.Name = "buttonTact7";
            this.buttonTact7.Size = new System.Drawing.Size(78, 35);
            this.buttonTact7.TabIndex = 8;
            this.buttonTact7.Text = "X";
            this.buttonTact7.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 85);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(78, 35);
            this.textBox1.TabIndex = 74;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(171, 126);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(78, 35);
            this.textBox2.TabIndex = 75;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(255, 126);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(78, 35);
            this.textBox3.TabIndex = 76;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(255, 44);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(78, 35);
            this.textBox4.TabIndex = 77;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(339, 44);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(78, 35);
            this.textBox5.TabIndex = 78;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(339, 85);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(78, 35);
            this.textBox6.TabIndex = 79;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(423, 44);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(78, 35);
            this.textBox7.TabIndex = 80;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(423, 85);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(78, 35);
            this.textBox8.TabIndex = 81;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(507, 85);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(78, 35);
            this.textBox9.TabIndex = 82;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(507, 126);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(78, 35);
            this.textBox10.TabIndex = 83;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(591, 126);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(78, 35);
            this.textBox11.TabIndex = 84;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(591, 44);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(78, 35);
            this.textBox12.TabIndex = 85;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(675, 44);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(78, 35);
            this.textBox13.TabIndex = 86;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label25, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label24, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label23, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label22, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(162, 35);
            this.tableLayoutPanel3.TabIndex = 101;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(84, 17);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(75, 18);
            this.label25.TabIndex = 104;
            this.label25.Text = "|______________";
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(75, 17);
            this.label24.TabIndex = 103;
            this.label24.Text = "_________________";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 17);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(75, 18);
            this.label23.TabIndex = 102;
            this.label23.Text = "Stage";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(84, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 17);
            this.label22.TabIndex = 101;
            this.label22.Text = "Tact";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(675, 85);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(78, 35);
            this.textBox14.TabIndex = 87;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(759, 85);
            this.textBox15.Multiline = true;
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(78, 35);
            this.textBox15.TabIndex = 88;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(759, 126);
            this.textBox16.Multiline = true;
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(78, 35);
            this.textBox16.TabIndex = 89;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 41);
            this.label8.TabIndex = 90;
            this.label8.Text = "1";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.UseWaitCursor = true;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(3, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 41);
            this.label12.TabIndex = 91;
            this.label12.Text = "2";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.UseWaitCursor = true;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(3, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(162, 41);
            this.label13.TabIndex = 92;
            this.label13.Text = "3";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.UseWaitCursor = true;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(171, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 41);
            this.label14.TabIndex = 93;
            this.label14.Text = "0";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.UseWaitCursor = true;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(255, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 41);
            this.label15.TabIndex = 94;
            this.label15.Text = "1";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.UseWaitCursor = true;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(339, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 41);
            this.label16.TabIndex = 95;
            this.label16.Text = "2";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.UseWaitCursor = true;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(423, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 41);
            this.label17.TabIndex = 96;
            this.label17.Text = "3";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label17.UseWaitCursor = true;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(507, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 41);
            this.label18.TabIndex = 97;
            this.label18.Text = "4";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label18.UseWaitCursor = true;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(591, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 41);
            this.label19.TabIndex = 98;
            this.label19.Text = "5";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label19.UseWaitCursor = true;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(675, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 41);
            this.label20.TabIndex = 99;
            this.label20.Text = "6";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label20.UseWaitCursor = true;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(759, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 41);
            this.label21.TabIndex = 100;
            this.label21.Text = "7";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label21.UseWaitCursor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(842, 164);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelChooseStrategy
            // 
            this.labelChooseStrategy.AutoSize = true;
            this.labelChooseStrategy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChooseStrategy.Location = new System.Drawing.Point(586, 474);
            this.labelChooseStrategy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChooseStrategy.Name = "labelChooseStrategy";
            this.labelChooseStrategy.Size = new System.Drawing.Size(132, 20);
            this.labelChooseStrategy.TabIndex = 75;
            this.labelChooseStrategy.Text = "Optimal strategy";
            this.labelChooseStrategy.Click += new System.EventHandler(this.label1_Click);
            // 
            // ilabelInit
            // 
            this.ilabelInit.AutoSize = true;
            this.ilabelInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ilabelInit.Location = new System.Drawing.Point(586, 506);
            this.ilabelInit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ilabelInit.Name = "ilabelInit";
            this.ilabelInit.Size = new System.Drawing.Size(0, 20);
            this.ilabelInit.TabIndex = 76;
            // 
            // comboBoxRoutine
            // 
            this.comboBoxRoutine.FormattingEnabled = true;
            this.comboBoxRoutine.Items.AddRange(new object[] {
            "Uninterrupted",
            "By step"});
            this.comboBoxRoutine.Location = new System.Drawing.Point(682, 620);
            this.comboBoxRoutine.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxRoutine.Name = "comboBoxRoutine";
            this.comboBoxRoutine.Size = new System.Drawing.Size(145, 24);
            this.comboBoxRoutine.TabIndex = 77;
            this.comboBoxRoutine.Text = "Uninterrupted";
            this.comboBoxRoutine.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoutine_SelectedIndexChanged);
            // 
            // labelRoutine
            // 
            this.labelRoutine.AutoSize = true;
            this.labelRoutine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoutine.Location = new System.Drawing.Point(586, 620);
            this.labelRoutine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRoutine.Name = "labelRoutine";
            this.labelRoutine.Size = new System.Drawing.Size(66, 20);
            this.labelRoutine.TabIndex = 78;
            this.labelRoutine.Text = "Routine";
            // 
            // tableProcess
            // 
            this.tableProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnProcess1,
            this.columnProcess2});
            this.tableProcess.Location = new System.Drawing.Point(91, 307);
            this.tableProcess.Name = "tableProcess";
            this.tableProcess.ReadOnly = true;
            this.tableProcess.RowTemplate.Height = 24;
            this.tableProcess.Size = new System.Drawing.Size(306, 408);
            this.tableProcess.TabIndex = 79;
            this.tableProcess.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableProcess_CellContentClick);
            // 
            // columnProcess1
            // 
            this.columnProcess1.HeaderText = "Process 1";
            this.columnProcess1.Name = "columnProcess1";
            this.columnProcess1.ReadOnly = true;
            // 
            // columnProcess2
            // 
            this.columnProcess2.HeaderText = "Process 2";
            this.columnProcess2.Name = "columnProcess2";
            this.columnProcess2.ReadOnly = true;
            // 
            // MemoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 769);
            this.Controls.Add(this.tableProcess);
            this.Controls.Add(this.labelRoutine);
            this.Controls.Add(this.comboBoxRoutine);
            this.Controls.Add(this.ilabelInit);
            this.Controls.Add(this.labelChooseStrategy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.errorMessega);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxStrategy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.startButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MemoryForm";
            this.Load += new System.EventHandler(this.MemoryForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableProcess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxStrategy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label errorMessega;
        private System.Windows.Forms.Button buttonTact0;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonTact1;
        private System.Windows.Forms.Button buttonTact2;
        private System.Windows.Forms.Button buttonTact3;
        private System.Windows.Forms.Button buttonTact4;
        private System.Windows.Forms.Button buttonTact5;
        private System.Windows.Forms.Button buttonTact6;
        private System.Windows.Forms.Button buttonTact7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label labelChooseStrategy;
        private System.Windows.Forms.Label ilabelInit;
        private System.Windows.Forms.ComboBox comboBoxRoutine;
        private System.Windows.Forms.Label labelRoutine;
        private System.Windows.Forms.DataGridView tableProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProcess1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProcess2;
    }
}

