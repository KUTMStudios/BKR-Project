using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        instance = this;
    }

    // Resources
    public List<Sprite> playerSprites;
    public List<Sprite> weaponSprites;
    public List<int> weaponPrices;
    public List<int> xpTable;

    //References Missing Public Player player 

    // Public Weapon weapon...

    // Logic 
    public int pesos;
    public int experience;

    // Save State
    public void SaveState()
    {
        Debug.Log("SaveState");
    }
    public void LoadState()
    {
        Debug.Log("LoadState");
    }

}
