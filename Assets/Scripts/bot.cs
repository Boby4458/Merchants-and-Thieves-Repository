using System;
using UnityEngine;
using System.Collections.Generic;


public class bot : botManager {

    public Vector3 myPos;
    public List<tradingItem> myItems;
    public town targetTown;
    public transportType _transportType;
    public int botMoney;

    public bot (Vector3 myPos, transportType _transportType){
        this.myPos = myPos;
        this._transportType = _transportType;

        targetTown = closestTownChunk(myPos);
    }

    /*public town closestTownChunk(Vector3 fromPos)
    {
        town returnTown = null;

        float lowestDist = Mathf.Infinity;

        foreach (Node tempTown in nodes.Values)
        {
            if (tempTown.myTown != null)
            {
                float tempDist = Vector3.Distance(fromPos, tempTown.gameObject.transform.position);
                if (tempDist < lowestDist)
                {
                    returnTown = tempTown.myTown;
                    lowestDist = tempDist;
                }
            }
        }

        return returnTown;
    }
    */
    public town cheapestTown()
    {
        town returnTown;
         
        
       
        return returnTown;
    }
}

