using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace MS_CS_Pt1
{
    internal class Program
    {
        static void PassArrayByRef(ref int[] numsArray)
        {
            // Modify the first element of the array
            numsArray[0] = 49;
            // Return the sum of all elements in the array
            numsArray = new int[] { 7, 8, 9 };

        }
        static void Main(string[] args)
        {
            // Debugging
            /*string name = "challenges";//breakpoint can be set when you click far left margin
            int[] number = [1, 2, 3, 4];
            Console.WriteLine($"Hello, {name}!"); 
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"You are {age} years old.");*/


            //SumTwoNumbers();
            //FistDegreeEq();
            //Pass_or_Fail();
            //DivisionOfTwoNumbers();
            //Even_or_Odd();
            //CountFrom1To10();
            //IntergerFrom1to3();
            //MS_CS_Pt1();
            //MS_CS_Pt2();
            //MS_CS_Pt3();
            //MS_CS_Pt4();

            // Call the Methods to execute the functionality (MS_CS_Pt5)
            /*int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int ouput = AddTwoNumbers(n1, n2);
            Console.WriteLine("The sum of " + n1 + " and " + n2 + " is: " + ouput);*/

            // Using ref keyword (MS_CS_Pt5)
            /*int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int ouput = AddTwoNumbers(ref n3, ref n4);
            int result = n3 + n4;
            Console.WriteLine("results: {result}");*/

            // Passby value vs Passby reference (MS_CS_Pt5)
            /*int[] nums = new int[] { 1, 2, 3, 4 };
            // method call
            int[] output = PassArrayByValue(nums);
            Console.WriteLine(output);*/

            // Passby reference (MS_CS_Pt5)
            /*int[] nums = new int[] {1, 2, 3, 4};
            Console.WriteLine($"Before method call: {nums[0]} \n");//1
            // Method call
            PassArrayByRef(ref nums);
            Console.WriteLine($"After method call: {nums[0]} \n");//7*/

            //MS_CS_Pt6();

        }
        // Add parameters to the method (MS_CS_Pt5)
        static int AddTwoNumbers(int num1, int num2)
        {
            // Store the first parameter (num1) in a local variable 'x'
            int x = num1;

            // Store the second parameter (num2) in a local variable 'y'
            int y = num2;

            // Add x and y, store the result in a variable named 'resultOfSum'
            int resultOfSum = x + y;

            // Return the result of the addition to the part of the program that called this method
            return resultOfSum;

            // Alternatively, we could simplify this by returning the sum directly:
            // return num1 + num2;
        }

        // Add parameters to the method (MS_CS_Pt5)
        // 'static' means this method belongs to the class itself, not an object.
        // 'int' means the method will return an integer value.
        // '(ref int num1, ref int num2)' means both parameters are passed BY REFERENCE,
        // so the method can modify their original values directly.
        static int AddTwoNumbers(ref int num1, ref int num2)
        {
            // Assign new values to both variables.
            // Because we’re using 'ref', these changes will affect the variables
            // in the code that *called* this method.
            num1 = 5;
            num2 = 10;

            // Add the two numbers and store the result in 'resultOfSum'.
            int resultOfSum = num1 + num2;

            // Return the sum to the caller.
            return resultOfSum;

            // Alternatively, we could have written:
            // return num1 + num2;
        }

        static int[] PassArrayByValue(int[] numsArray)
        {
            // Modify the first element of the array.
            // Even though arrays are passed BY VALUE, they are REFERENCE TYPES.
            // That means the method receives a *copy of the reference* to the same array in memory.
            // So changing numsArray[0] here ALSO changes the original array outside this method.
            numsArray[0] = 49;

            // Reassign the parameter 'numsArray' to a *new array*.
            // This does NOT affect the original array outside the method,
            // because now 'numsArray' is pointing to a *different array object* in memory.
            numsArray = new int[] { 7, 8, 9 };

            // Return the new array (the one we just created with 7, 8, 9).
            return numsArray;
        }

        static void SumTwoNumbers()
        {
            // Ask for input before calling ReadLine()
            // 'Console.Write()' displays a message on the screen without moving to a new line.
            // This makes it clear to the user what to type next.
            Console.Write("Enter number 1: ");

            // Read user input from the keyboard as a string.
            // 'Console.ReadLine()' waits for the user to type something and press Enter.
            // 'int.Parse()' converts that text input into an integer.
            int num1 = int.Parse(Console.ReadLine());

            // Prompt the user for the second number.
            Console.Write("Enter number 2: ");
            int num2 = int.Parse(Console.ReadLine());

            // Perform the addition.
            // Here we simply add num1 and num2 and store the result in a new variable.
            int result = num1 + num2;

            // Display the result on the console.
            // 'Console.WriteLine()' prints the text and moves to a new line afterward.
            Console.WriteLine("The sum is: " + result);
        }

        static void FistDegreeEq()
        {
            // Explain the equation: y = 3x + 2
            // We'll calculate y for a value of x provided by the user.

            // Prompt the user to enter a value for x
            // Console.Write() prints text without a newline.
            Console.Write("Enter number for x in the equation 3x+2: ");

            // Read user input as a string and convert it to an integer
            // int.Parse() converts the input string to an int.
            // If the user types something that isn't a number, it will throw an error.
            int num1 = int.Parse(Console.ReadLine());

            // Calculate the equation using the input
            // Multiply x by 3, then add 2
            int result = (3 * num1) + 2;

            // Print the result in a readable format
            Console.WriteLine("The result of the equation 3(" + num1 + ") + 2 = " + result);
        }

        static void Pass_or_Fail()
        {
            // Prompt the user to enter a grade
            // Console.Write() prints the message without a newline so the input stays on the same line
            Console.Write("Please enter your grade (0-100): ");

            // Read the input from the user and convert it to an integer
            // int.Parse() takes the string from Console.ReadLine() and turns it into an integer
            int grade = int.Parse(Console.ReadLine());

            // Use an 'if' statement to check if the grade is passing
            // If the grade is 60 or higher, the student passes
            if (grade >= 60)
            {
                // Print a congratulations message if the student passed
                Console.WriteLine("Congratulations! You passed.");
            }
            else
            {
                // Print a message if the student failed
                Console.WriteLine("Unfortunately, you failed.");
            }
        }

        static void DivisionOfTwoNumbers()
        {
            // Prompt the user to enter the dividend (the number to be divided)
            // Console.Write() prints a message without moving to a new line
            Console.Write("Enter the dividend: ");
            // Read the user input as a string and convert it to a double
            double dividend = double.Parse(Console.ReadLine());

            // Prompt the user to enter the divisor (the number to divide by)
            Console.Write("Enter the divisor: ");
            // Read input and convert to double
            double divisor = double.Parse(Console.ReadLine());

            // Check if the divisor is not zero
            // Division by zero is not allowed in mathematics
            if (divisor != 0)
            {
                // Perform the division if the divisor is valid
                double result = dividend / divisor;

                // Display the result
                Console.WriteLine("The result of the division is: " + result);
            }
            else
            {
                // Handle the case when the divisor is zero
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
        }

        static void Even_or_Odd()
        {
            // Prompt the user to enter a number
            // Console.Write() prints the text on the same line, waiting for input
            Console.Write("Please enter a number: ");

            // Read the user input and convert it to an integer
            // int.Parse() converts the string input from Console.ReadLine() into an int
            int number = int.Parse(Console.ReadLine());

            // Check if the number is even
            // The '%' operator calculates the remainder of division
            // number % 2 == 0 means the number is divisible by 2 (even)
            if (number % 2 == 0)
            {
                // If true, print that the number is even
                Console.WriteLine("The number " + number + " is even.");
            }
            else
            {
                // If false (not divisible by 2), the number is odd
                Console.WriteLine("The number " + number + " is odd.");
            }
        }

        static void CountFrom1To10()
        {
            // Use a 'for' loop to count from 1 to 10
            for (
                int count = 1;      // Initialize the loop variable 'count' to 1
                count <= 10;        // Continue looping as long as 'count' is less than or equal to 10
                count++             // After each iteration, increment 'count' by 1
            )
            {
                // Print the current value of 'count' to the console
                Console.WriteLine(count);
            }
        }

        static void IntergerFrom1to3()
        {
            // Initialize a variable to store the sum
            // Starting with 0 because we haven't added anything yet
            int sum = 0;

            // Use a 'for' loop to iterate through numbers from 1 to 3
            for (
                int num = 1;   // Initialize loop variable 'num' to 1
                num <= 3;      // Continue looping while 'num' is less than or equal to 3
                num++          // Increment 'num' by 1 after each iteration
            )
            {
                // Add the current number to the sum
                // sum = sum + num; is the same as sum += num;
                sum += num;
            }

            // Print the total sum to the console
            Console.WriteLine("The sum of integers from 1 to 3 is: " + sum);
        }

        static void MS_CS_Pt1()
        {
            // Print text normally
            Console.WriteLine("Hello, World!"); // Prints: Hello, World!

            Console.WriteLine("This is my first C# program."); // Prints: This is my first C# program.

            // Print text with special characters
            // \" → prints double quotes inside a string
            // \n → adds a new line
            Console.WriteLine("Hello \"World\"!\n");
            // Output:
            // Hello "World"!
            // (then moves to the next line)

            // Format output with more escape sequences
            // \" → prints quotes around "Contoso Corp"
            // \n → creates a newline
            Console.WriteLine("Generating invoices for customers \"Contoso Corp\" ... \n");
            // Output:
            // Generating invoices for customers "Contoso Corp" ... 
            // (new line after)

            // Tabs for alignment
            // \t → adds a horizontal tab for spacing
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1022\t\tComplete!");
            // Output:
            // Invoice: 1021        Complete!
            // Invoice: 1022        Complete!

            // Console.Write() vs Console.WriteLine()
            // Write() prints text without adding a new line
            // \n can still be added manually if needed
            Console.Write("\nOutput Directory:\t");
            // Output:
            // (blank line first because of \n)
            // Output Directory:    (tab space)

            // ============================
            // Verbatim String Literal (@)
            // ============================

            // Use @ to write a string exactly as it appears
            // No need to escape backslashes (\) or create new lines manually
            Console.WriteLine(@"       c:\source\repos
            (this is where your code goes)");
            // Output:
            // c:\source\repos
            // (this is where your code goes)

            // Add an empty line for spacing
            Console.WriteLine();

            // Normal string with escape sequences
            Console.WriteLine("Generating invoices for customers \"Contoso Corp\" ... \n");
            // Output:
            // Generating invoices for customers "Contoso Corp" ... 
            // (newline after \n)

            // Use tabs for alignment in normal string
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1022\t\tComplete!");
            // Output:
            // Invoice: 1021        Complete!
            // Invoice: 1022        Complete!

            // Print a label without a newline using Write()
            Console.Write("\nOutput Directory:\t");
            // Output:
            // (blank line first because of \n)
            // Output Directory:    (tab space)

            // Use @ to write a file path literally without double backslashes
            Console.Write(@"c:\invoices");
            // Output:
            // c:\invoices

            // Add a new line at the end
            Console.WriteLine();

            // ============================
            // Unicode Characters
            // ============================
            // Set the console to UTF-8 encoding
            // This ensures the console can display non-ASCII characters (like Japanese)
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Print "Hello World" in Japanese using Unicode escape sequences
            // \uXXXX represents a Unicode character, where XXXX is the hex code
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
            // Output:
            // こんにちは World!

            // Print a longer Japanese string using Unicode
            // \u65e5 = 日, \u672c = 本, etc.
            // \n = newline, \t = tab
            Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            // Output:
            // (two blank lines first)
            // 日本の請求書を生成するには：
            //     (tab space)

            // Print a command for generating Japanese invoices
            // Using @ to keep backslashes literal
            Console.WriteLine(@"c:\invoices\app.exe -j");
            // Output:
            // c:\invoices\app.exe -j

            // Add an extra newline for spacing
            Console.WriteLine();

            // =====================================
            // String Concatenation & Interpolation
            // =====================================
            // Declare some string variables
            string greeting = "Hello";
            string firstName = "Tony";
            string lastName = "Bell";

            // Concatenate strings using the + operator
            // Adds strings together manually
            string message = "Hello " + firstName + " " + lastName + "!";
            Console.WriteLine(message + " Concatenate\n");
            // Output:
            // Hello Tony Bell! Concatenate

            // String interpolation using $
            // Embeds variables directly inside a string
            string messageInterpolation = $"{greeting} {firstName} {lastName}!";
            Console.WriteLine(messageInterpolation + " Interpolation\n");
            // Output:
            // Hello Tony Bell! Interpolation

            // Convert strings to upper and lower case
            // .ToUpper() converts all letters to uppercase
            string upperMessage = message.ToUpper();
            // .ToLower() converts all letters to lowercase
            string lowerMessage = messageInterpolation.ToLower();

            Console.WriteLine(upperMessage + " .ToUpper"); // Output: HELLO TONY BELL! .ToUpper
            Console.WriteLine(lowerMessage + " .ToLower\n"); // Output: hello tony bell! .ToLower

            // Declare some string variables
            string greeting1 = "Hello";
            string firstName1 = "Tony";
            string lastName1 = "Bell";

            // Concatenate strings using the + operator
            // Adds strings together manually
            string message1 = "Hello " + firstName + " " + lastName + "!";
            Console.WriteLine(message + " Concatenate\n");
            // Output:
            // Hello Tony Bell! Concatenate

            // String interpolation using $
            // Embeds variables directly inside a string
            string messageInterpolation1 = $"{greeting} {firstName} {lastName}!";
            Console.WriteLine(messageInterpolation1 + " Interpolation\n");
            // Output:
            // Hello Tony Bell! Interpolation

            // Convert strings to upper and lower case
            // .ToUpper() converts all letters to uppercase
            string upperMessage1 = message.ToUpper();
            // .ToLower() converts all letters to lowercase
            string lowerMessage1 = messageInterpolation.ToLower();

            Console.WriteLine(upperMessage + " .ToUpper"); // Output: HELLO TONY BELL! .ToUpper
            Console.WriteLine(lowerMessage + " .ToLower\n"); // Output: hello tony bell! .ToLower

            // ============================
            // Type Casting
            // ============================
            // Implicit Conversion (int → decimal)
            // C# automatically converts smaller numeric types to larger types
            int intNumber = 10;
            decimal decimalNumber = intNumber; // No cast needed
            Console.WriteLine("Decimal Number: " + decimalNumber);
            // Output: Decimal Number: 10

            // Explicit Conversion (decimal → int)
            // Explicit cast is needed when converting from a larger or more precise type to a smaller one
            decimal priceDecimal = 99.99m;
            int intPrice = (int)priceDecimal; // Truncates decimal part, result is 99
            Console.WriteLine("Integer Price: " + intPrice + "\n");
            // Output: Integer Price: 99

            // Explicit Conversion (double → int)
            // Truncates the decimal portion, does NOT round
            double preciseValue = 9.78;
            int roundedValue = (int)preciseValue; // Result is 9
            Console.WriteLine($"Precise Value: {preciseValue}\nRounded Value: {roundedValue}\n");
            // Output:
            // Precise Value: 9.78
            // Rounded Value: 9

            // ============================
            // Operator Precedence (PEMDAS)
            // ============================

            // Perform arithmetic with parentheses first
            // PEMDAS = Parentheses, Exponents, Multiplication/Division, Addition/Subtraction
            int guessResult = (2 + 2) * 3;
            // Step-by-step:
            // 2 + 2 = 4       (Parentheses first)
            // 4 * 3 = 12      (Then multiplication)
            Console.WriteLine("2 + 2 * 3 = " + guessResult + "\n");
            // Output:
            // 2 + 2 * 3 = 12;

            // ============================
            // Increment & Decrement
            // ============================

            // Initialize a counter variable
            int counter = 0;

            // Increment the counter by 1
            counter++; // Equivalent to counter = counter + 1
            Console.WriteLine("Counter after increment: " + counter + "\n");
            // Output: Counter after increment: 1

            // Decrement the counter by 1
            counter--; // Equivalent to counter = counter - 1
            Console.WriteLine("Counter after decrement: " + counter + "\n");
            // Output: Counter after decrement: 0

            // Increment the counter by a specific value (5)
            counter += 5; // Equivalent to counter = counter + 5
            Console.WriteLine("Counter after incrementing by 5: " + counter + "\n");
            // Output: Counter after incrementing by 5: 5
        }

        static void MS_CS_Pt2()
        {
            // ============================
            // Random Number Generation (Dice Rolls)
            // ============================

            // Create a Random object
            // Random is a class in C# used to generate random numbers
            Random dice = new Random();

            // Generate 3 random numbers between 1 and 6 (inclusive)
            // dice.Next(min, max) generates a number >= min and < max
            // To include 6, we set max = 7
            int roll1 = dice.Next(1, 7); // First dice roll
            int roll2 = dice.Next(1, 7); // Second dice roll
            int roll3 = dice.Next(1, 7); // Third dice roll

            // Sum the three dice rolls
            int total = roll1 + roll2 + roll3;

            // Display the result
            // Using string interpolation ($"") to insert variables directly into the string
            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}\n");

            // ============================
            // Decision Logic: If / Else
            // ============================
            // Bank application example
            // Minimum opening deposit required: $100
            decimal depositAmount = default; // Initialize variable

            Console.Write("Enter opening deposit amount: ");
            depositAmount = decimal.Parse(Console.ReadLine()); // Convert input to decimal
            Console.WriteLine($"Deposit Amount Entered: ${depositAmount}");

            if (depositAmount >= 100) // Check if deposit is sufficient
            {
                Console.WriteLine("Account created successfully!");
            }
            else // Deposit less than $100
            {
                Console.WriteLine("Error: Minimum initial deposit is $100.\n");
            }

            // ============================
            // Bank Account Tiers (If / Else If / Else)
            // ============================
            decimal depositAmount2 = default;

            Console.Write("Enter opening deposit amount: ");
            depositAmount2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Deposit Amount Entered: ${depositAmount2}");

            // Determine account tier
            if (depositAmount2 >= 1000)
            {
                Console.WriteLine("Account Tier: Gold\n");
            }
            else if (depositAmount2 >= 500)
            {
                Console.WriteLine("Account Tier: Silver\n");
            }
            else if (depositAmount2 >= 100)
            {
                Console.WriteLine("Account Tier: Bronze\n");
            }
            else
            {
                Console.WriteLine("Deposit amount is insufficient. A minimum of $100 is required.\n");
            }

            // ============================
            // Arrays and Foreach Loops
            // ============================
            // Hardcoded customer names
            string customer1 = "Alice";
            string customer2 = "Bob";
            string customer3 = "Charlie";
            string customer4 = "Diana";
            Console.WriteLine("Customer List (Hardcoded):\n" + "Alice\n" + "Bob\n" + "Charlie\n" + "Diana\n");

            // ============================
            // Array of Customer Names
            // ============================

            // Declare an array of strings with 4 elements
            string[] customerNames = new string[4];
            // The array can hold 4 string values, initially empty (null)

            // Assign values to each element manually
            customerNames[0] = "Alice";    // First element (index 0)
            customerNames[1] = "Bob";      // Second element (index 1)
            customerNames[2] = "Charlie";  // Third element (index 2)
            customerNames[3] = "Diana";    // Fourth element (index 3)

            // Print the array elements individually
            Console.WriteLine("Customer List (Array):");
            Console.WriteLine(customerNames[0]); // Prints Alice
            Console.WriteLine(customerNames[1]); // Prints Bob
            Console.WriteLine(customerNames[2]); // Prints Charlie
            Console.WriteLine(customerNames[3] + "\n"); // Prints Diana and adds a blank line

            // ==============================
            // Array Initialization Shortcut
            // ==============================

            // Declare and initialize an array in one line
            string[] customerNames2 = new string[] { "Alice", "Bob", "Charlie", "Diana" };
            // No need to assign each element manually; values are listed in curly braces

            // Get the number of elements in the array
            Console.Write($"Number of customers: {customerNames2.Length}\n");
            // .Length property returns the total number of elements (4 in this case)

            // Print header
            Console.WriteLine("Customer List (Array Initialization):");

            // Iterate through the array using a foreach loop
            // foreach automatically loops through each element in the array
            foreach (string customer in customerNames2)
            {
                Console.WriteLine(customer); // Prints each customer name
            }

            static void MS_CS_Pt3()
            {
                // ============================
                // Comparison Operators
                // ============================
                // Greater than: >, Less than: <, Greater or equal: >=, Less or equal: <=
                // Equal: ==, Not equal: !=

                // ============================
                // Event Handling Example (Registration)
                // ============================

                // Declare variables for age and name
                int age3 = 20;             // User's age
                string name3 = "adam";     // User's name

                // Check registration rules using Logical AND (&&)
                // Rule 1: Age must be 18 or older
                // Rule 2: Name must start with 'A' (case-insensitive)
                if (age3 >= 18 && name3.ToUpper().StartsWith("A"))
                {
                    //Both  conditions are true → registration succeeds
                    Console.WriteLine("Registration successful!\n");
                }
                else
                {
                    // any condition fails → registration fails
                    Console.WriteLine("Registration failed. Age must be 18 or older and name must start with 'A'.\n");
                }

                // ============================
                // Logical OR (||) and NOT (!) Operators
                // ============================

                // Declare variables for age and name
                int age4 = 20;           // User's age
                string name4 = "adam";   // User's name

                // Check registration rules with a combination of AND, OR, and NOT
                // Rule: Age must be 18 or older AND (name does NOT start with 'A' OR name starts with 'B')
                if (age4 >= 18 && (!name4.ToUpper().StartsWith("A") || name4.ToUpper().StartsWith("B")))
                {
                    // Conditions satisfied → registration succeeds
                    Console.WriteLine("Registration successful!");
                }
                else
                {
                    // Otherwise → registration fails
                    Console.WriteLine("Registration failed. Age must be 18 or older and name must start with 'B'.\n");
                }

                // ============================
                // Conditional (Ternary) Operator
                // ============================
                // Example 1: Discount based on sale amount
                int saleAmount = 1001;

                // Syntax: condition ? value_if_true : value_if_false
                // If saleAmount > 1000 → discount = 100, otherwise discount = 50
                int discount = saleAmount > 1000 ? 100 : 50;

                Console.WriteLine($"Discount: {discount}\n");
                // Output: Discount: 100

                // Example 2: Pass/Fail evaluation
                int score = 54;

                // If score >= 60 → "Passed", else → "Failed"
                string result = (score >= 60) ? "Passed" : "Failed";

                Console.WriteLine($"Student has: {result}\n");
                // Output: Student has: Failed

                // ============================
                // Block Scope Demonstration
                // ============================
                // Outer scope variable
                int number5 = 10;

                // Start of a block (if statement)
                if (true)
                {
                    number5 = 10; // Can modify outer variable inside block
                    Console.WriteLine($"Inside the block scope: {number5}\n"); // Prints 10
                }

                // Outside the block
                Console.WriteLine($"Outside the block scope: {number5}\n"); // Still accessible, prints 10

                // ---------------------------

                // Another example with a separate outer variable
                int score1 = 5; // Outer scope variable

                if (true)
                {
                    score1 = 10;        // Modifies outer variable
                    int number = 10;    // Local block variable, exists only inside this block

                    Console.WriteLine($"Inside the block scope: {number}\n"); // Prints 10
                    Console.WriteLine($"Score inside the block scope: {score1}\n"); // Prints 10
                }

                // Outside the block
                Console.WriteLine($"Score outside the block scope: {score1}\n"); // Prints 10
                Console.WriteLine("Outside the block scope: integer 'number' not accessible\n");
                // 'number' does not exist outside the if-block

                // ============================
                // IF-ELSE Menu Example
                // ============================

                // Display menu options to the user
                Console.Write("Menu Options:");                        // Prints "Menu Options:" without newline
                Console.WriteLine("1. Add New Customer:");             // Prints option 1 and adds newline
                Console.WriteLine("2. View Customers Details");        // Prints option 2 and adds newline
                Console.WriteLine("3. Delete Customer");              // Prints option 3 and adds newline

                // Prompt user to enter their choice
                Console.Write("Enter your choice (1, 2, or 3): ");   // Prints prompt without newline

                // Read input from user (Console.ReadLine() returns a string)
                // Convert input string to integer using int.Parse()
                int choice = int.Parse(Console.ReadLine());

                // ---------------------------
                // IF-ELSE decision logic
                // ---------------------------

                // If the user entered 1
                if (choice == 1)
                {
                    Console.WriteLine("Adding a new customer...\n");
                }
                // Else if the user entered 2
                else if (choice == 2)
                {
                    Console.WriteLine("Viewing customer details...\n");
                }
                // Else if the user entered 3
                else if (choice == 3)
                {
                    Console.WriteLine("Deleting a customer...\n");
                }
                // If user entered anything else
                else
                {
                    Console.WriteLine("Invalid choice. Please select 1, 2, or 3.\n");
                }

                // ============================
                // Switch-Case Menu Example
                // ============================

                // Display menu options to the user
                Console.Write("Menu Options:");                        // Prints "Menu Options:" without newline
                Console.WriteLine("1. Add New Customer:");             // Prints option 1 and newline
                Console.WriteLine("2. View Customers Details");        // Prints option 2 and newline
                Console.WriteLine("3. Delete Customer");              // Prints option 3 and newline

                // Prompt user to enter their choice
                Console.Write("Enter your choice (1, 2, or 3): ");   // Prints prompt without newline
                int choice1 = int.Parse(Console.ReadLine());          // Read user input and convert string to integer

                // ---------------------------
                // Switch-case decision logic
                // ---------------------------

                switch (choice1)  // Checks the value of 'choice1'
                {
                    case 1:       // If choice1 is 1
                        Console.WriteLine("Adding a new customer...\n");
                        break;    // Stop checking further cases

                    case 2:       // If choice1 is 2
                        Console.WriteLine("Viewing customer details...\n");
                        break;

                    case 3:       // If choice1 is 3
                        Console.WriteLine("Deleting a customer...\n");
                        break;

                    default:      // If choice1 does not match any case
                        Console.WriteLine("Invalid choice. Please select 1, 2, or 3.\n");
                        break;
                }

                // ============================
                // For Loops with Arrays
                // ============================

                // Declare and initialize an array of customer names
                string[] customers = new string[] { "Alice", "Bob", "Charlie", "Diana" };

                // ---------------------------
                // Iterate forward through the array
                // ---------------------------
                for (int index = 0;               // Start from the first index (0)
                     index < customers.Length;    // Continue as long as index is less than array length
                     index++)                     // Increment index by 1 each iteration
                {
                    // Access the element at 'index' and print it
                    Console.WriteLine($"Customer name: {customers[index]}\n");
                }

                // ---------------------------
                // Iterate backward through the array
                // ---------------------------
                for (int index1 = customers.Length - 1; // Start from last index (Length - 1)
                     index1 >= 0;                        // Continue until index reaches 0
                     index1--)                            // Decrement index by 1 each iteration
                {
                    // Access the element at 'index1' and print it
                    Console.WriteLine($"Customer name: {customers[index1]}\n");
                }

                // ============================
                // Do-While Loop Example
                // ============================

                // Declare a variable to store user choice
                int choice2 = 0;

                // Start a do-while loop
                // The block will execute at least once, then check the condition at the end
                do
                {
                    // Display menu options
                    Console.Write("Menu Options:");
                    Console.WriteLine("1. Add New Customer:");
                    Console.WriteLine("2. View Customers Details");
                    Console.WriteLine("3. Delete Customer");
                    Console.WriteLine("4. Exit");

                    // Ask user to enter a choice
                    Console.Write("Enter your choice (1, 2, 3, or 4): ");
                    choice2 = int.Parse(Console.ReadLine()); // Convert input string to integer

                    // Handle the user's choice using a switch-case
                    switch (choice2)
                    {
                        case 1:
                            Console.WriteLine("Adding a new customer...\n");
                            break;
                        case 2:
                            Console.WriteLine("Viewing customer details...\n");
                            break;
                        case 3:
                            Console.WriteLine("Deleting a customer...\n");
                            break;
                        case 4:
                            Console.WriteLine("Exiting the menu. Goodbye!\n");
                            Console.Write(" Press any key to exit...");
                            Console.ReadLine(); // Wait for user input before closing
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select 1, 2, 3, or 4.\n");
                            break;
                    }

                    // Continue looping until user chooses option 4 (Exit)
                } while (choice2 != 4);

                // ============================
                // While Loop Example
                // ============================

                // Initialize a counter variable
                int counter = 0;

                // Start a while loop
                // Condition is checked before each iteration
                while (counter <= 10)
                {
                    // Print current counter value
                    Console.WriteLine($"Counter value: {counter}\n");

                    // Increment counter by 1
                    counter++;
                }


            }
        }

        static void MS_CS_Pt4()
        {
            // ============================
            // Numeric Types in C#
            // ============================

            // Signed integral types (can store negative and positive numbers)
            Console.WriteLine("Signed Integral Types:");
            Console.WriteLine($"sbyte   : {sbyte.MinValue} to {sbyte.MaxValue} ({sizeof(sbyte)} byte)  // -128 to 127");
            Console.WriteLine($"short   : {short.MinValue} to {short.MaxValue} ({sizeof(short)} bytes)  // -32,768 to 32,767");
            Console.WriteLine($"int     : {int.MinValue} to {int.MaxValue} ({sizeof(int)} bytes)      // -2,147,483,648 to 2,147,483,647");
            Console.WriteLine($"long    : {long.MinValue} to {long.MaxValue} ({sizeof(long)} bytes)    // very big numbers\n");

            // Unsigned integral types (only positive numbers, zero included)
            Console.WriteLine("Unsigned Integral Types:");
            Console.WriteLine($"byte    : {byte.MinValue} to {byte.MaxValue} ({sizeof(byte)} byte)   // 0 to 255");
            Console.WriteLine($"ushort  : {ushort.MinValue} to {ushort.MaxValue} ({sizeof(ushort)} bytes) // 0 to 65,535");
            Console.WriteLine($"uint    : {uint.MinValue} to {uint.MaxValue} ({sizeof(uint)} bytes)    // 0 to 4,294,967,295");
            Console.WriteLine($"ulong   : {ulong.MinValue} to {ulong.MaxValue} ({sizeof(ulong)} bytes)  // really big numbers\n");

            // Floating-point types (can store decimals)
            Console.WriteLine("Floating Point Types:");
            Console.WriteLine($"float   : {float.MinValue} to {float.MaxValue} ({sizeof(float)} bytes)   // 7-digit precision, small memory");
            Console.WriteLine($"double  : {double.MinValue} to {double.MaxValue} ({sizeof(double)} bytes) // 15-16 digit precision, bigger memory");
            Console.WriteLine($"decimal : {decimal.MinValue} to {decimal.MaxValue} ({sizeof(decimal)} bytes) // 28-29 digit precision, perfect for money\n");


            // ============================
            // Value Types Example
            // ============================

            // Value types store the actual value directly in memory
            int val_A = 2;        // val_A holds 2
            int val_B = val_A;    // val_B gets a COPY of val_A's value (2)
            val_B = 5;            // Changing val_B does NOT affect val_A

            Console.WriteLine(" --Value Types--");
            Console.WriteLine($"val_A: {val_A}  // Still 2");  // val_A remains 2
            Console.WriteLine($"val_B: {val_B}  // Now 5\n");  // val_B is 5

            // Arrays and strings
            int[] data = new int[3];  // Creates an array of 3 integers, all initialized to 0
            string shortendString = "Hello World!"; // A string variable
            string message = new string('*', 3);    // Creates a string "***" by repeating '*' 3 times

            Console.WriteLine(message);            // Output: ***
            Console.WriteLine(shortendString + "\n"); // Output: Hello World!

            // ============================
            // Reference Types Example
            // ============================

            // Reference types store a reference (or "address") to the actual data in memory
            int[] ref_A = new int[1];  // Create an array of 1 integer
            ref_A[0] = 2;              // Set the first element to 2
            Console.WriteLine($"ref_A[0] before modification: {ref_A[0]}\n"); // Output: 2

            int[] ref_B = ref_A;       // ref_B now points to the SAME array as ref_A
            ref_B[0] = 9;              // Modify the array through ref_B

            Console.WriteLine(" --Reference Types--");
            Console.WriteLine($"ref_A[0]: {ref_A[0]}  // Output: 9, changed because both point to same array");
            Console.WriteLine($"ref_B[0]: {ref_B[0]}  // Output: 9\n");

            // ============================
            // Type Casting and Conversion
            // ============================

            // Example 1: Implicit string concatenation
            int first = 2;        // integer
            string second = "4";  // string
            string result = first + second;  // int automatically converted to string
            Console.WriteLine(result + "\n"); // Output: "24"

            // Example 2: Concatenating string and int
            string firstNumber = "123";  // string
            int secondNumber = 456;      // int
            string results = firstNumber + secondNumber; // int converted to string automatically
            Console.WriteLine($"Results is:  {results}\n"); // Output: "123456"

            // Example 3: Converting string to int for arithmetic
            int results1 = int.Parse(firstNumber) + secondNumber; // string -> int using Parse
            Console.WriteLine($"Results is:  {results1}"); // Output: 579

            /* 
            Narrowing conversion; explicit casting; loss of data
            decimal myDecimal = 123.4m;
            int intNumber = (int)myDecimal; // decimal explicitly cast to int
            Console.WriteLine($"Integer Number: {intNumber}"); // Output: 123, decimal part truncated
            */

            // ============================
            // Data Conversion Examples
            // ============================

            // Converting values to string
            int x = 300;
            decimal y = 44.5m;
            bool isActive = true;

            Console.WriteLine(x.ToString());        // "300"  -> int converted to string
            Console.WriteLine(y.ToString());        // "44.5" -> decimal converted to string
            Console.WriteLine(isActive.ToString()); // "True" -> bool converted to string

            // Converting string to numeric types
            int z = int.Parse("123");       // string "123" -> int 123
            decimal f = decimal.Parse("99.99"); // string "99.99" -> decimal 99.99

            Console.WriteLine($"z is: {z}"); // Output: 123
            Console.WriteLine($"f is: {f}"); // Output: 99.99

            // Using Convert class for numeric conversion
            int a = Convert.ToInt32(1.5m); // decimal 1.5 -> int 1 (fraction truncated)
            Console.WriteLine($"a is : {a}\n"); // Output: 2 (Note: Convert rounds, unlike explicit cast)

            // ============================
            // Array Sorting and Reversing
            // ============================

            // Array of pallet codes
            string[] pallets = new string[] { "B14", "A11", "B12", "A13" }; // Use 'new string[]' for array initialization

            // Sort the array in alphabetical order
            Console.WriteLine("Sorted...");
            Array.Sort(pallets);  // Sorts the array in ascending order
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}"); // Print each element
            }

            Console.WriteLine("");

            // Reverse the array
            Console.WriteLine("Reversed...");
            Array.Reverse(pallets); // Reverses the order of elements in the array
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}"); // Print each element
            }

            // ============================
            // Clearing (Deleting) Elements in an Array
            // ============================

            // Array of pallet codes
            string[] pallets1 = new string[] { "B14", "A11", "B12", "A13" };

            // Clear 2 elements starting from index 0
            Array.Clear(pallets1, 0, 2);
            // What happens: "B14" and "A11" are set to null
            Console.WriteLine($"Clearing 2... total elements: {pallets1.Length}");
            foreach (var pallet in pallets1)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine("");

            // Array of customer names
            string[] customers = new string[] { "Bill", "Sue", "John", "Pam" };

            // Clear 2 elements starting from index 2
            Array.Clear(customers, 2, 2);
            // What happens: "John" and "Pam" are set to null
            Console.WriteLine($"Clearing 2... total elements: {customers.Length}\n");

            // Print remaining elements (skip nulls)
            foreach (var cust in customers)
            {
                if (cust != null) // Only print non-null values
                    Console.WriteLine($"Customer Name: {cust}");
            }

            // ============================
            // Resizing an Array
            // ============================

            // Original array of customers
            string[] customers1 = new string[] { "Bill", "Sue", null, null };

            // Print current array
            Console.WriteLine("Original array:");
            foreach (var cust in customers1)
            {
                Console.WriteLine($"-- {cust}");
            }

            // Resize the array to hold 6 elements
            Array.Resize(ref customers1, 6);
            // Note: 'ref' is required because Resize changes the original array

            // Add new elements after resizing
            customers1[4] = "Gabe";
            customers1[5] = "Liam";

            Console.WriteLine("\nArray after resizing and adding new customers:");
            foreach (var cust in customers1)
            {
                Console.WriteLine($"-- {cust}");
            }

            // ============================
            // Remove commas from a string
            // ============================

            // Original string with commas
            string demoString = "1, 2, 3, 4, 5";

            // Convert string to a character array
            char[] arrayOfLetter = demoString.ToCharArray();

            // Initialize an empty string to store the result
            string new_version = string.Empty;

            // Loop through each character
            foreach (var ch in arrayOfLetter)
            {
                // Only add the character if it is NOT a comma
                if (ch != ',')
                    new_version += ch;
            }

            // Print the result
            Console.WriteLine(new_version); // Output: "1 2 3 4 5"

            // ============================
            // Remove commas and join data
            // ============================

            // Original string with commas
            string demoString1 = "1, 2, 3, 4, 5";

            // Split the string into an array using ',' as separator
            string[] stringArray = demoString1.Split(',');

            // Join all elements of the array back into a single string without any separator
            string new_version1 = string.Join("", stringArray);

            // Print the result
            Console.WriteLine(new_version1); // Output: "1 2 3 4 5" (spaces remain from original string)

            // ============================
            // Composite Formatting vs String Interpolation
            // ============================

            string first2 = "Hello";
            string second2 = "World";

            // Composite Formatting (older style)
            string result2 = string.Format("{0} {1}!", first2, second2);
            Console.WriteLine(result2); // Output: Hello World!

            // String Interpolation (modern and cleaner way)
            Console.WriteLine($"{first2} {second2}!\n"); // Output: Hello World!

            // ============================
            // Formatting Currency in C#
            // ============================

            decimal price = 123.45m; // Price value
            int discount = 50;       // Discount percentage

            // Format currency using {price:C}
            // The "C" specifier converts number to currency format based on current culture
            Console.WriteLine($"The price is {price:C} with a discount of {discount}%\n");
            // Example Output (US culture): The price is $123.45 with a discount of 50%

            // Change culture to British English (en-GB) for formatting
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");

            // Format currency again with new culture
            Console.WriteLine($"The price is {price:C} with a discount of {discount}%\n");
            // Example Output (UK culture): The price is £123.45 with a discount of 50%

            // ============================
            // Number and Percentage Formatting
            // ============================

            // Number format with 4 decimal places
            decimal measurement = 123.456789m;
            // "N4" formats the number with 4 decimal places
            Console.WriteLine($"Number with 4 decimal places: {measurement:N4}\n");
            // Output: Number with 4 decimal places: 123.4568

            // Percentage format with 3 decimal places
            decimal tax = 0.36785m;
            // "P3" formats the number as a percentage with 3 decimal places
            Console.WriteLine($"Tax rate: {tax:P3}\n");
            // Output: Tax rate: 36.785%

            // Percentage format for discount
            decimal price2 = 49.99m;
            decimal salePrice = 19.99m;
            // Calculate discount percentage and format with 2 decimal places
            string finalDiscount = $"A discount of {((price2 - salePrice) / price2):P2}!";
            Console.WriteLine(finalDiscount);
            // Output: A discount of 60.00%!
            Console.WriteLine(finalDiscount + "\n");

            // ============================
            // Formatting Strings by Adding White Space
            // ============================

            // Example 1
            int custID = 1;
            string name = "Alice";
            int age3 = 30;

            // PadRight(n) → adds spaces to the right to make total length n
            // PadLeft(n) → adds spaces to the left to make total length n
            Console.Write(custID.ToString().PadRight(5));  // ID: 1 + 4 spaces
            Console.Write(name.PadRight(10));              // Name: "Alice" + 5 spaces
            Console.Write(age3.ToString().PadLeft(3).PadRight(5)); // Age: right-aligned in 3 spaces, then 2 extra spaces
            Console.WriteLine("Padding Example Complete");

            // Example 2
            int custID1 = 2;
            string name1 = "Shakeem";
            int age31 = 34;

            Console.Write(custID1.ToString().PadRight(5));  // ID: 2 + 4 spaces
            Console.Write(name1.Substring(0, 4).PadRight(10)); // Take first 4 letters "Shak" and pad to 10 chars
            Console.Write(age31.ToString().PadLeft(3).PadRight(5)); // Age: 34 → right-aligned in 3 spaces, then padded to 5
            Console.WriteLine("Padding Example Complete");

            // ============================
            // Creating a Formatted Table
            // ============================

            // ---------------------------
            // Table Header
            // ---------------------------
            Console.WriteLine("".PadLeft(29, '-'));  // Draw a horizontal line using '-'

            Console.Write("ID".PadRight(5));        // Column: ID, padded to 5 spaces
            Console.Write("| ");                     // Column separator
            Console.Write("Name".PadRight(10));     // Column: Name, padded to 10 spaces
            Console.Write(" | ");                    // Column separator
            Console.Write("Age".PadRight(5));       // Column: Age, padded to 5 spaces
            Console.WriteLine(" | ");                // End of header row

            Console.WriteLine("".PadLeft(28, '-'));  // Horizontal line under header

            // ---------------------------
            // Data Row 1
            // ---------------------------
            Console.Write("1".ToString().PadRight(5)); // ID column
            Console.Write(" | ");
            Console.Write("shakeeme".Length > 8 ? "shakeeme".Substring(0, 8).PadRight(10) : "shakeeme".PadRight(10)); // Name column
            Console.Write(" | ");
            Console.Write("33".ToString().PadRight(5)); // Age column
            Console.WriteLine(" | ");

            // ---------------------------
            // Data Row 2
            // ---------------------------
            Console.Write("2".ToString().PadRight(5)); // ID column
            Console.Write(" | ");
            Console.Write("Emad".Length > 8 ? "Emad".Substring(0, 8).PadRight(10) : "Emad".PadRight(10)); // Name column
            Console.Write(" | ");
            Console.Write("22".ToString().PadRight(5)); // Age column
            Console.WriteLine(" | ");

            // ============================
            // Built-in string data type methods
            // ============================

            // Example string
            string message4 = "Find what is (inside the parentheses)";

            // Find the index of the first '(' and ')'
            int openingPosition = message4.IndexOf('(');  // Finds index of '('
            int closingPosition = message4.IndexOf(')');  // Finds index of ')'

            Console.WriteLine(openingPosition); // Prints position of '('
            Console.WriteLine(closingPosition); // Prints position of ')'

            // Extract the text inside the parentheses
            openingPosition += 1;  // Move past '('
            int length = closingPosition - openingPosition;  // Calculate length of substring
            Console.WriteLine(message4.Substring(openingPosition, length) + "\n"); // Prints "inside the parentheses"

            // ----------------------------
            // LastIndexOf Example
            // ----------------------------
            string message2 = "Hello, Wordl! Welcome to the World of C#.";

            // Find the last occurrence of "World"
            int lastPosition = message2.LastIndexOf("World"); // Finds last occurrence
            Console.WriteLine(lastPosition + "\n"); // Prints index of the last "World"

        }

        static void MS_CS_Pt6()
        {
            // ============================
            // Understanding Exception Handling
            // ============================

            // This bool keeps track if code executed successfully
            bool continueLoop = true;

            try
            {
                // Ask the user for two numbers
                Console.Write("Please type a number1: ");
                int num1 = int.Parse(Console.ReadLine() + "\n"); // Convert string input to int

                Console.Write("Please type a number2: ");
                int num2 = int.Parse(Console.ReadLine() + "\n"); // Convert string input to int

                // Attempt division
                int dividNumbers = num1 / num2; // Can throw DivideByZeroException
                Console.WriteLine($"The result is: {dividNumbers}");
            }
            catch (DivideByZeroException divideEx) // Specific exception for division by zero
            {
                continueLoop = false; // Mark that execution failed
                Console.WriteLine("Error: Division by zero is not allowed.");
                // Optional: prints system exception message
                Console.WriteLine($"Exception Message: {divideEx.Message}\n");
            }
            catch (FormatException formatEx) // Exception when input is not a valid integer
            {
                continueLoop = false;
                Console.WriteLine("Error: Invalid input format. Please enter valid integers.");
                // Optional: custom message instead of system message
                Console.WriteLine($"Exception Message: Please use a number");
            }
            catch (Exception ex) // Generic exception for anything else unexpected
            {
                continueLoop = false;
                Console.WriteLine("An unexpected error occurred...");
            }
            finally
            {
                // This block always runs, whether an exception occurred or not
                if (continueLoop)
                {
                    Console.WriteLine($"Execution Completed");
                }
                else
                {
                    Console.WriteLine(""); // Optional: leave blank if an error occurred
                }
            }
        }
    }
}