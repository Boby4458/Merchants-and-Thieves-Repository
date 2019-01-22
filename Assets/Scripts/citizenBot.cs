using System;
using UnityEngine;
using System.Collections.Generic;


public class citizenBot : MonoBehaviour, botBase {

    public botType type { get; set; }
    public botInventory inventory { get; set; }
    public transportType transportType { get; set; }
   
    public citizenBot(Vector3 pos, botType type, botInventory inventory, transportType transportType){

        this.transform.position = pos;
        this.type = type;
        this.inventory = inventory;
        this.transportType = transportType;

    }
    
    public void die()
    {
        Destroy(this.gameObject);
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
    
    public town cheapestTown()
    {
        town returnTown;

        
       
        return null;
    }*/
}

