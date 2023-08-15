using System.Xml.Linq;

Dictionary<string, int> GuestBook =  new Dictionary<string, int>();
string userName;
int membersInFamily;
int totalGuests = 0;

(string,int) GreetAndGetInfo()
{
    Console.WriteLine("Hello, welcome to the event! This is a guest book app");
    Console.Write("What is your name? :");
	userName = Console.ReadLine();
	Console.Write("How many people are in your party including you? :");
	membersInFamily = int.Parse(Console.ReadLine());

    Console.WriteLine(Environment.NewLine);
    return (userName, membersInFamily);
}


Console.WriteLine("Enter the information to the guest list. When done, enter 0\n");
do
{
	(userName, membersInFamily) = GreetAndGetInfo();
	if (userName != "0")
	{
		GuestBook.Add(userName, membersInFamily); 
	}
} while (userName != "0");


foreach (var member in GuestBook.Keys)
{
    Console.Write(member + " family, ");
	totalGuests = totalGuests +  GuestBook[member];
}

Console.WriteLine("\nTotal Numbers of guests: " + totalGuests);
