// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string inputPlayer, inputCPU;
int randomINT;
bool playagain = true;
int scoreplayer = 0;
int scorecpu = 0;
while (playagain)
{

    while (scoreplayer < 3 && scorecpu < 3)
    {

        Console.WriteLine("Choose Between rock paper & Scissor:      ");
        inputPlayer = Console.ReadLine();
        Random rnd = new Random();
        randomINT = rnd.Next(1, 4);

        switch (randomINT)
        {
            case 1:
                inputCPU = "Rock";

                Console.WriteLine("Computer Choose rock");
                if (inputPlayer == "Rock")
                {
                    Console.WriteLine("Draw");
                }
                else if (inputPlayer == "paper")
                {
                    Console.WriteLine("Player Wins");
                    scoreplayer++;
                }
                else if (inputPlayer == "Scissor")
                {
                    Console.WriteLine("cpu win");
                    scorecpu++;
                }
                break;
            case 2:
                inputCPU = "paper";
                Console.WriteLine("Computer Choose paper");
                if (inputPlayer == "paper")
                {
                    Console.WriteLine("Draw");
                }
                else if (inputPlayer == "Rock")
                {
                    Console.WriteLine("cpu Wins");
                    scorecpu++;
                }
                else if (inputPlayer == "Scissor")
                {
                    Console.WriteLine("player win");
                    scoreplayer++;
                }
                break;

            case 3:
                inputCPU = "Scissor";
                Console.WriteLine("Computer Choose Scissor");
                if (inputPlayer == "Scissor")
                {
                    Console.WriteLine("Draw");
                }
                else if (inputPlayer == "paper")
                {
                    Console.WriteLine("cpu Wins");
                    scorecpu++;
                }
                else if (inputPlayer == "Rock")
                {
                    Console.WriteLine("player win");
                    scoreplayer++;
                }
                break;
            default:
                Console.WriteLine("invalid entry");
                break;

        }
       
                if (scoreplayer == 3)
                {
                    Console.WriteLine("player won!!");
                }
                else if (scorecpu == 3)
                {
                    Console.WriteLine("cpu won!!");
                }
                else
                {

                }
        

    }
    Console.WriteLine("Player score: {0} CPU SCore:{1}", scoreplayer, scorecpu);
    Console.WriteLine("do you want to play again?? y/n");
    string loop = Console.ReadLine();
    if (loop == "y")
    {
        playagain = true;
    }
    else if (loop == "n")
    {
        playagain = false;
    }
    else
    {
        playagain = false;
    }

}