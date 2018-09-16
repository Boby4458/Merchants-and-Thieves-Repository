using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interiorManager : MonoBehaviour {

    interiorType curType;

    public void openInterior (interiorType interior)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("interiorScene");
        curType = interior;

    }
}

public enum interiorType
{
    Grocery_Store,
    Saloon,
    Liquor_Store,
    Clothing_Store,
    Weapon_Store,
    Blacksmith,
    Land_Store

}