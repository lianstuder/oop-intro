using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RechteckFlaeche
{
    class Rect
    {
        private int length;
        private int width;

        public Rect(string length, string width)
        {
            if (!int.TryParse(width, out this.width) || 
                !int.TryParse(length, out this.length))
            {
                throw new Exception("Input has to be a number");
            }
        }

        public int getArea()
        {
            return length * width;
        }
    }
}
