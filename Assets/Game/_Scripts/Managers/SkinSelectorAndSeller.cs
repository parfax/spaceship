using System.Collections.Generic;
using Game.Scripts;
using TMPro;
using UnityEngine;

public class SkinSelectorAndSeller : MonoBehaviour
{
    private List<(SkinData, int)> skins = new List<(SkinData, int)>();
    public SpriteRenderer preview;
    public TextMeshProUGUI text, name;
    
    public int index, length, id;

    private void Awake()
    {
        GetSkins();
        Startup();
    }

    private void Startup()
    {
        var f = PlayerPrefs.GetInt("Selected Skin");

        for(int i = 0; i < skins.Count; i++)
            if(skins[i].Item2 == f) Preview(i);
    }


    private void GetSkins()
    {
        PreservationSystem.LoadSkins();
        skins = PreservationSystem.GetAvailableSkins();
        
        length = skins.Count - 1;
    }

    public void Select()
    {
        PlayerPrefs.SetInt("Selected Skin", id);
        text.text = "Selected";
    }

    public void Preview(int n = 0)
    {
        index = index + n;

        // index boundaries
        if (index < 0) index = length;
        else if (index > length) index = 0;

        id = skins[index].Item2; // getting ID
        text.text = id == PlayerPrefs.GetInt("Selected Skin") ? "Selected" : "Select";
        name.text = skins[index].Item1.name;
        
        preview.sprite = skins[index].Item1.sprite;
        
    }

    public void Sell()
    {
        if (!PlayerPrefs.HasKey($"skin{id}")) return;

        var balance = PlayerPrefs.GetInt("Balance");
        PlayerPrefs.SetInt("Balance", balance + skins[index].Item1.price);
        PlayerPrefs.DeleteKey($"skin{id}");
        
        if(id == PlayerPrefs.GetInt("Selected Skin"))
            PlayerPrefs.SetInt("Selected Skin", 0);

        GetSkins();
        Preview();
    }
}
