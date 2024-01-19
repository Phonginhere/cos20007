using SplashKitSDK;
using ShaperDrawer;

namespace ShapeDrawing
{
    public class Program
    {
        public static void Main()
        {
            Drawing myDrawing = new Drawing();
            new Window("Shape Drawing", 800, 600);

            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen(SplashKit.RandomRGBColor(255));
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    int ShapeXPos = (int)SplashKit.MouseX();
                    int ShapeYPos = (int)SplashKit.MouseY();
                    myDrawing.AddShape(new Shape(ShapeXPos, ShapeYPos));
                    Console.WriteLine("Mouse Left Click - Shape added at {0}, {1}", ShapeXPos, ShapeYPos);
                }

                //Change to new random background color when user press the spacekey button
                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    myDrawing.Background = SplashKit.RandomRGBColor(255);
                    Console.WriteLine("Space Key Pressed - Background color changed");
                }

                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    myDrawing.SelectedShapesAt(SplashKit.MousePosition());
                }

                if (SplashKit.KeyTyped(KeyCode.DeleteKey))
                {
                    myDrawing.RemoveShape();
                }

                if (SplashKit.MouseClicked(MouseButton.MiddleButton))
                {
                    myDrawing.ChangeShapeColor();
                }

                myDrawing.Draw();
                SplashKit.RefreshScreen();

            } while (!SplashKit.WindowCloseRequested("Shape Drawing"));
        }
    }
}
