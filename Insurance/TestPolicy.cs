using System;
using System.Collections;


public class TestPolicy
{
    public static void Main()
    {
        Policy policy = new Policy(
            8976441, 
            //20170418, 
            200000.00m, 
            50000.00m, 
            "InForceFullyPaid"
            //04182018
            );
        Console.WriteLine(policy.Id);
    }
}
