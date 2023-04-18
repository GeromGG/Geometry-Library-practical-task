namespace GeometryLibrary
{
    public class Circle : IShape
    {
        public double Radius { get; set; }
        public double Diameter { get; set; }
        public double Circumference { get; set; }

        public double CalculateArea()
        {
            if (Circumference != 0)
            {
                return Circumference * Circumference / (Math.PI * 4);
            }

            var radius = Radius;

            if ((Radius == 0) && (Diameter != 0))
            {
                radius = Diameter / 2;
            }

            return Math.PI * radius * radius;
        }
    }
}
