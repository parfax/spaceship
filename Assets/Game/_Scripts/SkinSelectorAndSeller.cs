using System.Collections.Generic;
using Game.Scripts;
using UnityEngine;
using UnityEngine.UI;

public class SkinSelectorAndSeller : MonoBehaviour
{
    private List<(Sprite, int)> skins = new List<(Sprite, int)>();
    public SpriteRenderer preview;
    public Text text;
    
    public int index, length;
    public int skinID;

    private void Awake()
    {
        Sturtup();
    }

    private void Sturtup()
    {
        PreservationSystem.LoadSkins();
        PreservationSystem.GetAvailableSkins();
        skins = PreservationSystem.availableSkins;
        
        length = skins.Count - 1;
    }

    public void Select()
    {
        PlayerPrefs.SetInt("Selected Skin", skinID);
        text.text = "Selected";
    }

    public void Preview(int n)
    {
        index = index + n;

        // index boundaries
        if (index < 0) index = length;
        else if (index > length) index = 0;

        skinID = skins[index].Item2; // getting ID
        text.text = skinID == PlayerPrefs.GetInt("Selected Skin") ? "Selected" : "Select";
        
        preview.sprite = skins[index].Item1;
        
    }

    public void Sell()
    {
        if (!PlayerPrefs.HasKey($"skin{skinID}")) return;
        
        PlayerPrefs.SetInt("Balance", PlayerPrefs.GetInt("Balance")+5000); // 5000 нізя!
        PlayerPrefs.DeleteKey($"skin{skinID}");
        
        if(skinID == PlayerPrefs.GetInt("Selected Skin"))
            PlayerPrefs.SetInt("Selected Skin", 0);
        
        PreservationSystem.availableSkins.Clear();
        Sturtup();
        Preview(1);
    }
    

    // public void skn2Sell()
    // {
    //     m += 400;
    // }
    // public void skn3Sell()
    // {
    //     m += 200;
    // }
    // public void skn4Sell()
    // {
    //     m += 1999;
    // }
    // public void skn5Sell()
    // {
    //     m += 7000;
    // }
    // public void skn6Sell()
    // {
    //     m += 111;
    // }
    // public void skn7Sell()
    // {
    //     m += 766;
    // }
    // public void skn8Sell()
    // {
    //     m += 1700;
    // }
    // public void skn9Sell()
    // {
    //     m += 60;
    // }
    // public void skn10Sell()
    // {
    //     m += 100;
    // }
    // public void skn11Sell()
    // {
    //     m += 600;
    // }
}
