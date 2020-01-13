namespace Operations2
{
    public class Division
    {
        public static int Quotient(int a, int b)
        {
            return a / b;
        }

        public static double Quotient(double a, double b)
        {
            return a / b;
        }

        public static double Quotient(double[] a)
        {
            double c = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                c = Quotient(c, a[i]);
            }
            return c;
        }

        public static int Quotient(int[] a)
        {
            int c = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                c = Quotient(c, a[i]);
            }
            return c;
        }
    }
}