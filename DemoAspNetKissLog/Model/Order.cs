using System;

namespace DemoAspNetKissLog.Model
{
    public class Order
    {
        protected Order()
        {
            
        }
        public Order(decimal total, decimal taxes, DateTime issueDate, int sequence)
        {
            Id = Guid.NewGuid();            
            this.Total = total;
            this.Taxes = taxes;
            this.IssueDate = issueDate;
            this.Sequence = sequence;
        }
        public Guid Id { get; }
        public decimal Total { get; set; }
        public decimal Taxes { get; set; }
        public DateTime IssueDate { get; set; }
        public int Sequence { get; set; }
    }
}