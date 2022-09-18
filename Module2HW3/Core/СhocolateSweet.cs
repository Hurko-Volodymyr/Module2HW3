using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class СhocolateSweet : ContentedSweet
    {
        public СhocolateSweet(string name, int weight) : base(name, weight)
        {
        }
        public void HaveChokоlateContent()
        {
            Console.WriteLine($"{Name} has chocolate content");
        }
    }
}
