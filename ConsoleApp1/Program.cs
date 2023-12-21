
//Task1
//Console.WriteLine("Enter the first number:");
//string num1Str = Console.ReadLine();
//int num1 = Convert.ToInt32(num1Str);

//Console.WriteLine("Enter the second number:");
//string num2Str = Console.ReadLine();
//int num2 = Convert.ToInt32(num2Str);

//Console.WriteLine("Enter the third number:");
//string num3Str = Console.ReadLine();
//int num3 = Convert.ToInt32(num3Str);

//int largestNum = num1;
//if (num2 > largestNum)
//{
//    largestNum = num2;
//}
//else if(num3 > largestNum)
//{
//    largestNum = num3;
//}
//Console.WriteLine($"The largest number is: {largestNum}");




//Task6
//Console.Write("Enter the education type -- programming, design, system: ");
//string educationType = Console.ReadLine();
//int educationHour;

//        switch (educationType)
//        {
//            case "programming":
//        educationHour = 400;
//                break;
//            case "design":
//        educationHour = 250;
//                break;
//            case "system":
//        educationHour = 200;
//                break;
//            default:
//                Console.WriteLine("Incorrect education type !");
//                return;
//        }
//        Console.WriteLine(educationHour);






//Task5
//int[] numbers = new int[5];
//int sum = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine("Enter the number:");
//    string numbersStr = Console.ReadLine();
//    numbers[i] = Convert.ToInt32(numbersStr);

//    sum += numbers[i];
//}
//Console.WriteLine($"Total Sum: {sum}");




//Task2
//Console.WriteLine("Enter the text:");
//string text = Console.ReadLine();
//bool letterA = false;

//for (int i = 0; i < text.Length; i++)
//{
//    if (text[i] == 'A')
//    {
//        letterA = true;
//        Console.WriteLine("There is a letter 'A'");
//        break;
//    }
//}
//    Console.WriteLine("There is not a letter 'A'");






//Task4
//int number;
//Console.Write("Enter a positive and even number: ");
//string numStr = Console.ReadLine();
//number = Convert.ToInt32(numStr);

//if (number > 0 && number % 2 == 0)
//{
//    int square = number * number;
//    Console.WriteLine($"The square of {number} is: {square}");
//}
//else Console.WriteLine("Invalid input.Please enter a positive and even number!");






//Task3
//Console.WriteLine("Enter the text:");
//string text =Console.ReadLine();
//int countA = 0;

//for (int i = 0; i < text.Length; i++)
//{
//  countA++;
//}
//Console.WriteLine($"The number of 'A' in the text is: {countA}");




