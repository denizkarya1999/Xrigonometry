namespace objects.TriangleExtended
{
    public class RightTriangle
    {
        //Declare properties
        private String _name;
        private String type;
        private double x;
        private double y;
        private double z;
        private String hypotenuse;

        //Declare constructor
        public RightTriangle(String triangleName, String objectType, double x, double y)
        {
            _name = triangleName;
            type = objectType;
            this.x = x;
            this.y = y;
            this.z = 1;
            this.hypotenuse = triangleName + "'s Hypotenuse";
        }

        //Setters
        public void setName(String targetName) { 
            this._name = targetName; 
            this.hypotenuse = targetName + "'s Hypotenuse"; 
        }
        public void setx(double x) { this.x = x; }
        public void sety(double y) { this.y = y; }

        //Getters
        public String getName() { return _name; }
        public String getType() { return type; }
        public double getX() { return this.x; }
        public double getY() { return this.y; }
        public double getZ() { return this.z; }
        public String getHypotenuse() { return this.hypotenuse; }
    }
}