﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Report
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalSales { get; set; }
        public string? Details { get; set; }
    }
}
