namespace Library
{
    public abstract class Product
    {
        protected string _name;
        public string Name {
            get => _name;
            set 
            {
                if (_name == string.Empty)
                    throw new EmptyStringException();
                _name = value;
            }
        }
        protected decimal _price;
        public decimal Price {
            get => _price;
            set 
            { 
                if(value < 0) throw new NegativeNumberException();
                _price = value;
            }
        }
        protected int _count;
        public int Count
        {
            get => _count;
            set
            {
                if (value < 0)
                    throw new NegativeNumberException();
                _count = value;
            }
        }
        public virtual string Display()
        {
            return  $"\n" +
                    $"Product\n" +
                    $"\tName: {Name}\n" +
                    $"\tPrice: {Price}\n" +
                    $"\tCount: {Count}\n";
        }
        public Product(string name, decimal price, int count) 
        { 
            _name = name;
            _price = price;
            _count = count;
            Name = name;
            Price = price;
            Count = count;
        }
    }
}
