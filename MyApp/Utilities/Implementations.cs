using System;


namespace MyApp.Utilities
{
    public class Implementations
    {
        public static int ReverseNumbers(int num)
        {
            //option 1
            //string output = "";
            //char[] charArray =num.ToString().ToCharArray();
            //for (int i = charArray.Length -1; i >= 0; i--)
            //{
            //    output += charArray[i];
            //}
            //return Int32.Parse(output);


            //option 2
            char[] charArray = num.ToString().ToCharArray();
            Array.Reverse(charArray);
            return Int32.Parse(new string(charArray));
        }

        public static int CalculateFacturial(int num)
        {
            //option 1
            //int result = 1;
            //if (num > 0) 
            //{
            //    while(num > 1) 
            //    {
            //        result *= num--;
            //    }
            //}
            //return result;

            //option 2 
            int result = 1;
            for (int i =1; i <= num; i++) 
            { 
                result *= i;
            }
            return result;
        }

        public static string LogestWord (string[] words) 
        {
            string longest = "";
            for (int i = 0; i < words.Length; i++) 
            {
                if (words[i].Length > longest.Length)
                {
                    longest = words[i];
                }
            }
            return longest;
        }



    }
}
