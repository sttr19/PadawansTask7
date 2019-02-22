using System;

namespace PadawansTask7
{
    public class StringExtension
    {
        public static void OrderStringsByLength(string[] array)
        {

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i].Length > array[j].Length)
                    {
                        string tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
        }
    }
}