using System.Collections.Generic;


public interface botBase {

   void die();
   botType type { get; set; }
   botInventory inventory { get; set; }
   transportType transportType { get; set; }

}

public enum botType
{
    Citizen, Trader, Thieve
}



public class botInventory
{
    public int money;


    public List<tradingItem> items = new List<tradingItem>();

    
}