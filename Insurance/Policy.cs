using System;
using System.Collections;
using System.Collections.Generic;

abstract public class Policy
{
    private ArrayList accounts;
    private int id;
    private decimal propertyLimit;
    private decimal liabilityLimit;
    protected string status;
    protected DateTime start
    public Policy(int id, decimal propertyLimit, decimal liabilityLimit, string status)
    {
        this.id = id;
        this.propertyLimit = propertyLimit;
        this.liabilityLimit = liabilityLimit;
        this.status = status;

    }

    virtual public void Started(TimeSpan startDate)
    {

    }
    //void Ended(TimeSpan endDate);

}

