using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance
{
    interface IPolicy
    {
        int Id { get; }
        float PropertyLimit { get; set; }
        float LiabilityLimit { get; set; }
        TimeSpan CoverageStart(TimeSpan start);
        TimeSpan CoverageEnded(TimeSpan end);
    }
}
