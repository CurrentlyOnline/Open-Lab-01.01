using System;

namespace Open_Lab_01._01
{
    public class Exercise
    {
        public bool IsLessThan10(string input)
        {
            int n;
            Int32.TryParse(input, out n);
            if (n < 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
