using System;

namespace Mynamespase
{
    class Pen
    {
        public string color;
        public int cost;

        //Конструктор без параметров
        public Pen()
        {
            color = "black";
            cost = 100;
        }

        //Конструктор с параметрами
        public Pen(string penColor, int penCost)
        {
            color= penColor;
            cost = penCost;
        }
    }
}