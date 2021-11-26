using Kata3;
using System;
using System.ComponentModel.DataAnnotations;

namespace Kata3
{
    public class Validatorisbn
    {
        public bool Valid10(string isbn)
        {
            string isbnN = System.Text.RegularExpressions.Regex.Replace(isbn, "[^ .0-9]", "");

            if (isbnN.Length != 10)
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
            string isbnN = System.Text.RegularExpressions.Regex.Replace(isbn, "[^ .0-12]", "");

            if (isbnN.Length != 10)
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

    }
}

class main
{
    static void Main(string[] args)
    {
        Validatorisbn obj = new Validatorisbn();


        string isbn = "0716703440";

        if (obj.Valid10(isbn))
            Console.WriteLine("Valid");
        else
            Console.WriteLine("Invalid");

        string iisbnn = "9780716703440";

        if (obj.Valid13(iisbnn))
            Console.WriteLine("Valid");
        else
            Console.WriteLine("Invalid");
    }
}


