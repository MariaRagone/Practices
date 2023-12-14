
//--------------------------------------ALPHABETIZE NAMES-------------------------------------

//        Console.WriteLine("Hello! Please enter 6 names separated by spaces:");

//        string[] names = Console.ReadLine().ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);

//        if (names != null && names.Length == 6)
//        {
//            Array.Sort(names);

//            Console.WriteLine("Sorted Names:");
//            foreach (var name in names)
//            {
//                Console.WriteLine(name);
//            }
//        }
//        else
//        {
//            Console.WriteLine("Invalid input. Please enter exactly 6 names separated by spaces.");
//        }


//-----------------------------CHECK FOR PRIME NUMBER------------------------------------------

//    Console.WriteLine("Please enter a range of 2 numbers to check between.");


//        string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
//        int[] nums = new int[input.Length];

//        for (int i = 0; i < input.Length; i++)
//        {
//            if (int.TryParse(input[i], out int parsedNumber))
//            {
//                nums[i] = parsedNumber;
//            }
//            else
//            {
//                // Handle the case where the input is not a valid integer
//                Console.WriteLine($"Invalid input: '{input[i]}' is not a valid integer.");
//                // You might want to exit or take corrective action based on your requirements
//            }
//        }

//        // Call the IsPrime method for each number and display the result
//        foreach (int num in nums)
//        {
//            bool isPrime = IsPrime(num);
//            Console.WriteLine($"{num} is prime: {isPrime}");
//        }


//    static bool IsPrime(int number)
//    {
//        // A prime number is greater than 1 and can only be divisible by 1 and itself
//        if (number <= 1)
//        {
//            return false;
//        }

//        for (int j = 2; j <= Math.Sqrt(number); j++)
//        {
//            if (number % j == 0)
//            {
//                return false;
//            }
//        }

//        return true;
//    }

//---------------------------RANDOM NUMBER GUESSING-------------------------------------
//Random rndNumber = new Random();

//int computerNumber = rndNumber.Next(1, 101);


//Console.WriteLine("Guess a number");
//int userNumber = int.Parse(Console.ReadLine());

////Console.WriteLine($"This is the random number: {computerNumber}");
//while (userNumber !=computerNumber)
//{

//    if (userNumber > computerNumber)
//    {
//        Console.WriteLine("Too high!");
//    }
//    else if (userNumber < computerNumber)
//    {
//        Console.WriteLine("Too low!");
//    }
//    else
//    {
//        Console.WriteLine("You entry is invalid!");
//    }
//    Console.WriteLine("Guess Again");
//    userNumber = int.Parse(Console.ReadLine());
//}
//        Console.WriteLine("You guessed it!");


//------------------------------------FIND EVEN NUMBERS--------------------------

//Random random = new Random();
//int[] randomNumbers = new int[10];
//for (int i = 0; i < 10; i++)
//{
//    randomNumbers[i] = random.Next(1, 101);

//    Console.WriteLine(randomNumbers[i]);
//}
//static int[] GetEvenNumbers(int[] randomNumbers)
//{
//    List<int> evenNumbersList = new List<int>();
//    foreach (int number in randomNumbers)
//    {
//        if (number % 2 == 0)
//        {
//            //add the number to the list
//            evenNumbersList.Add(number);
//        }

//    }
//    int[] evenNumbers = evenNumbersList.ToArray();
//    return evenNumbers;
//}

//int[] evenNumbers = GetEvenNumbers(randomNumbers);

//Console.WriteLine();
//Console.WriteLine("Even Numbers:");
//foreach (int number in evenNumbers)
//{
//    Console.WriteLine(number);
//}


//initialize an array
using System.ComponentModel;
using System.Runtime.CompilerServices;

int[] newArray;
newArray = new int[] { 1, 2, 3, 4, 5, };
//or 
int[] newArray2 = { 1, 2, 3, 4, 5, 6 };
//access array elements
int firstNumber = newArray2[0];
int thirdNumber = newArray[2];

//length
int length = newArray.Length;

//interating through arrays
for (int i = 0; i < newArray.Length; i++)
{
    Console.WriteLine(newArray[i]);
}

//or use a foreach loop
foreach (int n in newArray2)
{
    Console.WriteLine(n);
}

//multidimensional arrays (2d array)
int[,] matrix = new int[3, 3];
matrix[0, 0] = 1;
matrix[0, 1] = 2;

//jagged arrays are arrays of arrays
int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[] { 1, 2, 3 };
jaggedArray[1] = new int[] { 4, 5 };
jaggedArray[2] = new int[] { 6, 7, 8, 9 };

//passing arrays as parameters to methods
static void PrintArray(int[] array)
{
    foreach (int element in array)
    {
        Console.WriteLine("This is passing an array as a parameter");
        Console.WriteLine(element);
    }
}
PrintArray(newArray);


//Array Sum of Even Numbers
//Declare an array of integers with at least 5 elements.
//Write a function that takes this array as a parameter and calculates the sum of all even numbers in the array.
//Print the original array and the sum of even numbers.

int[] allNumbers = { 10, 12, 33, 33, 8 };

int calcSumOfEvenNumbers = CalcSumOfEvenNumbers(allNumbers);
static int CalcSumOfEvenNumbers(int[] allNumbers)
{

    int evenNumbers = 0;
    foreach (int n in allNumbers)
    {
        if (n % 2 == 0)
        {
            evenNumbers += n;
        }

    }
    Console.WriteLine(evenNumbers);
    return evenNumbers;
}

//Write a C# program that takes an array of integers and finds the maximum and minimum values in the array.

//Create an array of integers (you can choose the values).
//Write a method that finds and returns the maximum value in the array.
//Write another method that finds and returns the minimum value in the array.
//In your Main method, call these methods with your array and print the results.

int[] values = { 5, 34, 934, 345, 435, 67, 19 };
FindMaxValues(values);
FindMinValues(values);

static int FindMaxValues(int[] values)
{
    int maxValue = values[0];
    for (int i = 0; i < values.Length; i++)
    {

        if (values[i] > maxValue)
        {
            maxValue = values[i];
        }
    }
    Console.WriteLine($"Max Value: {maxValue}");
    return maxValue;
}
static int FindMinValues(int[] values)
{
    int minValue = values[0];
    for (int i = 0; i < values.Length; i++)
    {

        if (values[i] < minValue)
        {
            minValue = values[i];
        }
    }
    Console.WriteLine($"Min Value: {minValue}");
    return minValue;
}



//-------------------------REVERSE A STRING-----------------------
Console.WriteLine("Type in a sentence to reverse it.");
string sentence = Console.ReadLine();
List<string> wordsList = new List<string>(sentence.Split(' '));
Console.WriteLine($"REVERSED:--- {ReverseString(wordsList)}");
static string ReverseString(List<string> newList)
{
    for (int i = 0; i <= newList.Count / 2; i++) //interate through half of the list
    {
        string tempList = newList[i];//create a new temporary list and assign it the value of the element at the current position i in the list
        newList[i] = newList[newList.Count - 1 - i];//swaps the current element at position i with its mirror element which is at the position determined by  'newList.Count-i-1
        newList[newList.Count - 1 - i] = tempList;//restores the original value of the mirror element to its mirror position

    }
    return string.Join(" ", newList);
}

//---------------------FIZZBUZZ--------------------------
FizzBuzz();
static void FizzBuzz()
{
    for (int i = 0; i <= 100; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (i % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (i % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(i);
        }

    }
}

//-------------------TWO SUM ------------------
//given an array of integers, find two numbers such that they add up to a specific target number

int[] twoSum = { 10, 2, 3, 4, 5, 6, 7, 8, 9 };
int target = twoSum[0];
Console.WriteLine($"These are the two numbers that add up to the target: {FindTwoSum(twoSum, target)}");
static int FindTwoSum(int[] arr, int targetNumber)
    
{
    int temp = 0;
    int[] tempList = new int[2];//the length of the list is 2 elements
    for (int i = 1; i <= arr.Length; i++) //iterate through the array starting at the 2nd number and go to the end
    {
        if (target - arr[i] == ) //if the target minus the indexed number = one of the numbers in the list
        {
            tempList.Add(i);
        }
    }

    return target;
}
