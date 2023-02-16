namespace academicManagementApp
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.CourseLbl = new System.Windows.Forms.Label();
            this.tableCmb = new System.Windows.Forms.ComboBox();
            this.recordCmb = new System.Windows.Forms.ComboBox();
            this.displayDGV = new System.Windows.Forms.DataGridView();
            this.enterBtn = new System.Windows.Forms.Button();
            this.recordLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fieldFiveBox = new System.Windows.Forms.TextBox();
            this.fieldFourBox = new System.Windows.Forms.TextBox();
            this.fieldThreeBox = new System.Windows.Forms.TextBox();
            this.fieldTwoBox = new System.Windows.Forms.TextBox();
            this.fieldOneBox = new System.Windows.Forms.TextBox();
            this.fieldFiveLbl = new System.Windows.Forms.Label();
            this.fieldFourLabel = new System.Windows.Forms.Label();
            this.fieldThreeLabel = new System.Windows.Forms.Label();
            this.fieldTwoLbl = new System.Windows.Forms.Label();
            this.fieldOneLbl = new System.Windows.Forms.Label();
            this.fieldCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.tbSix = new System.Windows.Forms.TextBox();
            this.tbFive = new System.Windows.Forms.TextBox();
            this.tbFour = new System.Windows.Forms.TextBox();
            this.tbSeven = new System.Windows.Forms.TextBox();
            this.tbTwo = new System.Windows.Forms.TextBox();
            this.tbThree = new System.Windows.Forms.TextBox();
            this.tbOne = new System.Windows.Forms.TextBox();
            this.fSevenLbl = new System.Windows.Forms.Label();
            this.fSixLbl = new System.Windows.Forms.Label();
            this.fFiveLbl = new System.Windows.Forms.Label();
            this.fFourLbl = new System.Windows.Forms.Label();
            this.fThreeLbl = new System.Windows.Forms.Label();
            this.fTwoLbl = new System.Windows.Forms.Label();
            this.fOneLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchGrid = new System.Windows.Forms.DataGridView();
            this.searchCmb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.displayDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Table:";
            // 
            // CourseLbl
            // 
            this.CourseLbl.AutoSize = true;
            this.CourseLbl.Location = new System.Drawing.Point(28, 106);
            this.CourseLbl.Name = "CourseLbl";
            this.CourseLbl.Size = new System.Drawing.Size(153, 25);
            this.CourseLbl.TabIndex = 1;
            this.CourseLbl.Text = "Select Record:";
            // 
            // tableCmb
            // 
            this.tableCmb.FormattingEnabled = true;
            this.tableCmb.Items.AddRange(new object[] {
            "students",
            "classes",
            "instructors"});
            this.tableCmb.Location = new System.Drawing.Point(293, 50);
            this.tableCmb.Name = "tableCmb";
            this.tableCmb.Size = new System.Drawing.Size(216, 33);
            this.tableCmb.TabIndex = 4;
            this.tableCmb.SelectedIndexChanged += new System.EventHandler(this.tableCmb_SelectedIndexChanged);
            // 
            // recordCmb
            // 
            this.recordCmb.FormattingEnabled = true;
            this.recordCmb.Location = new System.Drawing.Point(293, 106);
            this.recordCmb.Name = "recordCmb";
            this.recordCmb.Size = new System.Drawing.Size(216, 33);
            this.recordCmb.TabIndex = 5;
            this.recordCmb.SelectedIndexChanged += new System.EventHandler(this.recordCmb_SelectedIndexChanged);
            // 
            // displayDGV
            // 
            this.displayDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayDGV.Location = new System.Drawing.Point(77, 660);
            this.displayDGV.Name = "displayDGV";
            this.displayDGV.RowHeadersWidth = 82;
            this.displayDGV.RowTemplate.Height = 33;
            this.displayDGV.Size = new System.Drawing.Size(1432, 635);
            this.displayDGV.TabIndex = 7;
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(124, 492);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(349, 49);
            this.enterBtn.TabIndex = 8;
            this.enterBtn.Text = "INSERT INTO";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // recordLabel
            // 
            this.recordLabel.AutoSize = true;
            this.recordLabel.Location = new System.Drawing.Point(607, 193);
            this.recordLabel.Name = "recordLabel";
            this.recordLabel.Size = new System.Drawing.Size(0, 25);
            this.recordLabel.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 598);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 46);
            this.label2.TabIndex = 10;
            this.label2.Text = "Results View";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fieldFiveBox);
            this.groupBox1.Controls.Add(this.fieldFourBox);
            this.groupBox1.Controls.Add(this.fieldThreeBox);
            this.groupBox1.Controls.Add(this.fieldTwoBox);
            this.groupBox1.Controls.Add(this.fieldOneBox);
            this.groupBox1.Controls.Add(this.fieldFiveLbl);
            this.groupBox1.Controls.Add(this.fieldFourLabel);
            this.groupBox1.Controls.Add(this.fieldThreeLabel);
            this.groupBox1.Controls.Add(this.fieldTwoLbl);
            this.groupBox1.Controls.Add(this.fieldOneLbl);
            this.groupBox1.Controls.Add(this.fieldCmb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.enterBtn);
            this.groupBox1.Location = new System.Drawing.Point(841, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 557);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new records";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // fieldFiveBox
            // 
            this.fieldFiveBox.Location = new System.Drawing.Point(433, 333);
            this.fieldFiveBox.Name = "fieldFiveBox";
            this.fieldFiveBox.Size = new System.Drawing.Size(197, 31);
            this.fieldFiveBox.TabIndex = 20;
            // 
            // fieldFourBox
            // 
            this.fieldFourBox.Location = new System.Drawing.Point(433, 274);
            this.fieldFourBox.Name = "fieldFourBox";
            this.fieldFourBox.Size = new System.Drawing.Size(197, 31);
            this.fieldFourBox.TabIndex = 19;
            // 
            // fieldThreeBox
            // 
            this.fieldThreeBox.Location = new System.Drawing.Point(433, 214);
            this.fieldThreeBox.Name = "fieldThreeBox";
            this.fieldThreeBox.Size = new System.Drawing.Size(197, 31);
            this.fieldThreeBox.TabIndex = 18;
            // 
            // fieldTwoBox
            // 
            this.fieldTwoBox.Location = new System.Drawing.Point(433, 163);
            this.fieldTwoBox.Name = "fieldTwoBox";
            this.fieldTwoBox.Size = new System.Drawing.Size(197, 31);
            this.fieldTwoBox.TabIndex = 17;
            // 
            // fieldOneBox
            // 
            this.fieldOneBox.Location = new System.Drawing.Point(433, 106);
            this.fieldOneBox.Name = "fieldOneBox";
            this.fieldOneBox.Size = new System.Drawing.Size(197, 31);
            this.fieldOneBox.TabIndex = 16;
            // 
            // fieldFiveLbl
            // 
            this.fieldFiveLbl.AutoSize = true;
            this.fieldFiveLbl.Location = new System.Drawing.Point(108, 339);
            this.fieldFiveLbl.Name = "fieldFiveLbl";
            this.fieldFiveLbl.Size = new System.Drawing.Size(0, 25);
            this.fieldFiveLbl.TabIndex = 15;
            // 
            // fieldFourLabel
            // 
            this.fieldFourLabel.AutoSize = true;
            this.fieldFourLabel.Location = new System.Drawing.Point(108, 274);
            this.fieldFourLabel.Name = "fieldFourLabel";
            this.fieldFourLabel.Size = new System.Drawing.Size(0, 25);
            this.fieldFourLabel.TabIndex = 14;
            // 
            // fieldThreeLabel
            // 
            this.fieldThreeLabel.AutoSize = true;
            this.fieldThreeLabel.Location = new System.Drawing.Point(108, 217);
            this.fieldThreeLabel.Name = "fieldThreeLabel";
            this.fieldThreeLabel.Size = new System.Drawing.Size(0, 25);
            this.fieldThreeLabel.TabIndex = 13;
            // 
            // fieldTwoLbl
            // 
            this.fieldTwoLbl.AutoSize = true;
            this.fieldTwoLbl.Location = new System.Drawing.Point(108, 163);
            this.fieldTwoLbl.Name = "fieldTwoLbl";
            this.fieldTwoLbl.Size = new System.Drawing.Size(0, 25);
            this.fieldTwoLbl.TabIndex = 12;
            // 
            // fieldOneLbl
            // 
            this.fieldOneLbl.AutoSize = true;
            this.fieldOneLbl.Location = new System.Drawing.Point(108, 106);
            this.fieldOneLbl.Name = "fieldOneLbl";
            this.fieldOneLbl.Size = new System.Drawing.Size(0, 25);
            this.fieldOneLbl.TabIndex = 11;
            // 
            // fieldCmb
            // 
            this.fieldCmb.FormattingEnabled = true;
            this.fieldCmb.Items.AddRange(new object[] {
            "students",
            "classes",
            "instructors"});
            this.fieldCmb.Location = new System.Drawing.Point(433, 48);
            this.fieldCmb.Name = "fieldCmb";
            this.fieldCmb.Size = new System.Drawing.Size(197, 33);
            this.fieldCmb.TabIndex = 10;
            this.fieldCmb.SelectedIndexChanged += new System.EventHandler(this.fieldCmb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select Table:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchCmb);
            this.groupBox2.Controls.Add(this.searchGrid);
            this.groupBox2.Controls.Add(this.searchBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(1549, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1046, 1110);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Engine";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.updateBtn);
            this.groupBox3.Controls.Add(this.tbSix);
            this.groupBox3.Controls.Add(this.tbFive);
            this.groupBox3.Controls.Add(this.tbFour);
            this.groupBox3.Controls.Add(this.tbSeven);
            this.groupBox3.Controls.Add(this.tbTwo);
            this.groupBox3.Controls.Add(this.tbThree);
            this.groupBox3.Controls.Add(this.tbOne);
            this.groupBox3.Controls.Add(this.fSevenLbl);
            this.groupBox3.Controls.Add(this.fSixLbl);
            this.groupBox3.Controls.Add(this.fFiveLbl);
            this.groupBox3.Controls.Add(this.fFourLbl);
            this.groupBox3.Controls.Add(this.fThreeLbl);
            this.groupBox3.Controls.Add(this.fTwoLbl);
            this.groupBox3.Controls.Add(this.fOneLbl);
            this.groupBox3.Controls.Add(this.tableCmb);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.recordCmb);
            this.groupBox3.Controls.Add(this.CourseLbl);
            this.groupBox3.Location = new System.Drawing.Point(77, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(722, 571);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Display/Edit records";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(616, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 27;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(151, 506);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(295, 49);
            this.updateBtn.TabIndex = 26;
            this.updateBtn.Text = "UPDATE";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // tbSix
            // 
            this.tbSix.Location = new System.Drawing.Point(293, 411);
            this.tbSix.Name = "tbSix";
            this.tbSix.Size = new System.Drawing.Size(216, 31);
            this.tbSix.TabIndex = 25;
            // 
            // tbFive
            // 
            this.tbFive.Location = new System.Drawing.Point(293, 364);
            this.tbFive.Name = "tbFive";
            this.tbFive.Size = new System.Drawing.Size(216, 31);
            this.tbFive.TabIndex = 24;
            // 
            // tbFour
            // 
            this.tbFour.Location = new System.Drawing.Point(293, 314);
            this.tbFour.Name = "tbFour";
            this.tbFour.Size = new System.Drawing.Size(216, 31);
            this.tbFour.TabIndex = 23;
            // 
            // tbSeven
            // 
            this.tbSeven.Location = new System.Drawing.Point(293, 459);
            this.tbSeven.Name = "tbSeven";
            this.tbSeven.Size = new System.Drawing.Size(216, 31);
            this.tbSeven.TabIndex = 22;
            // 
            // tbTwo
            // 
            this.tbTwo.Location = new System.Drawing.Point(293, 216);
            this.tbTwo.Name = "tbTwo";
            this.tbTwo.Size = new System.Drawing.Size(216, 31);
            this.tbTwo.TabIndex = 21;
            // 
            // tbThree
            // 
            this.tbThree.Location = new System.Drawing.Point(293, 266);
            this.tbThree.Name = "tbThree";
            this.tbThree.Size = new System.Drawing.Size(216, 31);
            this.tbThree.TabIndex = 20;
            // 
            // tbOne
            // 
            this.tbOne.BackColor = System.Drawing.Color.LightGray;
            this.tbOne.Location = new System.Drawing.Point(293, 169);
            this.tbOne.Name = "tbOne";
            this.tbOne.ReadOnly = true;
            this.tbOne.Size = new System.Drawing.Size(216, 31);
            this.tbOne.TabIndex = 19;
            // 
            // fSevenLbl
            // 
            this.fSevenLbl.AutoSize = true;
            this.fSevenLbl.Location = new System.Drawing.Point(28, 462);
            this.fSevenLbl.Name = "fSevenLbl";
            this.fSevenLbl.Size = new System.Drawing.Size(0, 25);
            this.fSevenLbl.TabIndex = 18;
            // 
            // fSixLbl
            // 
            this.fSixLbl.AutoSize = true;
            this.fSixLbl.Location = new System.Drawing.Point(28, 417);
            this.fSixLbl.Name = "fSixLbl";
            this.fSixLbl.Size = new System.Drawing.Size(0, 25);
            this.fSixLbl.TabIndex = 17;
            // 
            // fFiveLbl
            // 
            this.fFiveLbl.AutoSize = true;
            this.fFiveLbl.Location = new System.Drawing.Point(28, 364);
            this.fFiveLbl.Name = "fFiveLbl";
            this.fFiveLbl.Size = new System.Drawing.Size(0, 25);
            this.fFiveLbl.TabIndex = 16;
            // 
            // fFourLbl
            // 
            this.fFourLbl.AutoSize = true;
            this.fFourLbl.Location = new System.Drawing.Point(28, 314);
            this.fFourLbl.Name = "fFourLbl";
            this.fFourLbl.Size = new System.Drawing.Size(0, 25);
            this.fFourLbl.TabIndex = 15;
            // 
            // fThreeLbl
            // 
            this.fThreeLbl.AutoSize = true;
            this.fThreeLbl.Location = new System.Drawing.Point(28, 266);
            this.fThreeLbl.Name = "fThreeLbl";
            this.fThreeLbl.Size = new System.Drawing.Size(0, 25);
            this.fThreeLbl.TabIndex = 14;
            // 
            // fTwoLbl
            // 
            this.fTwoLbl.AutoSize = true;
            this.fTwoLbl.Location = new System.Drawing.Point(28, 216);
            this.fTwoLbl.Name = "fTwoLbl";
            this.fTwoLbl.Size = new System.Drawing.Size(0, 25);
            this.fTwoLbl.TabIndex = 13;
            // 
            // fOneLbl
            // 
            this.fOneLbl.AutoSize = true;
            this.fOneLbl.Location = new System.Drawing.Point(28, 169);
            this.fOneLbl.Name = "fOneLbl";
            this.fOneLbl.Size = new System.Drawing.Size(0, 25);
            this.fOneLbl.TabIndex = 12;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(1549, 1190);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(1046, 105);
            this.exitBtn.TabIndex = 15;
            this.exitBtn.Text = "EXIT APPLICATION";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(357, 607);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(250, 42);
            this.refreshBtn.TabIndex = 16;
            this.refreshBtn.Text = "Refresh View";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Select search type:";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(488, 43);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(528, 31);
            this.searchBox.TabIndex = 1;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // searchGrid
            // 
            this.searchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchGrid.Location = new System.Drawing.Point(20, 129);
            this.searchGrid.Name = "searchGrid";
            this.searchGrid.RowHeadersWidth = 82;
            this.searchGrid.RowTemplate.Height = 33;
            this.searchGrid.Size = new System.Drawing.Size(996, 962);
            this.searchGrid.TabIndex = 3;
            // 
            // searchCmb
            // 
            this.searchCmb.FormattingEnabled = true;
            this.searchCmb.Items.AddRange(new object[] {
            "student\'s classes",
            "teacher\'s students",
            "class roster"});
            this.searchCmb.Location = new System.Drawing.Point(260, 43);
            this.searchCmb.Name = "searchCmb";
            this.searchCmb.Size = new System.Drawing.Size(201, 33);
            this.searchCmb.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2809, 1320);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recordLabel);
            this.Controls.Add(this.displayDGV);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.displayDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CourseLbl;
        private System.Windows.Forms.ComboBox tableCmb;
        private System.Windows.Forms.ComboBox recordCmb;
        private System.Windows.Forms.DataGridView displayDGV;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Label recordLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label fieldOneLbl;
        private System.Windows.Forms.ComboBox fieldCmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fieldFiveBox;
        private System.Windows.Forms.TextBox fieldFourBox;
        private System.Windows.Forms.TextBox fieldThreeBox;
        private System.Windows.Forms.TextBox fieldTwoBox;
        private System.Windows.Forms.TextBox fieldOneBox;
        private System.Windows.Forms.Label fieldFiveLbl;
        private System.Windows.Forms.Label fieldFourLabel;
        private System.Windows.Forms.Label fieldThreeLabel;
        private System.Windows.Forms.Label fieldTwoLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox tbSix;
        private System.Windows.Forms.TextBox tbFive;
        private System.Windows.Forms.TextBox tbFour;
        private System.Windows.Forms.TextBox tbSeven;
        private System.Windows.Forms.TextBox tbTwo;
        private System.Windows.Forms.TextBox tbThree;
        private System.Windows.Forms.TextBox tbOne;
        private System.Windows.Forms.Label fSevenLbl;
        private System.Windows.Forms.Label fSixLbl;
        private System.Windows.Forms.Label fFiveLbl;
        private System.Windows.Forms.Label fFourLbl;
        private System.Windows.Forms.Label fThreeLbl;
        private System.Windows.Forms.Label fTwoLbl;
        private System.Windows.Forms.Label fOneLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DataGridView searchGrid;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox searchCmb;
    }
}