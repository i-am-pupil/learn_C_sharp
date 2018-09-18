namespace ConsoleApp5
{
    public class Rectangle : BaseFigure//прямоугольник
    {
        int _verticalSide;
        int _horizontalSide;
        public Rectangle(int vertical, int horizontal)
        {
            
            _verticalSide = vertical;
            _horizontalSide = horizontal;
        }
        public override int GetArea()
        {
            if (_verticalSide > 0 && _horizontalSide > 0)
                return _verticalSide * _horizontalSide;
            else return 0;
        }
    }
}
