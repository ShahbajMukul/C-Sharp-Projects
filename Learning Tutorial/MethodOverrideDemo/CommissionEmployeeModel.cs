namespace MethodOverrideDemo
{
	internal partial class Program
	{
		public class CommissionEmployeeModel : EmployeeModel
		{
            public decimal CommissionAmount { get; set; }

			public override decimal GetPaycheckAmount(decimal hoursWorked)
			{
				decimal initialPay = base.GetPaycheckAmount(hoursWorked);
				return initialPay + CommissionAmount;
			}
		}
	}
}
