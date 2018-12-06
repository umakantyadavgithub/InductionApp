using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Calculate.Instance.ValueOne = 10.5;
                Calculate.Instance.ValueTwo = 5.5;
                Console.WriteLine("Addition : " + Calculate.Instance.Addition());
                Console.WriteLine("Subtraction : " + Calculate.Instance.Subtraction());
                Console.WriteLine("Multiplication : " + Calculate.Instance.Multiplication());
                Console.WriteLine("Division : " + Calculate.Instance.Division());
                Console.WriteLine("\n----------------------\n");
                Calculate.Instance.ValueTwo = 10.5;
                Console.WriteLine("Addition : " + Calculate.Instance.Addition());
                Console.WriteLine("Subtraction : " + Calculate.Instance.Subtraction());
                Console.WriteLine("Multiplication : " + Calculate.Instance.Multiplication());
                Console.WriteLine("Division : " + Calculate.Instance.Division());
                
                Console.WriteLine("Addition : " + Singleton.Instance.

                Console.ReadLine();

                //Console.WriteLine(Singleton.getInstance);
                //Console.WriteLine(Singleton.getInstance);
                //Console.ReadLine();

                //ClassA objA = new ClassA();
                //ClassA objA1 = new ClassA();
                //objA.Display(); // A


                //ClassA obj = new ClassB();
                //obj.Display(); // A

                //ClassA objC = new ClassC();
                //objC.Display(); //A

                //ClassB obj1 = new ClassB();
                //obj1.Display(); //B

                //ClassB obj2 = new ClassC();
                //obj2.Display(); //B

                //ClassC obj3 = new ClassC();
                //obj3.Display(); //C

                ////var x = objA;
                //var booll = objA.Equals(objA);


                //if (objA == objA)
                //{
                //    Console.WriteLine(booll);
                //}


                ////Console.ReadLine();
                ////throw new Exception("error occurred!!");
                //int i = 1;
                //int j = 0;
                //int k;
                //k = i/j;

            }
            catch (Exception ex)
            {
                throw;
                //throw ex;
            }
            
            

        }
    }
}
