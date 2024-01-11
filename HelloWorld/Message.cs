using System;

namespace HelloWorld
{
    public class Message
    {
        //Fields:
        private String _text; //declare private variable _text of type String. Private feild, so it can only be accessed within this class

        //Constructor:
        public Message(string text){ 
            _text = text; //assign text to _text
        }
        
        //Method:
        public void Print(){
            Console.WriteLine(_text);
        }
    }
}