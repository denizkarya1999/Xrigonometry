namespace objects
{
    public class Hexagon
    {
        //Declare properties
        private String _name;
        private String type;
        private double a;
        private double l;

        public Hexagon(String hexagonName, String objectType,
            double a, double l)
        {
            _name = hexagonName;
            type = objectType;
            this.a = a;
            this.l = l;
        }

        //Setters
        public void setName(String targetName) { this._name = targetName; }
        public void setA(double a) { this.a = a; }
        public void setL(double l) { this.l = l; }

        //Getters
        public String getName() { return _name; }
        public String getType() { return type; }
        public double getA() { return this.a; }
        public double getL() { return this.l; }

        //Area
        public double Area()
        {
            return ((3 * Math.Sqrt(3))/2) * Math.Pow(a,2);
        }

        //Perimeter method
        public double Perimeter()
        {
            return 6 * a;
        }
    }
}