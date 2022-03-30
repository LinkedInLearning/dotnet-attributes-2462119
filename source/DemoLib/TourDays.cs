using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib {
  // Flag attribute

  // .ToString() formatted as comma separated values
  // .Parse(), parses comma separated string

  // bitwise operators
  [Flags]
  public enum TourDays : long {

    None = 0,
    Monday = 1 << 0,    //1  (0000-0001)
    Tuesday = 1 << 1,   //2  (0000-0010)
    Wednesday = 1 << 2, //4  (0000-0100)
    Thursday = 1 << 3,  //8  (0000-1000)
    Friday = 1 << 4,    //16 (0001-0000)
    Saturday = 1 << 5,  //32 (0010-0000
    Sunday = 1 << 6,    //64 (0100-0000
    Weekend = Sunday | Saturday, //96 (0110-0000)



  }
}
