using System;

namespace OneHunderedDoors
{
    class Doors
    {
        //Unoptimized way to solve.  Going down the list of doors 100 times
        public int[] OpenClose()
        {
            int[] doors = new int[100];
            for(int i = 0; i < doors.Length;i++)
            {
                for(int k = i; k < doors.Length;k=k + i + 1)
                {
                    if(doors[k] == 0)
                    {
                        doors[k] = 1;
                    }
                    else
                    {
                        doors[k] = 0;
                    }
                }
            }
            return doors;            
        }

        //Slighly different from about using Bools instead of ints.  Also different way of skipping doors each pass
        public bool[] TFOpenClose()
        {
            bool[] doors = new bool[100];
            for(int i = 0; i < doors.Length;i++)
            doors[i] = false;
            for(int i = 0; i < doors.Length;i++)
            {
                for(int k = 0; k < doors.Length;k++)
                {
                    if((k+1)%(i+1) == 0)
                    doors[k] = !doors[k];
                }
            }
            return doors;
        }
        
        //Optimized way by seeing that the open doors will always be perfect squares.  Only need to go down the 
        //list of doors once to get the answer
        public int[] OptiOpenClose()
        {
            int [] doors = new int[100];
            for(int i = 0; i < doors.Length; i++)
            {
                if(Math.Sqrt(i+1)%1 == 0)
                {
                    doors[i] = 1;
                }
            }
            return doors;
        }
    }
}