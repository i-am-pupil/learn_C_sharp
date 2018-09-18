using System;
using System.Collections.Generic;
//Описать несколько классов геометрических фигур.У каждой сделать свойство или метод расчёта её площади.
//Создать по несколько экземпляров каждого объекта.Все эти объекты поместить в одну коллекцию.
//И посчитать суммарную площадь всех фигур.


namespace ConsoleApp5
{
    class Program// я плохо знаю англ язык, по этому некоторые слова для себя перевожу на русс.
    {
        static void Main(string[] args)
        {
            List<figures> collection = new List<figures>();
            var rectangle = new rectangle(5, 7);
            var right_triangle = new right_triangle(10, 4);
            collection.Add(rectangle);
            collection.Add(right_triangle);
            int sum_area = 0;
            foreach (var item in collection)
            {
                sum_area += item.value_area();
            }
            Console.WriteLine(sum_area);
        }
    }
}
