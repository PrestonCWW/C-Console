class If
{
    public static void IfElse(int number)
    {
        
        if(number > 0)
        {
            Console.WriteLine("The Number is Positive.");
        }
        else if(number < 0)
        {
            Console.WriteLine("The Number is Negitive.");
        }
        else
        {

        }
    }
    public static void Health(int health) 
    {
        if(health > 75)
        {
            Console.WriteLine("The player is in great condition!");
        }
        else if(health > 50)
        {
            Console.WriteLine("The player is in good condition.");
        }
        else if(health > 0)
        {
            Console.WriteLine("The player is in danger!");
        }
        else
        {
            Console.WriteLine("Game Over");
        }
    }
}
