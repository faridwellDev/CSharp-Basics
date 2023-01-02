using System.Globalization;
using System.Text;
using System;
// string is a reference type
// Strings are immutable--the contents of 
//a string object can't be changed after the object is created

//Console.WriteLine("Hello, World!");
//string str = "Farid_123@gmail.com\'0'";
//StringInfo st = new StringInfo(str);
//Console.WriteLine(str.Length);

//var message = """
//"This is a very important message."
//""";
//Console.WriteLine(message);

//string s1 = "A string is more ";
//Console.WriteLine(s1.GetHashCode());
//string s2 = "than the sum of its chars.";
//Console.WriteLine(s2.GetHashCode());
//// Concatenate s1 and s2. This actually creates a new
//// string object and stores it in s1, releasing the
//// reference to the original object.
//s1 += s2;
//Console.WriteLine(s1.GetHashCode());
//System.Console.WriteLine(s1);
//// Output: A string is more than the sum of its chars.
///
//        string singleLine = """Friends say "hello" as they pass by.""";
//        string multiLine = """
//"Hello World!" is typically the first program someone writes.
//""";
//        Console.WriteLine(singleLine);
//        Console.WriteLine(multiLine);
//        string embeddedXML = """
//   <element attr = "content">
//       <body style="normal">
//           Here is the main text
//       </body>
//       <footer>
//           Excerpts from "An amazing story"
//       </footer>
//   </element >
//   """;
//        Console.WriteLine(embeddedXML);
//        // The line "<element attr = "content">" starts in the first column.
//        // All whitespace left of that column is removed from the string.

//        string rawStringLiteralDelimiter = """"
//Raw string literals are delimited 
//by a string of at least three double quotes,
//like this: """
//"""";
//        Console.WriteLine(rawStringLiteralDelimiter);

//string jsonString = """
//{
//      "Date": "2019-08-01T00:00:00-07:00",
//      "TemperatureCelsius": 25,
//      "Summary": "Hot",
//      "DatesAvailable": [
//        "2019-08-01T00:00:00-07:00",
//        "2019-08-02T00:00:00-07:00"
//      ],
//      "TemperatureRanges": {
//        "Cold": {
//          "High": 20,
//          "Low": -10
//        },
//        "Hot": {
//          "High": 60,
//          "Low": 20
//        }
//                },
//      "SummaryWords": [
//        "Cool",
//        "Windy",
//        "Humid"
//      ]
//}
//""";
//Console.WriteLine(jsonString);
//Console.WriteLine("\'");

//Dictionary

//var inventory = new Dictionary<string, int>()
//{   
//    ["hammer, ball pein"] = 18,
//    ["hammer, cross pein"] = 5,
//    ["screwdriver, Philips #2"] = 14
//};

//Console.WriteLine($"Inventory on {DateTime.Now:d}");
//Console.WriteLine(" ");
//Console.WriteLine($"|{"Item",-25}|{"Quantity",10}|");
//foreach(var item in inventory )
//{
//    Console.WriteLine($"|{item.Key, -25}|{item.Value, 10}|");
//}

//String interpolation

//var jh = (firstName: "Jupiter", lastName: "Hammon", born: 1711, published: 1761);
//Console.WriteLine($"{jh.firstName} {jh.lastName} was an African poet born in {jh.born}.");
//Console.WriteLine($"He was first published in {jh.published} at the age of {jh.published - jh.born}.");

//Console.WriteLine($"He'd be over {Math.Round((2018d - jh.born) / 100d) * 100d} years old today.");

// Output:
// Jupiter Hammon was an African American poet born in 1711.
// He was first published in 1761 at the age of 50.
// He'd be over 300 years old today.

//int X = 2;
//int Y = 3;

//var pointMessage = $$""" The point {{{X}}, {{Y}}} is {{Math.Sqrt(X * X + Y * Y)}} from the origin.""";
//Console.WriteLine(pointMessage);

//var pw = (firstName: "Philips", lastName: "Wheatley", born: 1753, published: 1773);

//string s3 = "Visual C# Express";
//Console.WriteLine(s3.Substring(7, 2));

//Console.WriteLine(s3.Replace("C#", "Basic"));

//int index = s3.IndexOf("C");
//Console.WriteLine(index);

//string s5 = "Printing backwards";

//int n = s5.Length;

//for(int i = 0; i < n; i++)
//{
//    Console.Write(s5[n-i-1]);
//}

//string question = "How DoES miCroSOFT woRD DEAL with THe caPs LOCK KEY?";

//StringBuilder sb = new StringBuilder(question);

//for(int i = 0; i < sb.Length; i++)
//{
//    if (char.IsLower(sb[i]) == true)
//    {
//        sb[i] = char.ToUpper(sb[i]);
//    }
//    else if (char.IsUpper(sb[i]) == true)
//    {
//        sb[i] = char.ToLower(sb[i]);
//    }
//}

//string corrected = sb.ToString();
//Console.WriteLine(corrected);

//string str = "hello";
//string nullStr = null;
//string emptyStr = String.Empty;

//string tempStr = str + nullStr;
//// Output of the following line: hello
//Console.WriteLine(tempStr);

//bool b = (emptyStr == nullStr);
//// Output of the following line: False
//Console.WriteLine(b);

//// The following line creates a new empty string.
//string newStr = emptyStr + nullStr;

//// Null strings and empty strings behave differently. The following
//// two lines display 0.
//Console.WriteLine(emptyStr.Length);
//Console.WriteLine(newStr.Length);
//// The following line raises a NullReferenceException.
////Console.WriteLine(nullStr.Length);

//// The null character can be displayed and counted, like other chars.
//string s1 = "\x0" + "abc";
//string s2 = "abc" + "\x0";
//// Output of the following line: * abc*
//Console.WriteLine("*" + s1 + "*");
//// Output of the following line: *abc *
//Console.WriteLine("*" + s2 + "*");
//// Output of the following line: 4
//Console.WriteLine(s2.Length);

//StringBuilder sb = new StringBuilder("Rat: the ideal pet");
//sb[0] = 'C';
//Console.WriteLine(sb.ToString());

//var sb = new StringBuilder();

//for(int i = 0; i< 10; i++)
//{
//    sb.Append(i.ToString());
//}

//Console.WriteLine(sb);

//sb[0] = sb[9];
//Console.WriteLine(sb);


// Type checking
// How to determine whether a string represents a numeric value (C# Programming Guide)

//double i = 0;
//string s = "108.004";
//bool result = double.TryParse(s, out i);
//if (result)
//{
//    Console.WriteLine("String contains numeric value");
//}
//else
//{
//    Console.WriteLine("String doesn't contain numeric value");
//}

//string numString = "1287543"; //"1287543.0" will return false for a long
//long number1 = 0;
//bool canConvert = long.TryParse(numString, out number1);
//if (canConvert == true)
//    Console.WriteLine("number1 now = {0}", number1);
//else
//    Console.WriteLine("numString is not a valid long");

//byte number2 = 0;
//numString = "255"; // A value of 256 will return false
//canConvert = byte.TryParse(numString, out number2);
//if (canConvert == true)
//    Console.WriteLine("number2 now = {0}", number2);
//else
//    Console.WriteLine("numString is not a valid byte");

//Check whether a value es non numeric
//decimal number3 = 0;
//numString = "27.3"; //"27" is also a valid decimal
//canConvert = decimal.TryParse(numString, out number3);
//if (canConvert == true)
//    Console.WriteLine("number3 now = {0}", number3);
//else
//    Console.WriteLine("number3 is not a valid decimal");

//string s = "123";

//Console.WriteLine(double.TryParse(s,out double value));

//int numInt = 500;

////get typeof numInt;

////Implicit version

//Type n = numInt.GetType();

//double numDouble = numInt;

//Type n1 = numDouble.GetType();

//Console.WriteLine("numInt value: " + numInt);
//Console.WriteLine("numInt Type: " + n);

////value after conversion
//Console.WriteLine("numDouble value: " + numDouble);
//Console.WriteLine("numDouble Type: " + n1);
//Console.WriteLine();

//string n = "100";

//int a = int.Parse(n);  //Convert.ToString();

//Console.WriteLine("Original string value: " +n);
//Console.WriteLine("Converted int value: " + a);

//int numVal = -1;

//bool repeat = true;

//while(repeat)
//{
//    Console.WriteLine("Enter a number: ");

//    string input  = Console.ReadLine();

//    try
//    {
//        numVal = Convert.ToInt32(input);
//        if (numVal < Int32.MaxValue)
//        {
//            Console.WriteLine("The new value is {0}", ++numVal);
//        }
//        else
//        {
//            Console.WriteLine("numVal cannot be incremented beyond its current value.");
//        }
//    }

//    catch (FormatException)
//    {
//        Console.WriteLine("Input string is not a sequence of digits");
//    }

//    catch(OverflowException)
//    { 
//        Console.WriteLine("The number cannot fit in an Int32.");
//    }

//    Console.Write("Go again? Y/N: ");
//    string go = Console.ReadLine();

//    if (go.ToUpper() != "Y")
//    {
//        repeat = false;
//    }
//}



//String splits

//string phrase = "The quick brown    fox jumps    over the lazy dog.";
//string[] words = phrase.Split(' ');

//foreach (var word in words)
//{
//    Console.WriteLine($"<{word}>");
//}

//char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

//string text = "one\ttwo three:four,five six seven";
//System.Console.WriteLine($"Original text: '{text}'");

//string[] words = text.Split(delimiterChars);
//System.Console.WriteLine($"{words.Length} words in text:");

//foreach (var word in words)
//{
//    System.Console.WriteLine($"<{word}>");
//}

//String.Split can take an array of strings (character sequences that act as separators for parsing the target string, instead of single characters).

//string[] separatingStrings = { "<<", "..." };

//string text = "one<<two......three<four";
//System.Console.WriteLine($"Original text: '{text}'");

//string[] words = text.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
//System.Console.WriteLine($"{words.Length} substrings in text:");

//foreach (var word in words)
//{
//    System.Console.WriteLine(word);
//}

// This example demonstrates the String.Split() methods that use
// the StringSplitOptions enumeration.
string s1 = ",ONE,,TWO,,,THREE,,";
string s2 = "[stop]" +
            "ONE[stop][stop]" +
            "TWO[stop][stop][stop]" +
            "THREE[stop][stop]";
char[] charSeparators = new char[] { ',' };
string[] stringSeparators = new string[] { "[stop]" };
string[] result;
// ------------------------------------------------------------------------------
// Split a string delimited by characters.
// ------------------------------------------------------------------------------
Console.WriteLine("1) Split a string delimited by characters:\n");

// Display the original string and delimiter characters.
Console.WriteLine($"1a) The original string is \"{s1}\".");
Console.WriteLine($"The delimiter character is '{charSeparators[0]}'.\n");

// Split a string delimited by characters and return all elements.
Console.WriteLine("1b) Split a string delimited by characters and " +
                  "return all elements:");
result = s1.Split(charSeparators, StringSplitOptions.None);
Show(result);

// Split a string delimited by characters and return all non-empty elements.
Console.WriteLine("1c) Split a string delimited by characters and " +
                  "return all non-empty elements:");
result = s1.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
Show(result);

// Split the original string into the string and empty string before the
// delimiter and the remainder of the original string after the delimiter.
Console.WriteLine("1d) Split a string delimited by characters and " +
                  "return 2 elements:");
result = s1.Split(charSeparators, 2, StringSplitOptions.None);
Show(result);

// Split the original string into the string after the delimiter and the
// remainder of the original string after the delimiter.
Console.WriteLine("1e) Split a string delimited by characters and " +
                  "return 2 non-empty elements:");
result = s1.Split(charSeparators, 2, StringSplitOptions.RemoveEmptyEntries);
Show(result);

// ------------------------------------------------------------------------------
// Split a string delimited by another string.
// ------------------------------------------------------------------------------
Console.WriteLine("2) Split a string delimited by another string:\n");

// Display the original string and delimiter string.
Console.WriteLine($"2a) The original string is \"{s2}\".");
Console.WriteLine($"The delimiter string is \"{stringSeparators[0]}\".\n");

// Split a string delimited by another string and return all elements.
Console.WriteLine("2b) Split a string delimited by another string and " +
                  "return all elements:");
result = s2.Split(stringSeparators, StringSplitOptions.None);
Show(result);

// Split the original string at the delimiter and return all non-empty elements.
Console.WriteLine("2c) Split a string delimited by another string and " +
                  "return all non-empty elements:");
result = s2.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
Show(result);

// Split the original string into the empty string before the
// delimiter and the remainder of the original string after the delimiter.
Console.WriteLine("2d) Split a string delimited by another string and " +
                  "return 2 elements:");
result = s2.Split(stringSeparators, 2, StringSplitOptions.None);
Show(result);

// Split the original string into the string after the delimiter and the
// remainder of the original string after the delimiter.
Console.WriteLine("2e) Split a string delimited by another string and " +
                  "return 2 non-empty elements:");
result = s2.Split(stringSeparators, 2, StringSplitOptions.RemoveEmptyEntries);
Show(result);

// Display the array of separated strings using a local function
void Show(string[] entries)
{
    Console.WriteLine($"The return value contains these {entries.Length} elements:");
    foreach (string entry in entries)
    {
        Console.Write($"<{entry}>");
    }
    Console.Write("\n\n");
}


