﻿namespace GCB.Utility.Memory
{
    public static class Pressure
    {
        public static void PauseAfter(this int incrementalVariable, int nthOperation, decimal pauseTimeInMilliseconds)
        {
            if(incrementalVariable % nthOperation == 0)
            {
                Thread.Sleep(1);
            }
        }
    }
}
