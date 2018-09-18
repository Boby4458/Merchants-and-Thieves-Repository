using System.Collections.Generic;
using UnityEngine;

public class botManager : MonoBehaviour {

    public List<bot> curBots = new List<bot>();
    public float trainBotsAmount;
    public float horseBotsAmount;
    public float footBotsAmount;
    public chunkSystem chunkSystem;


    private void initBots()
    {
        
        int tempBotT_Index = 0;
        for (; tempBotT_Index < trainBotsAmount; ++tempBotT_Index)
        {
            
        }

        int tempBotH_Index = 0;
        for (; tempBotH_Index < horseBotsAmount; ++tempBotH_Index)
        {

        }

        int tempBotF_Index = 0;
        for (; tempBotF_Index < footBotsAmount; ++tempBotF_Index)
        {

        }

        
       
    }

    private Vector3 rndBotPos (Mesh terrain, Vector3 offset, Vector2 sizeBox)
    {
        Vector3 returnPos = Vector3.zero;
        returnPos = new Vector3(Random.Range(0, sizeBox.x), Random.Range (0, sizeBox.y));
        returnPos += offset;
        return returnPos;
    }
}
