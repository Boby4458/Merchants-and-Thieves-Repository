﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MT
{
    namespace Economy
    {

        namespace TradingSystem
        {
            [CreateAssetMenu(fileName = "Trading Item", menuName = "MT Objects/Trading Item")]
            public class tradingItemData : ScriptableObject
            {

                public string itemName;
                public int averagePrice;
                public int averageTotalSupply;

                public Texture2D itemIcon;

            }
        }
    }
}