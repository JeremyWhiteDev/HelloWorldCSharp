string name;

do
{
    Console.WriteLine("Please enter your name");
    name = Console.ReadLine();
} while (name == null || name == "");

    Console.WriteLine($"Howdy {name}!! Press Enter to Run Program");

string favoriteColor;

do
{
    Console.WriteLine("Please enter your favorite Color");
    favoriteColor = Console.ReadLine();
} while (favoriteColor == null || favoriteColor == "");

//create a collection of strings for animals
var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

//random number generator
Random rnd = new Random();
int num = rnd.Next(0, animals.Length);

Console.WriteLine($"Would you like a {favoriteColor} {animals[num]}? (y/n)");

string animalChoice = Console.ReadLine();

while (animalChoice != "y" && animalChoice != "n")
{
    Console.Write("Please enter 'y' or 'n'");
    animalChoice = Console.ReadLine();
}

if (animalChoice == "y")
{
    Console.WriteLine($"Congrats! You now own a {favoriteColor} {animals[num]}");
}
else
{
    Console.WriteLine("OK!");
}


//Asks user if they want to see a list of animals
Console.Write("would you like to see a list of animals? (y/n)");
string showAnimals = Console.ReadLine();


//Validate if user entered either a y or n

while (showAnimals != "y" && showAnimals != "n") {
    Console.Write("Please enter 'y' or 'n'");
    showAnimals = Console.ReadLine();
}

//Show the correct info based on user input
if (showAnimals == "y")
{
foreach (var animal in animals)
{
    if (animal.Length > 5)
    {
    Console.WriteLine(animal);
    }
} 
}
else
{
    Console.WriteLine("Skipping Animals List");
}

Console.Write("Press Enter to Continue to Profile Greeting Selection");
Console.ReadLine();

//create list of greeting options.
List <string> greetingsOptions = new List<string> { "Southern", "Canadian", "Italian"};

//create list of greetings
List<string> greetings = new List<string> { "Howdy Y'all!!", "How're Ya Now?", "Ciao!!" };

Console.WriteLine("Type the number of your preffered greeting:");

//display greeting options
for (int i = 0;i < greetingsOptions.Count;i++)
{
    Console.WriteLine($"{i +1}) {greetingsOptions[i]}");
}

//check if user input is a number within the correct range, if not, prompt for input again.
string? greetingSelection = Console.ReadLine();
bool isNumber = int.TryParse(greetingSelection, out int userGreetingNumber);

while (!isNumber || userGreetingNumber < 0 || userGreetingNumber > (greetings.Count))
{
    Console.WriteLine($"Please Enter a number between 1 and {greetings.Count} ");
    greetingSelection = Console.ReadLine();
    isNumber = int.TryParse(greetingSelection, out int number);
    userGreetingNumber= number;

}

//display user's choice of number
Console.WriteLine($"Your Greeting is now {greetings[userGreetingNumber -1]}");
Console.WriteLine("Thanks for running this program! Press enter to quit");

Console.ReadLine();

//end of program