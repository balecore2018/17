using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace else_no_fix_ya_go_to_home.Classes
{
    public class Dish
    {
        public int id;
        public string name;
        public List<Sizes> sizes = new List<Sizes>();
        public string description;

        public int activeSize = 0;
        
        public class Sizes
        {
            public int id;
            public int id_size;
            public int size;
            public int price;
            public int wes;

            public int countOrder;
            public bool orders;
        }

        public class Ingredient
        {
            public int id; public string name; public int wes; public int price;
            public string img;
            public int count;
        }
    }
}
