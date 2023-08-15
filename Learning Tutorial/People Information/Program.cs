using People_Information;

/*
 string? firstName = "";
List<PersonModel> people = new List<PersonModel>();

Console.WriteLine("Enter the information. When done, type 'exit'");


do
{
	Console.Write("What is the first name? :");
	firstName = Console.ReadLine();

	if (firstName.ToLower() != "exit")
	{
		PersonModel person = new PersonModel();
		person.FirstName = firstName;
		Console.Write("What is the last name? :");
		string? lastName = Console.ReadLine();
		person.LastName = lastName;
		people.Add(person);
	} 
} while (firstName.ToLower() != "exit");


foreach (var person in people)
{
    ProcessPerson.GreetPerson(person);
}
*/

//full property test
/*
PersonModel person = new PersonModel();
person.SSN = "123-45-6789";
Console.WriteLine(person.SSN);*/


//substring practice - keeps the last 6 letters of the string
/*
string lyric = "Cornelia Street";
string x = lyric.Substring(lyric.Length - 6);
Console.WriteLine(x);*/

//car class

CarModel car = new CarModel(2022, "Honda", "Civic");