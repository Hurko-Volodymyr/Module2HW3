using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class MilkChokоlateSweet : ContentedSweet
    {
        public MilkChokоlateSweet(string name, int weight) : base(name, weight)
        {
        }
        public void HaveDarkChokоlateContent()
        {
            Console.WriteLine($"{Name} has milk chocolate content");
        }
    }
}
