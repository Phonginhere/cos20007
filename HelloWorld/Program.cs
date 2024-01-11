using System;

namespace HelloWorld
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //Step 1: Assign MyMessage a new Message with text "Hello World - from Message Object"
            Message MyMessage;
            MyMessage = new Message("Hello World - from Message Object");
            //Step 2: Tell MyMessage to Print
            MyMessage.Print();

            //declare variables
            string name = null;
            Message[] messages = new Message[5]; //create array of Message objects

            //Step 3: Assign messages at index 0, a new message with text "Welcome back!"
            messages[0] = new Message("Welcome back!"); //create new Message object, pass the value to the constructor
            //Step 4: Assign messages at index 1, a new message with text "What a lovely name"
            messages[1] = new Message("What a lovely name");
            //Step 5: Assign messages at index 2, a new message with text "Great name"
            messages[2] = new Message("Great name");
            //Step 6: Assign messages at index 3, a new message with text "Oh hi!"
            messages[3] = new Message("Oh hi!");
            //Step 7: Assign messages at index 4, a new message with text "That is a silly name"
            messages[4] = new Message("That is a silly name");



            do
            {
                //Step 8: Tell console to write "Enter name!"
                Console.Write("Enter name! ");
                //Step 9: Assign name, the result from asking the Console to ReadLine
                name = Console.ReadLine(); //read user input
                // int i = 0;
                // i++;
            } while (name == null || name.Length == 0 || name == " "); //check if input is null or empty (length is 0) or space

            //Step 10: If asking name toLower returns "mark" then

            //Convert "name" variable to lower case
            name = name.ToLower();

            //Check if name is "linh", "kien", "tuan", "tung" or something else
            if (name == "linh")
            {
                //Step 11: Tell messages[0] to Print
                messages[0].Print(); //call Print method of Message object
            }
            else if (name == "kien")
            {
                //Step 12: Tell messages[1] to Print
                messages[1].Print();
            }
            else if (name == "tuan")
            {
                //Step 13: Tell messages[2] to Print
                messages[2].Print();
            }
            else if (name == "tung")
            {
                //Step 14: Tell messages[3] to Print
                messages[3].Print();
            }
            else
            {
                //Step 15: Tell messages[4] to Print
                messages[4].Print();
            }

        }
    }
}
