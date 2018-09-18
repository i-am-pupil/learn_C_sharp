namespace ConsoleApp5
{
    public class RightTriangle : Figures
    {
        int _verticalSide;
        int _horizontalSide;
        public RightTriangle(int vertical, int horizontal)
        {
            _verticalSide = vertical;
            _horizontalSide = horizontal;
        }
        public override int GetArea()
        {
            if (_verticalSide > 0 && _horizontalSide > 0)
                return _verticalSide * _horizontalSide/2;
            else return 0;
        }
    }
}
