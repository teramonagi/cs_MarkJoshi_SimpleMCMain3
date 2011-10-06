using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleMCMain3
{
    class Program
    {
        static void Main(string[] args)
        {
            //parameters
            double expiry = 1.0;
            double strike = 50.0;
            double spot = 49.0;
            double vol = 0.2;
            double r = 0.01;

            //input number of montecarlo paths
            ulong number_of_paths = 10000;
            Console.Write("Enter number of montecarlo paths : ");
            number_of_paths = ulong.Parse(Console.ReadLine());

            //create payoff object
            PayOff call_payoff = new PayOffCall(strike);
            PayOff put_payoff = new PayOffPut(strike);

            //montecarlo simulation & output result
            double result = SimpleMC2.SimpleMonteCarlo2(call_payoff, expiry, spot, vol, r, number_of_paths);
            Console.WriteLine("the call price is " + result.ToString());

            result = SimpleMC2.SimpleMonteCarlo2(put_payoff, expiry, spot, vol, r, number_of_paths);
            Console.WriteLine("the put price is " + result.ToString());       
        }
    }
}
