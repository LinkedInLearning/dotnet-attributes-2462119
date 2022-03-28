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
  public enum TourDays {
   
    None =      0x00000000,
    Monday =    0x00000001, //1
    Tuesday =   0x00000010, //2
    Wednesday = 0X00000100, //4
    Thursday =  0x00001000, //8  
    Friday =    0x00010000, //16
    Saturday =  0x00100000, //32
    Sunday =    0x01000000, //64
    Weekend=    0x01100000, //96
    All =       0x01111111  //127
    // MondayTuesday = 0x00000011, // not the typical way to do combined values

  }
}
