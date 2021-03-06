﻿using System;
using System.Text;

namespace ShapeLib
{
    public class Rectangle : Shape , IPersist, IComparable
    {
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public Rectangle(int width, int height, ConsoleColor color) : base(color)
        {
            Width = width;
            Height = height;
        }

        private int Width { get; }

        private int Height { get; }

        public override double Area => Width * Height;

        public override void Display()
        {
            Console.BackgroundColor = Color;
            Console.WriteLine($"the width is " + Width + " the height is " + Height);
        }

        public void Write(StringBuilder sb)
        {
            sb.AppendLine("the width is " + Width + " the height is " + Height);
        }

        public int CompareTo(object obj)
        {
            dynamic shape = obj;
            if (Area > shape.Area)
                return 1;
            if (Area == shape.Area)
                return 0;
            return -1;
        }
    }
}
