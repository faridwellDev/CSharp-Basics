/*
 * ^ - Starts with
 * $ - Ends with
 * [] - Range
 * () - Group
 * . - Single character once
 * + - one or more characters in a row
 * ? - optional preceding character match
 * \ - escape character
 * \n - new line
 * \d - digit
 * \D - non digit
 * \s - white space
 * \S - no-white space
 * \w - alphanumeric/underscore character (word chars)
 * \W - non-word characters
 * {x,y} - Repeat low (x) to high (y) (no "y" means at least x, no ",y" means that many)
 * (x | y) - Alternative - x or y
 * [^x] - Anything but x (where x is whatever character you want)
 * */


//What is regular expression: A regular expression is a pattern that the regular expression
//engine attempts to match in input text. A pattern consists of one or more character literals,
//operators, or constructs.


// Topics: 
// 1-> Define regular expression (Need: Character Escapes(\t), Character Classes([ character_group ]), Anchors(^,$), Grouping Constructs(( subexpression )(\w)\1) "ee" in "deep", 
// Lookarounds expression ((?=check)	Positive Lookahead, Asserts that what immediately follows the current position in the string is "check")
// Quantifiers(*,+), Backreference Constructs (\number, (\w)\1 "ee" in "seek"), Alternation Constructs (th(e|is|at), Substitutions ($ number	Substitutes
// the substring matched by group number.	\b(\w+)(\s)(\w+)\b	$3$2$1	"one two"	"two one"), Regular Expression Options
// (i Use case-insensitive matching.	\b(?i)a(?-i)a\w +\b "aardvark", "aaaAuto" in "aardvark AAAuto aaaAuto Adam breakfast")

// 2-> Namespace System.Text.RegularExpressions (Need: Classes (Capture, Group, Regex..), Structs (Value match), Enums(RegexOptions), Delegates(MatchEvaluator) );

// 3-> .NET regular expressions 

// 4-> Regular expression object model

using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Globalization;
using System.ComponentModel;
using System.Linq.Expressions;
using System;
using System.Data.SqlTypes;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.IO.Compression;

namespace RegexDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //string pattern = "^Tim";//if start with "^Tim"
            //string toSearch = "Farid";
            //string pattern = @"\sTim\s";
            //string pattern = @"(\s|^)Tim\s"; //C sharp will turn this into a pattern a high level pattern
            ////if we want ignore case
            //Console.WriteLine(Regex.IsMatch("Timo", pattern));
            //Console.WriteLine(Regex.IsMatch("SomeTimes", pattern));
            //Console.WriteLine(Regex.IsMatch("I am Tim curry", pattern));

            //string toSearch = File.ReadAllText(path: "C:\\C#\\RegexDemo\\test.txt");
            //////string pattern = "dolores";
            ////string pattern = @"\d{3}-\d{3}-\d{4}"; //444-555-1078 (444) 555-1078
            //////This pattern matches phone nubmers in the following patterns
            //string pattern = @"\(?\d{3}\)?(-|.|\s)?\d{3}(-|.)?\d{4}";
            //MatchCollection matches = Regex.Matches(toSearch, pattern);

            //foreach (Match match in matches)
            //{
            //    Console.WriteLine(match.Value);
            //}
            //Stopwatch stopwatch = new();
            //stopwatch.Start();
            ////Regex test = new Regex(pattern); //instantiated compiled every time... if we dont instantiated it will never cached
            //Regex test = new Regex(pattern, RegexOptions.Compiled); //compiled version
            //for (int i = 0; i < 100000; i++)
            //{
            //    Regex.IsMatch("I am Tim Curry", pattern, RegexOptions.IgnoreCase);
            //    // test.IsMatch("I am Tim Curry"); //cached if we use second test object
            //}
            //stopwatch.Stop();

            //Console.WriteLine($"Time Elapsed in ms:  {stopwatch.ElapsedMilliseconds}");

            //............................................................................................................................

            //Example 1: Replace substrings

            //string pattern = "(Mr\\.? |Mrs\\.? |Miss |Ms\\.? )";
            //string[] names = { "Mr. Henry Hunt", "Ms. Sara Samuels",
            //             "Abraham Adams", "Ms. Nicole Norris" };
            //foreach (string name in names)
            //    Console.WriteLine(Regex.Replace(name, pattern, String.Empty));

            //The example displays the following output:
            //    Henry Hunt
            //    Sara Samuels
            //    Abraham Adams
            //    Nicole Norris

            //............................................................................................................................

            // Example 2: Identify duplicated words

            //string pattern = @"\b(\w+?)\b";
            //string input = "This this is a nice day. What about this? This tastes good. I saw a a dog.";
            //foreach (Match match in Regex.Matches(input, pattern, RegexOptions.IgnoreCase))
            //    Console.WriteLine("{0} (duplicates '{1}') at position {2}",
            //                      match.Value, match.Groups[1].Value, match.Index);

            // The example displays the following output:
            //       This this (duplicates 'This') at position 0
            //       a a (duplicates 'a') at position 66

            //............................................................................................................................

            //3-> Regular expression object model

            // -> The regular expression engine, ->The matchcollection and match objects, ->The group collection, ->The captured collection, ->The individual capture

            // Matching a Regular Expression Pattern
            //The Regex.IsMatch method returns true if the string matches the pattern, 
            //or false if it does not.The IsMatch method is often used to validate string input. 
            //For example, the following code ensures that a string matches a valid social security number in the United States.

            //string[] values = { "111-22-3333", "111-2-3333" };
            ////[0-9a- ZA - Z]+ //a123AZ
            //string pattern = @"^\d{3}-\d{2}-\d{4}$";
            //foreach (string value in values)
            //{
            //    if (Regex.IsMatch(value, pattern))
            //        Console.WriteLine("{0} is a valid SSN.", value);
            //    else
            //        Console.WriteLine("{0}: Invalid", value);
            //}

            // The example displays the following output:
            //       111-22-3333 is a valid SSN.
            //       111-2-3333: Invalid

            //............................................................................................................................


            //Extracting All Matches

            //The Regex.Matches method returns a MatchCollection object that contains information
            //about all matches that the regular expression engine found in the input string.For example, 
            //the previous example could be rewritten to call the Matches method instead of the Match and NextMatch methods.

            //string input = "This is a a farm that that raises % dairy cattle.";
            //string pattern = @"(\w+)\W+(\1)";
            //    foreach (Match match in Regex.Matches(input, pattern))
            //        Console.WriteLine("Duplicate '{0}' found at position {1}.",
            //                          match.Groups[1].Value, match.Groups[2].Index);
            // The example displays the following output:
            //       Duplicate 'a' found at position 10.
            //       Duplicate 'that' found at position 22.
            //............................................................................................................................


            //The Regex.Replace method replaces each substring that matches the regular 
            //expression pattern with a specified string or regular expression pattern,
            //and returns the entire input string with replacements.
            //For example, the following code adds a U.S.currency symbol before a decimal number in a string.

            // Replace a mathced substring 

            //string pattern = @"\b\d+[\.\d{2}]?\b";
            ////1st input: 103
            ////$100,000
            ////$100,000.00
            ////output: 100000
            ////
            //string replacement = "$$$&";
            ////string input = "Total Cost: 103.64";
            //string input = "$100,000.00";
            //string pattern = @"\$|,|\.";
            //string replacement = "";
            //string output = Regex.Replace(input, pattern, replacement);
            //Console.WriteLine(output); // 100000

            //Task
            //string[] values = { "$103", "$103,64.00" };
            //string pattern = @"\$|,|\.";
            //string replacement = "";
            //foreach (var value in values)
            //{
            //    string s = Regex.Replace(value, "\\$", replacement);
            //    double ans = double.Parse(s);
            //    int ans1 = (int)ans;
            //    string result = ans1.ToString();

            //    Console.WriteLine(Regex.Replace(result, pattern, replacement));
            //}


            // The example displays the following output:
            //       Total Cost: $103.64

            //............................................................................................................................


            //The Regex.Split method splits the input string at the positions defined by a regular expression match. 
            //    For example, the following code places the items in a numbered list into a string array.

            //Split a single string into an array of strings

            //string input = "10. Eggs 200. Bread 303. Milk 4. Coffee 5. Tea";
            //string pattern = @"\b\d+\.\s";
            //foreach (string item in Regex.Split(input, pattern))
            //{
            //    if (!String.IsNullOrEmpty(item))
            //        Console.WriteLine(item);
            //}

            // The example displays the following output:
            //       Eggs
            //       Bread
            //       Milk
            //       Coffee
            //       Tea     111-2-3333: Invalid

            //............................................................................................................................

            //The Match Collection

            //MatchCollection matches;
            //List<string> results = new List<string>();
            //List<int> matchposition = new List<int>();

            //////Create a new Regex object and define the regular expression.
            //Regex r = new Regex("abc");
            //// Use the Matches method to find all matches in the input string.
            //matches = r.Matches("123abc4abcd");
            //// Enumerate the collection to retrieve all matches and positions.
            //foreach (Match match in matches)
            //{
            //    // Add the match string to the string array.
            //    results.Add(match.Value);
            //    // Record the character position where the match was found.
            //    matchposition.Add(match.Index);
            //}
            //// List the results.
            //for (int ctr = 0; ctr < results.Count; ctr++)
            //    Console.WriteLine("'{0}' found at position {1}.",
            //                      results[ctr], matchposition[ctr]);

            //// The example displays the following output:
            ////       'abc' found at position 3.
            ////       'abc' found at position 7.
            ///

            //............................................................................................................................

            //Match collection

            //string pattern = "abc";
            //string input = "abc123abc456abc789";
            //foreach (Match match in Regex.Matches(input, pattern))
            //    Console.WriteLine("{0} found at position {1}.",
            //                      match.Value, match.Index);

            //The example displays the following output:
            //       abc found at position 0.
            //       abc found at position 6.
            //       abc found at position 12.

            //............................................................................................................................

            //Another procedure of match collection
            //string pattern = "abc";
            //string input = "abc123abc456abc789";
            //Match match = Regex.Match(input, pattern);
            //while (match.Success)
            //{
            //    Console.WriteLine("{0} found at position {1}.",
            //                      match.Value, match.Index);
            //    match = match.NextMatch();
            //}

            //............................................................................................................................

            //Group Collection

            //string pattern = @"\b(\w+)\s(\d{1,2}),\s(\d{4})\b";
            //string input = "Born: July $ 28, 1989";
            //Match match = Regex.Match(input, pattern);
            //if (match.Success)
            //    for (int ctr = 0; ctr < match.Groups.Count; ctr++)
            //        Console.WriteLine("Group {0}: {1}", ctr, match.Groups[ctr].Value);

            // The example displays the following output:
            //       Group 0: July 28, 1989
            //       Group 1: July
            //       Group 2: 28
            //       Group 3: 1989

            //............................................................................................................................

            // The Captured Group
            // var matchposition = new List<int>();
            // var results = new List<string>();
            // Define substrings abc, ab, b.
            //var r = new Regex("(a(b))c");
            // Match m = r.Match("abdabc");
            // int count = 0;
            // for (int i = 0; m.Groups[i].Value != ""; i++)
            // {
            //     count++;
            //     Add groups to string array.
            //     results.Add(m.Groups[i].Value);
            //     Record character position.
            //    matchposition.Add(m.Groups[i].Index);
            // }
            // Console.WriteLine(count);

            // Display the capture groups.
            // for (int ctr = 0; ctr < results.Count; ctr++)
            //     Console.WriteLine("{0} at position {1}",
            //                       results[ctr], matchposition[ctr]);
            // The example displays the following output:
            //       abc at position 3
            //       ab at position 3
            //       b at position 4

            //............................................................................................................................
            //The following example uses named grouping constructs
            //to capture substrings from a string that contains
            //data in the format "DATANAME:VALUE",
            //which the regular expression splits at the colon (:).

            //var r = new Regex(@"^(?<name>\w+):(?<value>\w+)");
            //Match m = r.Match("Section1:119900,Section2:119900");
            //Console.WriteLine(m.Groups["name"].Value);
            //Console.WriteLine(m.Groups["value"].Value);
            //The example displays the following output:
            ////       Section1
            ////       119900
            //............................................................................................................................

            //string pattern = "aaa(bbb)*ccc";
            //string input = "aaaccc";
            //Match match = Regex.Match(input, pattern);
            //Console.WriteLine("Match value: {0}", match.Value);
            //if (match.Groups[1].Success)
            //    Console.WriteLine("Group 1 value: {0}", match.Groups[1].Value);
            //else
            //    Console.WriteLine("The first capturing group has no match.");

            // The example displays the following output:
            //       Match value: aaaccc
            //       The first capturing group has no match.
            //............................................................................................................................
            //The Capture Collection

            //string pattern = "((a(b))c)+";
            //string input = "abcabcabc";

            //Match match = Regex.Match(input, pattern);
            //if (match.Success)
            //{
            //    Console.WriteLine("Match: '{0}' at position {1}",
            //                      match.Value, match.Index);
            //    GroupCollection groups = match.Groups;
            //    Console.WriteLine(groups.Count);
            //    Console.WriteLine();
            //    for (int ctr = 0; ctr < groups.Count; ctr++)
            //    {
            //        Console.WriteLine("   Group {0}: '{1}' at position {2}",
            //                          ctr, groups[ctr].Value, groups[ctr].Index);
            //        CaptureCollection captures = groups[ctr].Captures;
            //        for (int ctr2 = 0; ctr2 < captures.Count; ctr2++)
            //        {
            //            Console.WriteLine("      Capture {0}: '{1}' at position {2}",
            //                              ctr2, captures[ctr2].Value, captures[ctr2].Index);
            //        }
            //    }
            //}

            // The example displays the following output:
            //       Match: 'abcabcabc' at position 0
            //          Group 0: 'abcabcabc' at position 0
            //             Capture 0: 'abcabcabc' at position 0
            //          Group 1: 'abc' at position 6
            //             Capture 0: 'abc' at position 0
            //             Capture 1: 'abc' at position 3
            //             Capture 2: 'abc' at position 6
            //          Group 2: 'ab' at position 6
            //             Capture 0: 'ab' at position 0
            //             Capture 1: 'ab' at position 3
            //             Capture 2: 'ab' at position 6
            //          Group 3: 'b' at position 7
            //             Capture 0: 'b' at position 1
            //             Capture 1: 'b' at position 4
            //             Capture 2: 'b' at position 7

            //............................................................................................................................

            //The following example uses the regular expression
            //(Abc)+ to find one or more consecutive runs of the
            //string "Abc" in the string "XYZAbcAbcAbcXYZAbcAb".
            //The example illustrates the use of the Group.
            //Captures property to return multiple groups of captured substrings.

            //int counter;
            //Match m;
            //CaptureCollection cc;
            //GroupCollection gc;

            //// Look for groupings of "Abc".
            //var r = new Regex("(Abc)+");
            //// Define the string to search.
            //m = r.Match("XYZAbcAbcAbcXYZAbcAb");
            //gc = m.Groups;

            //// Display the number of groups.
            //Console.WriteLine("Captured groups = " + gc.Count.ToString());

            //// Loop through each group.
            //for (int i = 0; i < gc.Count; i++)
            //{
            //    cc = gc[i].Captures;
            //    counter = cc.Count;

            //    // Display the number of captures in this group.
            //    Console.WriteLine("Captures count = " + counter.ToString());

            //    // Loop through each capture in the group.
            //    for (int ii = 0; ii < counter; ii++)
            //    {
            //        // Display the capture and its position.
            //        Console.WriteLine(cc[ii] + "   Starts at character " +
            //             cc[ii].Index);
            //    }
            //}
            // The example displays the following output:
            //       Captured groups = 2
            //       Captures count = 1
            //       AbcAbcAbc   Starts at character 3
            //       Captures count = 3
            //       Abc   Starts at character 3
            //       Abc   Starts at character 6
            //       Abc   Starts at character 9

            //............................................................................................................................

            //The following example parses an input string for the temperature
            //of selected cities. A comma (",") is used to separate a city and
            //its temperature, and a semicolon (";") is used to separate each city's data.
            //The entire input string represents a single match.
            //In the regular expression pattern ((\w+(\s\w+)*),(\d+);)+,
            //which is used to parse the string, the city name is assigned
            //to the second capturing group, and the temperature is assigned to the fourth capturing group.

            //Individual Capture

            //string input = "Miami,78;Chicago,62;New York,67;San Francisco,59;Seattle,58;";
            //string pattern = @"((\w+(\s\w+)*),(\d+);)+";
            //Match match = Regex.Match(input, pattern);
            //if (match.Success)
            //{
            //    Console.WriteLine("Current temperatures:");
            //    for (int ctr = 0; ctr < match.Groups[2].Captures.Count; ctr++)
            //        Console.WriteLine("{0,-20} {1,3}", match.Groups[2].Captures[ctr].Value,
            //                          match.Groups[4].Captures[ctr].Value);
            //}

            // The example displays the following output:
            //       Current temperatures:
            //       Miami                 78
            //       Chicago               62
            //       New York              67
            //       San Francisco         59
            //       Seattle               58

            //............................................................................................................................


            //Extra Problems 

            //The following example uses a regular expression to check for repeated occurrences of words in a string.
            //The regular expression \b(?<word>\w+)\s+(\k<word>)\b can be interpreted as shown in the following table.

            // Define a regular expression for repeated words.
            //Regex rx = new Regex(@"\b(?<word>\w+)\s+(\k<word>)\b",
            //RegexOptions.Compiled | RegexOptions.IgnoreCase);

            //// Define a test string.
            //string text = "The the quick brown brown fox  fox jumps over the lazy dog dog.";

            ////Find matches.
            //MatchCollection matches = rx.Matches(text);

            //////Report the number of matches found.
            ////Console.WriteLine("{0} matches found in:\n   {1}",
            ////                  matches.Count,
            ////                  text);
            ////foreach(Match match in matches)
            ////{
            ////    Console.WriteLine(match);
            ////}

            ////............................................................................................................................

            //// Report on each match.
            //foreach (Match match in matches)
            //{
            //    GroupCollection groups = match.Groups;
            //    Console.WriteLine("'{0}' repeated at positions {1} and {2}",
            //                      groups["word"].Value,
            //                      groups[0].Index,
            //                      groups[1].Index);
            //}

            // The example produces the following output to the console:
            //       3 matches found in:
            //          The the quick brown fox  fox jumps over the lazy dog dog.
            //       'The' repeated at positions 0 and 4
            //       'fox' repeated at positions 20 and 25
            //       'dog' repeated at positions 49 and 53

            //............................................................................................................................

            //The following example illustrates the use of a regular expression to check whether
            //a string either represents a currency value or has the correct
            //format to represent a currency value. 


            // Get the en-US NumberFormatInfo object to build the regular 
            // expression pattern dynamically.
            //NumberFormatInfo nfi = CultureInfo.GetCultureInfo("en-US").NumberFormat;

            //       Pattern is ^\s*[\+-]?\s?\$?\s?(\d*\.?(\d{2})?){1}$
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

            //Regex rgx = new Regex(pattern);

            //// Define some test strings.
            //string[] tests = { "-42", "19.99", "0.001", "100 USD",
            //             ".34", "0.34", "1,052.21", "$10.62",
            //             "+1.43", "-$0.23" };

            //// Check each test string against the regular expression.
            //foreach (string test in tests)
            //{
            //    if (rgx.IsMatch(test))
            //        Console.WriteLine($"{test} is a currency value.");
            //    else
            //        Console.WriteLine($"{test} is not a currency value.");
            //}


            // The example displays the following output:

            //
            //       -42 is a currency value.
            //       19.99 is a currency value.
            //       0.001 is not a currency value.
            //       100 USD is not a currency value.
            //       .34 is a currency value.
            //       0.34 is a currency value.
            //       1,052.21 is not a currency value.
            //       $10.62 is a currency value.
            //       +1.43 is a currency value.
            //       -$0.23 is a currency value.
            //............................................................................................................................

            //string pattern = @"\b((\w+)\s?)+\.";

            //string input = "This is a sentence. This is another sentence.";

            //Match match = Regex.Match(input, pattern);
            //if (match.Success)
            //{
            //    Console.WriteLine("Match: " + match.Value);
            //    Console.WriteLine("Group 0: " + match.Groups[0].Value);
            //    Console.WriteLine("Group 1: " + match.Groups[1].Value);


            //}

            //// The example displays the following output:
            //       Match: This is a sentence.
            //       Group 2: sentence

            //............................................................................................................................

            //// Validate email address
            //string email = "faridul.islam@welldev.io";
            //Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            //Match match = regex.Match(email);
            //if (match.Success)
            //    Console.WriteLine(email + " is correct");
            //else
            //    Console.WriteLine(email + " is incorrect");
            //.............................................................................................................................
            //Stopwatch sw;
            //string[] addresses = { "AAAAAAAAAAA@contoso.com",
            //                 "AAAAAAAAAAaaaaaaaaaa!@contoso.com" };
            //// The following regular expression should not actually be used to
            //// validate an email address.
            //string pattern = @"^[0-9A-Z]([-.\w]*[0-9A-Z])*$";
            //string input;

            //foreach (var address in addresses)
            //{
            //    string mailBox = address.Substring(0, address.IndexOf("@"));
            //    int index = 0;
            //    for (int ctr = mailBox.Length - 1; ctr >= 0; ctr--)
            //    {
            //        index++;
            //        //Console.WriteLine(index);
            //        input = mailBox.Substring(ctr, index);
            //        sw = Stopwatch.StartNew();
            //        Match m = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
            //        sw.Stop();
            //        if (m.Success)
            //            Console.WriteLine("{0,2}. Matched '{1,25}' in {2}",
            //                              index, m.Value, sw.Elapsed);
            //        else
            //            Console.WriteLine("{0,2}. Failed  '{1,25}' in {2}",
            //                              index, input, sw.Elapsed);
            //    }
            //    Console.WriteLine();

            //}
            //............................................................................................................................

            //Everything is in one

            //string input = "This is one sentence. This is another.";
            //string pattern = @"\b(\w+[;,]?\s?)+[.?!]";

            //foreach (Match match in Regex.Matches(input, pattern))
            //{
            //    Console.WriteLine("Match: '{0}' at index {1}.",
            //                      match.Value, match.Index);
            //    int grpCtr = 0;
            //    foreach (Group grp in match.Groups)
            //    {
            //        Console.WriteLine("   Group {0}: '{1}' at index {2}.",
            //                          grpCtr, grp.Value, grp.Index);
            //        int capCtr = 0;
            //        foreach (Capture cap in grp.Captures)
            //        {
            //            Console.WriteLine("      Capture {0}: '{1}' at {2}.",
            //                              capCtr, cap.Value, cap.Index);
            //            capCtr++;
            //        }
            //        grpCtr++;
            //    }
            //    Console.WriteLine();
            //}

            // The example displays the following output:
            //       Match: 'This is one sentence.' at index 0.
            //          Group 0: 'This is one sentence.' at index 0.
            //             Capture 0: 'This is one sentence.' at 0.
            //          Group 1: 'sentence' at index 12.
            //             Capture 0: 'This ' at 0.
            //             Capture 1: 'is ' at 5.
            //             Capture 2: 'one ' at 8.
            //             Capture 3: 'sentence' at 12.
            //
            //       Match: 'This is another.' at index 22.
            //          Group 0: 'This is another.' at index 22.
            //             Capture 0: 'This is another.' at 22.
            //          Group 1: 'another' at index 30.
            //             Capture 0: 'This ' at 22.
            //             Capture 1: 'is ' at 27.
            //             Capture 2: 'another' at 30.

            //string input = "Hello, World!";
            //string pattern = @"^\b\w+[,\s]\w+[!,?]";

            //if(Regex.IsMatch(input, pattern, RegexOptions.IgnoreCase))
            //{
            //    Console.WriteLine("Okay");
            //}
            //else
            //{
            //    Console.WriteLine("Not okay");
            //}

        }
    }
}