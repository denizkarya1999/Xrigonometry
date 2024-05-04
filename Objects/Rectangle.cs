namespace objects
{
    public class Rectangle
    {
        //Declare properties
        private String _name;
        private String type;
        private double width;
        private double diagonal;
        private double length;

        //Declare constructor
        public Rectangle(String rectangleName, String objectType, float targetWidth, float targetDiagonal, float targetLength)
        {
            _name = rectangleName;
            type = objectType;
            width = targetWidth;
            diagonal = targetDiagonal;
            length = targetLength;
        }

        //Setters
        public void setName(String targetName) { this._name = targetName; }
        public void setWidth(double targetWidth) { this.width = targetWidth;  }
        public void setDiagonal(double targetDiagonal) { this.diagonal = targetDiagonal; }
        public void setLength(double targetLength) {  this.length = targetLength; }

        //Getters
        public String getName() { return _name; }
        public String getType() { return type; }
        public double getWidth() { return width; }
        public double getDiagonal() {  return diagonal; }
        public double getLength() { return length; }

        //Area method
        public double Area()
        {
            return length * width;
        }

        //Perimeter method
        public double Perimeter()
        {
            return 2 * (length + width);
        }
    }
}