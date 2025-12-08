using System;

class Program
{
    static void Main()
    {
        bool isAgree = true;
        string answer;

        while (isAgree)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine(
                "1. Triangle\n" +
                "2. Square\n" +
                "3. Rectangle\n" +
                "4. Reverse Triangle\n" +
                "5. Centered Triangle\n" +
                "6. Hollow Square\n" +
                "7. Hollow Triangle\n" +
                "8. Diamond\n" +
                "9. Exit");

            Console.Write("Select: ");
            int selectedItem = int.Parse(Console.ReadLine());

            switch (selectedItem)
            {
                case 1: DrawTriangle(); break;
                case 2: DrawSquare(); break;
                case 3: DrawRectangle(); break;
                case 4: DrawReverseTriangle(); break;
                case 5: DrawCenteredTriangle(); break;
                case 6: DrawHollowSquare(); break;
                case 7: DrawHollowTriangle(); break;
                case 8: DrawDiamond(); break;
                case 9:
                    Console.WriteLine("Bye!");
                    isAgree = false;
                    continue;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            Console.Write("Continue? y/n: ");
            answer = Console.ReadLine();
            isAgree = answer.ToLower() == "y" || answer.ToLower() == "yes";
        }
    }

    static void DrawTriangle()
    {
        Console.Write("*\n**\n***\n****\n*****\n");
    }

    static void DrawSquare()
    {
        Console.Write("*****\n*****\n*****\n*****\n*****\n");
    }

    static void DrawRectangle()
    {
        Console.Write("*******\n*******\n*******\n");
    }

    static void DrawReverseTriangle()
    {
        Console.Write("*****\n****\n***\n**\n*\n");
    }

    static void DrawCenteredTriangle()
    {
        Console.Write("    *\n   ***\n  *****\n *******\n*********\n");
    }

    static void DrawHollowSquare()
    {
        Console.Write("*****\n*   *\n*   *\n*   *\n*****\n");
    }

    static void DrawHollowTriangle()
    {
        Console.Write("*\n**\n* *\n*  *\n*****\n");
    }

    static void DrawDiamond()
    {
        Console.Write("    *\n   ***\n  *****\n *******\n*********\n *******\n  *****\n   ***\n    *\n");
    }
}
