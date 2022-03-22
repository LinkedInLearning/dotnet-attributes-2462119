namespace DataLib {

 
  public class CollectableCard {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Slogan { get; set; }

    public TeamNames TeamName { get; set; }

    public string? Description { get; set; }
    public decimal CatalogPrice { get; set; }
    public decimal BidPrice { get; set; }
    public int PopularityIndex { get; set; }
  }
}

public enum CardFamily {
  Monsters,
  Aliens,
  Robots,
  Animals
}

public enum TeamNames {
  BlueShadows,
  ThunderHeads,
  SpookTones,
  Crashmasters,
  Mavericks,
  LaserPhasers,
  Helios,
  Farsiders,
  SuperNovas
}
