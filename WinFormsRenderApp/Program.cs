using ConsoleApp5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsRenderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseFigure figure = new Rectangle(1, 2);

            Console.WriteLine($"Created figure {figure.GetType().FullName}");
        }
    }
}
