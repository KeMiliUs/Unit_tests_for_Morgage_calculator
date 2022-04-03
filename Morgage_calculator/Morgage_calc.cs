namespace Morgage_calculator
{
    public class Morgage_calc
    {
        public string amort(double rate, int bal, int term, int num_payments)
        {
            //string amort(double rate, double all_sum, int terms, int num_payment)
            double Rate = rate / 1200;
            int terms = term;
            double balance = (double)bal;
            int Month_number = num_payments;
            double n;
            double d;
            double c;
            double Int = 0;
            double princ = 0;
            if (num_payments > term)
                return "Error num_payments is bigger then term";
            if (rate < 0)
                return "Error degrees cant be less than zero";
            if (balance < 0)
                return "Error balance cant be less than zero";
            d = 1 - Math.Pow(1 + Rate, -1 * terms);
            n = balance * Rate;
            if (d == 0)
            {
                c = balance / terms;
            }
            else
                c = n / d;
            for (int i = 0; i < num_payments; i++)
            {
                Int = balance * Rate;
                princ = c - Int;
                balance = balance - princ;
            }
            if (balance < 0)
                balance = 0;
            string result = $"num_payment {num_payments} c {Math.Round(c, 0, MidpointRounding.AwayFromZero)} princ {Math.Round(princ, 0, MidpointRounding.AwayFromZero)} int {Math.Round(Int, 0, MidpointRounding.AwayFromZero)} balance {Math.Round(balance, 0, MidpointRounding.AwayFromZero)}";
            return result;
        }
    }
}