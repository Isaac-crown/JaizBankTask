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

        public string? Location { get; set; }
        public string? TerminalId { get; set; }
        public string? Stan { get; set; }
        public DateTime? DateTime { get; set; }
        public Double Amount { get; set; }
        public string? DebitCardNo { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string? AuthorizationCode { get; set; }
        
        public string? ResponseCode { get; set; }
        public string? AID { get; set; }
        public string? RRN { get; set; }
        public string? Accelerex { get; set; }

        public string? PTAD { get; set; }

    }
}
