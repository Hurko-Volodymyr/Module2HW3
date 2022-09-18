using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core
{
    public class Gift
    {
        private readonly List<Sweet> _sweets = new ();

        public void AddGift(Sweet sweet)
        {
            _sweets.Add(sweet);
        }
        public Sweet FindGiftByName(string name)
        {
            return _sweets.FirstOrDefault(sweet => sweet.Name == name);
        }

        public List<Sweet> SortByWeight()
        {
            return _sweets.OrderBy(sweet => sweet.Weight).ToList();
        }
    }
}

