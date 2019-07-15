using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{

    /// View legend.txt for button and operaion numbers

    class CalcModel
    {
        private double firstNum;
        private double secondNum;
        private int operation;

        public CalcModel(){}


        public void setFirstNum(double firstNum)
        {
            this.firstNum = firstNum;
        }

        public void setSecondNumber(double secondNum)
        {
            this.secondNum = secondNum;
        }

        public void setOperation(int operation)
        {
            this.operation = operation;
        }


        public double calculate()
        {
            switch (operation)
            {
                case 4:
                    return firstNum / secondNum;
                case 5:
                    return firstNum * secondNum;
                case 6:
                    return firstNum - secondNum;
                case 7:
                    return firstNum + secondNum;
                default:
                    return 0.0;
            }
        }

    }




}
