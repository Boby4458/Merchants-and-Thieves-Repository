using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace MT
{

    namespace TownSystem
    {
        [CreateAssetMenu(fileName = "Town", menuName = "MT Objects/Town Data Object")]
        public class townData : ScriptableObject
        {

            //PC - Per Chunk

            public string townName;
            public int totalPopulation;
            public int maxItems;

        }

    }
}