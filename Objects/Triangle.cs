namespace objects
{
    public class Triangle
    {
        //Declare properties
        private String _name;
        private String type;
        private double a;
        private double b;
        private double c;
        private double h;

        //Declare constructor
        public Triangle(String triangleName, String objectType, double a, double b, double c, double h)
        {
            _name = triangleName;
            type = objectType;
            this.a = a;
            this.b = b;
            this.c = c;
            this.h = h;
        }

        //Setters
        public void setName(String targetName) { this._name = targetName; }
        public void setA(double a) { this.a = a; }
        public void setB(double b) { this.b = b; }
        public void setC(double c) { this.c = c; }
        public void setH(double h) { this.h = h; }

        //Getters
        public String getName() { return _name; }
        public String getType() { return type; }
        public double getA() { return this.a; }
        public double getB() { return this.b; }
        public double getC() { return this.c; }
        public double getH() { return this.h; }

        //Area method
        public double Area()
        {
            return (b * h)/2;
        }

        //Perimeter method
        public double Perimeter()
        {
            return a+b+c;
        }
    }
}