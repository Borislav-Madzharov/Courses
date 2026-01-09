using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})(?<separetor>[-.\/])?(?<month>[A-Z][a-z]{2})\k<separetor>(?<year>\d{4})\b";
            string dates = Console.ReadLine();

            var regex = new System.Text.RegularExpressions.Regex(pattern);
            var dateMatches = regex.Matches(dates);

            foreach (Match match in dateMatches)
            {
                string day = match.Groups["day"].Value;
                string month = match.Groups["month"].Value;
                string year = match.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }





        }
    }
}
