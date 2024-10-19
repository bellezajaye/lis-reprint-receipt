using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISReprintReceipt.Report.ReportEntities
{
    public class AdditionalLoanSS
    {
        public string ClientName { get; set; }
        public int ClientID { get; set; }
        public string loanCateg { get; set; }
        public decimal addAmount { get; set; }
        public decimal Balance { get; set; }
        public decimal newBalance { get; set; }
        public decimal PayNxtSal { get; set; }
        public decimal PeriodPayment { get; set; }
        public DateTime addLoanDate { get; set; }
    }
}
