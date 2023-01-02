namespace Structs__Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Instatiating Structs
            //1st way
            //var coach = new Coach();
            //Console.WriteLine(coach.Name); //Null
            //Console.WriteLine(coach.YearsCoaching); //0

            //2nd way
            //var coach2 = new Coach() //This is called inline instantiation
            //{
            //    Name = "John Smith",
            //    YearsCoaching = 12
            //};
            //Console.WriteLine(coach2.Name);
            //Console.WriteLine(coach2.YearsCoaching);

            //3rd way
            //var coach3 = new Coach("Elaine Harkness", 6);

            //Console.WriteLine(coach3.Name); //Elaine Harkness
            //Console.WriteLine(coach3.YearsCoaching); //6
            //var player = new Player();
            //player.Name = "Alex Hampton";
            //player.YearsPlaying = 2;
            //Console.WriteLine(player.Name);
            //Console.WriteLine(player.YearsPlaying);

            //Readonly Struct
            //var readonlyPlayer = new ReadonlyPlayer("Matt", 1);
            //Console.WriteLine(readonlyPlayer.Name);
            //Console.WriteLine(readonlyPlayer.TurnOrder);

            //Readonly instance members

            var player = new Player("Matt", 1);
            Console.WriteLine(player.GetCustomDisplay());
        }
    }
    //public struct Player
    //{
    //    public string Name { get; set; }
    //    public int YearsPlaying { get; set; }

    //    public Player(string name, int yearsPlaying)
    //    {
    //        Name = name;
    //        YearsPlaying = yearsPlaying;
    //    }
    //}
    //Instantiating Structs
    //1st way
    //public struct Coach
    //{
    //    public string Name { get; set; }
    //    public int YearsCoaching { get; set; }
    //}

    //2nd way

    //public struct Coach
    //{
    //    public string Name { get; set; }
    //    public int YearsCoaching { get; set; }
    //}

    //3rd way
    //public struct Coach
    //{
    //    public string Name { get; set; }
    //    public int YearsCoaching { get; set; }

    //    public Coach(string name, int years)
    //    {
    //        Name = name;
    //        YearsCoaching = years;
    //    }
    //}

    // Readonly Struct

    //public readonly struct ReadonlyPlayer
    //{
    //    public string Name { get; } //No setter methods!
    //    public int TurnOrder { get; }

    //    public ReadonlyPlayer(string name, int turnOrder)
    //    {
    //        Name = name;
    //        TurnOrder = turnOrder;
    //    }
    //}

    //Readonly Instance Members

    public readonly struct Player
    {
        public string Name { get; }
        public int TurnOrder { get; }

        public Player(string name, int turnOrder)
        {
            Name = name;
            TurnOrder = turnOrder;
        }

        public readonly string GetCustomDisplay()
        {
            return Name + " will play in position #" + TurnOrder.ToString();
        }
    }

}