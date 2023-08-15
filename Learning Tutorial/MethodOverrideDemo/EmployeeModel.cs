namespace MethodOverrideDemo
{
	internal partial class Program
	{
		public class EmployeeModel : PersonModel
		{
            public decimal  HourlyRate { get; set; }	
			
			//virtual allows us to override a function in another class
			public virtual decimal GetPaycheckAmount(decimal hoursWorked)
			{
				return hoursWorked * HourlyRate;
			}
        }
	}
}
