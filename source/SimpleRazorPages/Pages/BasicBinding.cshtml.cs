using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TailorMadeTours.Models;

namespace SimpleRazorPages.Pages {

  // 	Model Binding in Razor Pages is the process that takes values
  // 	from HTTP requests and maps them to
  // 	handler method parameters or PageModel properties.
  //  By default, only values that form part of a POST request
  //  are considered for model binding when you use the BindProperty attribute.
  public class BasicBindingModel : PageModel {

    
    public void OnGet() {

      var stop = this.CurrentTourStop;
     
    }

    [BindProperty(SupportsGet = true)]
    public TourStop CurrentTourStop { get; set; }
  }
}
