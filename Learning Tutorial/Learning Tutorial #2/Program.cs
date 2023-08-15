
//Tuples- let you return more than one value from a method
/*
(string, string) GetFullName()
{
   Console.WriteLine("What is your first name?");
   string firstName = Console.ReadLine();

   Console.WriteLine("What is your last name?");
   string lastName = Console.ReadLine();

   return (firstName, lastName);
}

//access tuples
(string, string) fullName = GetFullName();

//or
var yourFullName = GetFullName();


Console.WriteLine("Your first name is: " + fullName.Item1);
Console.WriteLine("Your last name is: " + fullName.Item2);

//this works too
(string firstName, string lastName) = GetFullName();

//or
var (fName, lName) = GetFullName();

Console.WriteLine("Your first name is: " + firstName);
Console.WriteLine("Your last name is: " + lastName);

//if you don't need the last name, use underscore (the discard character
(string userFName, _ ) = GetFullName();
*/




//Homework
/*
using Learning_Tutorial__2;

//use introduceperson class
IntroducePerson user1 = new IntroducePerson();
user1.welcomeUser();
var(user1FirstName, user1LastName) = user1.GetFullName();
user1.greetUser(user1FirstName, user1LastName);	
*/

