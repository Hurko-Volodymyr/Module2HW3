namespace Module2HW3
{
    using Core;
    using NewYearGift;

    /// <summary>
    /// Main Program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Starts the App.
        /// </summary>
        /// <param name="args">console call params.</param>
        private static void Main(string[] args)
        {
            Console.WriteLine("Hовогодний подарок");

            var milk1 = new MilkChokоlateSweet("Classic Milka", 30);
            var milk2 = new MilkChokоlateSweet("Blue Milka", 100);
            var milk3 = new MilkChokоlateSweet("Yellow Milka", 80);

            var dark1 = new DarkChokоlateSweet("Classic Millenium", 90);
            var dark2 = new DarkChokоlateSweet("Exotic Millenium", 88);
            var dark3 = new DarkChokоlateSweet("Old Millenium", 136);

            dark3.BeEaten();

            var gifts = new Gift();
            gifts.AddGift(milk1);
            gifts.AddGift(milk2);
            gifts.AddGift(milk3);
            gifts.AddGift(dark1);
            gifts.AddGift(dark2);
            gifts.AddGift(dark3);
            var sortedGift = gifts.SortByWeight();
            var totalWeight = 0;

            Console.WriteLine("Sorted by weight sweets: ");

            foreach (var sweet in sortedGift)
            {
                sweet.WriteSweet();
                totalWeight += sweet.Weight;
            }

            Console.WriteLine($"Total weight: {totalWeight}");

            var soughtSweet = gifts.FindGiftByName("Classic Millenium");
            Console.WriteLine($"Sought sweet: {soughtSweet.Name}");
        }
    }
}