// ********************************Do excercise 33
var ynChange = "y";
var ynContinue = "y";

int[] intArray = new int[5] { 2, 8, 0, 24, 51 };
int replacementNumber;
int index = 0;

while (ynContinue == "y")
{
    Console.Write("Please enter a number 0 - 4 for the index: ");
    var isValidInteger = int.TryParse(Console.ReadLine(), out index);
    if (isValidInteger && index >= 0 && index <= 4) // remember to validate user input is in range
    {
        Console.Write($"The value at index {index} is {intArray[index]}. Would you like to change it (y/n)? ");
        ynChange = Console.ReadLine();

        while (ynChange == "y")
        {
            Console.Write("Please enter replacement number for index {index}: ");
            var isValidInteger2 = int.TryParse(Console.ReadLine(), out replacementNumber);
            intArray[index] = replacementNumber;

            break;
        }

        Console.Write($"The value at index {index} is {intArray[index]}. Would you like to continue (y/n)? ");
        ynContinue = Console.ReadLine();
    }

    Console.WriteLine("Bye-bye!");
}
