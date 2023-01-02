using System;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;

namespace RegexDemoPrac
{
    internal class Program
    {
        const int MaxTimeoutInSeonds = 3;

        public static int MaxTimeoutInSeconds { get; private set; }

        static void Main(string[] args)
        {
            ////1-> Define a regular expression for repeated words.
            //Regex rx = new Regex(@"\b(?<word>\w+)\s+(\k<word>)\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);

            //// Define a test string 
            //string text = "The the quick brown fox fox for jumps over the lazy dog dog";

            //// Find matches.
            //MatchCollection matches = rx.Matches(text);

            //// Report the number of matches found

            //Console.WriteLine("{0} matches foudn in:\n  {1}", matches.Count, text);

            //// Report for each match

            //foreach(Match match in matches)
            //{
            //    GroupCollection groups = match.Groups;

            //    Console.WriteLine("'{0}' repeated at position {1} and {2}", groups["word"].Value, groups[0].Index, groups[1].Index);
            //}


            //string input = "The quick brown fox jumps over the lazy dog";

            //Regex rx = new Regex(@"(?<word>\w+)", RegexOptions.Compiled | RegexOptions.IgnoreCase);

            //MatchCollection matches = rx.Matches(input);

            //foreach (Match m in matches)
            //{
            //    Console.WriteLine(m.Value);
            //}

            //2-> Get the en-US NumberFormatInfo object to build the regular 
            // expression pattern dynamically.
            //NumberFormatInfo nfi = CultureInfo.GetCultureInfo("en-US").NumberFormat;

            //// Define the regular expression pattern.
            //string pattern;
            //pattern = @"^\s*[";
            //// Get the positive and negative sign symbols.
            //pattern += Regex.Escape(nfi.PositiveSign + nfi.NegativeSign) + @"]?\s?";
            //// Get the currency symbol.
            //pattern += Regex.Escape(nfi.CurrencySymbol) + @"?\s?";
            //// Add integral digits to the pattern.
            //pattern += @"(\d*";
            //// Add the decimal separator.
            //pattern += Regex.Escape(nfi.CurrencyDecimalSeparator) + "?";
            //// Add the fractional digits.
            //pattern += @"(\d{";
            //// Determine the number of fractional digits in currency values.
            //pattern += nfi.CurrencyDecimalDigits.ToString() + "})?){1}$";

            //Console.WriteLine($"Pattern is {pattern}\n");

            ////Regex rgx = new Regex(@"^\s*[\+-]?\s?\$?\s?(\d*\.?\d{2}?){1}$"); //Statically
            //Regex rgx = new Regex(pattern);

            //string[] tests = { "-42", "19.99", "0.001", "100 USD",
            //             ".34", "0.34", "1,052.21", "$10.62",
            //             "+1.43", "-$0.23" };

            //// Check each test string against the regular expression.
            //foreach (string test in tests)
            //{
            //    if(rgx.IsMatch(test))
            //    {
            //        Console.WriteLine($"{test} is a currency value.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{test} is not a currency value.");
            //    }
            //}

            //String validator
            //string pattern = @"^\d{5}(-\d{4})?$";

            //RegexStringValidator validator = new RegexStringValidator(pattern);

            //try
            //{
            //    validator.Validate("12345-333");
            //    Console.WriteLine("Valid");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("Invalid: " + ex.Message);
            //}

            // Difference between Regex and String
            // Use the methods of the System.String class when you are searching for a specific string.
            // Use the Regex class when you are searching for a specific pattern in a string.

            // However, caching can adversely affect performance in the following two cases:

            //StreamReader sr = new StreamReader("test.txt");
            //Stopwatch sw = Stopwatch.StartNew();  
            //sw.Start();
            //string input;
            //string pattern = @"\b(\w+)\s\b";
            //Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);

            //while (sr.Peek() >= 0)
            //{
            //    input = sr.ReadLine();

            //    MatchCollection matches = rgx.Matches(input);
            //    if (matches.Count > 0)
            //    {
            //        Console.WriteLine("{0} ({1} matches):", input, matches.Count);
            //        foreach (Match match in matches)
            //            Console.WriteLine("   " + match.Value);
            //    }
            //}
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed.ToString()); 
            //sr.Close();

            // Regex Constructors

            //1. Regex (String)
            //string pattern = @"\b[at]\w+";
            //string text = "The threaded application ate up the thread pool as it executed.";
            //MatchCollection matches;

            //Regex defaultRegex = new Regex(pattern);
            //// Get matches of pattern in text
            //matches = defaultRegex.Matches(text);
            //Console.WriteLine("Parsing '{0}'", text);
            //// Iterate matches
            //for (int ctr = 0; ctr < matches.Count; ctr++)
            //    Console.WriteLine("{0}. {1}", ctr, matches[ctr].Value);


            // The example displays the following output:
            //       Parsing 'The threaded application ate up the thread pool as it executed.'
            //       0. threaded
            //       1. application
            //       2. ate
            //       3. the
            //       4. thread
            //       5. as

            //2. Regex(String, RegexOptions)
            //string pattern = @"\b[at]\w+";
            //RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.Compiled;
            //string text = "The threaded application ate up the thread pool as it executed.";
            //MatchCollection matches;

            //Regex optionRegex = new Regex(pattern, options);
            //Console.WriteLine("Parsing '{0}' with options {1}:", text, options.ToString());
            //// Get matches of pattern in text
            //matches = optionRegex.Matches(text);
            //// Iterate matches
            //for (int ctr = 0; ctr < matches.Count; ctr++)
            //    Console.WriteLine("{0}. {1}", ctr, matches[ctr].Value);

            // The example displays the following output:
            //    Parsing 'The threaded application ate up the thread pool as it executed.'
            //        with options IgnoreCase, Compiled:
            //    0. The
            //    1. threaded
            //    2. application
            //    3. ate
            //    4. the
            //    5. thread
            //    6. as

            //3. Regex(String, RegexOptions, TimeSpan)

            // The regular expression pattern (a+)+$, which matches one or more sequences of one
            // or more "a" characters at the end of a line, is subject to excessive backtracking. 

            //string pattern = @"(a+)+$";    // DO NOT REUSE THIS PATTERN.
            //Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase, TimeSpan.FromSeconds(1));
            //Stopwatch sw = null;

            //string[] inputs = { "aa", "aaaa>",
            //             "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
            //             "aaaaaaaaaaaaaaaaaaaaaa>",
            //             "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa>" };

            //foreach (var inputValue in inputs)
            //{
            //    Console.WriteLine("Processing {0}", inputValue);
            //    bool timedOut = false;
            //    do
            //    {
            //        try
            //        {
            //            sw = Stopwatch.StartNew();
            //            // Display the result.
            //            if (rgx.IsMatch(inputValue))
            //            {
            //                sw.Stop();
            //                Console.WriteLine(@"Valid: '{0}' ({1:ss\.fffffff} seconds)",
            //                                  inputValue, sw.Elapsed);
            //            }
            //            else
            //            {
            //                sw.Stop();
            //                Console.WriteLine(@"'{0}' is not a valid string. ({1:ss\.fffff} seconds)",
            //                                  inputValue, sw.Elapsed);
            //            }
            //        }
            //        catch (RegexMatchTimeoutException e)
            //        {
            //            sw.Stop();
            //            // Display the elapsed time until the exception.
            //            Console.WriteLine(@"Timeout with '{0}' after {1:ss\.fffff}",
            //                              inputValue, sw.Elapsed);
            //            Thread.Sleep(1500);       // Pause for 1.5 seconds.

            //            // Increase the timeout interval and retry.
            //            TimeSpan timeout = e.MatchTimeout.Add(TimeSpan.FromSeconds(1));
            //            if (timeout.TotalSeconds > MaxTimeoutInSeconds)
            //            {
            //                Console.WriteLine("Maximum timeout interval of {0} seconds exceeded.",
            //                                  MaxTimeoutInSeconds);
            //                timedOut = false;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Changing the timeout interval to {0}",
            //                                  timeout);
            //                rgx = new Regex(pattern, RegexOptions.IgnoreCase, timeout);
            //                timedOut = true;
            //            }
            //        }
            //    } while (timedOut);
            //    Console.WriteLine();

            //Replacing a matched Substring

            Console.WriteLine("input a decimal");
            var input = Console.ReadLine();
            while (input == "") input = Console.ReadLine();
            var decimalinput = Convert.ToDecimal(input);
            Console.WriteLine($"Standard currency format for input {decimalinput:C}");
            Console.WriteLine();
            Console.WriteLine("Before convert " + input);
            var commaPattern = @"(-?\d)(?=(\d{3})+\.\b)";
            var commaReplacement = "$1,";
            var output = Regex.Replace(input, commaPattern, commaReplacement);

            var intPattern = @"^(-?\d+)(?:\.0+)?$";
            var intReplacement = "$1.00";
            output = Regex.Replace(output, intPattern, intReplacement);
            //var output = Regex.Replace(input, @"^|(\d{3}(?=(\d{3})*(\.|$)))", m => m.Value == "" ? "$" : "," + m.Value);


            var dollarPattern = @"(.*\d)";
            var dollarReplacement = "$$$1";
            output = Regex.Replace(output, dollarPattern, dollarReplacement);

            Console.WriteLine("After convert " + output);
            Console.WriteLine("----------------");


            Console.WriteLine("Before convert " + output);
            string pattern = @"^\$|,|(?:\.0+)?$";
            var Replacement = "";
            var output2 = Regex.Replace(output, pattern, Replacement);
            Console.WriteLine("After convert " + output2);
            //var output = Convert.ToDecimal(getInput).ToString("C");
            //Console.WriteLine($"Output is:{output}");
            //string input = $"Total Cost: {getInput}";
            //Console.WriteLine(Regex.Replace(input, pattern, replacement));



            //Spliting a Single String into an Array of Strings
            //input: 1. Eggs 2. Bread 3. Milk 4. Coffe 5. Tea
            //output: Eggs
            // Bread
            // Milk.....

            //Console.WriteLine("Give an input: ");

            //var input = Console.ReadLine();

            ////var input = Console.ReadLine();
            ////while (input == "")
            ////{
            ////    input = Console.ReadLine();
            ////}

            //string pattern = @"\b\d+\.\s\b";
            //foreach( string item in Regex.Split (input, pattern))
            //{
            //    if(!String.IsNullOrEmpty(item))
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //while ((input = Console.ReadLine()) != null)

            //MatchCollection mathces;
            //List<string> results = new List<string>();
            //List<int> matchposition = new List<int>();

            //// Create a new regex object and define the regular express
            //Regex r = new Regex("abc");

            //while (true)
            //{
            //    var input = Console.ReadLine();

            //    if(input == "done")
            //    {
            //        break;
            //    }

            //    mathces = r.Matches(input);

            //    foreach (Match match in mathces)
            //    {
            //        results.Add(match.Value);
            //        matchposition.Add(match.Index);
            //    }
            //    for (int ctr = 0; ctr < results.Count; ctr++)
            //    {
            //        Console.WriteLine("{0} found at position {1}.", results[ctr], matchposition[ctr]);
            //    }
            //}
            //string pattern = "abc";
            //string[] input = { "abc123abc456abc789", "abcdedfgabcklm" };

            //foreach (var input1 in input)
            //{
            //    Match match = Regex.Match(input1, pattern);
            //    while (match.Success)
            //    {
            //        Console.WriteLine("{0} found at position {1}.",
            //                          match.Value, match.Index);
            //        match = match.NextMatch();
            //    }
            //}


            //string pattern = @"\b(\w+)\s(\d{1,2}),\s(\d{4})\b";
            //string input = "Born: July 28, 1989";
            //Match match = Regex.Match(input, pattern);
            //if (match.Success)
            //    for (int ctr = 0; ctr < match.Groups.Count; ctr++)
            //        Console.WriteLine("Group {0}: {1}", ctr, match.Groups[ctr].Value);

            //string input = "Miami,78;Chicago,62;New York,67;San Francisco,59;Seattle,58;";
            //string pattern = @"((\w+(\s\w+)*),(\d+);)+";
            //Regex r = new Regex(pattern);
            //Match m = r.Match(input);

            //Console.WriteLine(m.Groups.Count);
            //Console.WriteLine(m.Groups[4].Value);
            //Match match = Regex.Match(input, pattern);
            //if (match.Success)
            //{
            //    Console.WriteLine("Current temperatures:");
            //    for (int ctr = 0; ctr < match.Groups[2].Captures.Count; ctr++)
            //        Console.WriteLine("{0,-20} {1,3}", match.Groups[2].Captures[ctr].Value,
            //                          match.Groups[4].Captures[ctr].Value);
            //}

        }
    }
}