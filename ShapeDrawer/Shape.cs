using SplashKitSDK;

namespace ShapeDrawer
{
    public class Shape
    {
        //feild
        private Color _color;
        private float _x, _y;
        private int _width, _height;


        //constructor
        public Shape()
        {
            _color = Color.Green;
            _x = 0;
            _y = 0;
            _width = 100;
            _height = 100;
        }

        //method bin\Debug\net7.0\ShapeDrawer.dll
        public void Draw()
        {
            SplashKit.FillRectangle(_color, _x, _y, _width, _height);
        }

        //Point2D: a struct that contains an X and Y value represeting a point in 2d space - similar to point 2d on the window screen
        public bool IsAt(Point2D pt) //return boolean to indicate if the shape is at that point
        {
            return SplashKit.PointInRectangle(pt, SplashKit.RectangleFrom(_x, _y, _width, _height));
        }

        //getter and setter
        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public float X
        {
            get { return _x; }
            set { _x = value; }
        }

        public float Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }
    }
}