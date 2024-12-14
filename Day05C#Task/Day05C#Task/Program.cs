using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;

namespace Day05C_Task
{
    internal class Program
    {
        #region part_1

        #region problem_2+Que  
        //public static void TestDegensiveCode()
        //{
        //    int X, Y, Z;
        //    //bool flag;
        //    do
        //    {
        //        Console.WriteLine("enter first number :");
        //    }
        //    while (!int.TryParse(Console.ReadLine(), out X) || X<=0);
        //    do
        //    {
        //        Console.WriteLine("enter second number :");
        //    } 
        //    while (!int.TryParse(Console.ReadLine(), out Y) || Y <= 1);
        //    Z = X / Y;
        //    Console.WriteLine($"Result of {X} / {Y} = {Z}");

        //    int[] arr = { 1, 2, 3, 4 };
        //    if (arr?.Length > 108)
        //        arr[108] = 78;
        //}
        //Question: How does int.TryParse() improve program robustness compared toint.Parse()?
        /*`int.TryParse()`** improves program robustness by avoiding exceptions when parsing invalid inputs. 
         * Instead of throwing an error like `int.Parse()`, it returns a `bool` indicating success or failure,
         * allowing graceful handling of invalid inputs and keeping the program stable and efficient.
         */
        #endregion

        #region problem_9  

        //problem 9
        public static void SumAndMultiply(int Num1, int Num2, out int Sum, out int Mul)
        {
            Sum = Num1 + Num2;
            Mul = Num1 * Num2;
        }
        #endregion

        #region problem 10 
        // problem 10
        public static void Print(String Name, int Value = 5)
        {
            for (int i = 0; i < Value; i++)
            {
                Console.WriteLine(Name);
            }
        }
        #endregion

        #region problem_13  
        //problem 13
        public static void SumArray(params int[] Values)
        {
            int Sum = 0;
            foreach (int i in Values)
            {
                Sum += i;
            }
            Console.WriteLine($"The Sum of passed values= {Sum}");
        }
        #endregion
        #endregion

        #region part_2
        #region problem_1 
        //problem_1
        public static void printNums(int Num)
        {
            int i;
            for (i = 1; i < Num; i++)
            {
                Console.Write(i + ", ");
            }
            Console.Write(i);
        }
        #endregion

        #region problem_2  
        public static void MulTable(int num)
        {
            int i;
            for (i = 1; i < 12; i++)
            {
                Console.Write(num * i + ", ");
            }
            Console.WriteLine(num * i);
        }
        #endregion

        #region problem_4 
        public static void printEven(int Num)
        {
            for (int i = 1; i <= Num; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ", ");
                }
                else
                {
                    continue;
                }
            }
        }
        #endregion

        #region problem_4 
        public static void printExponentiation(int Num1, int Num2)
        {
            Console.WriteLine(Math.Pow(Num1, Num2));

        }
        #endregion

        #region problem_5
        public static void Reverse(String Value)
        {
            String ReversedValue = "";
            for (int i = Value.Length - 1; i >= 0; i--)
            {
                ReversedValue += Value[i];
            }
            Console.WriteLine(ReversedValue);
        }
        #endregion

        #region problem_6
        public static void ReverseNums(int Num)
        {

            while (Num > 0)
            {
                int LastDigit = Num % 10;
                Console.Write(LastDigit);
                Num = Num / 10;
            }
            Console.WriteLine();

        }
        #endregion

        #region problem_7
        public static int FindLongestDistance(int[] arr)
        {
            int maxDistance = 0;

            // Loop through each element
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[i] == arr[j])
                    {
                        int distance = j - i;
                        if (distance > maxDistance)
                        {
                            maxDistance = distance;
                        }
                        break; // No need to check earlier indexes for the same element
                    }
                }
            }

            return maxDistance;
        }
        #endregion

        #region problem_8
        public static String ReverseWords(String Sintance)
        {
            String[] Words = Sintance.Split(' ');

            Array.Reverse(Words);

            String ReversedSentance = String.Join(" ", Words);
            return ReversedSentance;
        }
        #endregion 
        #endregion

        static void Main(string[] args)
        {

            #region Part01  
            #region Problem_1 +Que  
            //    Console.WriteLine("Enter the first num,please!");
            //    String Input1 = Console.ReadLine();
            //    Console.WriteLine("Enter the second num,please!");
            //    String Input2 = Console.ReadLine();

            //    if(int.TryParse(Input1, out int num1) && int.TryParse(Input2, out int num2))
            //    {
            //        try
            //        {
            //            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            //        }
            //        catch (DivideByZeroException ex)
            //        {
            //            Console.WriteLine(ex.Message);
            //        }
            //        finally
            //        {
            //            Console.WriteLine("Operation complete");
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input! Please enter valid integers.");
            //    }
            //Question: What is the purpose of the finally block?
            /*Purpose of the finally Block:
              The finally block in C# ensures that a specific section of code is always executed, 
              regardless of whether an exception was thrown or caught. It is typically used for cleanup tasks or 
              releasing resources that need to occur regardless of success or failure in the try block.

             Key Points:
             1-Guaranteed Execution:
              The code in the finally block runs whether an exception occurs or not.

             2-Resource Management:
             Commonly used to release resources like file handles, database connections, or memory, ensuring no resource leaks.

             3-Works with Try-Catch:
             A finally block can exist with or without a catch block. If no exception is thrown, it still runs after the try block.

             4-Cannot Skip Execution:
             Even if the try or catch block contains a return statement, the finally block will still execute before the method exits.
             */
            #endregion

            #region problem_3+Que  
            // int? NullableInt = null;
            // //null Colescing operator
            //int DefaultValue = NullableInt ?? 10;
            // Console.WriteLine($"Value after using null-coalescing operator: {DefaultValue}");

            // if (NullableInt.HasValue)
            // {
            //     Console.WriteLine($"Value: {NullableInt.Value}");
            // }
            // else
            // {
            //     Console.WriteLine("Value is null, so accessing 'Value' would throw an exception.");
            // }

            //Question: What exception occurs when trying to access Value on a null Nullable<T>?
            /*When trying to access the Value property of a Nullable<T> type (e.g., int?) that is null,
             * an InvalidOperationException occurs.
             */
            #endregion

            #region Problem_4+Que 
            //int[] Arr1 = {1,2,3,4,5}; //fixed size=5
            //try
            //{
            //    Console.WriteLine(Arr1[50]);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Question: Why is it necessary to check array bounds before accessing elements?
            /*
             It is necessary to check array bounds before accessing elements to prevent the following issues:

            1. **IndexOutOfRangeException**: If you try to access an element outside the valid range of the array
            (i.e., using an index less than `0` or greater than or equal to the array's length), 
            the program will throw an `IndexOutOfRangeException`. This can cause the program to crash or behave unexpectedly.

            2. **Memory Corruption**: Accessing invalid array indices can lead to memory corruption 
            or undefined behavior,as you may overwrite memory that is not allocated for the array.

            3. **Data Integrity**: Ensuring proper bounds checking maintains the integrity of your data,
            as accessing the wrong index might result in incorrect or unintended values.

            4. **Program Stability**: By validating array bounds before accessing elements, 
            you make the program more robust, avoiding runtime errors and ensuring smoother user experiences. 

            In general, checking bounds helps to maintain safe and predictable execution of the program.
             */
            #endregion

            #region problem_5+Que  
            //int[,] Students_Grades = new int[3, 3];
            //for (int i = 0; i < Students_Grades.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter the Grades of Studnt number {i+1}");
            //    for (int j = 0; j < Students_Grades.GetLength(1);)
            //    {
            //        Console.WriteLine($"For subject number {j+1}");
            //        bool Flag = int.TryParse(Console.ReadLine(), out Students_Grades[i, j]);
            //        j = (Flag && Students_Grades[i, j] >= 0) ? ++j : j; 
            //    }
            //}

            ////Row_Sum --> Grades of each student
            //for(int i = 0;i<Students_Grades.GetLength(0);i++)
            //{
            //    int RowSum = 0;
            //    for(int j = 0;j<Students_Grades.GetLength(1);j++)
            //    {
            //        RowSum += Students_Grades[i, j];
            //    }
            //    Console.WriteLine($"Grades Sum of Student number {i+1} = {RowSum}");
            //}

            ////Col_Sum --> Grades Sum of each subject

            //for(int j= 0;j<Students_Grades.GetLength(1);j++)
            //{
            //    int ColSum= 0;
            //    for(int i = 0;i<Students_Grades.GetLength(0);i++)
            //    {
            //        ColSum += Students_Grades[i, j];
            //    }
            //    Console.WriteLine($"Grades Sum of Subject number {j+1} = {ColSum}");
            /*The GetLength(dimension) method is used in multi-dimensional arrays 
        * to retrieve the size of a specific dimension of the array.

       Syntax:
      array.GetLength(dimension)
      array: The multi-dimensional array.
      dimension: The zero-based index of the dimension for which you want to retrieve the size.
      Key Points:
      Dimension Index:

        0 represents the first dimension (rows in a 2D array).
        1 represents the second dimension (columns in a 2D array).
       For higher-dimensional arrays, you can pass indices like 2, 3, etc.
       Return Value:
      Returns an int representing the number of elements in the specified dimension.
        */
            #endregion

            #region problem_6+Que  
            //// Step 1: Declare and initialize the jagged array with varying row sizes
            //int[][] jaggedArray = new int[3][];

            //jaggedArray[0] =new int [2] ;
            //jaggedArray[1] =new int [3] ;
            //jaggedArray[2] =new int [4] ;

            //// Step 2: Populate the jagged array with user input
            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    Console.WriteLine($"Enter {jaggedArray[i].Length} values for row {i + 1}:");
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        bool isValidInput;
            //        do
            //        {
            //            Console.Write($"Enter value for element {j + 1} in row {i + 1}: ");
            //            string input = Console.ReadLine();
            //            isValidInput = int.TryParse(input, out jaggedArray[i][j]);
            //            if (!isValidInput)
            //            {
            //                Console.WriteLine("Invalid input! Please enter a valid integer.");
            //            }
            //        } while (!isValidInput);
            //    }
            //}

            //// Step 3: Print the jagged array row by row
            //Console.WriteLine("\nThe values in the jagged array are:");
            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    Console.Write($"Row {i + 1}: ");
            //    foreach (int value in jaggedArray[i])
            //    {
            //        Console.Write(value + " ");
            //    }
            //    Console.WriteLine();
            //}

            ////Question: How does the memory allocation differ between jagged arrays and rectangular arrays ?

            /*
             * Memory Allocation Differences:
             Jagged Arrays:
             Array of arrays, where rows can have different sizes.
             Memory is allocated separately for each row (non-contiguous).
             Flexible and saves memory for varying row sizes but slightly slower access.

             Rectangular Arrays:
             Fixed-size 2D array where all rows are the same length.
             Memory is allocated as a single contiguous block.
             Faster access and simpler, but wastes memory if rows vary in size.
             */
            #endregion

            #region problem_7+Que  
            //String? Name = null!;
            //Console.WriteLine("Please, Enter your Name or (press Enter to skip! )");
            //Name=Console.ReadLine();
            ////String InputName = Name ?? "Default Value";
            //String InputName=String.IsNullOrEmpty(Name)?"Default Value": Name;
            //Console.WriteLine($"The Final value is {InputName!}");


            // Question: What is the purpose of nullable reference types in C#?Question: What is the purpose of nullable reference types in C#?
            /*
             * Nullable reference types improve program robustness and reliability by:

            1-Enforcing nullability rules.
            2-Encouraging defensive programming practices.
            3-Catching potential null-related issues during compilation.
             */
            #endregion

            #region problem_8+ Que 
            //Object O1;
            //O1 = new Object();

            //try 
            //{
            //    O1 = 10;  //Boxing -->Safe Casting
            //    int Num = (int)O1;  //Unboxing
            //    Console.WriteLine($"Unboxed Value : {Num}");
            //}
            //catch(InvalidCastException ex)
            //{
            //    Console.WriteLine(ex.Message );
            //}


            //Question: What is the performance impact of boxing and unboxing in C#?
            /*
             * Boxing and unboxing introduce a performance overhead because they involve runtime operations, 
             * including memory allocation on the heap and type conversion. These operations can be costly in
             * scenarios where they occur frequently, impacting application performance.
             */
            #endregion

            #region problem_9 + Que   
            //int Sum,Mul;
            //SumAndMultiply(10, 20,out Sum,out Mul);

            //Console.WriteLine($"The Sum of two nums = {Sum}");
            //Console.WriteLine($"The Product of two nums = {Mul}");

            //Question: Why must out parameters be initialized inside the method?
            /*In C#, out parameters must be initialized inside the method because they are explicitly intended to return data
             * from the method to the caller. This ensures the caller receives meaningful and valid data when the method finishes execution.
             */
            #endregion

            #region problem_10 + Que  
            //String Name = "Haneen";
            //Print(Name);// not necessary to pass the optional argument (Value)
            //Console.WriteLine("---------------------------------------------------------");
            //Print(Name, 7); 

            //Question: Why must optional parameters always appear at the end of a method's parameter list ?

            /*
             *1- Unambiguous Method Calls:

            When calling a method with optional parameters, the compiler needs to know which arguments are being passed explicitly 
            and which are being assigned their default values.
            If optional parameters were placed before required ones, the compiler would not be able to distinguish between an
            argument passed explicitly for an optional parameter and one intended for a required parameter.

           2- Compiler Behavior:

           When optional parameters are placed at the end of the parameter list, the compiler can easily assume that any
           missing arguments correspond to the default values for those optional parameters.
           For example, in the method call Method(a, b), if b is optional, the compiler can infer that b uses its default value,
            and the method must have at least a specified.

           3-Consistent Method Overloading:
            If optional parameters could appear in the middle of a parameter list, it would make method overloading more difficult
            and error-prone. The compiler would not know how to select the appropriate overload when a method is called, leading to ambiguity.
             */
            #endregion

            #region problem_11+ Que  
            //int[]? Array = null;

            //// Using the null propagation operator to check if the array is null
            //if (Array?.Length>0)
            //{
            //    for (int i = 0; i < Array.Length; i++)
            //    {
            //        Console.WriteLine(Array[i]);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("The Array is null or Empty! ");
            //}

            ////Assigning a non-null value to demonstrate accessing elements
            //Array = new int[] { 1, 2, 3, 4, 5 };

            //if (Array?.Length > 0)
            //{
            //    for (int i = 0; i < Array.Length; i++)
            //    {
            //        Console.WriteLine(Array[i]);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("The Array is null or Empty! ");
            //}

            //Question: How does the null propagation operator prevent NullReferenceException?
            /*
             *1-Prevents exceptions: It automatically prevents NullReferenceException by returning null instead of attempting to access a member on a null object.
             2-Reduces boilerplate code: You don't need to manually check if the object is null before accessing its members.
             3-Improves readability: It simplifies code, especially in cases where null checks are common.*/
            #endregion

            #region problem_12 + Que  
            //Console.WriteLine("Enter a day of the week, Please! ");
            //String Day =Console.ReadLine();

            //switch (Day)
            //{
            //    case "Monday":
            //        Console.WriteLine(1); break;
            //    case "Tuseday":
            //        Console.WriteLine(2); break;
            //    case "Wednsday":
            //        Console.WriteLine(3); break;
            //    case "Thursday":
            //        Console.WriteLine(4); break;
            //    case "Friday":
            //        Console.WriteLine(5); break;
            //    case "Saturday":
            //        Console.WriteLine(6); break;
            //    default:
            //        Console.WriteLine(7); break;
            //}

            //Question: When is a switch expression preferred over a traditional if statement?

            /*A switch expression is preferred over a traditional if statement in the following scenarios:

            1-When there are multiple conditions:
             A switch expression is more concise and readable when you have several possible values to check,
              as it avoids multiple else if statements and makes the code more structured.

           2-When you need to return a value:
           A switch expression is designed to return a value directly, making it ideal for situations where the result of the expression 
            is used immediately in an assignment or function call. In contrast, a traditional if statement typically requires additional code to return a value.

          3-When you have constant values to compare:
          If the conditions involve comparing a variable to constant values, a switch expression can handle this more cleanly and in
            a more readable way than if statements.

           4-When using patterns or type checks:
           A switch expression supports more advanced patterns, such as type checks or complex matching, making it a better choice than 
            a series of if statements.*/
            #endregion

            #region problem_13+Que  

            //// Calling the method with individual values
            //SumArray(1, 2, 3, 4, 5);

            //int[] Arr = { 1, 2, 3 };

            //// Calling the method with an array of integers
            //SumArray(Arr);

            //Question: What are the limitations of the params keyword in method definitions?

            /*The params keyword in C# has several important limitations:

           1- Only One params Parameter:
            A method can only have one parameter marked with the params keyword. This parameter must be the last parameter in the method's signature.

          2- Array Type:
          The parameter with the params keyword must be of array type. You can use any array type, such as int[], string[], etc.

          3-No Additional Arrays After params:
           If you use the params keyword, no other array or collection parameters can follow it. The params array parameter must be the last one.

          4-Implicit Array Creation:
          When calling a method with params, you can pass a comma-separated list of arguments, but this implicitly creates an array.
            You cannot pass an array directly unless you specifically use the array itself as an argument.

         5-Limited to One Type:
          The type specified in the params array must be consistent for all passed arguments. For example, params int[] expects all arguments to be integers.

         6-Cannot Mix params with Named Arguments:
         If you use named arguments, the params array cannot be mixed with other named arguments in the method call.*/
            #endregion
            #endregion

            #region Part02  
            // part02

            //printNums(6);

            // MulTable(7);

            // printEven(16);

            // printExponentiation(3, 4);

            // Reverse("Hello");

            // ReverseNums(12345);

            #region problem_7  
            //Console.WriteLine("Enter the size of the array:");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];
            //Console.WriteLine("Enter the elements of the array:");

            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int longestDistance = FindLongestDistance(arr);
            //Console.WriteLine($"The longest distance between matching elements is: {longestDistance}");

            #endregion

            #region problem_8  
            //Console.WriteLine("Enter a sentence:");
            //string input = Console.ReadLine();

            //string result = ReverseWords(input);
            //Console.WriteLine($"Reversed sentence: {result}"); 
            #endregion 
            #endregion








        }

    }
}
