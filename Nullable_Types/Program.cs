namespace Nullable_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // int? - nullable value type
            // string? - nullable reference type
            // Id?.ToString(); - null conditional operator
            // var v = i ?? 0; - null coalescing operator
            // (numbers ??= new()).Add(8); - null coalescing assignment operator
            // s!.ToString() - null forgiving operator

            Console.WriteLine("Hello, World!");
            Nullable<bool> i = true;
            Console.WriteLine(i.GetValueOrDefault());
            //Console.WriteLine(i);
            //int? x = null; //this question mark makes value type to nullable
            //Console.WriteLine(x);
            //#nullable enable
            string? s = null; //reference type are already nullable
            //string? t = "WellDev is Awesome!";
            string t = s ?? "Hello world!";
            Console.WriteLine(value: $"The value of t is {t}");
            //s = Console.ReadLine();
            //Console.WriteLine(s);
            //s = Console.ReadLine();
            //Console.WriteLine(s!.Length); //! use just for igonoring invalid warning
            //Console.WriteLine(s);
            PersonModel? p = null; //by default they dont mention any reference so it is null
                                   //p = new();
                                   //p.Name = "Tim";
            p = new();

            //if p is not null && p.Name is not null && p.Name.Length > 0
            if (p?.Name?.Length > 0)
            {
                Console.WriteLine(p.Name.Length);
            }
            else
            {
                Console.WriteLine(value: "This was false");
            }
            //Console.WriteLine(p);

            //PersonModel? test1 = new(); //if we use ? aftere personmodel then in Nullable type project nullable using must be enable
            //                           // if we dont then disable is okay, if we want both then annotations is fine
            //test1.Name = "Tim";
            //PersonModel? test2 = test1;
            //test2.Name = "Sue";

            //Console.WriteLine(test1.Name);
            //Console.WriteLine(test2.Name);
        }
    }
}