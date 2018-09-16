using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu (fileName = "Trading Item", menuName = "MT Objects/Trading Item")]
public class tradingItemData : ScriptableObject {

    public string itemName;
    public int marketPrice;
    public int averageSupply;
    public town[] availableInTowns;
    

}
