using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Morgage_calculator;
namespace Morgage_calculator_tests
{
    [TestClass]
    public class MorgageCalculatorTests
    {
        [TestMethod]
        public void Margage_Calculate_Normal_parametres()
        {
            double rate=6;
            int balance=100000;
            int term=360;
            int num_payment=12;

            Morgage_calc calc=new Morgage_calc();
            string result = calc.amort(rate, balance, term, num_payment);

            Assert.AreEqual("num_payment 12 c 600 princ 105 int 494 balance 98772", result);
        }
        [TestMethod]
        public void Margage_Calculate_Balance_is_zero_last_month()
        {
            double rate = 7.4;
            int balance = 10215;
            int term = 24;
            int num_payment = 24;

            Morgage_calc calc = new Morgage_calc();
            string result = calc.amort(rate, balance, term, num_payment);

            Assert.AreEqual("num_payment 24 c 459 princ 456 int 3 balance 0", result);
        }
        [TestMethod]
        public void Margage_Calculate_num_payment_is_bigger_than_terms()
        {
            double rate = 7.4;
            int balance = 10215;
            int term = 24;
            int num_payment = 25;

            Morgage_calc calc = new Morgage_calc();
            string result = calc.amort(rate, balance, term, num_payment);

            Assert.AreEqual("Error num_payments is bigger then term", result);
        }

        [TestMethod]
        public void Margage_Calculate_start_balance_less_zero()
        {
            double rate = 7.4;
            int balance = -10215;
            int term = 24;
            int num_payment = 23;

            Morgage_calc calc = new Morgage_calc();
            string result = calc.amort(rate, balance, term, num_payment);

            Assert.AreEqual("Error balance cant be less than zero", result);
        }

        [TestMethod]
        public void Margage_Calculate_rate_degrees_less_zero()
        {
            double rate = -7.4;
            int balance = 10215;
            int term = 24;
            int num_payment = 23;

            Morgage_calc calc = new Morgage_calc();
            string result = calc.amort(rate, balance, term, num_payment);

            Assert.AreEqual("Error degrees cant be less than zero", result);
        }
    }
}