using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToTheBook
{
    class Color
    {



        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
            this.Alpha = alpha;
        }


        public Color(byte red, byte green, byte blue)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
            this.Alpha = 255;
        }



        private byte red;

        public byte Red
        {
            get { return red; }
            set { red = value; }
        }

        private byte green;

        public byte Green
        {
            get { return green; }
            set { green = value; }
        }

        private byte blue;

        public byte Blue    
        {
            get { return blue; }
            set { blue = value; }
        }

        private byte alpha;

        public byte Alpha
        {
            get { return alpha; }
            set { alpha = value; }
        }




        //public byte GetGrayScale()
        //{
            
        //}




    }
}
