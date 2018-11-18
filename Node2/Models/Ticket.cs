using System;
using System.Collections.Generic;

namespace Node2.Models
{
    public partial class Ticket
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int? AccountId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ProblemDescription { get; set; }
    }
}
