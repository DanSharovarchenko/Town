﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town
{
    class TrafficLightPassenger:TrafficLight
    {
        public TrafficLightPassenger(string name, int lights, int greenTime, int redTime) : base(name, lights, greenTime)
        {
            RedTime = redTime;
        }
        public TrafficLightPassenger() : base("Пешеходный светофор", 2, 30)
        {
            RedTime = 50;
        }
        public int RedTime;
        public override void PrintInfo()
        {
            base.PrintInfo();
        }
    }
}
