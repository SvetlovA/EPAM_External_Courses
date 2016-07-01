using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Выберете фигуру Линия/Прямоугольник/Окружность/Круг/Кольцо:");
                IFigure _figure = FigureSwitcher(Console.ReadLine());
                Console.WriteLine("Выбранная фигура: {0}", _figure.GetFigure());
                Console.WriteLine("Параметры фигуры:");
                Console.WriteLine("Площадь фигуры: {0}", _figure.GetArea());
                Console.WriteLine("Длинна фигуры: {0}", _figure.GetLength());
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели некорректные данные!!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\nНажмите любую кнопку для завершения...");
            Console.ReadKey();
        }

        /// <summary>
        /// Make figures
        /// </summary>
        /// <param name="figure"> Name of figure</param>
        /// <returns> Figure</returns>
        static IFigure FigureSwitcher(string figure)
        {
            switch (figure)
            {
                case "Линия":
                    Console.Write("Введите координату X начальной точки: ");
                    int _startX = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите координату Y начальной точки: ");
                    int _startY = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите координату Y конечной точки: ");
                    int _endX = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите координату X конечной точки: ");
                    int _endY = Convert.ToInt32(Console.ReadLine());
                    return new Line(_startX, _startY, _endX, _endY);
                case "Прямоугольник":
                    Console.Write("Введите ширину: ");
                    double _width = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите высоту: ");
                    double _height = Convert.ToDouble(Console.ReadLine());
                    return new Rectangle(_width, _height);
                case "Окружность":
                    Console.Write("Введите координату X: ");
                    int _circleX = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите координату Y: ");
                    int _circleY = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите радиус: ");
                    double _circleRadius = Convert.ToDouble(Console.ReadLine());
                    return new Circle(_circleX, _circleY, _circleRadius);
                case "Круг":
                    Console.Write("Введите координату X: ");
                    int _roundX = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите координату Y: ");
                    int _roundY = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите радиус: ");
                    double _roundRadius = Convert.ToDouble(Console.ReadLine());
                    return new Round(_roundX, _roundY, _roundRadius);
                case "Кольцо":
                    Console.Write("Введите координату X: ");
                    int _ringX = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите координату Y: ");
                    int _ringY = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите внутренний радиус: ");
                    double _ringRadius = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Веедите внешний радиус:");
                    double _ringOuterRadius = Convert.ToDouble(Console.ReadLine());
                    return new Ring(_ringX, _ringY, _ringRadius, _ringOuterRadius);
                default:
                    throw new FormatException();
            }
        }
    }
}
