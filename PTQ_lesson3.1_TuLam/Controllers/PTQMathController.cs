using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTQ_lesson3._1_TuLam.Controllers
{
    public class PTQMathController : Controller
    {
        // In ra các số nguyên tố từ 1 đến 100
        public ActionResult PrimeNumbers()
        {
            var primes = GetPrimeNumbers(1, 100);
            return View(primes);
        }

        // In ra giai thừa từ 1 đến 10
        public ActionResult Factorials()
        {
            var factorials = new Dictionary<int, long>();
            for (int i = 1; i <= 10; i++)
            {
                factorials[i] = Factorial(i);
            }
            return View(factorials);
        }

        // In ra bảng cửu chương từ 2 đến 9
        public ActionResult MultiplicationTables()
        {
            var tables = new Dictionary<int, List<int>>();
            for (int i = 2; i <= 9; i++)
            {
                var table = new List<int>();
                for (int j = 1; j <= 10; j++)
                {
                    table.Add(i * j);
                }
                tables[i] = table;
            }
            return View(tables);
        }

        // Hàm kiểm tra số nguyên tố
        private List<int> GetPrimeNumbers(int start, int end)
        {
            var primes = new List<int>();
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }
            return primes;
        }

        private bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        // Hàm tính giai thừa
        private long Factorial(int number)
        {
            if (number == 0 || number == 1) return 1;
            return number * Factorial(number - 1);
        }
    }
}