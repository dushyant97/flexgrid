using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C1Control.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public int Downloads { get; set; }
        public int Sales { get; set; }

        public int Amount { get; set; }

        public int Extra { get; set; }

        private static List<string> CountryNames = new List<string>
        { "United States", "United Kingdom", "Canada", "Japan", "China", "France", "German", "Italy", "Korea", "Australia" };

        public static List<Country> GetData(int total)
        {
            var rand = new Random(0);
            var list = Enumerable.Range(0, total).Select(i =>
            {
                string CntryName = CountryNames[rand.Next(0, CountryNames.Count - 1)];
                int download = rand.Next();
                int sales = rand.Next(0, 1000);
                int amt = rand.Next(1000, 10000);
                int extra = rand.Next(0, 5000);

                return new Country
                {
                    Id = i + 1,
                    CountryName = CntryName,
                    Downloads = download,
                    Sales = sales,
                    Amount = amt,
                    Extra = extra
                };
            });
            return list.ToList();
        }
    }
}
