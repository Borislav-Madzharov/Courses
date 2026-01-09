using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
/*
 +359 2 8863222
 +359 2 222 2222


+359 2 234 2324, +359 2 222 2222, +3592-654-1234

(?<!\d)\+359[ -]?2[ -]?\d{3}[ -]?\d{4}(?!\d)
\+359[ -]?2[ -]?\d{3}[ -]?\d{4}
 
 */
namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phoneNumbers = Console.ReadLine();
            string pattern = @"(^| )\+359([ -])2\2\d{3}\2\d{4}\b";

            var regex = new Regex(pattern);

            var phoneMatches = Regex.Matches(phoneNumbers, pattern);

            string[] matchedPhones = phoneMatches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));







        }
    }
}
