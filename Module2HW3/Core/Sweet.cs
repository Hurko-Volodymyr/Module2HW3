using System;

namespace Core
{
    public abstract class Sweet
    {
        public Sweet(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; set; }
        public int Weight { get; set; }

        public void BeEaten()
        {
            Console.WriteLine($"{Name} has been eaten");
        }
    }
}
