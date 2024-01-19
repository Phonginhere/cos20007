using SplashKitSDK;
using System.Collections.Generic;
using ShaperDrawer;

namespace ShapeDrawing
{
    public class Drawing
    {
        //feilds
        private readonly List<Shape> _shapes;
        private Color _background;

        //constructor
        public Drawing(Color background)
        {
            _shapes = new List<Shape>();
            _background = background;
        }

        public Drawing() : this(Color.White)
        {

        }

        //get,set
        public int ShapeCount
        {
            get { return _shapes.Count; }
        }

        public Color Background
        {
            get { return _background; }
            set { _background = value; }
        }

        public List<Shape> SelectedShapes
        {
            get
            {
                List<Shape> result = new List<Shape>();
                foreach (Shape s in result)
                {
                    if (s.Selected)
                    {
                        result.Add(s);
                    }
                }
                return result;
            }

        }


        //method

        public void Draw()
        {
            SplashKit.ClearScreen(_background);
            foreach (Shape shape in _shapes)
            {
                shape.Draw();
            }
        }

        public void SelectedShapesAt(Point2D pt)
        {
            foreach (Shape s in _shapes)
            {
                if (s.IsAt(pt))
                {
                    s.Selected = true;
                }
                else
                {
                    s.Selected = false;
                }
            }
        }





        public void AddShape(Shape shape)
        {
            _shapes.Add(shape);
        }

        public void RemoveShape()
        {
            foreach (Shape s in _shapes.ToList())
            {
                if (s.Selected)
                {
                    _shapes.Remove(s);
                }
            }
        }



        //additional method

        public void ChangeShapeColor()
        {
            foreach (Shape s in _shapes)
            {
                if (s.Selected)
                {
                    s.COLOR = SplashKit.RandomRGBColor(255);
                }
            }
        }





    }
}