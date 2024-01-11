using System;

namespace CounterTask {
    public class Counter{
        //feilds
        private int _count;
        private string _name;

        //constructor
        public Counter(string name){
            _name = name;
            _count = 0;
        }

        //Increment method that increase the value of _count feild by 1
        public void Increment(){
            _count++;
        }
        //Reset method that assigns 0 to the _count feild
        public void Reset(){
            _count = 0;
        }


        //Getter, Setter
        public string Name{
            get{
                return _name;
            }
            set{
                _name = value;
            }
        }

        //return value (getter), but readonly (no setter)
        public int Tick{
            get{
                return _count;
            }
        }

    }
}