﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class RepeatPosition
    {
        public static void CheckPosition()
        {
            int position = 0;
            int player = 1;


            

            while( position != 100)
            {
                Random random = new Random();
                int dieroll = random.Next(0, 7);
                switch (dieroll)
                {
                    case 1:
                        Console.WriteLine("Play Snake");
                        position -= 1;
                        break;
                    case 2:
                        Console.WriteLine("Play Ladder");
                        position++;
                        break;
                    default:
                        Console.WriteLine("No play");
                        break;
                }
            }
            if (position < 0)
            {
                position = 0;
            }
            
        }
    }
}
