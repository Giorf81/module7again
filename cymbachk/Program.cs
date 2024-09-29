using System.Runtime.InteropServices;

namespace cymbachk
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        class Rectangle()
        {
            int a, b;

            public int Square()
            {

                return a * b;
            }

            public Rectangle(int first, int second)
            {
                a = first;
                b = second;
            }
            public Rectangle(int side)
            {
                a = side;
            }

            public Rectangle()
            {
                a = 6; b = 4;
            }
        }
    }

}
