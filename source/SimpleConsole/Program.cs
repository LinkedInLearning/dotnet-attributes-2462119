// See https://aka.ms/new-console-template for more information
using DemoLib;

public class SimpleConsole {
  static void Main(string[] args) {

    //  The company offers tours on different days.
    //  for example the Bike the Waterfront tour is Monday, Wednesday and Friday
    //  The Railroad History tour is Saturday and Sunday.

    var tacoTuesdayTour = TourDays.Tuesday;
    var waterfrontTour = TourDays.Monday | TourDays.Wednesday | TourDays.Friday;

    var railroadTour1 = TourDays.Saturday | TourDays.Sunday;
    var railroadTour2 = TourDays.Weekend;

    Console.WriteLine($"Taco Extravaganza  tour: {tacoTuesdayTour}");

    Console.WriteLine($"Bike the Waterfront tour: {waterfrontTour}");

    Console.WriteLine($"Railroad History tour 1: {railroadTour1}");
    Console.WriteLine($"Railroad History tour 2: {railroadTour2}");
    Console.WriteLine();

    var tour1 = new Tour();
    var tour2 = new Tour();

     tour1.TourDays = Enum.Parse<TourDays>("Thursday");

    tour2.TourDays = Enum.Parse<TourDays>("Tuesday, Thursday");

    Console.WriteLine($"Tour 1 instance: {tour1.TourDays}");

    Console.WriteLine($"Tour 2 instance: {tour2.TourDays}");
  }
}

