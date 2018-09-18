namespace ConsoleApp5
{
    class rectangle : figures//прямоугольник
    {
        int vertical_side;
        int horizontal_side;
        public rectangle(int vertical, int horizontal)
        {
            vertical_side = vertical;
            horizontal_side = horizontal;
        }
        public int value_area()
        {
            if (vertical_side > 0 && horizontal_side > 0)
                return vertical_side * horizontal_side;
            else return 0;
        }
    }
}
