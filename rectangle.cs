using System;

namespace Arvuppgift
{
    public class Rectangle: Shape
    {
        public Rectangle(int width, int height): base(width,height)
        {
            
        }
        override public int Area(){
            int area = width * height;
            return area;
        }

        override public int Circumference(){
            int circumference = width * 2 + height *2;
            return circumference;
        }
    }
}