using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu (fileName = "Town", menuName = "MT Objects/Town")]
public class town : ScriptableObject {

    //PC - Per Chunk

    public string townName;
    public int populationPC;
    public int occupiedChunks;
}
