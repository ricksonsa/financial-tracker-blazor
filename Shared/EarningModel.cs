using System;
using System.ComponentModel.DataAnnotations;
using web.Shared;

namespace web.Shared
{
    public class EarningModel
    {
        [Required]
        public DateTime Date { get; set; }
        [Required]
        [MaxLength(50)]
        public string Subject { get; set; }
        [Required]
        public EarningCategory Category { get; set; }
        [Required]
        public decimal Amount { get; set; }

        public EarningModel()
        {
        }
    }
}
