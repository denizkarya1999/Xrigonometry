namespace objects
{
    public class Pentagon
    {
        //Declare properties
        private String _name;
        private String type;
        private double a;
        private double b;
        private double c;
        private double d;
        private double e;
        private double s;

        public Pentagon(String pentagonName, String objectType, 
            double a, double b, double c, double d, double e, double s)
        {
            _name = pentagonName;
            type = objectType;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.s = s;
        }

        //Setters
        public void setName(String targetName) { this._name = targetName; }
        public void setA(double a) { this.a = a; }
        public void setB(double b) { this.b = b; }
        public void setC(double c) { this.c = c; }
        public void setD(double d) { this.d = d; }
        public void setE(double e) { this.e = e; }
        public void setS(double s) { this.s = s; }

        //Getters
        public String getName() { return _name; }
        public String getType() { return type; }
        public double getA() { return this.a; }
        public double getB() { return this.b; }
        public double getC() { return this.c; }
        public double getD() { return this.d; }
        public double getE() { return this.e; }
        public double getS() { return this.s; }

        //Area method
        public double Area()
        {
            return (1.0 / 4) * (Math.Sqrt(5 * (5 + (2 * Math.Sqrt(5)))) * Math.Pow((Perimeter()/5), 2));
        }

        //Perimeter method
        public double Perimeter()
        {
            return a + b + c + d + e;
        }
    }
}