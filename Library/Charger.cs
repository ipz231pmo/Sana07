using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Charger : Product
    {
        protected decimal _power;
        protected string _type;
        public decimal Power
        {
            get => _power;
            set
            {
                if (value < 0)
                    throw new NegativeNumberException();
                _power = value;
            }
        }
        public string Type
        {
            get => _type;
            set
            {
                if(value == string.Empty)
                    throw new EmptyStringException();
                _type = value;
            }
        }
        public Charger(string name, decimal price, int count, decimal power, string type) : base(name, price, count)
        {
            _power = power;
            _type = type;
            Power = power;
            Type = type;
        }
        public override string Display()
        {
            return 
                base.Display() +
                $"\tCharge Power: {Power}\n" +
                $"\tCharhe Type: {Type}\n";
        }
    }
}
