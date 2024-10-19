using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISReprintReceipt.Report.ReportEntities
{
    public class CashAdvanceSS
    {
        public string ClientID { get; set; }
        public string ClientFullName { get; set; }
        public string Amount { get; set; }
        public string Terms { get; set; }
        public string InterestRate { get; set; }
        public string InterestAmount { get; set; }
        public string TotalAmount { get; set; }
        public string Balance { get; set; }
        public DateTime DateReceived { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }
    }
}
