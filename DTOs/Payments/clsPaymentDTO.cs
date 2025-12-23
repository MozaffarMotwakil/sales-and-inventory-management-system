using System;

namespace DTOs.Payments
{
    public class clsPaymentDTO
    {
        public int PaymentID { get; set; }
        public int InvoiceID { get; set; }
        public float PaymentAmount { get; set; }
        public byte PaymentMethodID { get; set; }
        public DateTime PaymentDate { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
