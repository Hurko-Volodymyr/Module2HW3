using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ContentedSweet : Sweet, IBeEaten
    {
        protected ContentedSweet(string name, int weight) : base(name, weight)
        {
        }
        public void HaveContent()
        {
            Console.WriteLine($"{Name} has content");
        }
    }
}
