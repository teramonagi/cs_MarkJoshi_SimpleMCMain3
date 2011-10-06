using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleMCMain3
{
    public abstract class PayOff
    {
        public abstract double Do(double spot);
    }
    public class PayOffCall : PayOff
    {
        public PayOffCall(double strike)
        {
            this.strike_ = strike;
        }
        public override double Do(double spot)
        { 	
            return(Math.Max(spot - strike_, 0));
        }
        private double strike_;
    }
    public class PayOffPut : PayOff
    {
        public PayOffPut(double strike)
        {
            this.strike_ = strike;
        }
        public override double Do(double spot)
        { 	
            return(Math.Max(strike_ - spot, 0));
        }
        private double strike_;
    }
}