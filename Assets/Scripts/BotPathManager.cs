using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BotPathManager 
{

    public Dictionary<pathParam, path> paths = new Dictionary<pathParam, path>();

    public bool isNeighbour(town fromTown, town toTown)
    {
        path outPath;
        if (paths.TryGetValue(new pathParam(fromTown, toTown), out outPath))
        {
            return true;
        }
        else
        {
            return false;

        }
    }

}


public struct pathParam
{
    public town fromTown;
    public town toTown;

    public pathParam (town fromTown, town toTown)
    {
        this.fromTown = fromTown;
        this.toTown = toTown;

    }
}

public struct path
{
    public pathParam thisPathParam;
    public Vector3[] pathPoints;

    public path (pathParam thisPathParam, Vector3[] pathPoints)
    {
        this.thisPathParam = thisPathParam;
        this.pathPoints = pathPoints;

    }

   
}
