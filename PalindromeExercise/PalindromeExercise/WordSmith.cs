using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public WordSmith() { }
        public bool IsAPalindrome(string a)
        {
            string backwards = "";
            if (a != null && a != "")
            {
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    backwards += a[i];
                }
                if (a == backwards)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
            
            
           
        }
    }
}
