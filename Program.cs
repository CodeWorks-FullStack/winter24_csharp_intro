// See https://aka.ms/new-console-template for more information


using System.Numerics;

Console.Clear();

Console.WriteLine("Hello, World!");


string name = "Jeremy";

string favoriteFood = "Macaroni and Cheese";

char letter = 'c';

Console.WriteLine($"My name is {name} and my favorite food is {favoriteFood}");

Console.WriteLine(""""" curly "boyz" """"".Trim());

bool jeremyHasManyCats = true;

jeremyHasManyCats = false;

// if (jeremyHasManyCats == true)
if (jeremyHasManyCats)
{
  Console.WriteLine("Jeremy has a lot of cats");
}
else
{
  Console.WriteLine("Jeremy should adopt some more cats");
}

if (name != null)
{
  Console.WriteLine("Name was not null");
}

// if(name){} //NOTE throws error, no truthy falsy in c#

if (name != "Jeremy")
{
  Console.WriteLine("Name was not Jeremy");
}


int numberOfCats = 6;

int maxInt = 260000000;

long maxLong = 2600000000000000000;

double decimalKinda = 7.35;

decimal superAccurateDecimal = 6.82641209843922342355234M; // NOTE probably be used for money application


Console.WriteLine(25 + 3 / 100 * 3);
double total = numberOfCats + decimalKinda;
Console.WriteLine(total);

Cat gopher = new Cat("Gopher", 4, "Black", true, 8);


var georgie = new Cat("Georgie", 4, "Grey", true, 6);

var nameOfCat = georgie.Name;


int[] numbers = [1, 2, 3, 99];

for (int i = 0; i < numbers.Length; i++)
{
  Console.WriteLine($"numbers at index of {i} is {numbers[i]}");
}

List<string> names = ["jeremy", "mick", "jake"];

foreach (var firstName in names)
{
  Console.WriteLine(firstName);
}

names.ForEach(firstName => Console.WriteLine(firstName));

var cats = new List<Cat> { new Cat("Cybil", 4, "Calico", false, 9) };

cats.Add(gopher);
cats.Add(georgie);

foreach (var cat in cats)
{
  Console.WriteLine(cat.IntroduceYourself());
}

// for (int i = 0; i < cats.Count; i++)
// {

// }

Cat? foundCat = cats.Find(cat => cat.Name == "Gopher");


class Cat
{
  public string Name { get; set; }
  public int NumberOfLegs { get; set; }
  public string Color { get; set; }
  public bool LikesCheese { get; set; }
  private int NumberOfLives;
  public bool IsAlive { get { return NumberOfLives > 0; } }

  public string IntroduceYourself()
  {
    return $@"
    Hi my name is {Name}.
    I am a {Color} cat with {NumberOfLegs} legs. 
    I {(LikesCheese ? "LOVE" : "HATE")} cheese.
    I {(IsAlive ? "am" : "am not")} alive.
    ";
  }

  public Cat(string name, int numberOfLegs, string color, bool likesCheese, int numberOfLives)
  {
    Name = name;
    NumberOfLegs = numberOfLegs;
    Color = color;
    LikesCheese = likesCheese;
    NumberOfLives = numberOfLives;
  }
}

// NOTE primary constructor, works the same as above class
// class Cat(string name, int numberOfLegs, string color, bool likesCheese, int numberOfLives)
// {
//     public string Name { get; set; } = name;
//     public int NumberOfLegs { get; set; } = numberOfLegs;
//     public string Color { get; set; } = color;
//     public bool LikesCheese { get; set; } = likesCheese;
//     private int NumberOfLives = numberOfLives;
//   public bool IsAlive { get { return NumberOfLives > 0; } }
// }