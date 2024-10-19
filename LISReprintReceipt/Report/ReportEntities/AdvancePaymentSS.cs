using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISReprintReceipt.Report.ReportEntities
{
    public class AdvancePaymentSS
    {
        public int ClientID { get; set; }
        public string ClientFullName { get; set; }
        public string ClientSalary { get; set; }
        public string ClientAdvPayment { get; set; }
        public string Change { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Categ { get; set; }
        public string IntAmount { get; set; }
        public string NewBal { get; set; }
    }
}
