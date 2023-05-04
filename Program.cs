using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proc
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public float CircleS(float r)
        {
            return (float)Math.PI * r * r;
        }

        public void Tmp(int a)
        {
            int b = a switch
            {
                < 0 => -1,
                0 => 0,
                > 1 => 1
            };
        }

        public float TriangleP(float a, float h)
        {
            return (float)Math.Sqrt((a / 2) * (a * 2) + h * h);
        }

        public bool Even(int k)
        {
            return k % 2 == 0;
        }

        private float TriangleP(int v1, int v2, float v3)
        {
            throw new NotImplementedException();
        }
        static int Sign(double x)
        {
            if (x < 0)
            {
                return -1;
            }
            else if (x > 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        #region Proc
        static void Proc16(double a, double b)
        {
            Console.WriteLine(Sign(a) + Sign(b));
        }
        //17
        public void proc18(int a, int c, int b)
        {
            Console.WriteLine(CircleS(5));
            Console.WriteLine(CircleS(1.5f));
            Console.WriteLine(CircleS(15));
        }
        //19

        public void proc20()
        {
            Console.Write(TriangleP(5, 10));
            Console.Write(TriangleP(10, 5));
            Console.Write(TriangleP(3, 2,6f));
        }

        public void proc21(int a, int b, int c)
        {
            Console.Write(SumRange(a, b));
            Console.Write(SumRange(a, b));
            Console.Write(SumRange(a, b));

        }
        //22
        //23
        public void Proc24(int[] a)
        {
            int counter = 0;
            foreach (var num in a)
            {
                counter += (Even(num) ? 1 : 0);
            }
        }
        //25
        #endregion 
    }
}