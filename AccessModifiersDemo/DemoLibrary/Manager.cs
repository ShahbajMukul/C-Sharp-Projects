namespace DemoLibrary
{
	//a grand children class will also have access to the protected FormerLastName
	public class Manager : Employees 
    {
        public string GetAllNames()
        {
            return $"{FirstName} {LastName} (formerly known as {FormerLastName})";
        }

        public void SavePerson()
        {
			DataAccess dataAccess = new DataAccess();
            dataAccess.GetConnectionString();

		}
    }
}
