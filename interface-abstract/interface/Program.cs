
public interface ILoyalCardHolder
{
    int TotalPoints
    {
        get;
    }
    int AddPoints(decimal transactionValue);
    void ResetPoints();
}

public class Customer : ILoyalCardHolder
{
    private int totalPoints;
    public int TotalPoints
    {
        get { return totalPoints; }
    }

    public int AddPoints(decimal transactionValue)
    {
        int points = Decimal.ToInt32(transactionValue);
        totalPoints += points;
        return totalPoints;
    }
    public void ResetPoints()
    {
        totalPoints = 0;
    }
}


public class Coffee : IBeverage
{
    private int servingTempWithoutMilk { get; set; }
    private int servingTempWithMilk { get; set; }

    public int IBeverage.GetservingTemperature(bool includesMilk)
    {
        if (includesMilk)
        {
            return servingTempWithMilk;
        }
        else
        {
            return servingTempWithoutMilk;
        }
    }

    public bool IBeverage.IsFairTrade { get; set; }
}
