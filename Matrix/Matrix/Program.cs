using System;

namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix();
            Matrix matrix2 = new Matrix(3);
            Matrix matrix3 = new Matrix(3, 3);

            matrix1.Feltolt(1.0);
            matrix2.Feltolt(2.0);
            matrix3.Feltolt(3.0);

            Console.WriteLine("Első mátrix:");
            Console.WriteLine(matrix1);

            Console.WriteLine("Második mátrix:");
            Console.WriteLine(matrix2);

            Console.WriteLine("Harmadik mátrix:");
            Console.WriteLine(matrix3);

            
            Matrix osszegMatrix = Matrix.Osszead(matrix1, matrix2);
            Console.WriteLine("Első és második mátrix összege:");
            Console.WriteLine(osszegMatrix);
            
            
                
        }
    }
}
