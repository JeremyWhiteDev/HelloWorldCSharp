Console.WriteLine("Howdy Y'all!!");
Console.ReadKey(); // What happens if you run the app without this line?

var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

foreach (var animal in animals)
{

    if (animal.Length > 5)
    {

    Console.WriteLine(animal);
    }
}