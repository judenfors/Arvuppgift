using System;

namespace Arvuppgift
{
    public class Triangle: Shape
    {
        public Triangle(int width, int height): base(width,height)
        {
            
        }

         override public int Area(){
            int area = height * width / 2; 
            return area;
        }

        override public int Circumference(){
            int circumference = (int)Math.Sqrt( height * height + width * width) + height + width;
            return circumference;
        }
    }
}