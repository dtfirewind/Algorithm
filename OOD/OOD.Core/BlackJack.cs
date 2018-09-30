using System;

namespace OOD.Core
{
    public class BlackJack : Poker
    {
        private int _value;
        private string _category;
        public override int Value
        {
            get
            {
                if(_value == 1){
                    return 1;
                }else{
                    return _value;
                }
            }
            set
            {
                if(value >= 10 && value <= 13){
                    _value = 10;
                }else if(value >= 1 && value < 10){
                    _value = value;
                }else {
                    _value = -1;
                }
                
            }
        }
    }
}
