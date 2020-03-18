﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Product
    {

        private LinkedList<string> parts;

        public Product()
        {
            parts= new LinkedList<string>();
        }

        public void Add(string part)
        {
            parts.AddLast(part);
        }

        public void Show()
        {
            Console.WriteLine("\n Product completed as below :");
            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}