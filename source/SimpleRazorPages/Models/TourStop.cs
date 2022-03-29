using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailorMadeTours.Models {
	public class TourStop {
    [Required]
    [Display(Name = "Stop Number"), Key]
    public int? StopNumber { get; set; }
		public string? TourName { get; set; }
		public string Latitude { get; set; }
		public string Longitude { get; set; }
		public string Description { get; set; }
		[Phone]
		public string Phone { get; set; }
		public string ImageUri { get; set; }
		public List<BusyTime> BusyTimes { get; set; }
		public bool Selected { get; set; }
		public int EstimatedMinutes { get; set; }

	}
	public class BusyTime {
    [Key]
		public int Hour { get; set; }
		public int Rank { get; set; }

	}
}
