using System.Numerics;
using Phantasma.RPC.Sharp.Api;
using Phantasma.RPC.Sharp.Client;

namespace SampleClient
{
    internal class SampleClient
    {
        private static BigInteger GetMultiplier(int units)
        {
            BigInteger unitMultiplier = 1;
            while (units > 0)
            {
                unitMultiplier *= 10;
                units--;
            }

            return unitMultiplier;
        }

        public static decimal ToDecimal(BigInteger value, int units)
        {
            if (value == 0)
            {
                return 0;
            }

            if (units == 0)
            {
                return (long)value;
            }

            var multiplier = (decimal)GetMultiplier(units);
            var n = decimal.Parse(value.ToString()); // TODO not very efficient, improve later...
            n /= multiplier;
            return n;
        }

        static void Main(string[] args)
        {
            var client = new ApiClient(@"http://localhost:7077/");
            var accountAPI = new AccountApi(client);

            var account = accountAPI.GetAccount("P2K9zmyFDNGN6n6hHiTUAz6jqn29s5G1SWLiXwCVQcpHcQb");

            Console.WriteLine("Result: " + account.Name);
            foreach (var balance in account.Balances)
            {
                var val = BigInteger.Parse(balance.Amount);
                var amount = ToDecimal(val, balance.Decimals.Value);
                Console.WriteLine($"{amount} {balance.Symbol}");
            }
        }
    }
}