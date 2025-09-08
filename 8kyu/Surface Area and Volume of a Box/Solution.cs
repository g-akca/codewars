using System;

    public class Kata
    {
        public static int[] Get_size(int w,int h,int d) => [2 * (w * h + w * d + h * d), w * h * d];
    }