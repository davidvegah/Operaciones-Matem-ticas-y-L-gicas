using System;

class Program
{
    static void Main(string[] args)
    {
        // Boolean
        bool AmIReal;
        AmIReal = true;
        bool AmIHandsome;
        AmIHandsome = false;

        // Byte
        byte a1 = 20;
        byte a2 = 50;

        // Character
        char b1 = 'E';
        char b2 = 'Z';

        // Short
        short c1 = -15000;
        short c2 = 18600;

        // Integer
        int d1 = 2000;
        int d2 = 2023;

        // Float
        float e1 = 3.8264833214F;
        float e2 = -1.8011654984F;

        // Double
        double f1 = 85.498;
        double f2 = 85.498D;

        // Long
        long g1 = 99416621159;
        long g2 = 219916655448;

        // Decimal
        decimal h1 = 7.626168462218513854565M;
        decimal h2 = -1.121513030115556621156M;

        // String
        string i1 = "Papa";
        string i2 = "Chayote";

// Resultados de las Operaciones

        // Boolean
        Console.WriteLine("BOOLEAN:");
        Console.WriteLine("Am I Real? = " + AmIReal);
        Console.WriteLine("Am I Handsome? = " + AmIHandsome);
        Console.WriteLine();

        // Byte
        Console.WriteLine("BYTE:");
        Console.WriteLine("A = " + a1);
        Console.WriteLine("B = " + a2);
        Console.WriteLine(a1 + " + " + a2 + " = " + (a1 + a2));
        Console.WriteLine(a1 + " - " + a2 + " = " + (a1 - a2));
        Console.WriteLine(a1 + " * " + a2 + " = " + (a1 * a2));
        Console.WriteLine(a1 + " / " + a2 + " = " + (a1 / a2));
        Console.WriteLine(a1 + " % " + a2 + " = " + (a1 % a2));
        Console.WriteLine(a1 + " > " + a2 + " = " + (a1 > a2));
        Console.WriteLine(a1 + " < " + a2 + " = " + (a1 < a2));        
        Console.WriteLine(a1 + " == " + a2 + " = " + (a1 == a2));
        Console.WriteLine(a1 + " >= " + a2 + " = " + (a1 >= a2));
        Console.WriteLine(a1 + " <= " + a2 + " = " + (a1 <= a2));
        Console.WriteLine(a1 + " != " + a2 + " = " + (a1 != a2));
        Console.WriteLine();
        
        // Character
        Console.WriteLine("CHARACTER:");
        Console.WriteLine("A = " + b1);
        Console.WriteLine("B = " + b2);
        Console.WriteLine(b1 + " == " + b2 + " = " + (b1 == b2)); 
        Console.WriteLine();

        // Short
        Console.WriteLine("SHORT:");
        Console.WriteLine("A = " + c1);
        Console.WriteLine("B = " + c2);
        Console.WriteLine(c1 + " + " + c2 + " = " + (c1 + c2));
        Console.WriteLine(c1 + " - " + c2 + " = " + (c1 - c2));
        Console.WriteLine(c1 + " * " + c2 + " = " + (c1 * c2));
        Console.WriteLine(c1 + " / " + c2 + " = " + (c1 / c2));
        Console.WriteLine(c1 + " % " + c2 + " = " + (c1 % c2));
        Console.WriteLine(c1 + " > " + c2 + " = " + (c1 > c2));
        Console.WriteLine(c1 + " < " + c2 + " = " + (c1 < c2));        
        Console.WriteLine(c1 + " == " + c2 + " = " + (c1 == c2));
        Console.WriteLine(c1 + " >= " + c2 + " = " + (c1 >= c2));
        Console.WriteLine(c1 + " <= " + c2 + " = " + (c1 <= c2));
        Console.WriteLine(c1 + " != " + c2 + " = " + (c1 != c2));
        Console.WriteLine();

        // Integer
        Console.WriteLine("INTEGER:");
        Console.WriteLine("A = " + d1);
        Console.WriteLine("B = " + d2);
        Console.WriteLine(d1 + " + " + d2 + " = " + (d1 + d2));
        Console.WriteLine(d1 + " - " + d2 + " = " + (d1 - d2));
        Console.WriteLine(d1 + " * " + d2 + " = " + (d1 * d2));
        Console.WriteLine(d1 + " / " + d2 + " = " + (d1 / d2));
        Console.WriteLine(d1 + " % " + d2 + " = " + (d1 % d2));
        Console.WriteLine(d1 + " > " + d2 + " = " + (d1 > d2));
        Console.WriteLine(d1 + " < " + d2 + " = " + (d1 < d2));        
        Console.WriteLine(d1 + " == " + d2 + " = " + (d1 == d2));
        Console.WriteLine(d1 + " >= " + d2 + " = " + (d1 >= d2));
        Console.WriteLine(d1 + " <= " + d2 + " = " + (d1 <= d2));
        Console.WriteLine(d1 + " != " + d2 + " = " + (d1 != d2));
        Console.WriteLine();

        // Float
        Console.WriteLine("FLOAT:");
        Console.WriteLine("A = " + e1);
        Console.WriteLine("B = " + e2);
        Console.WriteLine(e1 + " + " + e2 + " = " + (e1 + e2));
        Console.WriteLine(e1 + " - " + e2 + " = " + (e1 - e2));
        Console.WriteLine(e1 + " * " + e2 + " = " + (e1 * e2));
        Console.WriteLine(e1 + " / " + e2 + " = " + (e1 / e2));
        Console.WriteLine(e1 + " % " + e2 + " = " + (e1 % e2));
        Console.WriteLine(e1 + " > " + e2 + " = " + (e1 > e2));
        Console.WriteLine(e1 + " < " + e2 + " = " + (e1 < e2));        
        Console.WriteLine(e1 + " == " + e2 + " = " + (e1 == e2));
        Console.WriteLine(e1 + " >= " + e2 + " = " + (e1 >= e2));
        Console.WriteLine(e1 + " <= " + e2 + " = " + (e1 <= e2));
        Console.WriteLine(e1 + " != " + e2 + " = " + (e1 != e2));
        Console.WriteLine();

        // Double
        Console.WriteLine("DOUBLE:");
        Console.WriteLine("A = " + f1);
        Console.WriteLine("B = " + f2);
        Console.WriteLine(f1 + " + " + f2 + " = " + (f1 + f2));
        Console.WriteLine(f1 + " - " + f2 + " = " + (f1 - f2));
        Console.WriteLine(f1 + " * " + f2 + " = " + (f1 * f2));
        Console.WriteLine(f1 + " / " + f2 + " = " + (f1 / f2));
        Console.WriteLine(f1 + " % " + f2 + " = " + (f1 % f2));
        Console.WriteLine(f1 + " > " + f2 + " = " + (f1 > f2));
        Console.WriteLine(f1 + " < " + f2 + " = " + (f1 < f2));        
        Console.WriteLine(f1 + " == " + f2 + " = " + (f1 == f2));
        Console.WriteLine(f1 + " >= " + f2 + " = " + (f1 >= f2));
        Console.WriteLine(f1 + " <= " + f2 + " = " + (f1 <= f2));
        Console.WriteLine(f1 + " != " + f2 + " = " + (f1 != f2));
        Console.WriteLine();

        // Long
        Console.WriteLine("LONG:");
        Console.WriteLine("A = " + g1);
        Console.WriteLine("B = " + g2);
        Console.WriteLine(g1 + " + " + g2 + " = " + (g1 + g2));
        Console.WriteLine(g1 + " - " + g2 + " = " + (g1 - g2));
        Console.WriteLine(g1 + " * " + g2 + " = " + (g1 * g2));
        Console.WriteLine(g1 + " / " + g2 + " = " + (g1 / g2));
        Console.WriteLine(g1 + " % " + g2 + " = " + (g1 % g2));
        Console.WriteLine(g1 + " > " + g2 + " = " + (g1 > g2));
        Console.WriteLine(g1 + " < " + g2 + " = " + (g1 < g2));        
        Console.WriteLine(g1 + " == " + g2 + " = " + (g1 == g2));
        Console.WriteLine(g1 + " >= " + g2 + " = " + (g1 >= g2));
        Console.WriteLine(g1 + " <= " + g2 + " = " + (g1 <= g2));
        Console.WriteLine(g1 + " != " + g2 + " = " + (g1 != g2));
        Console.WriteLine();

        // Decimal
        Console.WriteLine("DECIMAL:");
        Console.WriteLine("A = " + h1);
        Console.WriteLine("B = " + h2);
        Console.WriteLine(h1 + " + " + h2 + " = " + (h1 + h2));
        Console.WriteLine(h1 + " - " + h2 + " = " + (h1 - h2));
        Console.WriteLine(h1 + " * " + h2 + " = " + (h1 * h2));
        Console.WriteLine(h1 + " / " + h2 + " = " + (h1 / h2));
        Console.WriteLine(h1 + " % " + h2 + " = " + (h1 % h2));
        Console.WriteLine(h1 + " > " + h2 + " = " + (h1 > h2));
        Console.WriteLine(h1 + " < " + h2 + " = " + (h1 < h2));        
        Console.WriteLine(h1 + " == " + h2 + " = " + (h1 == h2));
        Console.WriteLine(h1 + " >= " + h2 + " = " + (h1 >= h2));
        Console.WriteLine(h1 + " <= " + h2 + " = " + (h1 <= h2));
        Console.WriteLine(h1 + " != " + h2 + " = " + (h1 != h2));
        Console.WriteLine();
        
        // String
        Console.WriteLine("STRING:");
        Console.WriteLine("A = " + i1);
        Console.WriteLine("B = " + i2);
        Console.WriteLine(i1 + " == " + i2 + " = " + (i1 == i2)); 
    }
}