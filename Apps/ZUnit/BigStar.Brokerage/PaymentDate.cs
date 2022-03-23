using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigStar.Brokerage.PaymentSystem {
	public class PaymentDate {
		/// <summary>
		///  Calculates a payment date 30 days in the future
		///  from the provided date.
		///  If the payment date is on a weekend, 
		///  then move it to the first work day after the 
		///  proposed date
		/// </summary>
		/// <param name="startingDate">the date to use as starting date.</param>
		/// <returns></returns>
		public DateOnly CalculateFuturePaymentDate(DateOnly startingDate) {
			var tempDate = startingDate.AddDays(30);


			switch (tempDate.DayOfWeek)
			{
				case DayOfWeek.Saturday:
					tempDate = tempDate.AddDays(2);
					break;
				case DayOfWeek.Sunday:
					tempDate = tempDate.AddDays(3); // Error in our code here!
					break;


			}
			return tempDate;

		}
	}
}
