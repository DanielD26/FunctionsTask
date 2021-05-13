using System;

namespace FunctionsTask
{
    class Program {
        //Task 3
            // public static int Sum(int num1, int num2) {
            //     int total;
            //     total = num1 + num2;
            //     return total;
            // }
        static void Main(string[] args) {
            //Task 1 and 2
                // Console.WriteLine("Enter Name");
                // string getName = Console.ReadLine();
                // Console.WriteLine("Welcome friend " + getName + "!");
                // Console.WriteLine("Have a nice day!");

            //Task 3
                // Console.WriteLine("Enter first number: ");
                // int getNum1= Convert.ToInt32(Console.ReadLine());
                // Console.WriteLine("Enter Second number: ");
                // int getNum2= Convert.ToInt32(Console.ReadLine());
                // Console.WriteLine("The total of both numbers is: " + Sum(getNum1, getNum2));
            //Task 4
                // string userInput2;
                // Console.WriteLine("Please enter a sentence: ");
                // userInput2 = Console.ReadLine();
                // Console.WriteLine(userInput2 + " contains " + countSpaces(userInput2) + " spaces");

            // int[] numbers= new int[5];
            // int 

            //Task 5
                // int[] numbers= new int[5];
                // int count, sum=0;

                //     Console.WriteLine("Input 5 elements in the array :");
                //     for(count=0;count<5;count++)
                //     {
                //     Console.Write("element - {0} : ",count);
                //     numbers[count] = Convert.ToInt32(Console.ReadLine()); 
                //     }

                // for(count=0; count<5; count++)
                // {
                //     sum += numbers[count];
                // }

                // Console.Write("The sum of the elements of the array is: {0}", sum);
            //Task 6
                // int n1, n2;
                // Console.WriteLine("Enter first number: ");
                // n1= Convert.ToInt32(Console.ReadLine());
                // Console.WriteLine("Enter second number: ");
                // n2= Convert.ToInt32(Console.ReadLine());
                // changeNums(ref n1, ref n2);
                // Console.WriteLine("Now the first number is: {0}, and the second number is: {1}", n1, n2);

            //Task 7
                // int n1;
                // int exp1;
                // Console.WriteLine("Input base Number: ");
                // n1 = Convert.ToInt32(Console.ReadLine());
                // Console.WriteLine("Input the Exponent: ");
                // exp1 = Convert.ToInt32(Console.ReadLine());
                // Console.WriteLine("So the number {0} ^ (to the power) {1} = {2}", n1, exp1, raiseToPower(n1,exp1));

            //Task 8
                // Console.WriteLine("Input number of Fibonacci Series: ");
                // int n= Convert.ToInt32(Console.ReadLine());
                // Console.WriteLine("The Fibonacci series of {0} is: ", n);
                // for (int counter= 0; counter< n; counter++) {
                //     Console.Write(Fibonacci(counter)+ " ");
                // }

            //Task 9
                // Console.WriteLine("Input a number: ");
                // int n= Convert.ToInt32(Console.ReadLine());

                // if (prime(n)) {
                //     Console.WriteLine("{0} is a prime number", n);
                // } else {
                //     Console.WriteLine("{0} is not a prime number", n);
                // }
            
            //Task 10
                // int num;
                // Console.Write("Enter a number: ");
                // num = Convert.ToInt32(Console.ReadLine());
                // Console.WriteLine("The sum of the digits of the number {0} is: {1}", num, sumOfDigits(num));

            //Task 11    
                // Console.Write("Enter a number: ");
                // int n1 = Convert.ToInt32(Console.ReadLine());
                // double factorial = Factorial(n1);
                // Console.WriteLine("The factorial of {0}! is: {1}", n1, factorial);

            int num;
            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Fibonacci of {0}th term is {1}", num, Fibonacci(num));
        }
        //Task 4
            // public static int countSpaces(string userInput) {
            //     int spaces = 0;
            //     string userInput1;
            //     for (int i=0; i< userInput.Length;i++) {
            //         userInput1 = userInput.Substring(i,1);
            //         if (userInput1 == " ") {
            //             spaces++;
            //         }
            //     }
            //     return spaces;
            // }

        //Task 6
            // public static void changeNums (ref int num1, ref int num2) {
            //     int temp;

            //     temp= num1;
            //     num1= num2;
            //     num2= temp;
            // }

        //Task 7
            // public static int raiseToPower (int num, int exp) {
            //     int baseNum = 1;
            //     int counter;
            //     for (counter=1; counter <= exp; counter++)
            //     baseNum = baseNum * num;
            //     return baseNum;
            // }

        //Task 8
            // public static int Fibonacci(int amountN) {
            //     int num1= 0;
            //     int num2= 1;

            //     for (int counter = 0; counter < amountN; counter++) {
            //         int temp= num1;
            //         num1= num2;
            //         num2= temp + num2;
            //     }
            //     return num1;
            // }

        //Task 9
            // public static bool prime(int num) {
            //     for (int counter= 2; counter< num; counter++) {
            //         if (num %counter == 0)
            //         return false;
            //     }
            //     return true;
            // }

        //Task 10
            // public static int sumOfDigits(int n) {
            //     string n1 = Convert.ToString(n);
            //     int sum = 0;
            //     for (int counter = 0; counter< n1.Length; counter++) {
            //         sum += Convert.ToInt32(n1.Substring(counter, 1));
            //     }
            //     return sum;
            // }

        //Task 11
            // public static double Factorial(int n) {
            //     if (n == 0) {
            //         return 1;
            //     } else {
            //         return n* Factorial(n-1);
            //     }
            // }

         public static int Fibonacci(int n) {
            if (n <= 2) {
                return 1;
            } else {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
