using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventorySystem : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

namespace MT
{

    namespace Economy
    {
        namespace TradingSystem
        {
            public class inventory
            {

               public Dictionary<tradingItem, int> items = new Dictionary<tradingItem, int>();
                public int maxItems;
                
            }
        }
    }
}