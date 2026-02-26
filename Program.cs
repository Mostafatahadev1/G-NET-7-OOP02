namespace G_NET_7_OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1 Question 1
            /*
             1 - Public fields expose internal data directly
              Both Owner and Balance are declared as public, which allows any external code to modify them without restriction.
                    A- A negative balance
                    B- An owner name that is empty or null
            2-No validation or control over data modification
               The Withdraw method subtracts the amount directly:
                    A- A negative amount could be withdrawn, which would increase the balance instead of decreasing it.
                    B- There is no check to prevent withdrawing more than the current balance, which could lead to an overdraft.
            3- The class loses control over its own state
                Encapsulation requires that an object manages and protects its internal data,
                but here the data can be changed freely from outside the class.
                



             */
            #endregion

        }
    }
}
