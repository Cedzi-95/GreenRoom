public class GreenRoom
{

    public static void  Execute()
    {
        System.Console.WriteLine();
                Thread.Sleep(100);
        System.Console.WriteLine("Welcome to the green room");
        System.Console.WriteLine();
        Thread.Sleep(200);
        System.Console.WriteLine("Press enter to continue...");
        Console.ReadLine();
        Console.Clear();
        System.Console.WriteLine("This room is connected to an oxygen sucking machine");
        System.Console.WriteLine("You have to find a box and guess the code.");
        System.Console.WriteLine("Each failed guess takes up to 30 minutes to retry.");
        System.Console.WriteLine("Reminder that oxygen decreases by 10% per hour"); 
        System.Console.WriteLine("You have 3 hours and 6 trials before your oxygen levels reach 70%");
        System.Console.WriteLine("If you succeed, you will collect a green key");
        System.Console.WriteLine();
        System.Console.WriteLine("Press any key to continue...");
        Console.ReadKey();

        
        OpenBox();
        System.Console.WriteLine("press key to continue...");
        Console.ReadLine();
        GuessTheCode();
        
    }
    public static void OpenBox()
    {
        System.Console.WriteLine();
        System.Console.WriteLine("Look for a box that contains the door key ");
       while(true)
       {
                System.Console.WriteLine("Have you found the box yet? yes or no");
        string answer = Console.ReadLine()!;


        if(answer.Equals("yes") || answer.Equals("YES"))
        {
            System.Console.WriteLine("Great");
            break;
        }
        else  if(answer.Equals("NO") || answer.Equals("no")) 
        {
            System.Console.WriteLine("Keep looking, time is running out");

        }
       }
    }
    public static void GuessTheCode()
    {
        System.Console.WriteLine("Now it´s time to guess the last 2 digits of the code");
        System.Console.WriteLine("Press x to get a hint or press any other key to ignore it.");
        string hint = Console.ReadLine()!;
        if(hint.Equals("X") || hint.Equals("x"))
        {
            System.Console.WriteLine("Its between 54 and 61");
            
        }
        else 
        {
            System.Console.WriteLine("Okey, good luck");
        }
         
        while (true)
        {
            System.Console.Write("Enter 2 digits to crack the code: ");
            int numberInput;
         int GuessAmount = 6;
         Random slump = new Random();
            
            for (int i = GuessAmount - 1; i >= 0 ; i--)
            {
                 int randomNumber = slump.Next(54,61);
                numberInput = int.Parse(Console.ReadLine()!);
                if(numberInput != randomNumber && i > 1)
                {
                    System.Console.Write($"Wrong, you have {i} guesses left! try again: ");
                }
                if( i > 0 && i.Equals(1))
                {
                    if(numberInput != randomNumber)
                    {
                        System.Console.Write($"Wrong, time is running out. One guess left! Enter 2 digits:  ");
                    }
                }

                if( i.Equals(0))
                    {
                        if(numberInput!= randomNumber)
                        {
                        System.Console.WriteLine();
                        System.Console.Write("Oxygen is too low, You are dead!");
                        System.Console.WriteLine();
                        System.Console.WriteLine("Right number was " + randomNumber);
                        return;
                        }
                    }
                
                 else if(numberInput.Equals(randomNumber))
                {
                    System.Console.WriteLine($"Congratulations! you have won the green key ");
                    System.Console.WriteLine();
                    return;
                }
            }
        }
        
    }






}