using System.Transactions;
using System.Text.Json;
using System.Drawing.Text;
using System.ComponentModel;
namespace FinanceApp
{

    public partial class Form1 : Form
    {
        private BindingList<Transaction> transactions = new();
        private string filePath = "transaction.json";
        public Form1()
        {
            
            InitializeComponent();
            lblBalance.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblTotalIncome.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblTotalExpense.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvTransactions.EnableHeadersVisualStyles = false;
            dgvTransactions.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvTransactions.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvTransactions.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvTransactions.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgvTransactions.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvTransactions.RowTemplate.Height = 30;
            dgvTransactions.AutoGenerateColumns = false;
            //Indice
            dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "#",
                ReadOnly = true,
                Name = "Index"
            });
            //Date 
            dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Date",
                HeaderText = "Date"
            });

            //Description
            dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "Description"
            });

            //Category
            dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Category",
                HeaderText = "Categoria"
            });

            // Coluna Valor
            dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Amount",
                HeaderText = "Valor"
            });
            //Type
            var tipoColumn = new DataGridViewComboBoxColumn
            {
                DataPropertyName = "IsIncome",
                HeaderText = "Type",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton,
                ValueType = typeof(bool),
            };
           

            tipoColumn.DataSource = new[]
            {
                new { Text = "Receita", Value = true },
                new { Text = "Despesa", Value = false }
            };
            tipoColumn.DisplayMember = "Text";
            tipoColumn.ValueMember = "Value";
            dgvTransactions.Columns.Add(tipoColumn);


            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                transactions = JsonSerializer.Deserialize<BindingList<Transaction>>(json);
            }
            dgvTransactions.DataSource = transactions;
            transactions.ListChanged += (s, eArgs) => AtualizarIndices();
            AtualizarIndices();
            // Listen for changes
            dgvTransactions.CellValueChanged += DgvTransactions_CellValueChanged;
            dgvTransactions.UserDeletedRow += DgvTransactions_UserDeleteRow;
            dgvTransactions.RowsAdded += (s, eArgs) => AtualizarIndices();
        }
        private void SaveToFile()
        {
            var json = JsonSerializer.Serialize(transactions, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
        private void UpdateDashboard()
        {
            decimal totalIncome = transactions.Where(t => t.IsIncome).Sum(t => t.Amount);
            decimal totalExpense = transactions.Where(t => !t.IsIncome).Sum(t => t.Amount);
            decimal balance = totalIncome - totalExpense;

            lblTotalIncome.Text = $"Receitas: {totalIncome:C}";
            lblTotalExpense.Text = $"Despesas: {totalExpense:C}";
            lblBalance.Text = $"Saldo: {balance:C}";

            lblBalance.ForeColor = balance >= 0 ? Color.Green : Color.Red;
        }



        private void DgvTransactions_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SaveToFile();
            UpdateDashboard();
            AtualizarIndices();
        }
        private void DgvTransactions_UserDeleteRow(object sender, DataGridViewRowEventArgs e)
        {
            SaveToFile();
            UpdateDashboard();
            AtualizarIndices();
        }

        private void AtualizarIndices()
        {
            for (int i = 0; i < dgvTransactions.Rows.Count; i++)
            {
                if (!dgvTransactions.Rows[i].IsNewRow)
                {


                    dgvTransactions.Rows[i].Cells["Index"].Value = i + 1;
                }
            }
        }
    }
}




