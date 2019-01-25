using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MT.Economy.TradingSystem;


public class marketManager : MonoBehaviour
{
    public town[] allTowns;
    public tradingItemData[] itemData;
    public float marketRandomness;



    private marketManagerCompute manager = new marketManagerCompute ();

    private void Start()
    {
        manager.initManager(ref allTowns, ref itemData, marketRandomness);
        
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
                private int totalPopulation;

                public void initManager (ref town[] allTowns, ref tradingItemData[] itemData, float marketRandomness)
                {
                    this.allTowns = allTowns;
                    this.itemData = itemData;
                    this.marketRandomness = marketRandomness;

                    calcTotalPopulation();
                    refreshMarket();
                   

                }
                private void calcTotalPopulation()
                {

                    for (int townIndex = 0; townIndex < allTowns.Length; townIndex++)
                    {
                        totalPopulation += allTowns[townIndex].thisTown.totalPopulation;
                    }
                }
                public void refreshMarket()
                {
                    for (int townIndex = 0; townIndex < allTowns.Length; townIndex++){

                        for (int itemDataIndex = 0; itemDataIndex < itemData.Length; itemDataIndex++)
                        {
                            int itemCost;
                            int itemQuantity;

                            float randomCostFactor = Random.Range(-marketRandomness, marketRandomness);

                            itemCost = Mathf.RoundToInt((itemData[itemDataIndex].averagePrice * randomCostFactor));

                            float quantityMultiplier = totalPopulation / allTowns[townIndex].thisTown.totalPopulation;

                            itemQuantity = Mathf.RoundToInt((itemData[itemDataIndex].averageTotalSupply * quantityMultiplier));
                        }
                    }
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