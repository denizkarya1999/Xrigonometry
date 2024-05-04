namespace objects
{
    public class Polygon
    {
        //Declare properties
        private String _name;
        private String type;
        private double n;

        public Polygon(String ploygonName, String objectType,
            double n)
        {
            _name = ploygonName;
            this.type = objectType;
            this.n = n;
        }

        //Setters
        public void setName(String targetName) { this._name = targetName; }
        public void setN(double n) { this.n = n; }

        //Getters
        public String getName() { return _name; }
        public String getType() { return type; }
        public double getN() { return this.n; }

        //Sum of angles method
        public double sumOfAllAngles()
        {
            return (n - 2) * 180;
        }

        //Each angle of a polygon method
        public double eachAngleOfPolygon()
        {
            return ((n - 2) * 180) / n;
        }

        //Each angle of a polygon method
        public double polygonDiagonals()
        {
            return (n * (n - 3)) / 2;
        }

        //Sum of all exterior polygons
        public double SumOfExteriorPolygons()
        {
            return 360;
        }
    }
}