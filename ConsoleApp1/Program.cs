
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

Random random = new Random();
int[] randomNumbers = new int[10];
for (int i = 0; i < 10; i++)
{
    randomNumbers[i] = random.Next(1, 101);

    Console.WriteLine(randomNumbers[i]);
}
static int[] GetEvenNumbers(int[] randomNumbers)
{
    List<int> evenNumbersList = new List<int>();
    foreach (int number in randomNumbers)
    {
        if (number % 2 == 0)
        {
            //add the number to the list
            evenNumbersList.Add(number);
        }

    }
    int[] evenNumbers = evenNumbersList.ToArray();
    return evenNumbers;
}

int[] evenNumbers = GetEvenNumbers(randomNumbers);

Console.WriteLine();
Console.WriteLine("Even Numbers:");
foreach (int number in evenNumbers)
{
    Console.WriteLine(number);
}