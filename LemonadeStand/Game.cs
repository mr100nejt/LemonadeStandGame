﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        //comunicate weather to player
        // what day it is 
        // profits since begening game 
      public Weather weather = new Weather();  
        public Game()
        {
            Console.WriteLine(weather.forcast[0]);
            Console.ReadLine(); 
        }
    
    }
}