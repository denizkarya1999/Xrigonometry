using objects.TriangleExtended;

namespace objects.MathFunctions
{
    public class Trigonometry
    {
        public static double Sine(RightTriangle rightTriangle)
        {
            return rightTriangle.getY();
        }

        public static double Cosine(RightTriangle rightTriangle)
        {
            return rightTriangle.getX();
        }

        public static double Tangent(RightTriangle rightTriangle)
        {
            return rightTriangle.getY() / rightTriangle.getX();
        }

        public static double Cosecant(RightTriangle rightTriangle)
        {
            return 1 / rightTriangle.getY();
        }

        public static double Secant(RightTriangle rightTriangle)
        {
            return 1 / rightTriangle.getX();
        }

        public static double Cotangent(RightTriangle rightTriangle)
        {
            return rightTriangle.getX() / rightTriangle.getY();
        }
    }
}