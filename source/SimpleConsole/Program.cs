// See https://aka.ms/new-console-template for more information
using DemoLib;

public class SimpleConsole {
  static void Main(string[] args) {

    //  The company offers tours on different days.
    //  for example the Bike the Waterfront tour is Monday, Wednesday and Friday
    //  The Railroad History tour is Saturday and Sunday.

    var tacoTuesdayTour = TourDays.Tuesday;
    var waterfrontTour = TourDays.Monday | TourDays.Wednesday | TourDays.Friday;  // (1 + 4 + 16 = 21)

    var railroadTour = TourDays.Tuesday | TourDays.Thursday; // (2 + 8 = 10 )



    Console.WriteLine($"Taco Extravaganza  tour: {tacoTuesdayTour}");

    Console.WriteLine($"Bike the Waterfront tour: {waterfrontTour}");

    Console.WriteLine($"Railroad History tour: {railroadTour}");

    Console.WriteLine();


  }
}

