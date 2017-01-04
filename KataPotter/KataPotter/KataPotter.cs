using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo
{
    public static class KataPotter
    {
        public static float GetPrice(int[] books)
        {
            if (books.Any(b => b > 5 || b < 1))
                throw new ArgumentException();

            if (books.Length == 0)
                return 0;

            if (books.All(b => b == books.First()))
                return books.Length * 8;

            int bookFirst = books.FirstOrDefault();
            if (books.Any(b => b != bookFirst))
                return books.Length * 8 * GetCoef(books.Length);

            return 8;
        }

        public static float GetCoef(int booksNumber)
        {
            switch (booksNumber)
            {
                case 2: return 0.95f;
                case 3: return 0.90f;
                    //case 4: return 0.80f;
                    //case 5: return 0.75f;
            }
            return 1;
        }
    }
}
