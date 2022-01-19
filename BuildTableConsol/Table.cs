using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassAndEnum
{
    enum Color
    {
        Red = 1,
        Broun,
        Whine
    }
    enum Material
    {
        Wood = 1,
        Glass,
        Steel
    }
    enum Legs
    {
        Three = 1,
        Four,
        Five
    }
    class Table
    {
        public Material material;
        public Color color;
        public Legs legs;
    }
}
