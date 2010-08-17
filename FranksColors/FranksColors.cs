using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QualcommStandardInterfaces;

namespace FranksColors {
   public class FranksRed : IColorInterface {
      public FranksRed() { Name = "red"; Description = "This is the color of Frank's Shirt"; }
      public string Name { get; private set; }
      public string Description { get; private set; }
   }
   public class FranksBlue : IColorInterface {
      public FranksBlue() { Name = "blue"; Description = "This is the color of the Sky"; }
      public string Name { get; private set; }
      public string Description { get; private set; }
   }
   public class FranksGreen : IColorInterface {
      public FranksGreen() { Name = "green"; Description = "This is the color of Trees"; }
      public string Name { get; private set; }
      public string Description { get; private set; }
   }
}
