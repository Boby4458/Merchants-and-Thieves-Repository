using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

public class Node : MonoBehaviour {

    public Vector2Int posOnGrid;
    public marketManager _marketManager;
    public List<tradingItem> itemsInChunk = new List<tradingItem>();
    public town myTown;

    private void Start()
    {
        print("Showing items of " + myTown.townName);
        Invoke("showItems", 2);
    }
    private void showItems()
    {
        //print("Showing items of " + myTown.townName);

        foreach (tradingItem item in itemsInChunk)
        {
            print(myTown.townName + item.myItemType.itemName);

        }
    }


}
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
