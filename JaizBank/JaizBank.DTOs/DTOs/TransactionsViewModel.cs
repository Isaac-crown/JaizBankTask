using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaizBank.DTOs.DTOs
{
    public class TransactionsViewModel
    {
        
        public string? MerchantName { get; set; }
        public string? TerminalId { get; set; }
        public string? Stan { get; set; }
        public DateTime? DateTime { get; set; }
        public Decimal Amount { get; set; }
        public string? DebitCardNo { get; set; }
        public DateOnly ExpireDate { get; set; }
        public double? AuthorizationCode { get; set; }
        public string? Offline { get; set; }
        public int ResponseCode { get; set; }
        public string? AID { get; set; }
        public string? RRN { get; set; }

    }
}
