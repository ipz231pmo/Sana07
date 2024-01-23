using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Screen : Product
    {
        protected int _w, _h;
        public int W
        {
            get => _w;
            set
            {
                if (value < 0)
                    throw new NegativeNumberException();
                _w = value;
            }
        }
        public int H
        {
            get => _h;
            set
            {
                if (value < 0)
                    throw new NegativeNumberException();
                _h = value;
            }
        }
        public Screen(string name, decimal price, int count, int w, int h) : base(name, price, count)
        {
            _h = h;
            _w = w;
            W = w;
            H = h;
        }
        public override string Display()
        {
            return 
                base.Display() + 
                $"\tScreen Width: {W}\n" +
                $"\tScreen Heigh: {H}\n";
        }
    }
}
