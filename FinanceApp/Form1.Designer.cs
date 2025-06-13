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
            dgvTransactions = new DataGridView();
            lblTotalIncome = new Label();
            lblTotalExpense = new Label();
            lblBalance = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // dgvTransactions
            // 
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(12, 161);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.Size = new Size(671, 262);
            dgvTransactions.TabIndex = 4;
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.AutoSize = true;
            lblTotalIncome.Location = new Point(49, 83);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(72, 15);
            lblTotalIncome.TabIndex = 5;
            lblTotalIncome.Text = "Total Earned";
            // 
            // lblTotalExpense
            // 
            lblTotalExpense.AutoSize = true;
            lblTotalExpense.Location = new Point(49, 134);
            lblTotalExpense.Name = "lblTotalExpense";
            lblTotalExpense.Size = new Size(66, 15);
            lblTotalExpense.TabIndex = 8;
            lblTotalExpense.Text = "Total Spent";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(347, 134);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(88, 15);
            lblBalance.TabIndex = 9;
            lblBalance.Text = "Current Budget";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBalance);
            Controls.Add(lblTotalExpense);
            Controls.Add(lblTotalIncome);
            Controls.Add(dgvTransactions);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvTransactions;
        private Label lblTotalIncome;
        private Label lblTotalExpense;
        private Label lblBalance;
    }
}
