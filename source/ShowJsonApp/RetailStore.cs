using Json.Smasher.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLib
{
	[Sort(ReverseOrder = true)]
	internal class RetailStore
	{
		
		public int StoreNumber { get; set; }
		public string?  BranchName{ get; set; }
		public string? SalesRegion { get; set; }
		public bool IsFranchised { get; set; }

	}
}
