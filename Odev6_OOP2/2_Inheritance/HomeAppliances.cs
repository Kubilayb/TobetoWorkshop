using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Examples._2_Inheritance;

public class HomeAppliances
{
    public int Id { get; set; }
    public string Name { get; set; }

    public string Description { get; set; }

    public int ModelYear { get; set; }

    public double Price { get; set; }

}

public class Television : HomeAppliances 
{
    public string ResolutionQuality { get; set; }
    public string TVSize { get; set; }
}

public class WashingMachine : HomeAppliances
{
    public string MaxKg { get; set; }

    public int SpinSpeedRpm { get; set; }
}


