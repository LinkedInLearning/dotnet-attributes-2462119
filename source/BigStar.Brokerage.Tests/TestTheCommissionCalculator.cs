using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZUnit.Core;

namespace BigStar.Brokerage.Tests {
	public class TestTheCommissionCalculator {

		[Fact]
		public void Should_ReturnStandardCommission_GivenAmountsBelowThresholds() {
			// Arrange

			var unitsSold = 90;
			var unitPrice = 50.00M;
			var calculator = new BigStar.Brokerage.CommissionCalculator();

			// Act
			decimal calculatedCommission = calculator.DetermineVariableRate(unitsSold, unitPrice);

			// Assert
			decimal expectedCommission = (unitsSold * unitPrice) *
																	 BigStar.Brokerage.Constants.CommissionRate.Standard;
			ZUnit.Core.Assert.DecimalEqual(expectedCommission, calculatedCommission, "Commission is not correct!");
		}
	}
}
