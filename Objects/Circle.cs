namespace objects
{
    public class Circle
    {
        //Declare properties
        private String _name;
        private String type;
        private double r;
        private double pi;

        //Declare constructor
        public Circle(String circleName, String objectType, double r)
        {
            _name = circleName;
            type = objectType;
            this.r = r;
            this.pi = 3.141592653589793238462643383279502884197;
        }
        //Setters
        public void setName(String targetName) { this._name = targetName; }
        public void setR(String targetR) { this.r = r; }

        //Getters
        public String getName() { return _name; }
        public String getType() { return type; }
        public double getR() { return this.r; }

        //Area formula
        public double Area()
        {
            return this.pi * Math.Pow(r, 2);
        }

        //Circumference formula
        public double Circumference()
        {
            return 2 * this.pi * r;
        }
    }
}