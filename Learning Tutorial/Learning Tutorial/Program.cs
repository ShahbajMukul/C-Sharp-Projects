using Learning_Tutorial;
using System.Xml.Linq;

/*
string filePath = "C:\\Demo\\Learning";
string filePathWithAt = @"C:\Demo\Learning";

Console.WriteLine("filePath: " + filePath);
Console.WriteLine("filePathWithAt: " + filePathWithAt);

*/

/*
Human person1 = new Human("John", "Green");
person1.printInfo();

Box box1 = new Box(5,6);
//box1.dimension = 2;

box1.printInfo();

*/

/*
//nullable variables
string? personName;
int? age;
bool? isAlive;
string? phoneNumber;

*/
/*
using System.Globalization;


DateTime yourBirthday = DateTime.ParseExact("01/08/1995", "dd/MM/yyyy", CultureInfo.InvariantCulture);




DateTime gradDate = DateTime.ParseExact("11/06/2021 03:30 PM Monday", " hh:mm tt dddd", CultureInfo.InvariantCulture);
DateTime gradTime = DateTime.ParseExact("03:30", "", CultureInfo.InvariantCulture);

Console.WriteLine(gradDate.ToString());

*/
/*
DateOnly birthday = DateOnly.Parse("6/11/1998");
DateOnly gradDate = DateOnly.Parse("6/11/2021");


Console.WriteLine(gradDate.ToString("MMMM dddd yyyy"));

Console.WriteLine(birthday.ToString("MMMM dddd,yyyy"));

*/

/*
TimeOnly storeOpensAt = TimeOnly.Parse("09:00 PM");
TimeOnly rightNow = TimeOnly.FromDateTime(DateTime.Now);

Console.WriteLine(storeOpensAt);
Console.WriteLine(rightNow);
*/
/*
int? userAge;
int dogAgeInt;//

*//*Console.Write("What is your age? :");

userAge  = int.TryParse(Console.ReadLine(), out int age) ? age : null;

Console.WriteLine($"Your age is {userAge}");
*//*
Console.Write("What is your dog's age in words? :");
int.TryParse(Console.ReadLine(), out dogAgeInt);

Console.WriteLine($"Your dog's age is {dogAgeInt}");

//int to double conversion
double dogAgeDouble = (double)dogAgeInt;

Console.WriteLine($"Your dog's age is {dogAgeDouble}");

*/


/*
int? userAge;

Console.Write("What is your age, big sire? :");

userAge = int.Parse(Console.ReadLine());
Console.WriteLine("You were " + (userAge - 25) + " 25 years ago.");
Console.WriteLine($"You will be {userAge + 25} in 25 years");

//shift + Enter to make curly braces after conditional statements and go inside them
if (userAge >= 18)
{
    Console.WriteLine("Ga deh!");
}
else if (userAge < 18)
{
    Console.WriteLine("wasap broo");
    Console.WriteLine("wasap broo");
    Console.WriteLine("wasap broo");
    Console.WriteLine("wasap broo");
    Console.WriteLine("wasap broo");
    Console.WriteLine("wasap broo");
}
*/

/*
Console.WriteLine("Give me a name");
string firstName = Console.ReadLine();
int age = 38;
switch (firstName.ToLower())
{
    case "":
        Console.WriteLine("Give me a name");
         firstName = Console.ReadLine();
        Console.WriteLine("your name is " + firstName);
        break;
    case "shah":
        Console.WriteLine("Wassup bro");
        break;
    default:
        Console.WriteLine("IDK you");
        break;
}

Console.WriteLine("Give me your age");
age = int.Parse(Console.ReadLine());

switch (age)
{
    case <=3:
        Console.WriteLine("How do you know how to use computers");
        break;
    case > 3 and <16:
        Console.WriteLine("Hello, what cartoon would you like to watch?");
        break;
    default:
        Console.WriteLine("Check out the new studies about quantum entanglement!");
        break;
}
*/

/*Console.Write("Hello, ");
string firstName;
bool match = false;


do
{
    Console.WriteLine("what is your first name?");
    firstName = Console.ReadLine();
	switch (firstName.ToLower())
    {
        case "tim":
            Console.WriteLine($"Welcome, Prof. Tim");
            break;
        default:
            Console.WriteLine("Welcome student");
            break;
    }
    
} while (firstName.ToString() != "tim");
*/

/*
string[] firstNames = new string[4];

firstNames[0] = "Abdallah";
firstNames[1] = "James";
firstNames[2] = "Karim";
firstNames[3] = "Jabbar";

foreach (string name in firstNames)
{
    Console.Write(name + " ");
}
Console.Write(Environment.NewLine);

//string to array conversion
string namesInstring = "Abdallah, James, Karim, Jabbar";
string[] namesInArray = new string[4];
namesInArray = namesInstring.Split(", ");

foreach (string name in namesInArray)
{
	Console.Write(name + " ");
}

Console.Write(Environment.NewLine);

for (int i = 0; i < 10; i++)
{
	Console.Write("Hatta...");
}

string[] lastNames = new string[] { "Starling", "Veira", "Rodrigez" };

foreach (string name in lastNames)
{
    Console.Write(name + " ");
}*/

/*
string[] names = new string[] { "Rahim", "Abdallah", "Swift" };
int inp;
do
{
    Console.Write("Select a number (0 to exit): ");
    inp = int.Parse(Console.ReadLine());

    if(inp > 0 && inp < 4)
    {
        Console.WriteLine(names[inp - 1]);
    }
    else if(inp ==0)
    {
        break;
    }
    else 
    { 
        Console.WriteLine("Invalid input"); 
    }
} while (inp != 0);
*/

/*
List<string> listOfNames = new List<string>();
List<int> listOfNumbers  = new List<int> { 1, 2, 3 };
listOfNames.Add("England");
listOfNames.Add("Bangladesh");

foreach (var name in listOfNames)
{
    Console.WriteLine(name); 
}

//variable to list conversion
string someStates = "Michigan, Florida, Arizona, California, Delaware";
List<string> listOfStates = someStates.Split(", ").ToList();

foreach (var state in listOfStates)
{
    Console.WriteLine(state);
}
*/
/*
List<string> students = new List<string>();
string input;
Console.WriteLine("when done, enter 0");

do
{
    Console.Write("Enter the name of the student: ");
    input = Console.ReadLine();

	students.Add(input.ToString());
} while (input != "0");

Console.WriteLine($"Number of students added: {students.Count}");
*/


/*
Dictionary<string, string> lookup = new Dictionary<string, string>();

//btw, we don't have to repeat the name or the data type each time
Dictionary<int, string> numbers = new (); //C# knows what we want

lookup["animal"] = "not a human";
lookup["fish"] = "live in water";

Console.WriteLine($"Fishes do what? They {lookup["fish"]}");

*/
/*
Dictionary<int, string> employees = new Dictionary<int, string>();
employees[923] = "Jamie Carrager";
employees[011] = "Terry Henry";
employees[234] = "Miecha Rechards";

int userInp = int.Parse(Console.ReadLine());

Console.WriteLine(employees[userInp]);
*/
/*
string userNames;
string[] arrayOfNames = new string[5] ;

Console.WriteLine("Enter 5 first names separated only by commas");
Console.WriteLine("Like this \"James,Kitty,...\"");

Console.Write("Enter the names: ");
userNames = Console.ReadLine();

arrayOfNames = userNames.Split(',');

foreach (string name in arrayOfNames)
{
    Console.WriteLine($"Hello, {name}");
}
*/


