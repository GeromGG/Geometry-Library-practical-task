namespace GeometryLibrary
{
    public class Triangle : IShape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public double CalculateArea()
        {
            if (Base != 0 && Height != 0)
            {
                return 0.5 * Base * Height;
            }

            return TriangleArea(A, B, C);
        }

        /// <summary>
        /// Данный метод находит площадь треугольника по трем сторонам a, b и c. 
        /// Для этого он находит полупериметр треугольника (p) по формуле (a+b+c)/2, 
        /// затем использует формулу Герона S=sqrt(p*(p-a)*(p-b)*(p-c)), 
        /// где S - площадь треугольника, a, b, c - длины сторон.
        /// Функция sqrt используется для нахождения корня из полученного выражения.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static double TriangleArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }


        /// <summary>
        /// Данный метод проверяет, образуют ли три числа (a, b, c) стороны прямоугольного треугольника. 
        /// Для этого он сортирует их по возрастанию и применяет формулу Пифагора для проверки соотношения между квадратами длин катетов и гипотенузой. 
        /// Возвращает метод значение true, если условие выполняется, и false в противном случае. 
        /// Константа 0.0001 используется для учёта погрешностей вычислений.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsRightTriangle(double a, double b, double c)
        {
            double[] sides = { a, b, c };
            Array.Sort(sides);
            return Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) < 0.0001;
        }
    }
}
