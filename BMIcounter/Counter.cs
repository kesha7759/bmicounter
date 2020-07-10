using System;
using System.Collections.Generic;
using System.Text;

namespace BMIcounter
{
    class Counter
    {
        private double height;
        public int Weight { get; set; }
        
        public double Height 
        {
            get => height;
            set => height = value/100;
        }
        public Counter (int weight, int height)
        {
            Weight = weight;
            Height = height;
        }
        public double Score()
        {
            return Weight/(Height*Height);   
        }
    }
}
