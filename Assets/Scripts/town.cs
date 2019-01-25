﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

using MT.TownSystem;
using MT.Economy.TradingSystem;


public class town : MonoBehaviour {

    public townData thisTown;
    public inventory townInventory;

    private void Start()
    {
        Debug.Log("Showing items of " + thisTown.townName);
        Invoke("showItems", 2);
    }
    private void showItems()
    {
        //print("Showing items of " + myTown.townName);

        foreach (tradingItem item in townInventory.items.Keys)
        {
            Debug.Log(thisTown.townName + item.itemType.itemName);

        }
    }


}

/*
[System.Serializable]
public class mapData
{

    public float x, y, z;
    public List<mapObj> mapObjs;



    public void saveMapData()
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(mapData));
        Stream stream = new FileStream("mapData.mpData", FileMode.Create);
        XmlWriter writer = new XmlTextWriter(stream, System.Text.Encoding.Unicode);
        xmlSerializer.Serialize(writer, this);
        writer.Close();

    }
}

[System.Serializable]
public class mapObj
{
    public vector pos;
    public vector rot;
    public string prefabName;
}

[System.Serializable]
public class vector
{
    float x, y, z;

    public vector(float x, float y, float z = 0)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
}
*/