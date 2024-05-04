namespace objects
{
    public class Square
    {
        //Declare properties
        private String _name;
        private String type;
        private double s;

        //Declare constructor
        public Square(String squareName, String objectType, double s)
        {
            _name = squareName;
            type = objectType;
            this.s = s;
        }

        //Setters
        public void setName(String targetName) { this._name = targetName; }
        public void setS(double s) { this.s = s; }

        //Getters
        public String getName() { return _name; }
        public String getType() { return type; }
        public double getS() { return this.s; }

        //Area method
        public double Area()
        {
            return Math.Pow(s, 2);
        }

        //Perimeter method
        public double Perimeter()
        {
            return 4 * s;
        }
    }
}