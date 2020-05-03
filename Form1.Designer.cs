namespace DirtyCompundInterest
{
  partial class Form1
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.Principal = new System.Windows.Forms.TextBox();
      this.periodsPerYear = new System.Windows.Forms.TextBox();
      this.yearsBox = new System.Windows.Forms.TextBox();
      this.interestRate = new System.Windows.Forms.TextBox();
      this.principalLabel = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.yearsLabel = new System.Windows.Forms.Label();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.totalLabel = new System.Windows.Forms.Label();
      this.totalBox = new System.Windows.Forms.TextBox();
      this.calculateButton = new System.Windows.Forms.Button();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.yearsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.period = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // Principal
      // 
      this.Principal.Location = new System.Drawing.Point(26, 77);
      this.Principal.Name = "Principal";
      this.Principal.Size = new System.Drawing.Size(139, 20);
      this.Principal.TabIndex = 0;
      // 
      // periodsPerYear
      // 
      this.periodsPerYear.Location = new System.Drawing.Point(218, 77);
      this.periodsPerYear.Name = "periodsPerYear";
      this.periodsPerYear.Size = new System.Drawing.Size(139, 20);
      this.periodsPerYear.TabIndex = 1;
      // 
      // yearsBox
      // 
      this.yearsBox.Location = new System.Drawing.Point(621, 77);
      this.yearsBox.Name = "yearsBox";
      this.yearsBox.Size = new System.Drawing.Size(139, 20);
      this.yearsBox.TabIndex = 3;
      // 
      // interestRate
      // 
      this.interestRate.Location = new System.Drawing.Point(429, 77);
      this.interestRate.Name = "interestRate";
      this.interestRate.Size = new System.Drawing.Size(139, 20);
      this.interestRate.TabIndex = 2;
      // 
      // principalLabel
      // 
      this.principalLabel.AutoSize = true;
      this.principalLabel.Location = new System.Drawing.Point(72, 61);
      this.principalLabel.Name = "principalLabel";
      this.principalLabel.Size = new System.Drawing.Size(47, 13);
      this.principalLabel.TabIndex = 4;
      this.principalLabel.Text = "Principal";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(243, 61);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(85, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "Periods per Year";
      // 
      // yearsLabel
      // 
      this.yearsLabel.AutoSize = true;
      this.yearsLabel.Location = new System.Drawing.Point(672, 61);
      this.yearsLabel.Name = "yearsLabel";
      this.yearsLabel.Size = new System.Drawing.Size(34, 13);
      this.yearsLabel.TabIndex = 7;
      this.yearsLabel.Text = "Years";
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yearsCol,
            this.period,
            this.value});
      this.dataGridView1.Location = new System.Drawing.Point(26, 103);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.Size = new System.Drawing.Size(542, 321);
      this.dataGridView1.TabIndex = 8;
      // 
      // totalLabel
      // 
      this.totalLabel.AutoSize = true;
      this.totalLabel.Location = new System.Drawing.Point(675, 216);
      this.totalLabel.Name = "totalLabel";
      this.totalLabel.Size = new System.Drawing.Size(31, 13);
      this.totalLabel.TabIndex = 10;
      this.totalLabel.Text = "Total";
      // 
      // totalBox
      // 
      this.totalBox.Location = new System.Drawing.Point(621, 232);
      this.totalBox.Name = "totalBox";
      this.totalBox.ReadOnly = true;
      this.totalBox.Size = new System.Drawing.Size(139, 20);
      this.totalBox.TabIndex = 11;
      // 
      // calculateButton
      // 
      this.calculateButton.Location = new System.Drawing.Point(650, 401);
      this.calculateButton.Name = "calculateButton";
      this.calculateButton.Size = new System.Drawing.Size(75, 23);
      this.calculateButton.TabIndex = 12;
      this.calculateButton.Text = "Calculate";
      this.calculateButton.UseVisualStyleBackColor = true;
      this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "Interest/Year",
            "Interest/Period"});
      this.comboBox1.Location = new System.Drawing.Point(438, 56);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(121, 21);
      this.comboBox1.TabIndex = 13;
      // 
      // yearsCol
      // 
      this.yearsCol.HeaderText = "Years";
      this.yearsCol.Name = "yearsCol";
      this.yearsCol.ReadOnly = true;
      // 
      // period
      // 
      this.period.HeaderText = "Periods";
      this.period.Name = "period";
      this.period.ReadOnly = true;
      // 
      // value
      // 
      dataGridViewCellStyle2.Format = "C2";
      dataGridViewCellStyle2.NullValue = null;
      this.value.DefaultCellStyle = dataGridViewCellStyle2;
      this.value.HeaderText = "Value";
      this.value.Name = "value";
      this.value.ReadOnly = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.calculateButton);
      this.Controls.Add(this.totalBox);
      this.Controls.Add(this.totalLabel);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.yearsLabel);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.principalLabel);
      this.Controls.Add(this.yearsBox);
      this.Controls.Add(this.interestRate);
      this.Controls.Add(this.periodsPerYear);
      this.Controls.Add(this.Principal);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.TextBox Principal;
        private System.Windows.Forms.TextBox periodsPerYear;
        private System.Windows.Forms.TextBox yearsBox;
        private System.Windows.Forms.TextBox interestRate;
        private System.Windows.Forms.Label principalLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label yearsLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.Button calculateButton;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.DataGridViewTextBoxColumn yearsCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn period;
    private System.Windows.Forms.DataGridViewTextBoxColumn value;
  }
}

