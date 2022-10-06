using UnityEngine;
using UnityEngine.UI;

public class SkinSelectorAndSeller : MonoBehaviour
{
    public GameObject[] skins;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("skins"))
        {
            PlayerPrefs.SetInt("skins", 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var skin in skins)
            skin.GetComponentInChildren<Button>().GetComponentInChildren<Text>().text = "select";
        skins[PlayerPrefs.GetInt("skins")].GetComponentInChildren<Button>().GetComponentInChildren<Text>().text = "selected";

        for (int i = 0; i < skins.Length; i++)
            skins[i].SetActive(bool.Parse(PlayerPrefs.GetString($"skin{i}")));
    }

    public void SelectSkin(int id) => PlayerPrefs.SetInt("skins", id);
    

    public void skn2Sell()
    {
        int m = PlayerPrefs.GetInt("money");
        m += 400;
        PlayerPrefs.SetInt("money", m);
        PlayerPrefs.SetString("skin1", "false");
        if(PlayerPrefs.GetInt("skins")==1)
            PlayerPrefs.SetInt("skins", 1);
    }
    public void skn3Sell()
    {
        int m = PlayerPrefs.GetInt("money");
        m += 200;
        PlayerPrefs.SetInt("money", m);
        PlayerPrefs.SetString("skin2", "false");
        if(PlayerPrefs.GetInt("skins")==2)
            PlayerPrefs.SetInt("skins", 1);
    }
    public void skn4Sell()
    {
        int m = PlayerPrefs.GetInt("money");
        m += 1999;
        PlayerPrefs.SetInt("money", m);
        PlayerPrefs.SetString("skin3", "false");
        if(PlayerPrefs.GetInt("skins")==3)
            PlayerPrefs.SetInt("skins", 1);
    }
    public void skn5Sell()
    {
        int m = PlayerPrefs.GetInt("money");
        m += 7000;
        PlayerPrefs.SetInt("money", m);
        PlayerPrefs.SetString("skin4", "false");
        if(PlayerPrefs.GetInt("skins")==4)
            PlayerPrefs.SetInt("skins", 1);
    }
    public void skn6Sell()
    {
        int m = PlayerPrefs.GetInt("money");
        m += 111;
        PlayerPrefs.SetInt("money", m);
        PlayerPrefs.SetString("skin5", "false");
        if(PlayerPrefs.GetInt("skins")==5)
            PlayerPrefs.SetInt("skins", 1);
    }
    public void skn7Sell()
    {
        int m = PlayerPrefs.GetInt("money");
        m += 766;
        PlayerPrefs.SetInt("money", m);
        PlayerPrefs.SetString("skin6", "false");
        if(PlayerPrefs.GetInt("skins")==6)
            PlayerPrefs.SetInt("skins", 1);
    }
    public void skn8Sell()
    {
        int m = PlayerPrefs.GetInt("money");
        m += 1700;
        PlayerPrefs.SetInt("money", m);
        PlayerPrefs.SetString("skin7", "false");
        if(PlayerPrefs.GetInt("skins")==7)
            PlayerPrefs.SetInt("skins", 1);
    }
    public void skn9Sell()
    {
        int m = PlayerPrefs.GetInt("money");
        m += 60;
        PlayerPrefs.SetInt("money", m);
        PlayerPrefs.SetString("skin8", "false");
        if(PlayerPrefs.GetInt("skins")==8)
            PlayerPrefs.SetInt("skins", 1);
    }
    public void skn10Sell()
    {
        int m = PlayerPrefs.GetInt("money");
        m += 100;
        PlayerPrefs.SetInt("money", m);
        PlayerPrefs.SetString("skin9", "false");
        if(PlayerPrefs.GetInt("skins")==9)
            PlayerPrefs.SetInt("skins", 1);
    }
    public void skn11Sell()
    {
        int m = PlayerPrefs.GetInt("money");
        m += 600;
        PlayerPrefs.SetInt("money", m);
        PlayerPrefs.SetString("skin10", "false");
        if(PlayerPrefs.GetInt("skins")==10)
            PlayerPrefs.SetInt("skins", 1);
    }
}
