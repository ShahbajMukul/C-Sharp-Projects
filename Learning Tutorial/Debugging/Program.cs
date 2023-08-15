//practice
/*
static void BadCall()
{
	//handling exception- 'try' +tab 2x
	int[] ages = new int[] { 1, 3, 5 };

	for (int i = 0; i <= ages.Length; i++)
	{
		try
		{
			Console.WriteLine(ages[i]);
		}
		catch (Exception ex) // ex: if there is an exception, put it on ex
		{

			Console.WriteLine("there is an error: " + ex.Message + Environment.NewLine);

			throw; //continues applications as if the error didn't occur
		}
	}
}

//exception handling for user
try
{
	BadCall();

}
catch (Exception ex)
{
	Console.WriteLine("there is an error: " + ex + Environment.NewLine); //ex.Message is useful for user
	throw; 
}
Console.ReadLine();
*/


//homework
/*//throw an exception after five iterations
int[] arr = new int[] { 0, 1, 2, 3, 4 };

for (int i = 0; i < 6; i++)
{
	try
	{
		Console.WriteLine(arr[i]);
    }
	catch (Exception ex)
	{
        Console.WriteLine(ex.Message);
        throw;
	}

}*/


//advanced exceptions

/*using System.Runtime.CompilerServices;

string inp = "shahbaj";
try
{
	//SimpleMethod();
	//DifferentMethod();
	ContextMethod(inp);

}

catch (InsufficientMemoryException ex)
{
	Console.WriteLine(ex.Message);
}
catch (ArgumentException ex)
{
	Console.WriteLine(ex.Message);
}
catch (InvalidOperationException ex) //specific exception
{
	Console.WriteLine(ex.Message);

}
catch (NotImplementedException)
{
	Console.WriteLine("You forgot to implement the method");

}

catch (Exception ex) when (inp.ToLower() == "shahbaj")
{
	Console.WriteLine("You used Shahbaj's name");
}

catch (Exception ex) //general Exceptions or the exceptions that are not covered by other catches goes through this
{
	Console.WriteLine("Error: " + ex.Message);
}
finally //this will run no matter if we catch any exceptions, example use is to close your database.
{
    Console.WriteLine("I always run"); 
}
Console.WriteLine("End");

//creating our own exception
static void SimpleMethod()
{
	throw new InvalidOperationException("You should not be calling this SimpleMethod");
}

static void DifferentMethod()
{
	throw new NotImplementedException();
}

static void ContextMethod(string name)
{
	if (name == "Shahbaj")
	{
		throw new InsufficientMemoryException("Shahbaj is too long for this method");
	}
	else
	{
		throw new ArgumentException("This person is not Shahbaj");
	}
}
*/





//Homework on advanced exceptions
static void MethodThatThrowsAnException()
{
	throw new NotImplementedException("");
}

try
{
	MethodThatThrowsAnException();
}

catch (NotImplementedException)
{
	Console.WriteLine("You did not implement this function");
}

catch (Exception ex)
{
	Console.WriteLine("Default exception" + ex.Message);
}
finally
{
    Console.WriteLine("End of Project");
}