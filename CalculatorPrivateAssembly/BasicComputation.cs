namespace CalculatorPrivateAssembly
{
    public class BasicComputation
    {
        public static float Add(float a, float b)
        {
            return a + b;
        }

        public static float Subtract(float a, float b)
        {
            return a - b;
        }

        public static float Multiply(float a, float b)
        {
            return a * b;
        }

        public static float Divide(float a, float b)
        {
            if (b != 0)
                return a / b;
            else
                throw new DivideByZeroException("Cannot divide by zero.");
        }
    }
}