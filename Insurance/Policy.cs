using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Insurance
{
    public class Policy
    {
        private ArrayList accounts;
        private int nextid = 1;
        public Policy() { }
        //void Started(TimeSpan startDate);
        //void Ended(TimeSpan endDate);

        string Status { get; }
        int Id { get; }
        decimal PropertyLimit { get; }
        decimal LiabilityLimit { get; }
    }

}
