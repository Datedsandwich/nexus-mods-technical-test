using System;

class Swap
{
    public void swap(ref int a, ref int b)
    {
        var temp = a;
        a = b;
        b = temp;
    }
}