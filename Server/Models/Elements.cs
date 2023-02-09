#nullable disable
using System;
using System.Collections.Generic;
namespace ExamSalesApp.Server.Models
{
    public partial class Elements
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public int? WindowId { get; set; }

        public virtual Windows Window { get; set; }
    }
}