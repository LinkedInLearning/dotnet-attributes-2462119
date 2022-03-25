using System;

namespace BigStar.Brokerage {

	public class CommissionCalculator {

		
		public decimal DetermineVariableRate(int unitsSold, decimal unitPrice) {


			// Sales representative gets top commission rate
			// if they sell over the sales threshold amount
			// or if they sell more than the max unit threshold
			if (unitsSold < 0)
			{
				throw new ArgumentOutOfRangeException("UnitsSold cannot be less than zero.");
			}

			if (unitPrice < 0)
			{
				throw new ArgumentOutOfRangeException("unitPrice cannot be less than zero.");
			}

			decimal grossSale = unitsSold * unitPrice;
			if (grossSale > Constants.CommissionThreshold.SalesAmount || unitsSold > Constants.CommissionThreshold.UnitAmount)
			{
				return grossSale * Constants.CommissionRate.Top;
			}
			else
			{
				return grossSale * Constants.CommissionRate.Standard;
			}
		}
	}
}