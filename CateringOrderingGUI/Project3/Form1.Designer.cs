namespace Project3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtGuest = new System.Windows.Forms.TextBox();
            this.lblGuest = new System.Windows.Forms.Label();
            this.cmbSauces = new System.Windows.Forms.ComboBox();
            this.SaucesGb = new System.Windows.Forms.GroupBox();
            this.SidesGb = new System.Windows.Forms.GroupBox();
            this.cmbSides = new System.Windows.Forms.ComboBox();
            this.EntreesGb = new System.Windows.Forms.GroupBox();
            this.rdoPasta = new System.Windows.Forms.RadioButton();
            this.rdoChicken = new System.Windows.Forms.RadioButton();
            this.rdoSteak = new System.Windows.Forms.RadioButton();
            this.lblReciept = new System.Windows.Forms.Label();
            this.msgBtn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbBar = new System.Windows.Forms.GroupBox();
            this.wineCbx = new System.Windows.Forms.CheckBox();
            this.openBarCb = new System.Windows.Forms.CheckBox();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblDisplayDate = new System.Windows.Forms.Label();
            this.lblAmtDue = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.edensLabel = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.SaucesGb.SuspendLayout();
            this.SidesGb.SuspendLayout();
            this.EntreesGb.SuspendLayout();
            this.gbBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGuest
            // 
            this.txtGuest.Location = new System.Drawing.Point(145, 125);
            this.txtGuest.Name = "txtGuest";
            this.txtGuest.Size = new System.Drawing.Size(100, 23);
            this.txtGuest.TabIndex = 0;
            // 
            // lblGuest
            // 
            this.lblGuest.AutoSize = true;
            this.lblGuest.Location = new System.Drawing.Point(31, 128);
            this.lblGuest.Name = "lblGuest";
            this.lblGuest.Size = new System.Drawing.Size(106, 15);
            this.lblGuest.TabIndex = 1;
            this.lblGuest.Text = "Number of Guests:";
            // 
            // cmbSauces
            // 
            this.cmbSauces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSauces.FormattingEnabled = true;
            this.cmbSauces.Location = new System.Drawing.Point(28, 42);
            this.cmbSauces.Name = "cmbSauces";
            this.cmbSauces.Size = new System.Drawing.Size(121, 23);
            this.cmbSauces.TabIndex = 3;
            // 
            // SaucesGb
            // 
            this.SaucesGb.Controls.Add(this.cmbSauces);
            this.SaucesGb.Location = new System.Drawing.Point(251, 177);
            this.SaucesGb.Name = "SaucesGb";
            this.SaucesGb.Size = new System.Drawing.Size(180, 79);
            this.SaucesGb.TabIndex = 5;
            this.SaucesGb.TabStop = false;
            this.SaucesGb.Text = "Sauces";
            // 
            // SidesGb
            // 
            this.SidesGb.Controls.Add(this.cmbSides);
            this.SidesGb.Location = new System.Drawing.Point(251, 262);
            this.SidesGb.Name = "SidesGb";
            this.SidesGb.Size = new System.Drawing.Size(180, 81);
            this.SidesGb.TabIndex = 6;
            this.SidesGb.TabStop = false;
            this.SidesGb.Text = "Sides";
            // 
            // cmbSides
            // 
            this.cmbSides.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSides.FormattingEnabled = true;
            this.cmbSides.Location = new System.Drawing.Point(28, 42);
            this.cmbSides.Name = "cmbSides";
            this.cmbSides.Size = new System.Drawing.Size(121, 23);
            this.cmbSides.TabIndex = 3;
            // 
            // EntreesGb
            // 
            this.EntreesGb.Controls.Add(this.rdoPasta);
            this.EntreesGb.Controls.Add(this.rdoChicken);
            this.EntreesGb.Controls.Add(this.rdoSteak);
            this.EntreesGb.Location = new System.Drawing.Point(42, 168);
            this.EntreesGb.Name = "EntreesGb";
            this.EntreesGb.Size = new System.Drawing.Size(203, 175);
            this.EntreesGb.TabIndex = 7;
            this.EntreesGb.TabStop = false;
            this.EntreesGb.Text = "Entrees";
            // 
            // rdoPasta
            // 
            this.rdoPasta.AutoSize = true;
            this.rdoPasta.Location = new System.Drawing.Point(28, 117);
            this.rdoPasta.Name = "rdoPasta";
            this.rdoPasta.Size = new System.Drawing.Size(53, 19);
            this.rdoPasta.TabIndex = 2;
            this.rdoPasta.TabStop = true;
            this.rdoPasta.Text = "Pasta";
            this.rdoPasta.UseVisualStyleBackColor = true;
            // 
            // rdoChicken
            // 
            this.rdoChicken.AutoSize = true;
            this.rdoChicken.Location = new System.Drawing.Point(28, 80);
            this.rdoChicken.Name = "rdoChicken";
            this.rdoChicken.Size = new System.Drawing.Size(68, 19);
            this.rdoChicken.TabIndex = 1;
            this.rdoChicken.TabStop = true;
            this.rdoChicken.Text = "Chicken";
            this.rdoChicken.UseVisualStyleBackColor = true;
            // 
            // rdoSteak
            // 
            this.rdoSteak.AutoSize = true;
            this.rdoSteak.Location = new System.Drawing.Point(28, 44);
            this.rdoSteak.Name = "rdoSteak";
            this.rdoSteak.Size = new System.Drawing.Size(53, 19);
            this.rdoSteak.TabIndex = 0;
            this.rdoSteak.TabStop = true;
            this.rdoSteak.Text = "Steak";
            this.rdoSteak.UseVisualStyleBackColor = true;
            // 
            // lblReciept
            // 
            this.lblReciept.AutoSize = true;
            this.lblReciept.Location = new System.Drawing.Point(312, 202);
            this.lblReciept.Name = "lblReciept";
            this.lblReciept.Size = new System.Drawing.Size(0, 15);
            this.lblReciept.TabIndex = 8;
            // 
            // msgBtn
            // 
            this.msgBtn.Enabled = false;
            this.msgBtn.Location = new System.Drawing.Point(237, 383);
            this.msgBtn.Name = "msgBtn";
            this.msgBtn.Size = new System.Drawing.Size(75, 23);
            this.msgBtn.TabIndex = 9;
            this.msgBtn.Text = "Summary";
            this.msgBtn.UseVisualStyleBackColor = true;
            this.msgBtn.Click += new System.EventHandler(this.msgBtn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(336, 383);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbBar
            // 
            this.gbBar.Controls.Add(this.wineCbx);
            this.gbBar.Controls.Add(this.openBarCb);
            this.gbBar.Location = new System.Drawing.Point(437, 177);
            this.gbBar.Name = "gbBar";
            this.gbBar.Size = new System.Drawing.Size(158, 90);
            this.gbBar.TabIndex = 12;
            this.gbBar.TabStop = false;
            this.gbBar.Text = "Bar Selection";
            // 
            // wineCbx
            // 
            this.wineCbx.AutoSize = true;
            this.wineCbx.Location = new System.Drawing.Point(29, 57);
            this.wineCbx.Name = "wineCbx";
            this.wineCbx.Size = new System.Drawing.Size(117, 19);
            this.wineCbx.TabIndex = 1;
            this.wineCbx.Text = "Wine with Dinner";
            this.wineCbx.UseVisualStyleBackColor = true;
            // 
            // openBarCb
            // 
            this.openBarCb.AutoSize = true;
            this.openBarCb.Location = new System.Drawing.Point(30, 25);
            this.openBarCb.Name = "openBarCb";
            this.openBarCb.Size = new System.Drawing.Size(75, 19);
            this.openBarCb.TabIndex = 0;
            this.openBarCb.Text = "Open Bar";
            this.openBarCb.UseVisualStyleBackColor = true;
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.Location = new System.Drawing.Point(143, 95);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(128, 15);
            this.lblCurrentDate.TabIndex = 13;
            this.lblCurrentDate.Text = "when run displays date";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(143, 383);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblDisplayDate
            // 
            this.lblDisplayDate.AutoSize = true;
            this.lblDisplayDate.Location = new System.Drawing.Point(31, 95);
            this.lblDisplayDate.Name = "lblDisplayDate";
            this.lblDisplayDate.Size = new System.Drawing.Size(77, 15);
            this.lblDisplayDate.TabIndex = 15;
            this.lblDisplayDate.Text = "Current Date:";
            // 
            // lblAmtDue
            // 
            this.lblAmtDue.AutoSize = true;
            this.lblAmtDue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAmtDue.Location = new System.Drawing.Point(458, 289);
            this.lblAmtDue.Name = "lblAmtDue";
            this.lblAmtDue.Size = new System.Drawing.Size(81, 15);
            this.lblAmtDue.TabIndex = 16;
            this.lblAmtDue.Text = "Amount Due:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(545, 285);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 17;
            // 
            // edensLabel
            // 
            this.edensLabel.AutoSize = true;
            this.edensLabel.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edensLabel.Location = new System.Drawing.Point(12, 9);
            this.edensLabel.Name = "edensLabel";
            this.edensLabel.Size = new System.Drawing.Size(464, 67);
            this.edensLabel.TabIndex = 18;
            this.edensLabel.Text = "EDENS CATERING";
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(42, 383);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 19;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.edensLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblAmtDue);
            this.Controls.Add(this.lblDisplayDate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblCurrentDate);
            this.Controls.Add(this.gbBar);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.msgBtn);
            this.Controls.Add(this.lblReciept);
            this.Controls.Add(this.EntreesGb);
            this.Controls.Add(this.SidesGb);
            this.Controls.Add(this.SaucesGb);
            this.Controls.Add(this.lblGuest);
            this.Controls.Add(this.txtGuest);
            this.Name = "Form1";
            this.Text = "Catering Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SaucesGb.ResumeLayout(false);
            this.SidesGb.ResumeLayout(false);
            this.EntreesGb.ResumeLayout(false);
            this.EntreesGb.PerformLayout();
            this.gbBar.ResumeLayout(false);
            this.gbBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtGuest;
        private Label lblGuest;
        private ComboBox cmbSauces;
        private GroupBox SaucesGb;
        private GroupBox SidesGb;
        private ComboBox cmbSides;
        private GroupBox EntreesGb;
        private RadioButton rdoPasta;
        private RadioButton rdoChicken;
        private RadioButton rdoSteak;
        private Label lblReciept;
        private Button msgBtn;
        private Button btnExit;
        private GroupBox gbBar;
        private CheckBox wineCbx;
        private CheckBox openBarCb;
        private Label lblCurrentDate;
        private Button btnClear;
        private Label lblDisplayDate;
        private Label lblAmtDue;
        private TextBox textBox1;
        private Label edensLabel;
        private Button calcBtn;
    }
}