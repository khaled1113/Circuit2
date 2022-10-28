using System;
namespace c_sharp_3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            char state;
            double r1, r2, r3, r4, i1, i2, i3, v, p;
            Console.WriteLine("Enter The Value Of R1");
            r1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value Of R2");
            r2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value Of R3");
            r3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value Of V");
            v = double.Parse(Console.ReadLine());
        Beg: Console.WriteLine("Enter Switch State (O = Open, C = Closed)");
            state = char.Parse(Console.ReadLine());
            if (state == 'O')
            {
                i1 = i3 = v / (r1 + r3);
                i2 = 0;
            }
            else if (state == 'C')
            {
                r4 = (r1 * r2) / (r1 + r2);
                i3 = v / (r3 + r4);
                i1 = (i3 * r2) / (r1 + r2);
                i2 = i3 - i1;
            }
            else
            {
                Console.WriteLine("Invalid Switch State Please Try Again");
                goto Beg;
            }
            p = i3 * v;
            Console.WriteLine("The Current I1 = {0}", i1);
            Console.WriteLine("The Current I2 = {0}", i2);
            Console.WriteLine("The Current I3 = {0}", i3);
            Console.WriteLine("The Power = {0}", p);
        }
    }
}