using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MT.Economy.TradingSystem;


public class marketManager : MonoBehaviour
{
    private town[] allTowns;
    private tradingItemData[] itemData;
    [SerializeField]
    private float marketRandomness;

    marketManagerCompute manager = new marketManagerCompute ();

    private void Start()
    {
        refreshMarket();

    }
    private void refreshMarket()
    {

    }
}

namespace MT
{
    namespace Economy
    {

        namespace TradingSystem
        { 

            public class marketManagerCompute
            {
                public town[] allTowns;
                public tradingItemData[] itemData;
                public float marketRandomness;

                public void initManager (ref town[] allTowns, ref tradingItemData[] itemData, float marketRandomness)
                {
                    this.allTowns = allTowns;
                    this.itemData = itemData;
                    this.marketRandomness = marketRandomness;
                }
                
            }

        }
    }
}
    /*
        private List<tradingItem> allCurrentItems = new List<tradingItem>();
    private Dictionary<tradingItemData, itemStatistic> getMarketStats (){

        Dictionary<tradingItemData, itemStatistic> itemStats = new Dictionary<tradingItemData, itemStatistic>();
        foreach (Node chunk in chunks)
        {
            allCurrentItems.AddRange(chunk.itemsInChunk);

        }
        foreach (tradingItem item in allCurrentItems)
        {
            try
            {
                itemStats[item.myItemType].count += 1;
                itemStats[item.myItemType].itemsOnMarket.Add(item);

            }
            catch
            {
                itemStats.Add(item.myItemType, new itemStatistic(1, item.myItemType));
                itemStats[item.myItemType].itemsOnMarket.Add(item);
                
            }
        }
        
        
        
        return itemStats;

    }

    private void refreshMarket()
    {
        foreach (tradingItemData itemType in dataItems)
        {
            print("1");
            int availableTowns = itemType.availableInTowns.Length;
            int supply =  itemType.averageSupply + Random.Range (-Mathf.RoundToInt(itemType.averageSupply * marketRandomness), Mathf.RoundToInt(itemType.averageSupply * marketRandomness));
        
            int perTownSupply = (int) supply / availableTowns;

            int townSupplies = availableTowns;

            foreach (town _town in itemType.availableInTowns)
            {
                print("2");
                int rnd = Random.Range(0, townSupplies);
                townSupplies -= rnd;

                int curTownSupply = (int) rnd * perTownSupply;

                int supplyPC = (int) curTownSupply / _town.occupiedChunks;

                foreach (Node chunk in chunks)
                {
                    print("3");
                    if (chunk.myTown == _town)
                    {

                        for (int i = 0; i <= supplyPC; i++) {
                            print("4");
                            tradingItem newItemInstance = new tradingItem();
                            newItemInstance.myCost = itemType.marketPrice; //Economy Manager
                            newItemInstance.myItemType = itemType;
                            chunk.itemsInChunk.Add (newItemInstance);
                            
                        }
                    }
                }
            }
        }
    }


}

sealed class itemStatistic
{
    public tradingItemData itemType;
    public int count;
    public List<tradingItem> itemsOnMarket = new List<tradingItem>();


    public itemStatistic (int count, tradingItemData itemType) {
        this.count = count;
        this.itemType = itemType;

    }
}
*/