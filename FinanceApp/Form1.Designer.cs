namespace FinanceApp
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
            txtDescription = new TextBox();
            cmbCategory = new ComboBox();
            chkIsIncome = new CheckBox();
            dgvTransactions = new DataGridView();
            lblTotalIncome = new Label();
            btnAdd = new Button();
            txtAmount = new TextBox();
            lblTotalExpense = new Label();
            lblBalance = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(459, 228);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 0;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(459, 325);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 23);
            cmbCategory.TabIndex = 1;
            // 
            // chkIsIncome
            // 
            chkIsIncome.AutoSize = true;
            chkIsIncome.Location = new Point(146, 249);
            chkIsIncome.Name = "chkIsIncome";
            chkIsIncome.Size = new Size(62, 19);
            chkIsIncome.TabIndex = 2;
            chkIsIncome.Text = "Earned";
            chkIsIncome.UseVisualStyleBackColor = true;
            // 
            // dgvTransactions
            // 
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(12, 12);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.Size = new Size(408, 231);
            dgvTransactions.TabIndex = 4;
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.AutoSize = true;
            lblTotalIncome.Location = new Point(469, 49);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(72, 15);
            lblTotalIncome.TabIndex = 5;
            lblTotalIncome.Text = "Total Earned";
            // 
            // btnAdd
            // 
            btnAdd.AccessibleName = "buttonAdicionar";
            btnAdd.Location = new Point(323, 303);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add\r\n";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += buttonAdd_Click;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(459, 270);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(100, 23);
            txtAmount.TabIndex = 7;
            // 
            // lblTotalExpense
            // 
            lblTotalExpense.AutoSize = true;
            lblTotalExpense.Location = new Point(469, 81);
            lblTotalExpense.Name = "lblTotalExpense";
            lblTotalExpense.Size = new Size(66, 15);
            lblTotalExpense.TabIndex = 8;
            lblTotalExpense.Text = "Total Spent";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(471, 117);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(88, 15);
            lblBalance.TabIndex = 9;
            lblBalance.Text = "Current Budget";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(605, 233);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 10;
            label1.Text = "Where ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(605, 278);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 11;
            label2.Text = "How much";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(605, 328);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 12;
            label3.Text = "Area ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblBalance);
            Controls.Add(lblTotalExpense);
            Controls.Add(txtAmount);
            Controls.Add(btnAdd);
            Controls.Add(lblTotalIncome);
            Controls.Add(dgvTransactions);
            Controls.Add(chkIsIncome);
            Controls.Add(cmbCategory);
            Controls.Add(txtDescription);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescription;
        private ComboBox cmbCategory;
        private CheckBox chkIsIncome;
        private DataGridView dgvTransactions;
        private Label lblTotalIncome;
        private Button btnAdd;
        private TextBox txtAmount;
        private Label lblTotalExpense;
        private Label lblBalance;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
