using GuestBookLibrary.Models;
//capture the info about each guest
//info to capture: first and last name, and message to the host
//once done, loop through each name and print their info, then print total




List<GuestModel> guests = new List<GuestModel>();

GetGuestInformation(guests);

PrintGuestInformation(guests);

static void GetGuestInformation(List<GuestModel> guests)
{
	string noMoreGuests = "";

	do
	{
		GuestModel guest = new GuestModel();

		guest.FirstName = GetInfoFromConsole("What is your first name? : ");
		guest.LastName = GetInfoFromConsole("What is your last name? : ");
		
		guest.MessageToHost = GetInfoFromConsole("What message would you like to tell your host? : ");

		noMoreGuests = GetInfoFromConsole("Are there any more guests coming? : ");

		guests.Add(guest);

		Console.Clear();

	} while (noMoreGuests.ToLower() == "yes");
}

static void PrintGuestInformation(List<GuestModel> guests)
{
	foreach (GuestModel guest in guests)
	{
		Console.WriteLine(guest.GuestInfo);
	}
}

static string GetInfoFromConsole(string message)
{
	string output = "";
    Console.WriteLine(message);
    output = Console.ReadLine();
	return output;
	
}
