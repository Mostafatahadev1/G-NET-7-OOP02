using System.Diagnostics;

namespace G_NET_7_OOP02
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1 Question 1 A
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

            #region Question 2 B

            /*
             To apply proper encapsulation, the class should be redesigned as follows:
            
                1- Make the fields private to hide internal data from direct external access.
            
                2-Provide properties to allow controlled read access to the data.
            
                3-Restrict modifications to the balance through well-defined methods such as:
                    A- A Deposit method to add funds, which checks for positive amounts.
                    
                    B- A Withdraw method that checks for sufficient balance and prevents negative withdrawals.
            
            
              4- Add validation rules inside these methods to enforce business logic, such as:
            
              5- Prevent withdrawing more than the available balance
            
              6- Reject negative amounts
            
            This ensures that the object fully controls how its data is accessed and modified.
             */
            #endregion

            #region Question 3 C 
            /*
             It breaks encapsulation
            External code can change the object’s data without following any rules.

            2️-It allows invalid object states => Without validation, the system may contain incorrect or inconsistent data.

            3️- It reduces maintainability => If validation or logic needs to be added later, every place that accesses the field must be modified.
                Using properties centralizes changes in one location.

            4️- It removes control from the class => In  object should define how its data is used and modified. Public fields remove this control and make the design fragile.
             */
            #endregion


            #region Question 4 

            // What is the difference between a Field and a Property in C#?

            /*
             1- A field is a variable that stores data directly inside a class.
                => Usually declared as public or private variables.
                => Has no validation or logic by default.
                => Breaks encapsulation if exposed publicly.
                => Accessed directly.
                => Example: public string Owner;
            2- A property provides controlled access to that data.
                => Uses get and set accessors.
                => Can include validation logic in the set accessor.
                => Supports encapsulation and protects object state.
                => Accessed through methods (get/set).
                => Looks like a field from outside but behaves like a method internally.
                => Example: public string Owner { get; private set; }

             */


            #endregion


            #region Question 5
            // What is this[int index] called? Explain its purpose.
            /*
            => It allows an object to be accessed like an array instead of using methods.
             Indexers improve:
                1- Readability => Accessing elements with array-like syntax is often more intuitive.
                2-Ease of Use => It allows for more natural code when working with collections or custom data structures.
                3- Natural acess => It allows the class to be accessed using an index, which can be more convenient than calling methods for certain types of data.
             */
            #endregion
        }


    }
}
