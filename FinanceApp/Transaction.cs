﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp
{
    public class Transaction
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Amount { get; set; }
        public bool IsIncome { get; set; }
    }
}
