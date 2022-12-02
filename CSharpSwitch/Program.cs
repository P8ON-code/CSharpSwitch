namespace CSharpSwitch
{
    /*
    SoloLearn: The default Case (C#)
    You are making a game, where the player selects the difficulty level:
    1 - Easy
    2 - Medium
    3 - Hard

    You are given a program that takes the number as input.
    Complete the program so that it will output the corresponding difficulty level.
    If the user entered an invalid number, the program should output "Invalid option". 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());

            /*
            1 - Easy
            2 - Medium
            3 - Hard
            other - "Invalid option"
            */

            //your code goes here
            switch (num)
            {
                case 1:
                    PrintMessage("Easy");
                    break;
                case 2:
                    PrintMessage("Medium");
                    break;
                case 3:
                    PrintMessage("Hard");
                    break;
                default:
                    PrintMessage("Invalid option");
                    break;
            }
        }
        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}

