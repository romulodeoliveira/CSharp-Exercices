namespace Exercice06
{
    public class ThreeValues
    {
        private double _valueA { get; set; }
        private double _valueB { get; set; }
        private double _valueC { get; set; }

        public ThreeValues(double valueA, double valueB, double valueC)
        {
            _valueA = valueA;
            _valueB = valueB;
            _valueC = valueC;
        }

        // a área do triângulo retângulo que tem A por base e C por altura
        public void RightTriangle()
        {
            System.Console.WriteLine($"Triangulo Retangulo: {_valueA * _valueB / 2}");
        }

        // a área do círculo de raio C. (pi = 3.14159)
        public void CircleWithRadius()
        {
            System.Console.WriteLine($"Circulo do Raio: {3.14159 * Math.Pow(_valueC, 2)}");
        }

        // a área do trapézio que tem A e B por bases e C por altura
        public void AreaOfATrapezoid()
        {
            System.Console.WriteLine($"Área do Trapézio: {(_valueA + _valueB) * _valueC / 2}");
        }

        // a área do quadrado que tem lado B
        public void SquareArea()
        {
            System.Console.WriteLine($"Área do Quadrado: {Math.Pow(_valueB, 2)}");
        }

        // a área do retângulo que tem lados A e B
        public void RectangleArea()
        {
            System.Console.WriteLine($"Área do Retangulo: {_valueA * _valueB}");
        }

    }
}