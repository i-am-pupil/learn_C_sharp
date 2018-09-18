using System;
using System.Collections.Generic;
using System.Linq;
//Описать несколько классов геометрических фигур.У каждой сделать свойство или метод расчёта её площади.
//Создать по несколько экземпляров каждого объекта.Все эти объекты поместить в одну коллекцию.
//И посчитать суммарную площадь всех фигур.

//Замечания по оформлению кода. Если кратко, в C# принято по именованию:
//— не использовать «_»;
//— имена классов, методов и свойств с большой буквы;
//— имена переменных и аргументов с маленькой;
//— имена интерфейсов с I, например IFigure;
//— приватные члены класса с «_», например, private int _width;;
//— названия методов должны быть английскими глаголами, например, public int GetArea() { … };
//— названия свойств и автосвойств должны быть, как правило, существительными, например,
//    public int Area { get { return … ; } }; для булевых обычно примерно так: public bool IsActive { get; set; }
//— названия файлов должны совпадать с названиями классов, которые в них определены.

//Модификаторы доступа классов (internal, public, private, protected) лучше не забывать указывать.То же касается и членов, методов, полей класса.
namespace ConsoleApp5
{
    class Program// я плохо знаю англ язык, по этому некоторые слова для себя перевожу на русс.
    {
        static void Main(string[] args)
        {
            List<BaseFigure> collection = new List<BaseFigure>();
            var rectangle = new Rectangle(5, 7);
            var rightTriangle = new RightTriangle(10, 4);
            collection.Add(rectangle);
            collection.Add(rightTriangle);
            double sumArea = collection.Sum(item => item.GetArea());
            Console.WriteLine(sumArea);
        }
    }
}
