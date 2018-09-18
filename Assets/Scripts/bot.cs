using System;
using UnityEngine;
using System.Collections.Generic;


public class bot : chunkSystem{

    public Vector3 myPos;
    public List<tradingItem> myItems;
    public Node targetTown;
    public transportType _transportType;

    public bot (Vector3 myPos, transportType _transportType){
        this.myPos = myPos;
        this._transportType = _transportType;

        targetTown = closestTownChunk(myPos);
    }

    public Node closestTownChunk(Vector3 fromPos)
    {
        Node returnNode = null;

        float lowestDist = Mathf.Infinity;

        foreach (Node tempTown in nodes.Values)
        {
            if (tempTown.myTown != null)
            {
                float tempDist = Vector3.Distance(fromPos, tempTown.gameObject.transform.position);
                if (tempDist < lowestDist)
                {
                    returnNode = tempTown;
                    lowestDist = tempDist;
                }
            }
        }

        return returnNode;
    }

}

