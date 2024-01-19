using SplashKitSDK;

namespace ShaperDrawer
{
    public class Shape
    {
        //feilds
        private bool _selected;
        private float _x, _y;
        private int _width, _height;

        private Color _color;

        //constructor
        public Shape(float x, float y)
        {
            _x = x;
            _y = y;
            _width = _height = 100;
            _color = Color.Black;
        }

        //getter,setter

        public bool Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                _selected = value;
            }
        }

        public float X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public float Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public Color COLOR{
            get{
                return _color;
            }
            set{
                _color = value;
            }
        }
        //method

        public void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.FillRectangle(_color, _x, _y, _width, _height);
        }


        public bool IsAt(Point2D pt)
        {
            return SplashKit.PointInRectangle(pt, SplashKit.RectangleFrom(X, Y, _width, _height));
        }


        public void DrawOutline()
        {
            SplashKit.FillRectangle(Color.Black, _x - 2, _y - 2, _width + 4, _height + 4);
        }

    }
}