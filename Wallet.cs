using System.Collections;

namespace ConsoleAppUpdate
{
    public class Wallet : IEnumerable
    {
        Money[] bills = null;
        int openIndex = 0;

        public Wallet()
        {
            bills = new Money[100];
        }

        public void Add (Money bill)
        {
            bills[openIndex] = bill;
            openIndex++;
        }
        public IEnumerator GetEnumerator()
        {
            foreach (Money bill in bills)
            {
                if (bill == null)
                {
                    break;
                }

                yield return bill;
            }
        }

    }
}
