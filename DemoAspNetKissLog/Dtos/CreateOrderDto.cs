using System;

namespace DemoAspNetKissLog.Dtos
{
    public class CreateOrderDto
    {
        public decimal Total { get; set; }        
        public decimal Taxes { get; set; }        
        public DateTime IssueDate { get; set; }
        public int Sequence { get; set; }      
    }
}