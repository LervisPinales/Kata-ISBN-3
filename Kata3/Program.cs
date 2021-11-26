using System;

namespace Kata3
{
    public class Program
    {
        public bool Valid10(string isbn)
        {
            string isbnN = System.Text.RegularExpressions.Regex.Replace(isbn, "[^ .0-9]", "");

            if (isbnN.Length)
            {
                return false;
            }

            int result = 0;

            for (int i = 0; i < isbnN.Length; i++)
            {
                int num = -1;
                num = (int)char.GetNumericValue(isbnN[i]);
                result = result + num * (10 - i);
            }

            return ((result % 11) == 0);
           
        }

        public bool Valid13(string isbn)
        {

        }
    }
}
