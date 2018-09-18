namespace ConsoleApp5
{
    class right_triangle : figures
    {
        int vertical_side;
        int horizontal_side;
        public right_triangle(int vertical, int horizontal)
        {
            vertical_side = vertical;
            horizontal_side = horizontal;
        }
        public int value_area()
        {
            return vertical_side * horizontal_side / 2;
        }
    }
}
