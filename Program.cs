using System.Diagnostics;

namespace G_NET_7_OOP02
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1

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

            #region Question 6
            // What happens if someone writes `register[10] = "Ali";` ? How would you make the indexer safer?
            /*
             => IndexOutOfRangeException => run-time error if the index is out of bounds. => Invalid index
            How to make the indexer safer
                1- Add bounds checking => Check if the index is within the valid range before accessing the array.
                2- Throw a meaningful exception => If the index is out of bounds, throw an exception with a clear message.
                3- Use a collection that handles bounds automatically => Instead of using a raw array, use a List<string> which provides built-in bounds checking.
                     => We prevented an incomprehensible crash
                     => We continued to protect the data (Encapsulation as well).
             */
            #endregion

            #region Question 7
            // a) What does the `static` keyword mean on `TotalOrders`?
            /*
             => static means this variable belongs to the class itself (Order)
             => not to individual objects (instances)
             => All objects of Order share the same TotalOrders variable
                For example ;
                    Order order1 = new Order("Pizaa");
                    Order order2 = new Order("Burger");
                    order1.TotalOrders++; // TotalOrders is now 1
                    order2.TotalOrders++; // TotalOrders is now 2 (shared across all instances)
             => TotalOrders will be 2 (shared across all objects)
             => Difference between TotalOrders and Item:
                - TotalOrders → static (shared between all objects)
                - Item → instance variable (each object has its own copy)
            o1.Item = "Pizaa"
            o2.Item = "Burger"


 

             */

            #endregion

            #region Question 8
            // b) Can a static method inside `Order` access the `Item` field directly?
            /*
             => No, it cannot
             => Because static methods belong to the class, not to a specific object
             => And Item is an instance variable, which requires an object
             => Correct way: pass an object to the static method

            
                public static void PrintItem(Order order)
                {
                    Console.WriteLine(order.Item); // correct
                }
                
                public static void PrintItem()
                {
                    // Console.WriteLine(Item); ===> compile-time error
                }
                




             */

            #endregion


            #endregion

        }


    }
}
