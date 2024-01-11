using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {
        public static void Main()
        {
            Shape myShape = new Shape();
            Window window = new Window("Shape Drawer", 800, 600);
            do{
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
                //tell myShape to Draw itself, after clearing the screen

                //user click left button, set the shape x, y
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    myShape.X = (float)SplashKit.MouseX(); //convert double to float, then assign to myShape.X
                    myShape.Y = (float)SplashKit.MouseY(); //same as above
                }
                //mouse is over the shape, and press the spacebar, change the shape Color to be random
                //MousePosition() return a Point2D, SpaceKey is a KeyCode
                if (myShape.IsAt(SplashKit.MousePosition()) && SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    myShape.Color = SplashKit.RandomRGBColor(255);
                }
                myShape.Draw();

                SplashKit.RefreshScreen();
            }while(!window.CloseRequested);
        }
    }
}
