namespace objects
{
    public class Sphr
    {
        //Declare properties
        private String _name;
        private String type;
        private double radius;
        private double diameter;
        private double pi;

        //Declare constructor
        public Sphr(String sphereName, String objectType, float targetRadius,float targetDiameter)
        {
            _name = sphereName;
            type = objectType;
            radius = targetRadius;
            diameter = targetDiameter;
            pi = 3.141592653589793238462643383279502884197;
        }

        //Setters
        public void setName (String targetName) { this._name = targetName; }
        public void setRadius(double targetRadius) { this.radius = targetRadius; }
        public void setDiameters(double targetDiameter) { this.diameter = targetDiameter; }

        //Getters
        public String getName () { return _name; }
        public String getType () { return type; }
        public double getRadius() { return this.radius; }
        public double getDiameter() {  return this.diameter; }

        //Volume method
        public double Volume()
        {
            return (4 * this.pi * Math.Pow(this.radius, 3))/3;
        }

        //Surface Area method
        public double SurfaceArea()
        {
            return 4 * this.pi * Math.Pow(this.radius, 2);
        }
    }
}