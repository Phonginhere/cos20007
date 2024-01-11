using System;
using SplashKitSDK; // a library that provides a set of functions that can be used to create graphical programs.

namespace TheFirstOwnSplashKit
{
    public class Program
    {
        public static void Main()
        {
            //Begin create a "window" object
            Window window = new Window("Shape Drawer", 800, 600); //parameter: caption title "..." and the size of px width x height
            do
            { // perform loop when the window is not closed.
                SplashKit.ProcessEvents(); // will process all the events that have happened since the last time it was called.
                SplashKit.ClearScreen(); // clear the screen.
                SplashKit.RefreshScreen(); // refresh the screen.
            } while (!window.CloseRequested); // will keep running until the window is closed.
        }
    }
}


