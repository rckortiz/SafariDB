using System;
using System.Linq;

namespace SafariDB
{
  class Program
  {
    static void SeedData()
    {
      var db = new SafariContext();
      var expedition = new Safari
      {
        Species = "Jaguar",
        CountOfTimesSeen = 24,
        LocationOfLastSeen = "Jungle"
      };
      var expedition2 = new Safari
      {
        Species = "Rhino",
        CountOfTimesSeen = 30,
        LocationOfLastSeen = "Desert"

      };
      var expedition3 = new Safari
      {
        Species = "Panther",
        CountOfTimesSeen = 40,
        LocationOfLastSeen = "Jungle"
      };
      var expedition4 = new Safari
      {
        Species = "Tiger",
        CountOfTimesSeen = 60,
        LocationOfLastSeen = "Jungle",
      };
      var expedition5 = new Safari
      {
        Species = "Elephant",
        CountOfTimesSeen = 20,
        LocationOfLastSeen = "Desert"
      };

      db.SaveChanges();

    }

    static void ReadData()
    {
      var db = new SafariContext();
      var allSpecies = db.Safaris.Select(safari => safari.Species);
      foreach (var species in allSpecies)
      {
        Console.WriteLine(species);
      }
      static void ReadDataAgain()
      {
        var db = new SafariContext();
      }
    }
  }
}
