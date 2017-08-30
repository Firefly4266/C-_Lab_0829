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
    protected DateTime start;
    protected DateTime ended;
    public Policy(int id, DateTime start, decimal propertyLimit, decimal liabilityLimit, string status, DateTime ended)
    {
        this.id = id;
        this.start = start;
        this.propertyLimit = propertyLimit;
        this.liabilityLimit = liabilityLimit;
        this.status = status;
        this.ended = ended;
    }
    public int Id
    {
        get
        {
            return id;
        }
    }
    public DateTime Start
    {
        get
        {
            return start;
        }
    }
    public decimal PropertyLimit
    {
        get
        {
            return propertyLimit;
        }
    }
    public decimal LiabilityLimit
    {
        get
        {
            return liabilityLimit;
        }
    }
    public string Status
    {
        get
        {
            return status;
        }
    }
    public DateTime Ended
    {
        get
        {
            return ended;
        }
    }
}

