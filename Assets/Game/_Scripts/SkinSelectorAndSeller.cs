using System.Collections.Generic;
using Game.Scripts;
using UnityEngine;

public class SkinSelectorAndSeller : MonoBehaviour
{
    private List<Sprite> skins = new List<Sprite>();
    public SpriteRenderer preview;
    private int index, length;

    void Start()
    {
        PreservationSystem.LoadSkins();
        PreservationSystem.GetAvailableSkins();
        skins = PreservationSystem.availableSkins;

        length = skins.Count - 1;
    }

    // void Update()
    // {
    //     foreach (var skin in skins)
    //         skin.GetComponentInChildren<Button>().GetComponentInChildren<Text>().text = "select";
    //     skins[PlayerPrefs.GetInt("Selected Skin")].GetComponentInChildren<Button>().GetComponentInChildren<Text>().text = "selected";
    //
    //     for (int i = 0; i < skins.Length; i++)
    //         skins[i].SetActive(bool.Parse(PlayerPrefs.GetString($"skin{i}")));
    // }

    public void SelectSkin(int id) => PlayerPrefs.SetInt("Selected Skin", id);

    public void PreviewSkin(int n)
    {
        index = index + n;
        
        // index boundaries
        if (index < 0) index = length;
        else if (index > length) index = 0;

        preview.sprite = skins[index];
    }
    

    // public void skn2Sell()
    // {
    //     int m = PlayerPrefs.GetInt("Balance");
    //     m += 400;
    //     PlayerPrefs.SetInt("Balance", m);
    //     PlayerPrefs.SetString("skin1", "false");
    //     if(PlayerPrefs.GetInt("Selected Skin")==1)
    //         PlayerPrefs.SetInt("Selected Skin", 1);
    // }
    // public void skn3Sell()
    // {
    //     int m = PlayerPrefs.GetInt("Balance");
    //     m += 200;
    //     PlayerPrefs.SetInt("Balance", m);
    //     PlayerPrefs.SetString("skin2", "false");
    //     if(PlayerPrefs.GetInt("Selected Skin")==2)
    //         PlayerPrefs.SetInt("Selected Skin", 1);
    // }
    // public void skn4Sell()
    // {
    //     int m = PlayerPrefs.GetInt("Balance");
    //     m += 1999;
    //     PlayerPrefs.SetInt("Balance", m);
    //     PlayerPrefs.SetString("skin3", "false");
    //     if(PlayerPrefs.GetInt("Selected Skin")==3)
    //         PlayerPrefs.SetInt("Selected Skin", 1);
    // }
    // public void skn5Sell()
    // {
    //     int m = PlayerPrefs.GetInt("Balance");
    //     m += 7000;
    //     PlayerPrefs.SetInt("Balance", m);
    //     PlayerPrefs.SetString("skin4", "false");
    //     if(PlayerPrefs.GetInt("Selected Skin")==4)
    //         PlayerPrefs.SetInt("Selected Skin", 1);
    // }
    // public void skn6Sell()
    // {
    //     int m = PlayerPrefs.GetInt("Balance");
    //     m += 111;
    //     PlayerPrefs.SetInt("Balance", m);
    //     PlayerPrefs.SetString("skin5", "false");
    //     if(PlayerPrefs.GetInt("Selected Skin")==5)
    //         PlayerPrefs.SetInt("Selected Skin", 1);
    // }
    // public void skn7Sell()
    // {
    //     int m = PlayerPrefs.GetInt("Balance");
    //     m += 766;
    //     PlayerPrefs.SetInt("Balance", m);
    //     PlayerPrefs.SetString("skin6", "false");
    //     if(PlayerPrefs.GetInt("Selected Skin")==6)
    //         PlayerPrefs.SetInt("Selected Skin", 1);
    // }
    // public void skn8Sell()
    // {
    //     int m = PlayerPrefs.GetInt("Balance");
    //     m += 1700;
    //     PlayerPrefs.SetInt("Balance", m);
    //     PlayerPrefs.SetString("skin7", "false");
    //     if(PlayerPrefs.GetInt("Selected Skin")==7)
    //         PlayerPrefs.SetInt("Selected Skin", 1);
    // }
    // public void skn9Sell()
    // {
    //     int m = PlayerPrefs.GetInt("Balance");
    //     m += 60;
    //     PlayerPrefs.SetInt("Balance", m);
    //     PlayerPrefs.SetString("skin8", "false");
    //     if(PlayerPrefs.GetInt("Selected Skin")==8)
    //         PlayerPrefs.SetInt("Selected Skin", 1);
    // }
    // public void skn10Sell()
    // {
    //     int m = PlayerPrefs.GetInt("Balance");
    //     m += 100;
    //     PlayerPrefs.SetInt("Balance", m);
    //     PlayerPrefs.SetString("skin9", "false");
    //     if(PlayerPrefs.GetInt("Selected Skin")==9)
    //         PlayerPrefs.SetInt("Selected Skin", 1);
    // }
    // public void skn11Sell()
    // {
    //     int m = PlayerPrefs.GetInt("Balance");
    //     m += 600;
    //     PlayerPrefs.SetInt("Balance", m);
    //     PlayerPrefs.SetString("skin10", "false");
    //     if(PlayerPrefs.GetInt("Selected Skin")==10)
    //         PlayerPrefs.SetInt("Selected Skin", 1);
    // }
}
