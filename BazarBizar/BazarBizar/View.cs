﻿using System;
using System.Diagnostics.Eventing;

namespace BazarBizar
{
    public class View
    {

        public View()
        {
            Console.ReadKey(true);
        }

        public static void WriteLine(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void Write(string msg)
        {
            Console.Write(msg);
        }
    }
}