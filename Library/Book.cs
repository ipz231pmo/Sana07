using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book : Product
    {
        protected string _category;
        protected string _autor;
        protected string _title;

        public string Category
        {
            get { return _category; }
            set 
            { 
                if (value == string.Empty) 
                { 
                    throw new EmptyStringException();
                }
                _category = value; 
            }
        }
        public string Autor
        {
            get { return _autor; }
            set
            {
                if(value == string.Empty)
                {
                    throw new EmptyStringException();
                }
                _autor = value;
            }
        }
        public string Title
        {
            get { return _title; }
            set 
            {
                if(value == string.Empty)
                {
                    throw new EmptyStringException();
                }
                _title = value;
            }
        }
        public Book(string name, decimal price, int count, string category, string autor, string title) : base(name, price, count)
        {
            _category = category;
            _autor = autor;
            _title = title;
            Category = category;
            Autor = autor;
            Title = title;
        }

        public override string Display()
        {
            return 
                base.Display() + 
                $"\tBook Category: {Category}\n" +
                $"\tBook Autor: {Autor}\n" +
                $"\tBook Title: {Title}\n";
        }
    }
}
