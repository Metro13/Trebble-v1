using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4_1
{
    class StatisticalData
    {
        private int num1;
        private int num2;
        private int num3;
        private int largest;
        private int smallest;
        private int average;

        public int Num1
        {
            set
            {
                num1 = value;
            }
            get
            {
                return num1;
            }
        }

        public int Num2
        {
            set
            {
                num2 = value;
            }
            get
            {
                return num2;
            }
        }

        public int Num3
        {
            set
            {
                num3 = value;
            }
            get
            {
                return num3;
            }
        }

        public int Largest
        {
            set
            {
                largest = value;
            }
            get
            {
                return largest;
            }
        }

        public int Smallest
        {
            set
            {
                smallest = value;
            }
            get
            {
                return smallest;
            }
        }

        public int Average
        {
            set
            {
                average = value;
            }
            get
            {
                return average;
            }
        }



        public void FindLargest()
        {
            if(Num1 > Num2 && Num1 > Num3)
            {
                Largest = Num1;
            }
            else if(Num2 > Num1 && Num2 > Num3)
            {
                Largest = Num2;
            }
            else
            {
                Largest = Num3;
            }
        }

        public void FindSmallest()
        {
            if (Num1 < Num2 && Num1 < Num3)
            {
                Smallest = Num1;
            }
            else if (Num2 < Num1 && Num2 < Num3)
            {
                Smallest = Num2;
            }
            else
            {
                Smallest = Num3;
            }
        }

        public void CalculateAverage()
        {
            Average = Num1 + Num2 + Num3 / 3;
        }
    }
}
