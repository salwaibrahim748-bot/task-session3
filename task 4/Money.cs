using System;
using System.Collections.Generic;
using System.Text;

namespace task_4
{
    public record Money(decimal Amount, string Currency);
    public class Money2
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }

        public Money2(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }
    }

}
