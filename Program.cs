using System;

namespace ejercicio
{
    internal class Program
    {
        static void Resize (ref int[] myArray, int value)
        {
            Array.Resize<int>(ref myArray, value);
        }
        static void Main(string[] args)
        {
            int [] myArr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            Console.Write("Введите размер массива: ");
            int valueRes = int.Parse(Console.ReadLine());
                
            Resize(ref myArr, valueRes);
            for (int i = 0; i < myArr.Length; i++)
            {
                Console.WriteLine(myArr[i]);
            } 
            

            
        }
    }
}
