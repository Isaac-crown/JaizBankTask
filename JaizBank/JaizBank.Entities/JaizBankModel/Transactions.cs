using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaizBank.Entities.JaizBankModel
{
    public  class Transactions
    {
        public int TransactionsId { get; set; }
        public string? MerchantId { get; set; }
        public string? MerchantName { get; set; }

        public string? Location { get; set; }
        public string? TerminalId { get; set; }
        public string? Stan { get; set;}
        public DateTime? DateTime { get; set; }
        public Decimal Amount { get; set; }
        public string?  DebitCardNo { get; set; }
        public DateTime? ExpireDate { get; set; }
        public double? AuthorizationCode { get; set; }
        public string? Offline { get; set; }
        public int ResponseCode { get; set; }
        public string? AID { get; set; }
        public string? RRN { get; set; }

        public string? Accelerex { get; set; }

        public string? PTAD { get; set; }

    }
}
