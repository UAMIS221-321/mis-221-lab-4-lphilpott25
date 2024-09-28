string userInput = "";


while (userInput != "4")
{
    DisplayMenu();
    userInput = GetUserChoice();
    RoutEm(userInput);
}



static void DisplayMenu()
{
    Console.Clear();
    System.Console.WriteLine(" 1. Display Plain Pizza \n 2. Displa Cheese Pizza\n 3. Display Pepperioni Pizza \n 4. Exit ");
}

static string GetUserChoice()
{
    System.Console.WriteLine("Enter your menu choice:");
    return Console.ReadLine();
}

static void RoutEm(string userChoice)
{
    if (userChoice == "1")
    {
        DisplayPlainPizza();
    }
    else if (userChoice == "2")
    {
        DisplayCheesePizza();
    }
    else if (userChoice == "3")
    {
        DisplayPepperoniPizza();
    }
    else{
        DisplayMenu();
    }
}

static void DisplayPlainPizza()
{
    Random random = new Random();
    int randomRows = random.Next(8,13);

    System.Console.WriteLine();
    for(int i = randomRows; i>=0; i--)
    {
        for(int j = 0; j<i+1; j++)
        {
            System.Console.Write("*");
        }
        System.Console.WriteLine();
    }
    Pause();
}
static void Pause()
{
    System.Console.WriteLine("press any key to continue");
    Console.ReadKey();
}


static void DisplayCheesePizza()
{

}
static void DisplayPepperoniPizza()
{

}