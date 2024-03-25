// See https://aka.ms/new-console-template for more information



Console.Clear();

Console.WriteLine("Hello, World!");

// SECTION strings

string name = "Jeremy";

string favoriteFood = "Macaroni and Cheese";

char letter = 'c';

Console.WriteLine($"My name is {name} and my favorite food is {favoriteFood}");

Console.WriteLine(""""" curly "boyz" """"".Trim());

// !SECTION



// SECTION booleans and conditionals

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

// !SECTION



// SECTION numbers

int numberOfCats = 6;

int maxInt = 260000000;

long maxLong = 2600000000000000000;

double decimalKinda = 7.35;

decimal superAccurateDecimal = 6.82641209843922342355234M; // NOTE probably be used for money application

Console.WriteLine(25 + 3 / 100 * 3);


double total = numberOfCats + decimalKinda;

Console.WriteLine(total);

// !SECTION

// SECTION objects, arrays, loops

Cat gopher = new Cat("Gopher", 4, "Black", true, 8); // explicit type

var georgie = new Cat("Georgie", 4, "Grey", true, 6); // implicit type

var nameOfCat = georgie.Name; // implicit type

int[] numbers = [1, 2, 3, 99]; // arrays are stinky in C#

for (int i = 0; i < numbers.Length; i++)
{
  Console.WriteLine($"numbers at index of {i} is {numbers[i]}");
}

List<string> names = ["jeremy", "mick", "jake"]; // Lists will be the collection data type we use the most

foreach (var firstName in names) // foreach runs similar to for in loop from js
{
  Console.WriteLine(firstName);
}

names.ForEach(firstName => Console.WriteLine(firstName)); // ForEach is a List Method that runs similar to forEach from js


var cats = new List<Cat> { new Cat("Cybil", 4, "Calico", false, 9) }; // creates a List of type Cat

cats.Add(gopher); // adds to end of list, similar to push from js
cats.Add(georgie);

foreach (var cat in cats)
{
  Console.WriteLine(cat.IntroduceYourself());
}

// for (int i = 0; i < cats.Count; i++)
// {

// }

Cat? foundCat = cats.Find(cat => cat.Name == "Gopher"); // finds a single Cat from list, ? denotes that foundCat can be null


class Cat
{
  // NOTE properties that exist on Cat class
  // get set allows us to view / change properties on data
  // public is an access modifier that allows any outside code to access this property
  public string Name { get; set; }
  public int NumberOfLegs { get; set; }
  public string Color { get; set; }
  public bool LikesCheese { get; set; }
  // NOTE private members are only accessible to the code inside this class
  private int NumberOfLives;

  // NOTE getter method, can access private members of class
  public bool IsAlive { get { return NumberOfLives > 0; } }

  // NOTE method, string is return type
  public string IntroduceYourself()
  {
    return $@"
    Hi my name is {Name}.
    I am a {Color} cat with {NumberOfLegs} legs. 
    I {(LikesCheese ? "LOVE" : "HATE")} cheese.
    I {(IsAlive ? "am" : "am not")} alive.
    ";
  }

  // NOTE constructor
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

// !SECTION