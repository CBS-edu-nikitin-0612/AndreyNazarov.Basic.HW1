namespace Task2
{
    class Rectangle
    {

        private double side1;
        public double Side1
        {
            get { return side1; }
        }

        private double side2;
        public double Side2
        {
            get { return side2; }
        }

        public double Area
        {
            get { return areaCalculator(); }
        }
        public double Perimeter
        {
            get { return perimeterCalculator(); }
        }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        private double areaCalculator()
        {
            return side1 * side2;
        }
        private double perimeterCalculator()
        {
            return side2 * 2 + side1 * 2;
        }
    }
}
