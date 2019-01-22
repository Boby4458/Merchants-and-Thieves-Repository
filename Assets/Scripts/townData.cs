using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu (fileName = "Town", menuName = "MT Objects/Town Data Object")]
public class townData : ScriptableObject {

    //PC - Per Chunk

    public string townName;
    public int population;
    public int occupiedChunks;
}
