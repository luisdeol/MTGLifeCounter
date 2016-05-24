using System.Text;
using System;

namespace LifeCounter
{
    public static class Counter
    {
        public static string CounterPlus(int count)
        {
            return (count++).ToString();
        }
        public static string CounterMinus(int count)
        {
            return (count--).ToString();
        }
    }
}