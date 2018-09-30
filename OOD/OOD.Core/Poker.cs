using System;

namespace OOD.Core
{
    public class Poker
    {
        private int _value;
        private string _category;
        public virtual int Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value <= 13 && value >= 1 ? value : -1;
            }
        }
        public virtual string Category
        {
            get{ return _category;}
            set{ _category = value;}
        }
    }
}
