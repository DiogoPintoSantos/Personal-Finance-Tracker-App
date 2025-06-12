using System.Transactions;
using System.Text.Json;
using System.Drawing.Text;
namespace FinanceApp
{

    public partial class Form1 : Form
    {
        private List<Transaction> transactions = new();
        private string filePath = "transaction.json";
        public Form1()
        {
            
        InitializeComponent();
    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.AddRange(new string[] { "ASalário", "Alimentação", "Transporte", "lazer", "Outros" });

            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                transactions = JsonSerializer.Deserialize<List<Transaction>>(json);
            }
            UpdateGrid();
            UpdateDashboard();
        }
        private void SaveToFile()
        {
            var json = JsonSerializer.Serialize(transactions, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
        private void UpdateGrid()
        {
            dgvTransactions.DataSource = null;
            dgvTransactions.DataSource = transactions.Select(t => new
            {
                Data = t.Date.ToString("dd/MM/yyyy"),
                t.Description,
                t.Category,
                Valor = t.Amount.ToString("C"),
                Tipo = t.IsIncome ? "Receita" : "Despesa"
            }).ToList();
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
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(txtAmount.Text) ||
                cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("Valor inválido.");
                return;
            }

            var transaction = new Transaction
            {
                Description = txtDescription.Text,
                Category = cmbCategory.SelectedItem.ToString(),
                Amount = amount,
                IsIncome = chkIsIncome.Checked
            };

            transactions.Add(transaction);
            SaveToFile();
            UpdateGrid();
            UpdateDashboard();

            // Limpar campos
            txtDescription.Text = "";
            txtAmount.Text = "";
            cmbCategory.SelectedIndex = -1;
            chkIsIncome.Checked = false;
        }

    } }

