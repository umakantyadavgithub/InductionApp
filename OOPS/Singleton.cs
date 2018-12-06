// -----------------------------------------------------------------------
// <copyright file="Singleton.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace OOPS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public sealed class Singleton
    {
        private static int counter = 0;
        private Singleton()
        {
            counter++;
            Console.WriteLine(counter);
        }

        private  static  Singleton _instance = null;

        public static Singleton Instance
        {

            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }

        public double ValueOne { get; set; }
        public double ValueTwo { get; set; }
        public double Addition()
        {
            return ValueOne + ValueTwo;
        }
    }
}
