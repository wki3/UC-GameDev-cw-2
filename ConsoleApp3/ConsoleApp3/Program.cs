float playerSpeed = 30;

compareSpeed(2.5f);

void compareSpeed(float speed)
{
    Console.WriteLine("Old Player Speed is " + playerSpeed);
    // playerspeed = speed 
    Console.WriteLine("New Player Speed is " + speed);
    if (playerSpeed > speed)
    {
        Console.WriteLine(playerSpeed + " is the Old speed (faster)");
    }
    else if (playerSpeed < speed)
    {
        Console.WriteLine(speed + " is the New speed (faster)");
    }
    else
    {
        Console.WriteLine(" the speed is the same");
    }
}